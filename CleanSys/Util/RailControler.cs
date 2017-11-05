using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CCWin.SkinControl;
using CleanSys.Properties;
using System.Windows.Forms;
using CleanSys.SelfEnum;
using CleanSys.Mode;

namespace CleanSys.Util
{
    /// <summary>
    /// 负责处理各个轨道状态及变化。
    /// 主要响应UI中click, start, pause, stop 这四个事件。
    /// </summary>
    public class RailControler
    {
        private Dictionary<RailID, RailMode> RailDic;

        /// <summary>
        /// 禁用无参构造方法
        /// </summary>
        private RailControler()
        { }

        public RailControler(List<SkinPictureBox> rails)
        {
            this.RailDic = new Dictionary<RailID, RailMode>();
            this.InitRails(rails);
        }

        #region 外部属性API - IsAllStoped, IsSelected, IsRunning, IsWorking, IsPause

        /// <summary>
        /// 所有轨道都为 ready 状态，才为 true
        /// </summary>
        public bool IsAllStoped
        {
            get
            {
                bool allStopped = true;

                foreach (var item in this.RailDic)
                {
                    if (item.Value.Status != RailStatus.Ready)
                    {
                        allStopped = false;
                    }
                }

                return allStopped;
            }
        }

        /// <summary>
        ///  返回是否有一个轨道被选中
        ///  未被选中，且该轨道已经清理完毕。
        /// </summary>
        public bool IsSelected
        {
            get
            {
                bool isSelected = false;

                if (this.GetSelectedRail() != null)
                {
                    isSelected = true;
                }

                return isSelected;
            }
        }

        /// <summary>
        /// 返回被选中的轨道编号
        /// </summary>
        public RailID SelectedRailNum
        {
            get
            {
                RailMode rail = this.GetSelectedRail();
                return rail != null ? rail.ID : RailID.UnSupported;
            }
        }

        /// <summary>
        /// 返回是否有轨道在running
        /// running 是正在清理状态
        /// </summary>
        public bool IsRunning
        {
            get
            {
                RailMode rail = this.GetRunningRail();
                return rail != null ? true : false;
            }
        }

        public RailID RunningNum
        {
            get
            {
                RailMode rail = this.GetRunningRail();
                return rail != null ? rail.ID : RailID.UnSupported;
            }
        }

        /// <summary>
        /// 返回是否有轨道在working状态
        /// 包括running，pause状态
        /// </summary>
        public bool IsWorking
        {
            get
            {
                RailMode rail = this.GetWorkingRail();
                return rail != null ? true : false;
            }
        }

        public RailID WorkingNum
        {
            get
            {
                RailMode rail = this.GetWorkingRail();
                return rail != null ? rail.ID : RailID.UnSupported;
            }
        }

        public bool IsPause
        {
            get
            {
                RailMode rail = this.GetPauseRail();
                return rail != null ? true : false;
            }
        }

        public RailID PauseNum
        {
            get
            {
                RailMode rail = this.GetPauseRail();
                return rail != null ? rail.ID : RailID.UnSupported;
            }
        }

        public AutoCleanStatus CurrnetStatus
        {
            get
            {
                if (this.IsSelected)
                {
                    return AutoCleanStatus.Ready;
                }
                else if (this.IsPause)
                {
                    return AutoCleanStatus.Pause;
                }
                else if (this.IsRunning)
                {
                    return AutoCleanStatus.Running;
                }
                else
                {
                    return AutoCleanStatus.WaitSelect;
                }
            }
        }

        #endregion

        #region 轨道控制方法API - Start, Pause, Continue, Stop, Finish(完成轨道清理)
        /// <summary>
        /// 1.对应开始按钮, 当启动开始时，改变轨道的清理状态，并且返回轨道号
        /// 2.如果没有选定轨道， 返回 -1, UI 弹窗显示未选中
        /// 3.对于没有
        /// </summary>
        /// <returns>返回 当前工作的 轨道号</returns>
        public bool Start()
        {
            RailMode rail = this.GetSelectedRail();

            if (rail != null)
            {
                rail.Progress = RailProgress.CleanRail;
                rail.Status = RailStatus.Running;
                return true;
            }

            return false;
        }

        public bool Continue()
        {
            RailMode rail = this.GetPauseRail();

            if (rail != null)
            {
                rail.Status = RailStatus.Running;
                return true;
            }

            return false;
        }

        /// <summary>
        /// 对应暂停按钮, 改变轨道状态为暂停。
        /// </summary>
        public bool Pause()
        {
            RailMode rail = this.GetRunningRail();

            if (rail != null)
            {
                rail.Status = RailStatus.Pause;
                return true;
            }

            return false;
        }

        /// <summary>
        /// 对应停止按钮， 如果返回-1：说明当前没有工作的轨道，弹窗提示用户。
        /// </summary>
        public bool Stop()
        {
            RailMode rail = this.GetWorkingRail();

            if (rail != null)
            {
                rail.Progress = RailProgress.Stop;
                rail.Status = RailStatus.Ready;
                return true;
            }

            return false;
        }

        /// <summary>
        /// 完成轨道清理
        /// </summary>
        /// <returns></returns>
        public bool FinishClean()
        {
            RailMode rail = this.GetRunningRail();

            if (rail != null)
            {
                rail.Progress = RailProgress.Done;
                rail.Status = RailStatus.Ready;
                return true;
            }

            return false;
        }

        #endregion

        #region 轨道进度控制方法API - SetRailProgress(设置轨道当前的进度)

        /// <summary>
        /// 设置当前工作轨道的清理进度
        /// </summary>
        /// <param name="step"></param>
        public bool SetRailProgress(CleanSteps step)
        {
            RailMode mode = GetWorkingRail();

            if (mode == null)
                return false;

            switch (step)
            {
                case CleanSteps.CleanRail:
                    mode.Progress = RailProgress.CleanRail;
                    break;
                case CleanSteps.DropAlcohol:
                    mode.Progress = RailProgress.DropAlcohol;
                    break;
                case CleanSteps.CoveredWithGrease:
                    mode.Progress = RailProgress.DropAlcohol;
                    break;
                case CleanSteps.Done:
                    mode.Progress = RailProgress.Done;
                    mode.Status = RailStatus.Ready;
                    break;
            }

            return true;
        }

        /// <summary>
        /// 给手动清理设置轨道状态用的。因为手动清理轨道没有因为步骤变化图标
        /// </summary>
        /// <param name="railStatus"></param>
        /// <returns></returns>
        public bool SetRailStatus(RailStatus railStatus)
        {
            RailMode mode = GetWorkingRail();
            if (mode == null)
            {
                return false;
            }

            mode.Status = railStatus;

            return true;
        }

        #endregion


        #region 内部方法

        private void InitRails(List<SkinPictureBox> rails)
        {
            if (rails != null && rails.Count > 0)
            {
                foreach (var item in rails)
                {
                    item.Click += this.img_Click;
                    RailID id = this.ConvertNameToID(item.Name);
                    RailMode mode = new RailMode { ID = id };
                    mode.ImageBox = item;
                    mode.Status = RailStatus.Ready;
                    mode.Progress = RailProgress.UnSelected;
                    this.RailDic.Add(id, mode);
                }
            }
        }

        private RailMode GetRunningRail()
        {
            foreach (var item in this.RailDic)
            {
                if (item.Value.Status == RailStatus.Running)
                {
                    return item.Value;
                }
            }

            return null;
        }
        
        /// <summary>
        /// 获取当前被选中的轨道
        /// </summary>
        /// <returns></returns>
        private RailMode GetSelectedRail()
        {
            foreach (var item in this.RailDic)
            {
                if (item.Value.Progress == RailProgress.Selected)
                {
                    return item.Value;
                }
            }

            return null;
        }

        private RailMode GetPauseRail()
        {
            foreach (var item in this.RailDic)
            {
                if (item.Value.Status == RailStatus.Pause)
                {
                    return item.Value;
                }
            }

            return null;
        }
        
        private RailMode GetWorkingRail()
        {
            RailMode mode = null;

            foreach (var item in this.RailDic)
            {
                if (item.Value.Status != RailStatus.Ready)
                {
                    mode = item.Value;
                }
            }

            return mode;
        }
        
        /// <summary>
        /// img click 事件接受器
        /// </summary>
        /// <param name="sender">事件发起方</param>
        /// <param name="e">参数</param>
        private void img_Click(object sender, EventArgs e)
        {
            SkinPictureBox img = sender as SkinPictureBox;
            RailID id = this.ConvertNameToID(img.Name);
            RailMode rail = this.RailDic[id];

            if (this.IsAllStoped)
            {
                switch (rail.Progress)
                {
                    // 如果 其他轨道 被选中，并且所有 轨道 都没有在工作， 则特定 轨道 被选中，其他都清除状态
                    // 如果所有的 轨道 都没有被选中，则直接选中
                    case RailProgress.UnSelected:
                        this.ClearOtherRail(id);
                        rail.Progress = RailProgress.Selected;
                        break;

                    // 再次单击已选中轨道，取消选中
                    case RailProgress.Selected:
                        rail.Progress = RailProgress.UnSelected;
                        break;

                    // 单击已经清理过的轨道， 弹窗提示
                    case RailProgress.Done:
                        DialogResult result = MessageBox.Show("该轨道已经清理过，是否确认重新清理?","确认对话框", MessageBoxButtons.YesNo);
                        if (result == DialogResult.Yes)
                        {
                            rail.Progress = RailProgress.Selected;
                        }
                        break;
                }

            }
        }

        /// <summary>
        /// 清除所有轨道的进度状态
        /// </summary>
        private void ClearAllRail()
        {
            foreach (var item in this.RailDic)
            {
                item.Value.Progress = RailProgress.UnSelected;
            }
        }

        /// <summary>
        /// 清除 除了给定轨道之外， 其他轨道的进度状态--选中状态。
        /// </summary>
        /// <param name="specificRail">特定的轨道</param>
        private void ClearOtherRail(RailID id)
        {
            foreach (var item in this.RailDic)
            {
                RailMode rail = item.Value;
                if (rail.ID != id && rail.Progress == RailProgress.Selected)
                {
                    rail.Progress = RailProgress.UnSelected;
                }
            }
        }        

        /// <summary>
        /// 把图片控件的name转换成 railID.
        /// </summary>
        /// <returns></returns>
        private RailID ConvertNameToID(string name)
        {
            int num = int.Parse(name.Replace("img", ""));
            return (RailID)Enum.ToObject(typeof(RailID), num);
        }

        #endregion
    }
}
