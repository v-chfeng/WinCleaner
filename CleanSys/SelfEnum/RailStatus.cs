using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CleanSys.SelfEnum
{
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
    }
}
