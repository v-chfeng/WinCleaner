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

        private string spendTimeTemplate = @"用时: {0:00}:{1:00}";

        private string angleOne = "upRight1";
        private string angleTwo = "upLeft2";
        private string angleThre = "downLeft3";
        private string angleFour = "downRight4";

        private string stepZeroGray = "Gray";

        private delegate void AsynUpdateUI(SyncStatusMode status);
        
        private CleanSteps CurrentCleanStep;
        
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
            /// 三个步骤用时初始化
            string defaultSpend = string.Format(this.spendTimeTemplate, "00","00");

            this.upArrow.Location = new Point(ManualCleanFrm.UpArrowLeft, ManualCleanFrm.UpArrowTop);
            
            this.CurrentCleanStep = CleanSteps.UnSupported;

            this.eightAngle1.ImgOne.BackgroundImage = ((System.Drawing.Image)(Resources.ResourceManager.GetObject(this.angleOne + this.stepZeroGray)));
            this.eightAngle1.ImgTwo.BackgroundImage = ((System.Drawing.Image)(Resources.ResourceManager.GetObject(this.angleTwo + this.stepZeroGray)));
            this.eightAngle1.ImgThree.BackgroundImage = ((System.Drawing.Image)(Resources.ResourceManager.GetObject(this.angleThre + this.stepZeroGray)));
            this.eightAngle1.ImgFour.BackgroundImage = ((System.Drawing.Image)(Resources.ResourceManager.GetObject(this.angleFour + this.stepZeroGray)));
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
                this.UpdateUpArrowLocation(status.ProgressRate);
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

        private void forward_mouseDown(object sender, EventArgs args)
        {
            if (!this.railsControler.IsSelected)
            {
                MessageBox.Show("请先选择要清理的轨道!");
            }
            else if (this.cleanStep == CleanSteps.UnSupported)
            {
                MessageBox.Show("请先选择清理步骤!");
            }
            else
            {
                bool success = MachinePortal.Forward(this.railsControler.SelectedRailNum, this.cleanStep);
                if (success)
                {
                    this.isWorking = true;
                    this.backfowrdBtn.Enabled = false;
                    this.railsControler.SetRailStatus(RailStatus.Running);

                    this.updateUiThread = new Thread(this.getter.GetStatus);
                    this.updateUiThread.IsBackground = true;
                    this.updateUiThread.Start();
                }
                else
                {
                    MessageBox.Show("发送清理命令失败，请检查网络连接!");
                }                
            }
        }

        private void forward_mouseUp(object sender, EventArgs args)
        {
            bool success = MachinePortal.PauseForward(this.railsControler.SelectedRailNum);
            if (!success)
            {
                MessageBox.Show("发送清理命令失败，请检查网络链接!");
                return;
            }

            this.isWorking = false;
            this.backfowrdBtn.Enabled = true;
            this.railsControler.SetRailStatus(RailStatus.Ready);
            this.updateUiThread.Abort();
        }

        private void backword_mouseDown(object sender, MouseEventArgs args)
        {
            if (!this.railsControler.IsSelected)
            {
                MessageBox.Show("请先选择要清理的轨道!");
            }
            else if (this.cleanStep == CleanSteps.UnSupported)
            {
                MessageBox.Show("请先选择清理步骤!");
            }
            else
            {
                bool success = MachinePortal.Backward(this.railsControler.SelectedRailNum, this.cleanStep);
                if (success)
                {
                    this.isWorking = true;
                    this.forwardBtn.Enabled = false;
                    this.railsControler.SetRailStatus(RailStatus.Running);

                    this.updateUiThread = new Thread(this.getter.GetStatus);
                    this.updateUiThread.IsBackground = true;
                    this.updateUiThread.Start();
                }
                else
                {
                    MessageBox.Show("发送清理命令失败，请检查网络连接!");
                }
            }
        }

        private void backword_mouseUp(object sender, MouseEventArgs args)
        {
            bool success = MachinePortal.PauseForward(this.railsControler.SelectedRailNum);
            if (!success)
            {
                MessageBox.Show("发送清理命令失败，请检查网络链接!");
                return;
            }

            this.isWorking = false;
            this.forwardBtn.Enabled = true;
            this.railsControler.SetRailStatus(RailStatus.Ready);
            this.updateUiThread.Abort();
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
                this.process1.BackgroundImage = ((System.Drawing.Image)Resources.ResourceManager.GetObject("stepOne"));
                this.cleanStep = CleanSteps.CleanRail;

                ///改变另外两个颜色，颜色变浅变灰
                this.process2.BackgroundImage = ((System.Drawing.Image)Resources.ResourceManager.GetObject("stepTwo"));
                this.process3.BackgroundImage = ((System.Drawing.Image)Resources.ResourceManager.GetObject("stepThree"));
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
                this.process2.BackgroundImage = ((System.Drawing.Image)Resources.ResourceManager.GetObject("stepTwo"));
                this.cleanStep = CleanSteps.CoveredWithGrease;

                ///改变另外两个颜色，颜色变浅变灰
                this.process1.BackgroundImage = ((System.Drawing.Image)Resources.ResourceManager.GetObject("stepOne"));
                this.process3.BackgroundImage = ((System.Drawing.Image)Resources.ResourceManager.GetObject("stepThree"));
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
                this.process3.BackgroundImage = ((System.Drawing.Image)Resources.ResourceManager.GetObject("stepThree"));
                this.cleanStep = CleanSteps.DropAlcohol;

                ///改变另外两个颜色，颜色变浅变灰
                this.process1.BackgroundImage = ((System.Drawing.Image)Resources.ResourceManager.GetObject("stepOne"));
                this.process2.BackgroundImage = ((System.Drawing.Image)Resources.ResourceManager.GetObject("stepTwo"));
            }
        }
    }
}
