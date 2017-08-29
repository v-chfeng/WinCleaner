using System;
using System.Windows.Forms;
using System.Drawing;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Configuration;

namespace CleanSys
{
    static class Program
    {
        /// <summary>
        /// 应用程序的主入口点。
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new FrmMain());
        }
    }
     static class myData
    {
        public static Size myPossition;
        public static Form mainFrm;
        public static void ShowNewForm(Form presentFrm, Form newFrm)
        {
            myData.myPossition = (Size)presentFrm.Location;
            presentFrm.Close();
            newFrm.StartPosition = FormStartPosition.Manual;
            newFrm.Location = (Point)myData.myPossition;
            newFrm.Show();
        }

        public static Stack<Form> frmStack = new Stack<Form>();

        public static string MiddleTitle()
        {
            return DateTime.Now.ToString("M月dd日") + "  " + GetWeek();
        }

        public static string RightTime()
        {
            return DateTime.Now.ToString("hh:mm");
        }

         public static string GetWeek()
        {
            DayOfWeek week = DateTime.Now.DayOfWeek;
            string weekStr = string.Empty;
            switch (week)
            {
                case DayOfWeek.Monday:
                    weekStr = "星期一";
                    break;
                case DayOfWeek.Tuesday:
                    weekStr = "星期二";
                    break;
                case DayOfWeek.Wednesday:
                    weekStr = "星期三";
                    break;
                case DayOfWeek.Thursday:
                    weekStr = "星期四";
                    break;
                case DayOfWeek.Friday:
                    weekStr = "星期五";
                    break;
                case DayOfWeek.Saturday:
                    weekStr = "星期六";
                    break;
                case DayOfWeek.Sunday:
                    weekStr = "星期日";
                    break;
            }

            return weekStr;
        }

        public static void SaveRecord(string content)
        {            
            string fileName = string.Format("record_{0}.log", DateTime.Now.ToString("yyyyMMdd"));
            string filePath = @".\log\" + fileName;
            string title = "箱编号\t操作员\t清理状态\t清理时间\t轨道1\t轨道2\t轨道3\t轨道4\n";

            if (!File.Exists(filePath))
            {
                File.AppendAllText(filePath, title);
            }

            File.AppendAllText(filePath, content);
        }
    }

    public static class MachineControler
    {
        public const string Command_Start  = "Start";
        public const string Command_GetStatus  = "Get";
        public const string Command_Stop = "Stop";
        private static MockMachineReceiver receiver;
        private static string IP;
        private static string Port;

        public static bool SendCMD(string cmd)
        {
            IP = ConfigurationManager.AppSettings["IP"];
            Port = ConfigurationManager.AppSettings["Port"];

            bool isSuccess = true;

            if (cmd == Command_Start)
            {
                receiver = new MockMachineReceiver();
            }

            return isSuccess;
        }

        public static MachineStatus GetStatus()
        {
            MachineStatus status;

            if (receiver == null)
            {
                status = new MachineStatus();
                status.IsError = true;
                status.ErrorMsg = "请先启动清理机器";
            }
            else
            {
                status = receiver.SendStatus();
            }

            return status;
        }
    }

    public class MachineStatus
    {
        private List<int> _stepsList;

        public int machineNum { get; set; }

        public int stepNum { get; set; }

        public bool IsError { get; set; }

        public bool AllDone { get; set; }

        public string ErrorMsg { get; set; }

        // 清理轨道进度
        public int stepOneProcess { get; set; }
        
        // 滴定无水乙醇
        public int stepTwoProcess { get; set; }

        // 涂润滑油
        public int stepThreeProcess { get; set; }

        // 进度list
        public List<int> StepsList
        {
            get
            {
                this._stepsList = new List<int>();
                this._stepsList.Add(stepOneProcess);
                this._stepsList.Add(stepTwoProcess);
                this._stepsList.Add(stepThreeProcess);

                return this._stepsList;
            }
        }
    }

    public class MockMachineReceiver
    {
        private int currentWorkingMachineNum;
        private const int MachineCount = 4;

        // 清理速率 1% / 1s
        private int rate = 1;

        private int currentStepNum;
        private const int StepCount = 3;
        private DateTime startTime;
        private int currentProcess;
        private bool isDone;

        public MockMachineReceiver()
        {
            this.Init();
        }

        public void Init()
        {
            this.currentWorkingMachineNum = 1;
            this.currentStepNum = 1;
            this.startTime = DateTime.Now;
            this.currentProcess = 0;
            this.isDone = false;
        }

        public MachineStatus SendStatus()
        {
            this.Clean();

            MachineStatus currentStatus = new MachineStatus();

            if (this.isDone)
            {
                currentStatus.AllDone = true;
            }
            else
            {
                currentStatus.machineNum = this.currentWorkingMachineNum;
                currentStatus.stepNum = this.currentStepNum;
                currentStatus.stepOneProcess = currentStepNum > 1 ? 100 : this.currentProcess;
                currentStatus.stepTwoProcess = currentStepNum > 2 ? 100 : currentStepNum == 2 ? this.currentProcess : 0;
                currentStatus.stepThreeProcess = currentStepNum != 3 ? 0 : this.currentProcess;
                currentStatus.IsError = false;
                currentStatus.ErrorMsg = string.Empty;
            }

            return currentStatus;
        }

        public void Clean()
        {
            TimeSpan span = DateTime.Now - this.startTime;
            int spanProcess = (int)span.TotalSeconds * this.rate;

            if (this.currentProcess + spanProcess > 100)
            {
                if (this.currentStepNum + 1 > MockMachineReceiver.StepCount)
                {
                    if (this.currentWorkingMachineNum + 1 > MockMachineReceiver.MachineCount)
                    {
                        this.isDone = true;
                        //this.Init();
                    }
                    else
                    {
                        this.startTime = DateTime.Now;
                        this.currentWorkingMachineNum++;
                        this.currentStepNum = 1;
                        this.currentProcess = this.currentProcess + spanProcess - 100;
                    }
                }
                else
                {
                    this.startTime = DateTime.Now;
                    this.currentStepNum++;
                    this.currentProcess = this.currentProcess + spanProcess - 100;

                }
            }
            else
            {
                this.startTime = DateTime.Now;
                this.currentProcess = this.currentProcess + spanProcess - 100;
            }
        }
    }
}
