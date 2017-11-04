using CleanSys.SelfEnum;
using CleanSys.Mode;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CleanSys.Util
{
    public static class MachineSender
    {
        public const string Command_Start = "Start";
        public const string Command_GetStatus = "Get";
        public const string Command_Stop = "Stop";
        private static MockMachineReceiver receiver;
        private static string IP;
        private static string Port;
        private static MockMachineReceiver mockReceiver = new MockMachineReceiver();

        public static bool SendCMD(string cmd)
        {
            IP = ConfigurationManager.AppSettings["IP"];
            Port = ConfigurationManager.AppSettings["Port"];

            bool isSuccess = true;

            if (cmd == Command_Start)
            {
                receiver = new MockMachineReceiver();
            }

            return isSuccess;
        }

        public static bool SendCMD(RailID railID, CleanCommand cmd)
        {  
            switch (cmd)
            {
                case CleanCommand.StartAutoClean:
                    mockReceiver.StartAutoClean(railID);
                    break;
                case CleanCommand.PauseAutoClean:
                    mockReceiver.PauseAutoClean(railID);
                    break;
                case CleanCommand.ContinueClean:
                    mockReceiver.ContinueClean(railID);
                    break;
                case CleanCommand.StopAutoClean:
                    mockReceiver.StopAutoClean(railID);
                    break;
                case CleanCommand.Forward:
                    mockReceiver.Forward(railID);
                    break;
                case CleanCommand.ContinueForward:
                    mockReceiver.ContinueForward(railID);
                    break;
                case CleanCommand.Backward:
                    mockReceiver.Backward(railID);
                    break;
                case CleanCommand.ContinueBackword:
                    mockReceiver.ContinueBackword(railID);
                    break;
                case CleanCommand.PauseManualClean:
                    mockReceiver.PauseManualClean(railID);
                    break;
                case CleanCommand.StopManualClean:
                    mockReceiver.StopManualClean(railID);
                    break;
            }

            return true;
        }

        public static SyncStatusMode GetStatus()
        {
            return mockReceiver.SendStatus();
        }
    }
}
