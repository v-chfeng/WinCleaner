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

    public partial class ManualCleanFrm : CCSkinMain
    {
        /// <summary>
        /// 模拟轨道属性值
        /// </summary>
        private const int UpArrowTop = 301;
        private const int UpArrowLeft = -2;
        private const int RailLength = 12;

        private const int GunDongLeft = 268;
        private const int GunDongRight = 1068;
        private const int GunDongTop = 648;

        private string angleOne = "_1";
        private string angleTwo = "_2";
        private string angleThre = "_3";
        private string angleFour = "_4";

        private string stepZeroGray = "Gray";
        private string CurrentStatus;

        private delegate void AsynUpdateUI(SyncStatusMode status);

        private Thread updateUiThread;

        private RailControler railsControler;
        private Dictionary<CleanSteps, TimeSpan> saveSpendTimeDic;
        private DataStatusSyncer getter;

        private bool isWorking;
        private CleanSteps cleanStep; 

        public ManualCleanFrm()
        {
            InitializeComponent();
            this.saveSpendTimeDic = new Dictionary<CleanSteps, TimeSpan>();
            getter = new DataStatusSyncer();
            getter.UpdateUIDelegate += this.UpdateProcessUI;
            getter.TaskCallBack += this.DoneClean;
            this.isWorking = false;
            this.cleanStep = CleanSteps.UnSupported;
            this.GunDongFont.Text = "等待清理";
            this.GunDongTimer.Interval = 100;
            this.GunDongTimer.Enabled = true;
            this.CurrentStatus = "ready";
        }

        private void ManualCleanFrm_Load(object sender, EventArgs e)
        {
            int x = (System.Windows.Forms.SystemInformation.WorkingArea.Width - this.Size.Width) / 2;
            int y = (System.Windows.Forms.SystemInformation.WorkingArea.Height - this.Size.Height) / 2;
            this.StartPosition = FormStartPosition.Manual; //窗体的位置由Location属性决定
            myData.myPossition = new Size(x, y);
            this.Location = (Point)myData.myPossition;         //窗体的起始位置为(x,y)
            DataLabel.Text = myData.MiddleTitle();
            TimeLabel.Text = myData.RightTime();

            this.BackgroundImage = ((System.Drawing.Image)(Resources.ResourceManager.GetObject("backgroud2")));


            this.railsControler = new RailControler(this.eightAngle1.ImgList);

            this.upArrow.Location = new Point(ManualCleanFrm.UpArrowLeft, ManualCleanFrm.UpArrowTop);

            this.eightAngle1.ImgOne.BackgroundImage = ((System.Drawing.Image)(Resources.ResourceManager.GetObject(this.angleOne + this.stepZeroGray)));
            this.eightAngle1.ImgTwo.BackgroundImage = ((System.Drawing.Image)(Resources.ResourceManager.GetObject(this.angleTwo + this.stepZeroGray)));
            this.eightAngle1.ImgThree.BackgroundImage = ((System.Drawing.Image)(Resources.ResourceManager.GetObject(this.angleThre + this.stepZeroGray)));
            this.eightAngle1.ImgFour.BackgroundImage = ((System.Drawing.Image)(Resources.ResourceManager.GetObject(this.angleFour + this.stepZeroGray)));
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
        
        private void stopBtn_Click(object sender, EventArgs e)
        {
            if (!this.railsControler.IsAllStoped)
            {
                DialogResult result = MessageBox.Show("确实终止清理", "确认", MessageBoxButtons.OKCancel);
                if (result == DialogResult.OK)
                {
                    RailID id = this.railsControler.WorkingNum;
                    bool isSuccess = MachinePortal.StopManualClean(id);
                    if (!isSuccess)
                    {
                        MessageBox.Show("终止清理失败!");
                    }
                    else
                    {
                        this.railsControler.Stop();
                        this.cleanStep = CleanSteps.UnSupported;
                        this.UpdateUpArrowLocation(0);
                        this.ClearStepBtns();
                        this.PauseManual();
                    }
                }
            }
            else
            {
                MessageBox.Show("清理没有进行，无需终止!");
            }
        }

        private void ClearStepBtns()
        {
            this.stepOneBtn.BackgroundImage = global::CleanSys.Properties.Resources.stepOne;
            this.stepTwoBtn.BackgroundImage = global::CleanSys.Properties.Resources.stepTwo;
            this.stepThreeBtn.BackgroundImage = global::CleanSys.Properties.Resources.stepThree;
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

        /// <summary>
        /// 更新界面
        /// </summary>
        /// <param name="status"></param>
        private void Update(SyncStatusMode status)
        {
            CheckForIllegalCrossThreadCalls = false;

            if (status.IsError)
            {
                MessageBox.Show(status.ErrorMsg);
            }
            else
            { 
                this.UpdateUpArrowLocation(status.ProgressRate);

                if (status.CleanSteps == CleanSteps.Done)
                {
                    MessageBox.Show("到达终点，清理停止！");
                    this.PauseManual();
                }
                //this.railsControler.SetRailProgress(status.CleanSteps);
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
            int newTop = ManualCleanFrm.UpArrowTop - 25 * (int)(distance / ManualCleanFrm.RailLength);

            // 向下走，改变小车箭头方向
            if (newTop > currentTop)
            {
                ;
            }
            else
            {
                ;
            }

            System.Drawing.Point newLocation = new Point(ManualCleanFrm.UpArrowLeft, newTop);
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

        private void forward_Click(object sender, EventArgs args)
        {
            if (!this.railsControler.IsSelected)
            {
                MessageBox.Show("请先选择要清理的轨道!");
            }
            else if (this.cleanStep == CleanSteps.UnSupported)
            {
                MessageBox.Show("请先选择清理步骤!");
            }
            else if (!this.isWorking)
            {
                bool success = MachinePortal.Forward(this.railsControler.SelectedRailNum, this.cleanStep);
                if (success)
                {
                    this.isWorking = true;
                    this.railsControler.SetRailStatus(RailStatus.Running);
                    this.forwardBtn.BackgroundImage = global::CleanSys.Properties.Resources.forwardBtnDown;

                    this.updateUiThread = new Thread(this.getter.GetStatus);
                    this.updateUiThread.IsBackground = true;
                    this.updateUiThread.Start();
                }
                else
                {
                    MessageBox.Show("发送清理命令失败，请检查网络连接!");
                }
            }
            else
            {
                this.PauseManual();
            }
        }

        private void backward_Click(object sender, EventArgs args)
        {
            if (!this.railsControler.IsSelected)
            {
                MessageBox.Show("请先选择要清理的轨道!");
            }
            else if (this.cleanStep == CleanSteps.UnSupported)
            {
                MessageBox.Show("请先选择清理步骤!");
            }
            else if (!this.isWorking)
            {
                bool success = MachinePortal.Backward(this.railsControler.SelectedRailNum, this.cleanStep);
                if (success)
                {
                    this.isWorking = true;
                    this.railsControler.SetRailStatus(RailStatus.Running);
                    this.backfowrdBtn.BackgroundImage = global::CleanSys.Properties.Resources.backwardBtnDown;

                    this.updateUiThread = new Thread(this.getter.GetStatus);
                    this.updateUiThread.IsBackground = true;
                    this.updateUiThread.Start();
                }
                else
                {
                    MessageBox.Show("发送清理命令失败，请检查网络连接!");
                }
            }
            else
            {
                this.PauseManual();
            }
        }

        /// <summary>
        /// 当第二次单击 前进后者后退的时候，就相当于暂停状态
        /// 只是发送 停止命令，并且杀死 更新UI进程，并不改变 轨道，清理步骤 和模拟小车的状态
        /// </summary>
        private void PauseManual()
        {
            bool success = MachinePortal.StopManualClean(this.railsControler.WorkingNum);
            if (success)
            {
                this.updateUiThread.Abort();
                this.isWorking = false;
                this.forwardBtn.Enabled = true;
                this.backfowrdBtn.Enabled = true;
                this.railsControler.SetRailStatus(RailStatus.Ready);
                this.forwardBtn.BackgroundImage = global::CleanSys.Properties.Resources.forwardBtn;
                this.backfowrdBtn.BackgroundImage = global::CleanSys.Properties.Resources.backwardBtn;
            }
            else
            {
                MessageBox.Show("发送暂停前进命令失败，请检查网络连接!");
            }
        }

        private void StepOne_Click(object sender, EventArgs args)
        {
            if (this.isWorking)
            {
                if (this.cleanStep != CleanSteps.CleanRail)
                {
                    MessageBox.Show("请先停掉当前清理工作，再选择清理步骤！");
                    return;
                }
                else
                {
                    //取消选中，停止清理？
                }
            }
            else
            {
                this.cleanStep = CleanSteps.CleanRail;
                this.stepOneBtn.BackgroundImage = global::CleanSys.Properties.Resources.StepOneDown;

                ///改变另外两个颜色，颜色变浅变灰
                this.stepTwoBtn.BackgroundImage = global::CleanSys.Properties.Resources.stepTwo;
                this.stepThreeBtn.BackgroundImage = global::CleanSys.Properties.Resources.stepThree;
            }
        }

        private void StepTwo_Click(object sender, EventArgs args)
        {
            if (this.isWorking)
            {
                if (this.cleanStep != CleanSteps.CoveredWithGrease)
                {
                    MessageBox.Show("请先停掉当前清理工作，再选择清理步骤！");
                    return;
                }
                else
                {
                    //取消选中，停止清理？
                }
            }
            else
            {

                this.cleanStep = CleanSteps.CoveredWithGrease;
                this.stepTwoBtn.BackgroundImage = global::CleanSys.Properties.Resources.StepTwoDown;

                ///改变另外两个颜色，颜色变浅变灰
                this.stepOneBtn.BackgroundImage = global::CleanSys.Properties.Resources.stepOne;
                this.stepThreeBtn.BackgroundImage = global::CleanSys.Properties.Resources.stepThree;
            }
        }

        private void StepThree_Click(object sender, EventArgs args)
        {

            if (this.isWorking)
            {
                if (this.cleanStep != CleanSteps.DropAlcohol)
                {
                    MessageBox.Show("请先停掉当前清理工作，再选择清理步骤！");
                    return;
                }
                else
                {
                    //取消选中，停止清理？
                }
            }
            else
            {
                this.cleanStep = CleanSteps.DropAlcohol;
                this.stepThreeBtn.BackgroundImage = global::CleanSys.Properties.Resources.StepThreeDown;

                ///改变另外两个颜色，颜色变浅变灰
                this.stepTwoBtn.BackgroundImage = global::CleanSys.Properties.Resources.stepTwo;
                this.stepOneBtn.BackgroundImage = global::CleanSys.Properties.Resources.stepOne;
            }
        }

        private void GunDongTimer_Tick(object sender, EventArgs e)
        {
            int newLeft = this.GunDongFont.Location.X - 3;
            if (newLeft < GunDongLeft)
            {
                newLeft = GunDongRight;
            }

            this.GunDongFont.Location = new Point(newLeft, GunDongTop);

        }

        private string GetGunDongText(RailID id, string cleanStatus)
        {
            string text = string.Empty;
            string railTip = string.Empty;
            string stepTip = string.Empty;

            switch (id)
            {
                case RailID.One:
                    railTip = "一号轨道";
                    break;
                case RailID.Two:
                    railTip = "二号轨道";
                    break;
                case RailID.Three:
                    railTip = "三号轨道";
                    break;
                case RailID.Four:
                    railTip = "四号轨道";
                    break;
            }

            switch (this.CurrentCleanStep)
            {
                case CleanSteps.CleanRail:
                    stepTip = "清理轨道";
                    break;
                case CleanSteps.CoveredWithGrease:
                    stepTip = "涂润滑油";
                    break;
                case CleanSteps.DropAlcohol:
                    stepTip = "滴定无水乙醇";
                    break;
                case CleanSteps.Done:
                    stepTip = "清理完成";
                    break;
            }

            switch (cleanStatus)
            {
                case "ready":
                    text = "等待清理";
                    break;
                case "running":
                    text = railTip + stepTip;
                    break;
                case "pause":
                    text = railTip + "-暂停清理";
                    break;
            }

            return text;
        }
    }
}
