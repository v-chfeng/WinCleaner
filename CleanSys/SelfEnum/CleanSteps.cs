using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CleanSys.SelfEnum
{
    public enum CleanSteps
    {
        UnSupported,
        /// <summary>
        /// step one: 清理轨道
        /// </summary>
        CleanRail,//StepOne,

        /// <summary>
        /// step three: 滴定无水乙醇
        /// </summary>
        DropAlcohol,

        /// <summary>
        /// step two: 涂润滑油
        /// </summary>
        CoveredWithGrease,

        /// <summary>
        /// 清理完成
        /// </summary>
        Done,
    }
}
