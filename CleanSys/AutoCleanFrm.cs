using CCWin;
using CCWin.SkinControl;
using CleanSys.Properties;
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
using CleanSys.Util;
using WinTimer = System.Windows.Forms.Timer;
using CleanSys.Mode;
using CleanSys.SelfEnum;

namespace CleanSys
{

    public partial class AutoCleanFrm : CCSkinMain
    {
        /// <summary>
        /// 模拟轨道属性值
        /// </summary>
        private const int UpArrowTop = 301;
        private const int UpArrowLeft = -2;
        private const int RailLength = 12;

        private string spendTimeTemplate = @"用时: {0:00}:{1:00}";

        private string angleOne = "upRight1";
        private string angleTwo = "upLeft2";
        private string angleThre = "downLeft3";
        private string angleFour = "downRight4";

        private string stepZeroGray = "Gray";

        private delegate void AsynUpdateUI(SyncStatusMode status);
        
        private CleanSteps CurrentCleanStep;
        
        private Thread updateUiThread;
        private Thread timerThread1;
        private Thread timerThread2;
        private Thread timerThread3;

        private RailControler railsControler;
        private Dictionary<CleanSteps, TimeSpan> saveSpendTimeDic;
        private DataStatusSyncer getter;

        public AutoCleanFrm()
        {
            InitializeComponent();
            this.saveSpendTimeDic = new Dictionary<CleanSteps, TimeSpan>();
            getter = new DataStatusSyncer();
            getter.UpdateUIDelegate += this.UpdateProcessUI;
            getter.TaskCallBack += this.DoneClean;
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


            this.railsControler = new RailControler(this.eightAngle1.ImgList);

            this.InitProcessBar();
        }

        /// <summary>
        /// 清理的距离长度
        /// 用于控制小车的位置
        /// </summary>
        public float CleanDistance
        {
            set
            {
                this.UpdateUpArrowLocation(value);
            }
        }

        #region 清理轨道， 涂润滑油， 滴定无水乙醇 三个步骤的进度控制
        public float CleanRailStepRate
        {
            get
            {
                return this.process1.ProcessBar.Value;
            }
            set
            {
                this.process1.ProcessBar.Value = Convert.ToInt32(value);
                this.process1.ProcessBar.Text = Convert.ToInt32(value) + "%";
            }
        }

        public string ConvertSpanToString(TimeSpan span)
        {
            return string.Format(this.spendTimeTemplate, span.Minutes, span.Seconds);
        }

        public TimeSpan ConvertStringToSpan(string str)
        {
            string[] strArr = str.Split(':');
            int mins = int.Parse(strArr[0]);
            int seconds = int.Parse(strArr[1]);
            return new TimeSpan(0, mins, seconds);
        }

        /// <summary>
        /// 清理轨道计时器时间
        /// </summary>
        public TimeSpan CleanRailSpan
        {
            get
            {
                return this.ConvertStringToSpan(this.spendTime1.Text);
            }
            set
            {
                this.spendTime1.Text = this.ConvertSpanToString(value);
            }
        }

        public float CoveredWithGreaseStepRate
        {
            get
            {
                return this.process2.ProcessBar.Value;
            }
            set
            {
                this.process2.ProcessBar.Value = Convert.ToInt32(value);
                this.process2.ProcessBar.Text = Convert.ToInt32(value) + "%";
            }
        }

        public TimeSpan CoveredWithGreaseSpan
        {
            get
            {
                return this.ConvertStringToSpan(this.spendTime2.Text);
            }
            set
            {
                this.spendTime2.Text = this.ConvertSpanToString(value);
            }
        }
        
        public float DropAlcoholStepRate
        {
            get
            {
                return this.process3.ProcessBar.Value;
            }
            set
            {
                this.process3.ProcessBar.Value = Convert.ToInt32(value);
                this.process3.ProcessBar.Text = Convert.ToInt32(value) + "%";
            }
        }

        public TimeSpan DropAlcoholSpan
        {
            get
            {
                return this.ConvertStringToSpan(this.spendTime3.Text);
            }
            set
            {
                this.spendTime3.Text = this.ConvertSpanToString(value);
            }
        }
        #endregion

        #region 清理步骤计时器 线程方法

        private void RenewTimer(bool isReset)
        {
            this.saveSpendTimeDic.Clear();
            this.timerThread1 = new Thread(new ParameterizedThreadStart(this.Thread1_Tick));
            this.timerThread2 = new Thread(new ParameterizedThreadStart(this.Thread2_Tick));
            this.timerThread3 = new Thread(new ParameterizedThreadStart(this.Thread3_Tick));
            this.timerThread1.IsBackground = true;
            this.timerThread2.IsBackground = true;
            this.timerThread3.IsBackground = true;

            if (isReset)
            {
                this.CleanRailSpan = new TimeSpan(0, 0, 0);
                this.CoveredWithGreaseSpan = new TimeSpan(0, 0, 0);
                this.DropAlcoholSpan = new TimeSpan(0, 0, 0);
            }
        }

        private void Thread1_Tick(object start)
        {
            CheckForIllegalCrossThreadCalls = false;

            TimeSpan startSpan = (TimeSpan)start;
            DateTime startTime = DateTime.Now;

            while (true)
            {
                TimeSpan span = DateTime.Now - startTime;
                TimeSpan totalSpan = span + startSpan;
                this.CleanRailSpan = totalSpan;
                Thread.Sleep(1000);
            }
        }

        private void Thread2_Tick(object start)
        {
            CheckForIllegalCrossThreadCalls = false;

            TimeSpan startSpan = (TimeSpan)start;
            DateTime startTime = DateTime.Now;

            while (true)
            {
                TimeSpan span = DateTime.Now - startTime;
                TimeSpan totalSpan = span + startSpan;
                this.CoveredWithGreaseSpan = totalSpan;
                Thread.Sleep(1000);
            }
        }

        private void Thread3_Tick(object start)
        {
            CheckForIllegalCrossThreadCalls = false;

            TimeSpan startSpan = (TimeSpan)start;
            DateTime startTime = DateTime.Now;

            while (true)
            {
                TimeSpan span = DateTime.Now - startTime;
                TimeSpan totalSpan = span + startSpan;
                this.DropAlcoholSpan = totalSpan;
                Thread.Sleep(1000);
            }
        }

        #endregion

         

        /// <summary>
        /// 标题更新 计时器
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        protected void RTC_Tick(object sender, EventArgs e)
        {
            DataLabel.Text = myData.MiddleTitle();
            TimeLabel.Text = myData.RightTime();
            //testProcess();
        }

        /// <summary>
        /// 变量初始化器
        /// </summary>
        private void InitProcessBar()
        {
            ///三个步骤进度初始化
            this.CleanRailStepRate = 0;
            this.CoveredWithGreaseStepRate = 0;
            this.DropAlcoholStepRate = 0;

            /// 三个步骤用时初始化
            string defaultSpend = string.Format(this.spendTimeTemplate, "00","00");
            this.spendTime1.Text = defaultSpend;
            this.spendTime2.Text = defaultSpend;
            this.spendTime3.Text = defaultSpend;

            this.upArrow.Location = new Point(AutoCleanFrm.UpArrowLeft, AutoCleanFrm.UpArrowTop);
            
            this.CurrentCleanStep = CleanSteps.UnSupported;

            this.eightAngle1.ImgOne.BackgroundImage = ((System.Drawing.Image)(Resources.ResourceManager.GetObject(this.angleOne + this.stepZeroGray)));
            this.eightAngle1.ImgTwo.BackgroundImage = ((System.Drawing.Image)(Resources.ResourceManager.GetObject(this.angleTwo + this.stepZeroGray)));
            this.eightAngle1.ImgThree.BackgroundImage = ((System.Drawing.Image)(Resources.ResourceManager.GetObject(this.angleThre + this.stepZeroGray)));
            this.eightAngle1.ImgFour.BackgroundImage = ((System.Drawing.Image)(Resources.ResourceManager.GetObject(this.angleFour + this.stepZeroGray)));
        }

        /// <summary>
        /// 开始 暂停 单击响应方法
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void StartPause_Click(object sender, EventArgs e)
        {
            RailID selectedID = RailID.UnSupported;
            AutoCleanStatus currentStatus = this.railsControler.CurrnetStatus;

            switch (currentStatus)
            {
                case AutoCleanStatus.Ready:
                    selectedID = this.railsControler.SelectedRailNum;
                    this.StartClean(selectedID);
                    break;
                case AutoCleanStatus.Running:
                    selectedID = this.railsControler.RunningNum;
                    this.PauseClean(selectedID);
                    break;
                case AutoCleanStatus.Pause:
                    selectedID = this.railsControler.PauseNum;
                    this.ContinueClean(selectedID);
                    break;
                case AutoCleanStatus.WaitSelect:
                    MessageBox.Show("请先选择要清理的轨道！");
                    break;
            }
        }

        /// <summary>
        /// 开始 清理
        /// </summary>
        /// <param name="selectedID"></param>
        private void StartClean(RailID selectedID)
        {
            bool isSuccess = MachinePortal.StartAutoClean(selectedID);

            if (isSuccess)
            {
                // 更新开始按钮图片
                this.startBtn.BackgroundImage = global::CleanSys.Properties.Resources.PauseBtn;
                this.CurrentCleanStep = CleanSteps.CleanRail;

                //更新八角形UI：轨道颜色
                this.railsControler.Start();

                // 启动界面更新线程，更新进度百分比，更新模拟小车,
                this.CleanDistance = 0;
                this.InitProcessBar();
                
                // 重置三个计时器
                this.RenewTimer(true);
                this.timerThread1.Start(new TimeSpan(0, 0, 0));

                // 重置更新UI 线程               
                this.updateUiThread = new Thread(this.getter.GetStatus);
                this.updateUiThread.IsBackground = true;
                this.updateUiThread.Start();
            }
            else
            {
                MessageBox.Show("发送“清理”请求失败，检查网络情况！");
            }
        }

        private void ContinueClean(RailID selectedID)
        {
            bool isSuccess = MachinePortal.ContinueAutoClean(selectedID);

            if (isSuccess)
            {
                // 更新开始按钮图片
                this.startBtn.BackgroundImage = global::CleanSys.Properties.Resources.PauseBtn;

                //更新八角形UI
                this.railsControler.Continue();

                //继续计时器
                TimeSpan span = this.saveSpendTimeDic[this.CurrentCleanStep];
                switch (this.CurrentCleanStep)
                {
                    case CleanSteps.CleanRail:
                        this.timerThread1.Start(span);
                        break;
                    case CleanSteps.CoveredWithGrease:
                        this.timerThread2.Start(span);
                        break;
                    case CleanSteps.DropAlcohol:
                        this.timerThread3.Start(span);
                        break;
                }

                // 启动界面更新线程，更新进度百分比，更新模拟小车, 更新轨道颜色。
                this.updateUiThread = new Thread(this.getter.GetStatus);
                this.updateUiThread.IsBackground = true;
                this.updateUiThread.Start();

                //清除记录
                this.saveSpendTimeDic.Clear();
            }
            else
            {
                MessageBox.Show("发送“清理”请求失败，检查网络情况！");
            }
        }

        private void PauseClean(RailID selectedID)
        {
            // send pause cmd;
            bool isSuccess = MachinePortal.PauseAutoClean(selectedID);

            if (isSuccess)
            {
                //保存 当前状态
                switch (this.CurrentCleanStep)
                {
                    case CleanSteps.CleanRail:
                        this.saveSpendTimeDic.Add(this.CurrentCleanStep, this.CleanRailSpan);
                        break;
                    case CleanSteps.CoveredWithGrease:
                        this.saveSpendTimeDic.Add(this.CurrentCleanStep, this.CoveredWithGreaseSpan);
                        break;
                    case CleanSteps.DropAlcohol:
                        this.saveSpendTimeDic.Add(this.CurrentCleanStep, this.DropAlcoholSpan);
                        break;
                }

                // 更新开始按钮图片
                this.startBtn.BackgroundImage = global::CleanSys.Properties.Resources.StartBtn;

                //更新八角形UI
                this.railsControler.Pause();

                // 杀死界面更新程序
                this.updateUiThread.Abort();
                this.timerThread1.Abort();
                this.timerThread2.Abort();
                this.timerThread3.Abort();
            }
            else
            {
                MessageBox.Show("发送“清理”请求失败，检查网络情况！");
            }
        }

        /// <summary>
        /// 新需求中有一个开始 button。所以这个button不可用。
        /// </summary>
        private void AutoClean_Click(object sender, EventArgs e)
        {
            ;//this.StartCleanOld();
        }

        private void stopBtn_Click(object sender, EventArgs e)
        {
            if (!this.railsControler.IsAllStoped)
            {
                DialogResult result = MessageBox.Show("确实终止清理", "确认", MessageBoxButtons.OKCancel);
                if (result == DialogResult.OK)
                {
                    RailID id = this.railsControler.WorkingNum;
                    bool isSuccess = MachinePortal.StopAutoClean(id);
                    if (!isSuccess)
                    {
                        MessageBox.Show("终止清理失败!");
                    }
                    else
                    {
                        this.railsControler.Stop();
                        this.CurrentCleanStep = CleanSteps.UnSupported;
                        this.saveSpendTimeDic.Clear();
                        this.updateUiThread.Abort();
                        this.timerThread1.Abort();
                        this.timerThread2.Abort();
                        this.timerThread3.Abort();
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
            myData.mainFrm.Show();// show();
            myData.frmStack.Clear();
            this.Close();
        }

        private void rightBtn_Click(object sender, EventArgs e)
        {
            Form backFrm = myData.frmStack.Pop();
            backFrm.Show();
            this.Close();
        }

        private void UpdateProcessUI(SyncStatusMode status)
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
            ;
        }

        private void Update(SyncStatusMode status)
        {
            CheckForIllegalCrossThreadCalls = false;

            if (status.IsError)
            {
                MessageBox.Show(status.ErrorMsg);
            }
            else
            { 
                switch (status.CleanSteps)
                {
                    case CleanSteps.CleanRail:
                        this.CleanRailStepRate = status.ProgressRate / AutoCleanFrm.RailLength;
                        this.CurrentCleanStep = CleanSteps.CleanRail;
                        break;
                    case CleanSteps.CoveredWithGrease:
                        this.CleanRailStepRate = 100;
                        this.timerThread1.Abort();
                        this.CoveredWithGreaseStepRate = status.ProgressRate / AutoCleanFrm.RailLength;
                        this.CurrentCleanStep = CleanSteps.CoveredWithGrease;
                        break;
                    case CleanSteps.DropAlcohol:
                        this.CleanRailStepRate = 100;
                        this.timerThread1.Abort();
                        this.CoveredWithGreaseStepRate = 100;
                        this.timerThread2.Abort();
                        this.DropAlcoholStepRate = status.ProgressRate / AutoCleanFrm.RailLength;
                        this.CurrentCleanStep = CleanSteps.DropAlcohol;
                        break;
                    case CleanSteps.Done:
                        this.CleanRailStepRate = 100;
                        this.timerThread1.Abort();
                        this.CoveredWithGreaseStepRate = 100;
                        this.timerThread2.Abort();
                        this.DropAlcoholStepRate = 100;
                        this.timerThread3.Abort();
                        this.CurrentCleanStep = CleanSteps.Done;
                        int num = (int)this.railsControler.WorkingNum;
                        MessageBox.Show($"轨道{num}清理完成!");
                        break;
                }

                this.UpdateUpArrowLocation(status.ProgressRate);
                this.railsControler.SetRailProgress(status.CleanSteps);
            }
        }

        /// <summary>
        /// 更新小车位置
        /// 默认轨道长度12米
        /// </summary>
        /// <param name="">小车距离初始点的距离</param>
        private void UpdateUpArrowLocation(float distance)
        {
            CheckForIllegalCrossThreadCalls = false;
            int currentTop = this.upArrow.Location.Y;
            int newTop = AutoCleanFrm.UpArrowTop - 25 * (int)(distance / AutoCleanFrm.RailLength);

            // 向下走，改变小车箭头方向
            if (newTop > currentTop)
            {
                ;
            }
            else
            {
                ;
            }

            System.Drawing.Point newLocation = new Point(AutoCleanFrm.UpArrowLeft, newTop);
            this.upArrow.Location = newLocation;
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
    }
}
