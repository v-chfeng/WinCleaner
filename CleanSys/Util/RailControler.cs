using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CCWin.SkinControl;
using CleanSys.Properties;
using System.Windows.Forms;

namespace CleanSys.Util
{
    /// <summary>
    /// 负责处理各个轨道状态及变化。
    /// 主要响应UI中click, start, pause, stop 这四个事件。
    /// </summary>
    public class RailControler
    {
        // 因为空间中没有封装状态，只能在这里写上了。以后可以把所有状态及操作都封装到控件中去。
        /// <summary>
        /// RailWrapper
        ///     ID
        ///     RailEntity
        ///     Status
        ///     Progress
        /// 
        /// Dictionary<string, RailWrapper> RailDic
        /// </summary>

        // 把这些状态放到一个list里边。
        private RailStatus FirstRailStatus;
        private RailStatus SecondRailStatus;
        private RailStatus ThirdRailStatus;
        private RailStatus ForthRailStatus;

        private RailProgress _firstRailProgress;
        private RailProgress _secondRailProgress;
        private RailProgress _thirdRailProgress;
        private RailProgress _forthRailProgress;

        private List<SkinPictureBox> railList;

        public RailControler(List<SkinPictureBox> rails)
        {
            this.FirstRailStatus = RailStatus.Ready;
            this.SecondRailStatus = RailStatus.Ready;
            this.ThirdRailStatus = RailStatus.Ready;
            this.ForthRailStatus = RailStatus.Ready;

            this.FirstRailProgress = RailProgress.UnSelected;
            this.SecondRailProgress = RailProgress.UnSelected;
            this.ThirdRailProgress = RailProgress.UnSelected;
            this.ForthRailProgress = RailProgress.UnSelected;

            this.railList = rails;

            this.BindClickEvent();
        }

        public RailProgress FirstRailProgress
        {
            get
            {
                return this._firstRailProgress;
            }
            set
            {
                if (value != this._firstRailProgress)
                {
                    this._firstRailProgress = value;

                    //此处相当于加了一个属性的 监听事件（NotifyPropertyChanged），有改动就触发UI更新。
                    this.ChangeImage(railList[0], value);
                }
            }
        }

        public RailProgress SecondRailProgress
        {
            get
            {
                return this._secondRailProgress;
            }
            set
            {
                if (value != this._secondRailProgress)
                {
                    this._secondRailProgress = value;
                    this.ChangeImage(railList[1], value);
                }
            }
        }

        public RailProgress ThirdRailProgress
        {
            get
            {
                return this._thirdRailProgress;
            }
            set
            {
                if (value != this._thirdRailProgress)
                {
                    this._thirdRailProgress = value;
                    this.ChangeImage(railList[1], value);
                }
            }
        }

        public RailProgress ForthRailProgress
        {
            get
            {
                return this._forthRailProgress;
            }
            set
            {
                if (value != this._forthRailProgress)
                {
                    this._forthRailProgress = value;
                    this.ChangeImage(railList[1], value);
                }
            }
        }

        /// <summary>
        /// 所有 轨道 都为 ready 状态，才 为 false
        /// </summary>
        public bool IsAllStoped
        {
            get
            {
                bool allStopped = true;

                if (FirstRailStatus != RailStatus.Ready)
                {
                    allStopped = false;
                }

                if (SecondRailStatus != RailStatus.Ready)
                {
                    allStopped = false;
                }

                if (ThirdRailStatus != RailStatus.Ready)
                {
                    allStopped = false;
                }

                if (ForthRailStatus != RailStatus.Ready)
                {
                    allStopped = false;
                }

                return allStopped;
            }
        }

        /// <summary>
        ///  返回是否有一个轨道被选中
        /// </summary>
        public bool IsSelected
        {
            get
            {
                bool isSelected = false;

                if (this.FirstRailProgress != RailProgress.UnSelected
                    && this.FirstRailProgress != RailProgress.Done)
                {
                    return true;
                }

                if (this.SecondRailProgress != RailProgress.UnSelected
                    && this.SecondRailProgress != RailProgress.Done)
                {
                    return true;
                }

                if (this.ThirdRailProgress != RailProgress.UnSelected
                    && this.ThirdRailProgress != RailProgress.Done)
                {
                    return true;
                }

                if (this.ForthRailProgress != RailProgress.UnSelected
                    && this.ForthRailProgress != RailProgress.Done)
                {
                    return true;
                }

                return isSelected;
            }
        }

        public bool IsRunning
        {
            get
            {
                bool isRunning = false;

                if (this.FirstRailStatus == RailStatus.Running || this.SecondRailStatus == RailStatus.Running
                    || this.ThirdRailStatus == RailStatus.Running || this.ForthRailStatus == RailStatus.Running)
                {
                    isRunning = true;
                }

                return isRunning;
            }
        }

        public bool IsWorking
        {
            get
            {
                bool isWorking = false;

                if (this.FirstRailStatus != RailStatus.Ready || this.SecondRailStatus != RailStatus.Ready
                    || this.ThirdRailStatus != RailStatus.Ready || this.ForthRailStatus != RailStatus.Ready)
                {
                    isWorking = true;
                }

                return isWorking;
            }
        }

        /// <summary>
        /// 1.对应开始按钮, 当启动开始时，改变轨道的清理状态，并且返回轨道号
        /// 2.如果没有选定轨道， 返回 -1, UI 弹窗显示未选中
        /// 3.对于没有
        /// </summary>
        /// <returns>返回 当前工作的 轨道号</returns>
        public int Start()
        {
            int railNum = -1;

            if (this.IsSelected)
            {
                //throw new NotImplementedException();
                railNum = this.GetSelectedRail();
                this.StartRail(railNum);
            }

            return railNum;
        }

        /// <summary>
        /// 对应暂停按钮
        /// </summary>
        public int Pause()
        {
            int railNum = -1;

            if (this.IsRunning)
            {
                railNum = this.GetRunningRail();
                this.PauseRail(railNum);
            }

            return railNum;
        }

        /// <summary>
        /// 对应停止按钮， 如果返回-1：说明当前没有工作的轨道，弹窗提示用户。
        /// </summary>
        public int Stop()
        {
            int railNum = -1;

            if (this.IsWorking ||!this.IsAllStoped)
            {
                railNum = this.InvokeStop();
            }

            return railNum;
        }

        private void PauseRail(int num)
        {
            switch (num)
            {
                case 1:
                    this.FirstRailStatus = RailStatus.Pause;
                    break;
                case 2:
                    this.SecondRailStatus = RailStatus.Pause;
                    break;
                case 3:
                    this.ThirdRailStatus = RailStatus.Pause;
                    break;
                case 4:
                    this.ForthRailStatus = RailStatus.Pause;
                    break;
            }
        }

        private int GetRunningRail()
        {
            int railNum = -1;

            if (this.FirstRailStatus == RailStatus.Running)
            {
                railNum = 1;
            }
            else if (this.SecondRailStatus == RailStatus.Running)
            {
                railNum = 2;
            }
            else if (this.ThirdRailStatus == RailStatus.Running)
            {
                railNum = 3;
            }
            else if (this.ForthRailStatus == RailStatus.Running)
            {
                railNum = 4;
            }

            return railNum;
        }

        private int GetSelectedRail()
        {
            int railNum = -1;

            if (this.FirstRailProgress == RailProgress.Selected)
            {
                railNum = 1;
            }
            else if (this.SecondRailProgress == RailProgress.Selected)
            {
                railNum = 2;
            }
            else if (this.ThirdRailProgress == RailProgress.Selected)
            {
                railNum = 3;
            }
            else if (this.ForthRailProgress == RailProgress.Selected)
            {
                railNum = 4;
            }

            return railNum;
        }

        private void StartRail(int num)
        {
            switch (num)
            {
                case 1:
                    this.FirstRailProgress = RailProgress.CleanRail;
                    this.FirstRailStatus = RailStatus.Running;
                    break;
                case 2:
                    this.SecondRailProgress = RailProgress.CleanRail;
                    this.SecondRailStatus = RailStatus.Running;
                    break;
                case 3:
                    this.ThirdRailProgress = RailProgress.CleanRail;
                    this.ThirdRailStatus = RailStatus.Running;
                    break;
                case 4:
                    this.ForthRailProgress = RailProgress.CleanRail;
                    this.ForthRailStatus = RailStatus.Running;
                    break;
            }
        }

        /// <summary>
        ///  调整在运行轨道的状态
        /// </summary>
        /// <returns></returns>
        private int InvokeStop()
        {
            int railNum = -1;

            int workingNum = this.GetWorkingRail();
            this.StopRail(workingNum);

            return railNum;
        }

        /// <summary>
        /// 停止操作，更新轨道状态。
        /// </summary>
        /// <param name="num"></param>
        private void StopRail(int num)
        {
            switch (num)
            {
                case 1:
                    this.FirstRailProgress = RailProgress.Done;
                    this.FirstRailStatus = RailStatus.Ready;
                    break;
                case 2:
                    this.SecondRailProgress = RailProgress.Done;
                    this.SecondRailStatus = RailStatus.Ready;
                    break;
                case 3:
                    this.ThirdRailProgress = RailProgress.Done;
                    this.ThirdRailStatus = RailStatus.Ready;
                    break;
                case 4:
                    this.ForthRailProgress = RailProgress.Done;
                    this.ForthRailStatus = RailStatus.Ready;
                    break;
            }
        }

        private int GetWorkingRail()
        {
            int railNum = -1;

            if (this.FirstRailStatus != RailStatus.Ready)
            {
                railNum = 1;
            }
            else if (this.SecondRailStatus != RailStatus.Ready)
            {
                railNum = 2;
            }
            else if (this.ThirdRailStatus != RailStatus.Ready)
            {
                railNum = 3;
            }
            else if (this.ForthRailStatus != RailStatus.Ready)
            {
                railNum = 4;
            }
            

            return railNum;
        }

        /// <summary>
        /// 给所有 轨道 控件绑定Click事件
        /// </summary>
        private void BindClickEvent()
        {
            if (this.railList != null && this.railList.Count > 0)
            {
                foreach (var item in this.railList)
                {
                    item.Click += this.img_Click;
                }
            }
        }

        /// <summary>
        /// img click 事件接受器
        /// </summary>
        /// <param name="sender">事件发起方</param>
        /// <param name="e">参数</param>
        private void img_Click(object sender, EventArgs e)
        {
            SkinPictureBox img = sender as SkinPictureBox;

            // 获取当前控件的状态
            RailStatus currentStatus;
            RailProgress currentProgress;
            this.BackfillRailStatus(img, out currentStatus, out currentProgress);

            // 如果符合条件才会对 click事件 作处理
            // 如果所有的 轨道 都没有被选中，则直接选中
            // 如果 其他轨道 被选中，并且所有 轨道 都没有在工作， 则特定 轨道 被选中，其他都清除状态
            if (this.IsAllStoped && currentProgress == RailProgress.UnSelected)
            {
                //首先清除其他选中的轨道
                this.ClearOtherRail(img);

                this.ChangeImage(img, RailProgress.Selected);
            }
            // 如果刚好 特定 轨道 被选中，再次单击 取消选中
            else if (this.IsAllStoped && currentProgress == RailProgress.Selected)
            {
                this.ChangeImage(img, RailProgress.UnSelected);
            }
            // 如果有 轨道 在工作(status: running, pause), 则 忽略 click 事件，或者弹窗。
            else if (!this.IsAllStoped)
            {
                MessageBox.Show("请等待清理结束，或者停止当前清理后，重试!");
            }

        }

        /// <summary>
        /// 获取 某一轨道 状态
        /// </summary>
        /// <param name="rail">轨道</param>
        /// <param name="status">清理状态</param>
        /// <param name="progress">清理进度</param>
        private void BackfillRailStatus(SkinPictureBox rail, out RailStatus status, out RailProgress progress)
        {
            string railNum = this.GetRailNum(rail.Name);

            switch (railNum)
            {
                case "1":
                    status = this.FirstRailStatus;
                    progress = this.FirstRailProgress;
                    break;
                case "2":
                    status = this.SecondRailStatus;
                    progress = this.SecondRailProgress;
                    break;
                case "3":
                    status = this.ThirdRailStatus;
                    progress = this.ThirdRailProgress;
                    break;
                case "4":
                    status = this.ForthRailStatus;
                    progress = this.ForthRailProgress;
                    break;
                default:
                    status = RailStatus.Ready;
                    progress = RailProgress.UnSelected;
                    break;
            }
        }

        /// <summary>
        /// 清除所有轨道的状态
        /// </summary>
        private void ClearAllRail()
        {
            if (this.railList != null && this.railList.Count > 0)
            {
                foreach (var rail in this.railList)
                {
                    this.ChangeImage(rail, RailProgress.UnSelected);
                }
            }
        }

        /// <summary>
        /// 清除 除了给定轨道之外， 其他轨道的状态。
        /// </summary>
        /// <param name="specificRail">特定的轨道</param>
        private void ClearOtherRail(SkinPictureBox specificRail)
        {
            if (this.railList != null && this.railList.Count > 0)
            {
                foreach (var rail in this.railList)
                {
                    if (rail.Name == specificRail.Name)
                    {
                        continue;
                    }

                    this.ChangeImage(rail, RailProgress.UnSelected);
                }
            }
        }

        /// <summary>
        /// 根据当前轨道的进度，改变轨道控件的图片样式
        /// </summary>
        /// <param name="img">轨道控件</param>
        /// <param name="progress">当前进度</param>
        private void ChangeImage(SkinPictureBox img, RailProgress progress)
        {
            string color = this.ConvertToColor(progress);

            //代表哪个轨道：1,2,3,4
            string railNum = this.GetRailNum(img.Name);
            string imgName = string.Format("_{0}{1}.png", railNum, color);
            img.BackgroundImage = (System.Drawing.Image)(Resources.ResourceManager.GetObject(imgName));

            this.SetRailProgress(img, progress);
        }

        private void SetRailProgress(SkinPictureBox rail, RailProgress progress)
        {
            string railNum = this.GetRailNum(rail.Name);

            switch (railNum)
            {
                case "1":
                    this.FirstRailProgress = progress;
                    break;
                case "2":
                    this.SecondRailProgress = progress;
                    break;
                case "3":
                    this.ThirdRailProgress = progress;
                    break;
                case "4":
                    this.ForthRailProgress = progress;
                    break;
            }
        }

        private string GetRailNum(string name)
        {
            string num = string.Empty;
            num = name.Replace("img", "");
            return num;
        }

        /// <summary>
        /// Convert rail progress to color string.
        /// </summary>
        /// <param name="progress">Current progress</param>
        /// <returns>color:string</returns>
        private string ConvertToColor(RailProgress progress)
        {
            string color = string.Empty;

            switch (progress)
            {
                case RailProgress.UnSelected:
                    color = "Gray";
                    break;
                case RailProgress.Selected:
                    color = "CheckedGray";
                    break;
                case RailProgress.CleanRail:
                    color = "CheckedRed";
                    break;
                case RailProgress.CoveredWithGrease:
                    color = "CheckedYellow";
                    break;
                case RailProgress.DropAlcohol:
                case RailProgress.Done:
                    color = "CheckedGreen";
                    break;
                    
            }

            return color;
        }
    }

    /// <summary>
    /// 轨道清理进度
    /// </summary>
    public enum RailProgress
    {
        /// <summary>
        /// 轨道未选中
        /// </summary>
        UnSelected,

        /// <summary>
        /// 轨道被选中
        /// </summary>
        Selected,

        /// <summary>
        /// step one: 清理轨道
        /// </summary>
        CleanRail,//StepOne,

        /// <summary>
        /// step two: 涂润滑油
        /// </summary>
        CoveredWithGrease,

        /// <summary>
        /// step three: 滴定无水乙醇
        /// </summary>
        DropAlcohol,

        /// <summary>
        /// 完成，但不改变轨道 图标状态
        /// </summary>
        Done,
    }

    /// <summary>
    /// 清理机器的状态
    /// </summary>
    public enum RailStatus
    {
        /// <summary>
        /// 未开始运行
        /// </summary>
        Ready,

        /// <summary>
        /// 正在清理，工作状态
        /// </summary>
        Running,

        /// <summary>
        /// 暂停状态
        /// </summary>
        Pause,

        /// <summary>
        /// 不应该有停止状态，ready就代表了停止。
        /// </summary>
        Stop,
    }
}
