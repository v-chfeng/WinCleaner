using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CleanSys.SelfEnum
{
    /// <summary>
    /// 轨道清理进度.暂停并不影响进度
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

        /// <summary>
        /// 停止，不知道图标应该是什么样子
        /// </summary>
        Stop,
    }
}
