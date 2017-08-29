using CCWin;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CleanSys
{
    public partial class AutoCleanFrm : CCSkinMain
    {
        private string spendTimeTemplate = @"用时: {0}";

        private string angleOne = "upRight1";
        private string angleTwo = "upRight1";
        private string angleThre = "upRight1";
        private string angleFour = "upRight1";

        private string stepZeroGray = "Gray";
        private string stepOneRed = "Red";
        private string stepTwoYellow = "Yellow";
        private string stepThreeGreen = "Green";

        private DateTime startTime1;
        private DateTime startTime2;
        private DateTime startTime3;
        private delegate void AsynUpdateUI(MachineStatus status);

        private int currentMachineNum;
        private int currentStepNum;
        private int stepOneProcess;
        private int stepTwoProcess;
        private int stepThreeProcess;

        private List<myProcesser> _processList;

        public AutoCleanFrm()
        {
            InitializeComponent();
            this._processList = null;
        }

        private void AutoCleanFrm_Load(object sender, EventArgs e)
        {
            int x = (System.Windows.Forms.SystemInformation.WorkingArea.Width - this.Size.Width) / 2;
            int y = (System.Windows.Forms.SystemInformation.WorkingArea.Height - this.Size.Height) / 2;
            this.StartPosition = FormStartPosition.Manual; //窗体的位置由Location属性决定
            myData.myPossition = new Size(x, y);
            this.Location = (Point)myData.myPossition;         //窗体的起始位置为(x,y)
            DataLabel.Text = myData.MiddleTitle();
            TimeLabel.Text = myData.RightTime();
        }

        protected void RTC_Tick(object sender, EventArgs e)
        {
            DataLabel.Text = myData.MiddleTitle();
            TimeLabel.Text = myData.RightTime();
            testProcess();
        }

        private void InitProcessBar()
        {
            this.process1.ProcessBar.Text = "0%";
            this.process2.ProcessBar.Text = "0%";
            this.process3.ProcessBar.Text = "0%";

            this.process1.ProcessBar.Value = 0;
            this.process2.ProcessBar.Value = 0;
            this.process3.ProcessBar.Value = 0;

            string defaultSpend = string.Format(this.spendTimeTemplate, "00:00");
            this.spendTime1.Text = defaultSpend;
            this.spendTime2.Text = defaultSpend;
            this.spendTime3.Text = defaultSpend;

            this.upArrow.Location = new Point(-2, 301);

            this.currentMachineNum = 0;
            this.currentStepNum = 0;
            this.stepOneProcess = 0;
            this.stepTwoProcess = 0;
            this.stepThreeProcess = 0;

            this.eightAngle1.ImgOne.BackgroundImage = ((System.Drawing.Image)(resources.GetObject(this.angleOne + this.stepZeroGray)));
            this.eightAngle1.ImgTwo.BackgroundImage = ((System.Drawing.Image)(resources.GetObject(this.angleTwo + this.stepZeroGray)));
            this.eightAngle1.ImgThree.BackgroundImage = ((System.Drawing.Image)(resources.GetObject(this.angleThre + this.stepZeroGray)));
            this.eightAngle1.ImgFour.BackgroundImage = ((System.Drawing.Image)(resources.GetObject(this.angleFour + this.stepZeroGray)));
        }

        private void testProcess()
        {
            this.process1.ProcessBar.Increment(90);// 环形进度条 增加百分比
            this.process2.ProcessBar.Increment(90);// 环形进度条 增加百分比
            this.process3.ProcessBar.Increment(90);// 环形进度条 增加百分比

            //this.process1.ProcessBar.t


            this.spendTime1.Text = "用时";
        }

        private void process2_Click(object sender, EventArgs e)
        {

        }

        private void AutoClean_Click(object sender, EventArgs e)
        {
            // 发送 自动清理请求 到 清理机器
            MachineControler.SendCMD(MachineControler.Command_Start);
            this.currentMachineNum = 1;
            this.currentStepNum = 1;

            //
            DataGet getter = new DataGet();
            //getter.

            // 进度条开始动

            // 灯开始亮
        }

        private void stopBtn_Click(object sender, EventArgs e)
        {
            ;
        }

        private void HomeBtn_Click(object sender, EventArgs e)
        {
            this.Close();
            myData.mainFrm.Show();// show();
            myData.frmStack.Clear();
        }

        private void rightBtn_Click(object sender, EventArgs e)
        {
            this.Close();
            Form backFrm = myData.frmStack.Pop();
            backFrm.Show();
        }

        private void UpdateProcessUI(MachineStatus status)
        {
            if (InvokeRequired)
            {
                this.Invoke(new AsynUpdateUI(this.Update), status);
            }
            else
            {
                this.Update(status);
            }
        }

        private void Update(MachineStatus status)
        {

            if (status.IsError)
            {
                MessageBox.Show(status.ErrorMsg);
            }
            else
            {
                // 如果当前轨道已经完成
                if (status.machineNum > this.currentMachineNum)
                {
                    this.ProcessIncreaseTo(this.process1.ProcessBar, 100);
                    this.ProcessIncreaseTo(this.process2.ProcessBar, 100);
                    this.ProcessIncreaseTo(this.process3.ProcessBar, 100);

                    //更新用时

                    Thread.Sleep(1000);

                    this.process1.ProcessBar.Value = 0;
                    this.process2.ProcessBar.Value = 0;
                    this.process3.ProcessBar.Value = 0;

                    //重置用时
                    this.ProcessIncreaseTo(this.process1.ProcessBar, status.stepOneProcess);
                    this.ProcessIncreaseTo(this.process2.ProcessBar, status.stepTwoProcess);
                    this.ProcessIncreaseTo(this.process3.ProcessBar, status.stepThreeProcess);

                    this.UpdateAngleMachine(status.machineNum, status.stepNum, true);
                }// 如果当前轨道的当前步骤完成
                else if (status.stepNum > this.currentStepNum)
                {
                    for (int i = 0; i < status.stepNum - 1; i++)
                    {
                        this.ProcessIncreaseTo(this.ProcessList[i].ProcessBar, 100);
                    }

                    this.UpdateAngleMachine(status.machineNum, status.stepNum);

                    this.ProcessIncreaseTo(this.ProcessList[status.stepNum - 1].ProcessBar, status.StepsList[status.stepNum - 1]);
                }
                else
                {
                    this.ProcessIncreaseTo(this.ProcessList[status.stepNum - 1].ProcessBar, status.StepsList[status.stepNum - 1]);
                }
            }
        }

        /// <summary>
        /// /
        /// </summary>
        /// <param name="num"></param>
        /// <param name="step"></param>
        /// <param name="isAll">ture,更新比num小的所有轨道，标记全完成为步骤三-绿色,</param>
        private void UpdateAngleMachine(int num, int step, bool isAll = false)
        {
            string imgStr = null;

            if (isAll)
            {
                for (int i = 0; i < num - 1; i++)
                {
                    imgStr = this.GetImgBackGround(i, 3);
                    this.eightAngle1.ImgList[i].BackgroundImage = ((System.Drawing.Image)(resources.GetObject(imgStr)));
                }
            }

            // 只更改当前轨道状态
            imgStr = this.GetImgBackGround(num, step);
            this.eightAngle1.ImgList[num-1].BackgroundImage = ((System.Drawing.Image)(resources.GetObject(imgStr)));
        }

        private string GetImgBackGround(int num, int step)
        {
            string imgStr = string.Empty;

            switch (num)
            {
                case 1:
                    imgStr += this.angleOne;
                    break;
                case 2:
                    imgStr += this.angleTwo;
                    break;
                case 3:
                    imgStr += this.angleThre;
                    break;
                case 4:
                    imgStr += this.angleFour;
                    break;
            }

            switch (step)
            {
                case 0:
                    imgStr += this.stepZeroGray;
                    break;
                case 1:
                    imgStr += this.stepOneRed;
                    break;
                case 2:
                    imgStr += this.stepTwoYellow;
                    break;
                case 3:
                    imgStr += this.stepThreeGreen;
                    break;
            }

            return imgStr;
        }

        private void ProcessIncreaseTo(CircularProgressBar.CircularProgressBar bar, int Num)
        {
            int increase = Num = bar.Value;
            if (increase > 0)
            {
                bar.Increment(increase);
            }
        }

        public List<myProcesser> ProcessList
        {
            get
            {
                if (this._processList == null)
                {
                    this._processList = new List<myProcesser>();
                    this._processList.Add(this.process1);
                    this._processList.Add(this.process2);
                    this._processList.Add(this.process3);
                }

                return this._processList;
            }
        }
    }

    public class DataGet
    {
        public delegate void UpdateUI(MachineStatus status);
        public UpdateUI UpdateUIDelegate;

        public delegate void AccomplishTask();
        public AccomplishTask TaskCallBack;
        private MachineStatus status;

        public void GetStatus()
        {
            do
            {
                status = MachineControler.GetStatus();
                this.UpdateUIDelegate(status);
                Thread.Sleep(1000); 
            }
            while (!status.AllDone);

            this.UpdateUIDelegate(status);

            this.TaskCallBack();
        }
    }
}
