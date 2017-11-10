using CleanSys.SelfEnum;
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

        public static bool ContinueAutoClean(RailID railID)
        {
            return MachineSender.SendCMD(railID, CleanCommand.ContinueClean);
        }

        public static bool StopAutoClean(RailID railID)
        {
            return MachineSender.SendCMD(railID, CleanCommand.StopManualClean);
        }

        public static bool Forward(RailID railID, CleanSteps steps)
        {
            return MachineSender.SendCMD(railID, CleanCommand.Forward, steps);
        }

        public static bool PauseForward(RailID railID)
        {
            return MachineSender.SendCMD(railID, CleanCommand.PauseManualClean);
        }

        public static bool ContinueForward(RailID railID)
        {
            return MachineSender.SendCMD(railID, CleanCommand.ContinueForward);
        }

        public static bool Backward(RailID railID, CleanSteps steps)
        {
            return MachineSender.SendCMD(railID, CleanCommand.Backward, steps);
        }

        public static bool PauseBackward(RailID railID)
        {
            return MachineSender.SendCMD(railID, CleanCommand.PauseManualClean);
        }

        public static bool ContinueBackward(RailID railID)
        {
            return MachineSender.SendCMD(railID, CleanCommand.ContinueBackword);
        }

        public static bool StopManualClean(RailID railID)
        {
            return MachineSender.SendCMD(railID, CleanCommand.StopManualClean);
        }

        public static SyncStatusMode GetStatus()
        {
            return MachineSender.GetStatus();
        }
    }
}
