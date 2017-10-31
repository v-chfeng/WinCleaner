using CCWin;
using CCWin.SkinControl;
using CleanSys.Mode;
using CleanSys.Properties;
using CleanSys.Util;
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
using WinTimer = System.Windows.Forms.Timer;

namespace CleanSys
{
    public partial class ManualCleanFrm : CCSkinMain
    {
        private string spendTimeTemplate = @"用时: {0}:{1}";

        private string angleOne = "upRight1";
        private string angleTwo = "upLeft2";
        private string angleThre = "downLeft3";
        private string angleFour = "downRight4";

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
        private List<WinTimer> _timerList;
        private List<DateTime> _startList;
        private List<SkinLabel> _spendTextList;
        private List<Thread> _threadList;

        private bool isWorking;

        //private WinTimer timer1;
        //private WinTimer timer2;
        //private WinTimer timer3;

        private Thread thread;
        private Thread timerThread1;
        private Thread timerThread2;
        private Thread timerThread3;

        public ManualCleanFrm()
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
            this.isWorking = false;

            this.timer1 = new WinTimer();
            this.timer2 = new WinTimer();
            this.timer3 = new WinTimer();

            this.timer1.Interval = 1000;
            this.timer2.Interval = 1000;
            this.timer3.Interval = 1000;

            this.timer1.Enabled = false;
            this.timer2.Enabled = false;
            this.timer3.Enabled = false;

            this.timer1.Tick += new EventHandler(Timer1_Tick);
            this.timer2.Tick += new EventHandler(Timer2_Tick);
            this.timer3.Tick += new EventHandler(Timer3_Tick);

            this.timerThread1 = new Thread(new ParameterizedThreadStart(this.Thread1_Tick));
            this.timerThread2 = new Thread(new ParameterizedThreadStart(this.Thread2_Tick));
            this.timerThread3 = new Thread(new ParameterizedThreadStart(this.Thread3_Tick));
            this.timerThread1.IsBackground = true;
            this.timerThread2.IsBackground = true;
            this.timerThread3.IsBackground = true;

            this.process1.BackgroundImage = ((System.Drawing.Image)Resources.ResourceManager.GetObject("stepOne"));
            this.process2.BackgroundImage = ((System.Drawing.Image)Resources.ResourceManager.GetObject("stepTwo"));
            this.process3.BackgroundImage = ((System.Drawing.Image)Resources.ResourceManager.GetObject("stepThree"));

            this.BackgroundImage = ((System.Drawing.Image)(Resources.ResourceManager.GetObject("backgroud2")));

            this.InitProcessBar();
        }

        private void Timer1_Tick(object sender, EventArgs e)
        {
            TimeSpan span = DateTime.Now - this.startTime1;
            this.spendTime1.Text = string.Format(spendTimeTemplate, span.Minutes, span.Seconds);
        }

        private void Thread1_Tick(object start)
        {
            CheckForIllegalCrossThreadCalls = false;

            while (true)
            {
                TimeSpan span = DateTime.Now - (DateTime)start;
                this.spendTime1.Text = string.Format(spendTimeTemplate, span.Minutes, span.Seconds);
                Thread.Sleep(1000);
            }
        }

        private void Thread2_Tick(object start)
        {
            CheckForIllegalCrossThreadCalls = false;

            while (true)
            {
                TimeSpan span = DateTime.Now - (DateTime)start;
                this.spendTime2.Text = string.Format(spendTimeTemplate, span.Minutes, span.Seconds);
                Thread.Sleep(1000);
            }
        }

        private void Thread3_Tick(object start)
        {
            CheckForIllegalCrossThreadCalls = false;

            while (true)
            {
                TimeSpan span = DateTime.Now - (DateTime)start;
                this.spendTime3.Text = string.Format(spendTimeTemplate, span.Minutes, span.Seconds);
                Thread.Sleep(1000);
            }
        }

        private void Timer2_Tick(object sender, EventArgs e)
        {
            TimeSpan span = DateTime.Now - this.startTime2;
            MessageBox.Show(string.Format(spendTimeTemplate, span.Minutes, span.Seconds));
            this.spendTime2.Text = string.Format(spendTimeTemplate, span.Minutes, span.Seconds);
        }

        private void Timer3_Tick(object sender, EventArgs e)
        {
            TimeSpan span = DateTime.Now - this.startTime3;
            this.spendTime3.Text = string.Format(spendTimeTemplate, span.Minutes, span.Seconds);
        }

        protected void RTC_Tick(object sender, EventArgs e)
        {
            DataLabel.Text = myData.MiddleTitle();
            TimeLabel.Text = myData.RightTime();
            //testProcess();
        }

        private void InitProcessBar()
        {
            this.process1.ProcessBar.Text = "0%";
            this.process2.ProcessBar.Text = "0%";
            this.process3.ProcessBar.Text = "0%";

            this.process1.ProcessBar.Value = 0;
            this.process2.ProcessBar.Value = 0;
            this.process3.ProcessBar.Value = 0;

            string defaultSpend = string.Format(this.spendTimeTemplate, "00","00");
            this.spendTime1.Text = defaultSpend;
            this.spendTime2.Text = defaultSpend;
            this.spendTime3.Text = defaultSpend;

            this.upArrow.Location = new Point(-2, 301);

            this.currentMachineNum = 0;
            this.currentStepNum = 0;
            this.stepOneProcess = 0;
            this.stepTwoProcess = 0;
            this.stepThreeProcess = 0;

            this.eightAngle1.ImgOne.BackgroundImage = ((System.Drawing.Image)(Resources.ResourceManager.GetObject(this.angleOne + this.stepZeroGray)));
            this.eightAngle1.ImgTwo.BackgroundImage = ((System.Drawing.Image)(Resources.ResourceManager.GetObject(this.angleTwo + this.stepZeroGray)));
            this.eightAngle1.ImgThree.BackgroundImage = ((System.Drawing.Image)(Resources.ResourceManager.GetObject(this.angleThre + this.stepZeroGray)));
            this.eightAngle1.ImgFour.BackgroundImage = ((System.Drawing.Image)(Resources.ResourceManager.GetObject(this.angleFour + this.stepZeroGray)));
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

        private void RefreshThread(int num)
        {
            switch (num)
            {
                case 1:
                    this.timerThread1 = new Thread(new ParameterizedThreadStart(this.Thread1_Tick));
                    this.timerThread1.IsBackground = true;
                    break;
                case 2:
                    this.timerThread2 = new Thread(new ParameterizedThreadStart(this.Thread2_Tick));
                    this.timerThread2.IsBackground = true;
                    break;
                case 3:
                    this.timerThread3 = new Thread(new ParameterizedThreadStart(this.Thread3_Tick));
                    this.timerThread3.IsBackground = true;
                    break;
            }

            this._threadList.Clear();
            this._threadList.Add(this.timerThread1);
            this._threadList.Add(this.timerThread2);
            this._threadList.Add(this.timerThread3);
        }

        private void AutoClean_Click(object sender, EventArgs e)
        {
            if (this.isWorking == false)
            {
                // 发送 自动清理请求 到 清理机器
                bool isSuccess = MachineSender.SendCMD(MachineSender.Command_Start);
                if (isSuccess)
                {
                    this.isWorking = true;

                    this.InitProcessBar();

                    this.currentMachineNum = 1;
                    this.currentStepNum = 1;
                    this.eightAngle1.ImgOne.BackgroundImage = ((System.Drawing.Image)(Resources.ResourceManager.GetObject(this.angleOne + this.stepOneRed)));

                    this.startTime1 = DateTime.Now;
                    //this.timer1.Enabled = true;

                    this.timerThread1 = new Thread(new ParameterizedThreadStart(this.Thread1_Tick));
                    this.timerThread2 = new Thread(new ParameterizedThreadStart(this.Thread2_Tick));
                    this.timerThread3 = new Thread(new ParameterizedThreadStart(this.Thread3_Tick));
                    this.timerThread1.IsBackground = true;
                    this.timerThread2.IsBackground = true;
                    this.timerThread3.IsBackground = true;

                    this.timerThread1.Start(DateTime.Now);
                    
                    DataGet getter = new DataGet();
                    getter.UpdateUIDelegate += this.Update;
                    getter.TaskCallBack += this.DoneClean;
                    this.thread = new Thread(getter.GetStatus);
                    this.thread.IsBackground = true;
                    this.thread.Start();
                }
            }
            else
            {
                MessageBox.Show("正在清理，请稍后再试");
            }
        }

        private void stopBtn_Click(object sender, EventArgs e)
        {
            if (this.isWorking)
            {
                DialogResult result = MessageBox.Show("确实终止清理", "确认", MessageBoxButtons.OKCancel);
                if (result == DialogResult.OK)
                {
                    bool isSuccess = MachineSender.SendCMD(MachineSender.Command_Stop);
                    if (!isSuccess)
                    {
                        MessageBox.Show("终止清理失败!");
                    }
                    else
                    {
                        this.thread.Abort();
                        this.timerThread1.Abort();
                        this.timerThread2.Abort();
                        this.timerThread3.Abort();
                        this.timer1.Enabled = false;
                        this.timer2.Enabled = false;
                        this.timer3.Enabled = false;
                        this.isWorking = false;
                    }
                }
            }
            else
            {
                MessageBox.Show("清理没有进行，无需终止!");
            }
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
            CheckForIllegalCrossThreadCalls = false;

            if (InvokeRequired)
            {
                this.Invoke(new AsynUpdateUI(this.Update), status);
            }
            else
            {
                this.Update(status);
            }
        }

        // 重置上次清理痕迹
        private void DoneClean()
        {
            this.isWorking = false;
        }

        private void Update(MachineStatus status)
        {
            CheckForIllegalCrossThreadCalls = false;

            if (status.IsError)
            {
                MessageBox.Show(status.ErrorMsg);
            }
            else if (status.AllDone)
            {
                this.ProcessIncreaseTo(this.process1.ProcessBar, 100);
                this.ProcessIncreaseTo(this.process2.ProcessBar, 100);
                this.ProcessIncreaseTo(this.process3.ProcessBar, 100);

                //停止计时
                this.timerThread1.Abort();
                this.timerThread2.Abort();
                this.timerThread3.Abort();
                this.timer1.Enabled = false;
                this.timer2.Enabled = false;
                this.timer3.Enabled = false;

                this.UpdateAngleMachine(4, 3, true);

                // 更新upArrow位置
                this.UpdateUpArrowLocation(4, 3);

                MessageBox.Show("清理完成");
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
                    this.timer1.Stop();
                    this.timer2.Stop();
                    this.timer3.Stop();
                    this.timerThread1.Abort();
                    this.timerThread2.Abort();
                    this.timerThread3.Abort();

                    Thread.Sleep(1000);

                    this.process1.ProcessBar.Value = 0;
                    this.process2.ProcessBar.Value = 0;
                    this.process3.ProcessBar.Value = 0;
                    this.spendTime1.Text = string.Format(this.spendTimeTemplate, "00","00");
                    this.spendTime2.Text = string.Format(this.spendTimeTemplate, "00","00");
                    this.spendTime3.Text = string.Format(this.spendTimeTemplate, "00","00");

                    this.ProcessIncreaseTo(this.process1.ProcessBar, status.stepOneProcess);
                    this.ProcessIncreaseTo(this.process2.ProcessBar, status.stepTwoProcess);
                    this.ProcessIncreaseTo(this.process3.ProcessBar, status.stepThreeProcess);

                    //重置用时
                    this.StartTimeList[status.stepNum - 1] = DateTime.Now;
                    //this.TimerList[status.stepNum - 1].Start();
                    this.RefreshThread(status.stepNum);
                    this.ThreadList[status.stepNum - 1].Start(DateTime.Now);

                    // 对于已经完成而没有统计的步骤，写一些假数据。
                    for (int i = 0; i < status.stepNum - 1; i++)
                    {
                        this.SpendTextList[i].Text = string.Format(this.spendTimeTemplate, "00", "30");
                    }

                    this.UpdateAngleMachine(status.machineNum, status.stepNum, true);

                    // 更新upArrow位置
                    this.UpdateUpArrowLocation(status.machineNum, status.stepNum);

                    // 记录状态
                    this.currentMachineNum = status.machineNum;
                    this.currentStepNum = status.stepNum;
                }// 如果当前轨道的当前步骤完成
                else if (status.stepNum > this.currentStepNum)
                {
                    for (int i = this.currentStepNum - 1; i < status.stepNum - 1; i++)
                    {
                        this.ProcessIncreaseTo(this.ProcessList[i].ProcessBar, 100);
                        this.TimerList[i].Stop();
                        this.ThreadList[i].Abort();
                    }

                    this.StartTimeList[status.stepNum - 1] = DateTime.Now;
                    //this.TimerList[status.stepNum - 1].Start();
                    this.RefreshThread(status.stepNum);
                    this.ThreadList[status.stepNum - 1].Start(DateTime.Now);

                    this.UpdateAngleMachine(status.machineNum, status.stepNum);

                    this.ProcessIncreaseTo(this.ProcessList[status.stepNum - 1].ProcessBar, status.StepsList[status.stepNum - 1]);

                    // 更新upArrow位置
                    this.UpdateUpArrowLocation(status.machineNum, status.stepNum);

                    // 记录状态
                    this.currentStepNum = status.stepNum;
                }
                else
                {
                    this.ProcessIncreaseTo(this.ProcessList[status.stepNum - 1].ProcessBar, status.StepsList[status.stepNum - 1]);
                }
            }
        }

        private void UpdateUpArrowLocation(int num, int step)
        {
            CheckForIllegalCrossThreadCalls = false;

            int left = -2;
            int top = 301;

            int increase = 25;
            int rate = (num - 1) * 3 + step;
            top -= increase * rate;

            System.Drawing.Point newLocation = new Point(left, top);
            this.upArrow.Location = newLocation;
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
                    imgStr = this.GetImgBackGround(i+1, 3);
                    this.eightAngle1.ImgList[i].BackgroundImage = ((System.Drawing.Image)(Resources.ResourceManager.GetObject(imgStr)));
                }
            }

            // 只更改当前轨道状态
            imgStr = this.GetImgBackGround(num, step);
            this.eightAngle1.ImgList[num-1].BackgroundImage = ((System.Drawing.Image)(Resources.ResourceManager.GetObject(imgStr)));
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
            CheckForIllegalCrossThreadCalls = false;

            int increase = Num - bar.Value;
            if (increase > 0)
            {
                bar.Increment(increase);
                bar.Text = Num.ToString() + "%";
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

        public List<WinTimer> TimerList
        {
            get
            {
                if (this._timerList == null)
                {
                    this._timerList = new List<WinTimer>();
                    this._timerList.Add(this.timer1);
                    this._timerList.Add(this.timer2);
                    this._timerList.Add(this.timer3);
                }

                return this._timerList;
            }
        }

        public List<DateTime> StartTimeList
        {
            get
            {
                if (this._startList == null)
                {
                    this._startList = new List<DateTime>();
                    this._startList.Add(this.startTime1);
                    this._startList.Add(this.startTime2);
                    this._startList.Add(this.startTime3);
                }

                //this.sp
                return this._startList;
            }
        }

        public List<CCWin.SkinControl.SkinLabel> SpendTextList
        {
            get
            {
                if (this._spendTextList == null)
                {
                    this._spendTextList = new List<SkinLabel>();
                    this._spendTextList.Add(this.spendTime1);
                    this._spendTextList.Add(this.spendTime2);
                    this._spendTextList.Add(this.spendTime3);
                }

                return this._spendTextList;
            }
        }

        public List<Thread> ThreadList
        {
            get
            {
                if (this._threadList == null)
                {
                    this._threadList = new List<Thread>();
                    this._threadList.Add(this.timerThread1);
                    this._threadList.Add(this.timerThread2);
                    this._threadList.Add(this.timerThread3);
                }

                return this._threadList;
            }
        }
    }

    public class ManualDataGet
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
                status = MachineSender.GetStatus();
                this.UpdateUIDelegate(status);
                Thread.Sleep(1000); 
            }
            while (!status.AllDone);

            this.TaskCallBack();
        }
    }
}
