using CCWin.SkinControl;
using CleanSys.Properties;
using CleanSys.SelfEnum;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CleanSys.Mode
{
    // 因为控件中没有封装状态，只能在这里写上了。以后可以把所有状态及操作都封装到控件中去。
    /// <summary>
    /// RailWrapper
    ///     ID
    ///     RailEntity
    ///     Status
    ///     Progress
    /// 
    /// Dictionary<string, RailWrapper> RailDic
    /// </summary>

    class RailMode
    {
        private RailProgress _progress;

        public RailID ID;

        public SkinPictureBox ImageBox;

        public RailStatus Status;

        public RailProgress Progress
        {
            get
            {
                return this._progress;
            }

            set
            {
                this._progress = value;

                if (ImageBox != null)
                {
                    //此处相当于加了一个属性的 监听事件（NotifyPropertyChanged），有改动就触发UI更新。
                    this.ChangeImage();
                }
            }
        }


        private void ChangeImage()
        {
            string color = this.ConvertToColor(this._progress);
            if (string.IsNullOrEmpty(color))
            {
                return;
            }

            //代表哪个轨道：1,2,3,4
            int railNum = (int)this.ID;
            string imgName = string.Format("_{0}{1}.png", railNum, color);
            this.ImageBox.BackgroundImage = (System.Drawing.Image)(Resources.ResourceManager.GetObject(imgName));
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
                case RailProgress.Stop:
                    color = "Gray";
                    break;

            }

            return color;
        }
    }
}
