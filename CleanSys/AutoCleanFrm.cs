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

        private string angleOne = "_1";
        private string angleTwo = "_2";
        private string angleThre = "_3";
        private string angleFour = "_4";

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

            this.CurrentCleanStep = CleanSteps.UnSupported;

            this.eightAngle1.ImgOne.BackgroundImage = ((System.Drawing.Image)(Resources.ResourceManager.GetObject(this.angleOne + this.stepZeroGray)));
            this.eightAngle1.ImgTwo.BackgroundImage = ((System.Drawing.Image)(Resources.ResourceManager.GetObject(this.angleTwo + this.stepZeroGray)));
            this.eightAngle1.ImgThree.BackgroundImage = ((System.Drawing.Image)(Resources.ResourceManager.GetObject(this.angleThre + this.stepZeroGray)));
            this.eightAngle1.ImgFour.BackgroundImage = ((System.Drawing.Image)(Resources.ResourceManager.GetObject(this.angleFour + this.stepZeroGray)));
        }

        private void ResetTimerThread()
        {
            this.timerThread1 = new Thread(new ParameterizedThreadStart(this.Thread1_Tick));
            this.timerThread2 = new Thread(new ParameterizedThreadStart(this.Thread2_Tick));
            this.timerThread3 = new Thread(new ParameterizedThreadStart(this.Thread3_Tick));
            this.timerThread1.IsBackground = true;
            this.timerThread2.IsBackground = true;
            this.timerThread3.IsBackground = true;
        }

        /// <summary>
        /// 清理的距离长度
        /// 用于控制小车的位置
        /// </summary>
        public float CleanDistance
        {
            set
            {
                CheckForIllegalCrossThreadCalls = false;
                this.UpdateUpArrowLocation(value);
            }
        }

        #region 清理轨道， 涂润滑油， 滴定无水乙醇 三个步骤的进度控制
        public float CleanRailStepRate
        {
            get
            {
                CheckForIllegalCrossThreadCalls = false;
                return this.process1.ProcessBar.Value;
            }
            set
            {
                CheckForIllegalCrossThreadCalls = false;
                this.process1.ProcessBar.Value = Convert.ToInt32(value);
                this.process1.ProcessBar.Text = Convert.ToInt32(value) + "%";
            }
        }

        public string ConvertSpanToString(TimeSpan span)
        {
            CheckForIllegalCrossThreadCalls = false;
            return string.Format(this.spendTimeTemplate, span.Minutes, span.Seconds);
        }

        public TimeSpan ConvertStringToSpan(string str)
        {
            CheckForIllegalCrossThreadCalls = false;
            string[] strArr = str.Split(':');
            int mins = int.Parse(strArr[1]);
            int seconds = int.Parse(strArr[2]);
            return new TimeSpan(0, mins, seconds);
        }

        /// <summary>
        /// 清理轨道计时器时间
        /// </summary>
        public TimeSpan CleanRailSpan
        {
            get
            {
                CheckForIllegalCrossThreadCalls = false;
                return this.ConvertStringToSpan(this.spendTime1.Text);
            }
            set
            {
                CheckForIllegalCrossThreadCalls = false;
                this.spendTime1.Text = this.ConvertSpanToString(value);
            }
        }

        public float CoveredWithGreaseStepRate
        {
            get
            {
                CheckForIllegalCrossThreadCalls = false;
                return this.process2.ProcessBar.Value;
            }
            set
            {
                CheckForIllegalCrossThreadCalls = false;
                this.process2.ProcessBar.Value = Convert.ToInt32(value);
                this.process2.ProcessBar.Text = Convert.ToInt32(value) + "%";
            }
        }

        public TimeSpan CoveredWithGreaseSpan
        {
            get
            {
                CheckForIllegalCrossThreadCalls = false;
                return this.ConvertStringToSpan(this.spendTime2.Text);
            }
            set
            {
                CheckForIllegalCrossThreadCalls = false;
                this.spendTime2.Text = this.ConvertSpanToString(value);
            }
        }
        
        public float DropAlcoholStepRate
        {
            get
            {
                CheckForIllegalCrossThreadCalls = false;
                return this.process3.ProcessBar.Value;
            }
            set
            {
                CheckForIllegalCrossThreadCalls = false;
                this.process3.ProcessBar.Value = Convert.ToInt32(value);
                this.process3.ProcessBar.Text = Convert.ToInt32(value) + "%";
            }
        }

        public TimeSpan DropAlcoholSpan
        {
            get
            {
                CheckForIllegalCrossThreadCalls = false;
                return this.ConvertStringToSpan(this.spendTime3.Text);
            }
            set
            {
                CheckForIllegalCrossThreadCalls = false;
                this.spendTime3.Text = this.ConvertSpanToString(value);
            }
        }
        #endregion

        #region 清理步骤计时器 线程方法

        private void RenewTimer(bool isReset)
        {
            CheckForIllegalCrossThreadCalls = false;

            this.timerThread1 = new Thread(new ParameterizedThreadStart(this.Thread1_Tick));
            this.timerThread2 = new Thread(new ParameterizedThreadStart(this.Thread2_Tick));
            this.timerThread3 = new Thread(new ParameterizedThreadStart(this.Thread3_Tick));
            this.timerThread1.IsBackground = true;
            this.timerThread2.IsBackground = true;
            this.timerThread3.IsBackground = true;

            if (isReset)
            {
                this.saveSpendTimeDic.Clear();
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
        public void RTC_Tick(object sender, EventArgs e)
        {
            DataLabel.Text = myData.MiddleTitle();
            TimeLabel.Text = myData.RightTime();
            //testProcess();
        }

        /// <summary>
        /// 变量初始化器
        /// </summary>
        public void InitProcessBar()
        {
            ///三个步骤进度初始化
            this.CleanRailStepRate = 0;
            this.CoveredWithGreaseStepRate = 0;
            this.DropAlcoholStepRate = 0;

            this.process1.ProcessBar.Value = Convert.ToInt32(0);
            this.process1.ProcessBar.Text = Convert.ToInt32(0) + "%";

            /// 三个步骤用时初始化
            string defaultSpend = string.Format(this.spendTimeTemplate, "00","00");
            this.spendTime1.Text = defaultSpend;
            this.spendTime2.Text = defaultSpend;
            this.spendTime3.Text = defaultSpend;

            this.upArrow.Location = new Point(AutoCleanFrm.UpArrowLeft, AutoCleanFrm.UpArrowTop);
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
                default:
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
                this.startBtn.BackgroundImage = global::CleanSys.Properties.Resources.NewPauseBtn;

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

                this.CurrentCleanStep = CleanSteps.CleanRail;
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
                this.startBtn.BackgroundImage = global::CleanSys.Properties.Resources.NewPauseBtn;

                //更新八角形UI
                this.railsControler.Continue();

                this.RenewTimer(false);

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
                this.startBtn.BackgroundImage = global::CleanSys.Properties.Resources.NewStartBtn;

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
                        this.startBtn.BackgroundImage = global::CleanSys.Properties.Resources.NewStartBtn;
                        this.InitProcessBar();
                        this.RenewTimer(true);
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

            //if (InvokeRequired)
            //{
            //    this.BeginInvoke(new AsynUpdateUI(this.Update), status);
            //}
            //else
            //{
                this.Update(status);
            //}
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
                //过滤掉非法数据
                float progress = status.ProgressRate > 100 ? 100 : status.ProgressRate < 0 ? 0 : status.ProgressRate;

                switch (status.CleanSteps)
                {
                    case CleanSteps.CleanRail:
                        this.CleanRailStepRate = progress; // AutoCleanFrm.RailLength;
                        this.CurrentCleanStep = CleanSteps.CleanRail;
                        break;
                    case CleanSteps.CoveredWithGrease:
                        this.CleanRailStepRate = 100;
                        this.timerThread1.Abort();
                        if (this.CurrentCleanStep != CleanSteps.CoveredWithGrease)
                        {
                            this.timerThread2.Start(new TimeSpan(0, 0, 0));
                        }
                        this.CoveredWithGreaseStepRate = progress;// AutoCleanFrm.RailLength;
                        this.CurrentCleanStep = CleanSteps.CoveredWithGrease;
                        break;
                    case CleanSteps.DropAlcohol:
                        this.CleanRailStepRate = 100;
                        this.timerThread1.Abort();
                        this.CoveredWithGreaseStepRate = 100;
                        this.timerThread2.Abort();
                        if (this.CurrentCleanStep != CleanSteps.DropAlcohol)
                        {
                            this.timerThread3.Start(new TimeSpan(0, 0, 0));
                        }
                        this.DropAlcoholStepRate = progress; // AutoCleanFrm.RailLength;
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
                        string numZh = this.ConvertNumToChinese(num);
                        this.startBtn.BackgroundImage = global::CleanSys.Properties.Resources.NewStartBtn;
                        MessageBox.Show($"{numZh}轨道清理完毕!");
                        break;
                }

                this.UpdateUpArrowLocation(progress);
                this.railsControler.SetRailProgress(status.CleanSteps);
            }
        }

        private string ConvertNumToChinese(int num)
        {
            CheckForIllegalCrossThreadCalls = false;

            switch (num)
            {
                case 1:
                    return "一号";
                case 2:
                    return "二号";
                case 3:
                    return "三号";
                case 4:
                    return "四号";
            }

            return string.Empty;
        }

        /// <summary>
        /// 更新小车位置
        /// 默认轨道长度12米
        /// </summary>
        /// <param name="">小车距离初始点的距离</param>
        private void UpdateUpArrowLocation(float distance)
        {
            CheckForIllegalCrossThreadCalls = false;

            distance = distance > 100 ? 100 : distance;
            distance = distance < 0 ? 0 : distance;
            int currentTop = this.upArrow.Location.Y;
            int newTop = AutoCleanFrm.UpArrowTop - 25 * (int)(distance /100 * AutoCleanFrm.RailLength);

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
