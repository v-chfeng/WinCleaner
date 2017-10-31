using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CleanSys.Enum
{
    public enum CleanCommand
    {
        StartAutoClean,
        PauseAutoClean,
        StopAutoClean,

        Forward,
        Backward,
        StopManualClean,

        GetStatus,
    }
}
