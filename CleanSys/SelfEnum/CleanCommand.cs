using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CleanSys.SelfEnum
{
    public enum CleanCommand
    {
        StartAutoClean,
        PauseAutoClean,
        ContinueClean,
        StopAutoClean,

        Forward,
        Backward,
        StopManualClean,

        GetStatus,
    }
}
