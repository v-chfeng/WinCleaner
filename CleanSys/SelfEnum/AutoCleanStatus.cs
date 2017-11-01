using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CleanSys.SelfEnum
{
    /// <summary>
    /// 描述所有轨道的状态，方便form判断状态
    /// </summary>
    public enum AutoCleanStatus
    {
        WaitSelect,
        Ready,
        Running,
        Pause,
    }
}
