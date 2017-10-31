﻿using CleanSys.Enum;
using CleanSys.Mode;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CleanSys.Util
{
    public static class MachinePortal
    {
        public static bool StartAutoClean(RailID railID)
        {
            return MachineSender.SendCMD(railID, CleanCommand.StartAutoClean);
        }

        public static bool PauseAutoClean(RailID railID)
        {
            return MachineSender.SendCMD(railID, CleanCommand.PauseAutoClean);
        }

        public static bool StopAutoClean(RailID railID)
        {
            return MachineSender.SendCMD(railID, CleanCommand.StopManualClean);
        }

        public static bool Forward(RailID railID)
        {
            return MachineSender.SendCMD(railID, CleanCommand.Forward);
        }

        public static bool Backward(RailID railID)
        {
            return MachineSender.SendCMD(railID, CleanCommand.Backward);
        }

        public static bool StopManualClean(RailID railID)
        {
            return MachineSender.SendCMD(railID, CleanCommand.StopManualClean);
        }

        public static MachineStatus GetStatus()
        {
            return MachineSender.GetStatus();
        }
    }
}