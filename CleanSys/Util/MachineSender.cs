using CleanSys.Enum;
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
            return SendCMD("Start");

            /*
            switch (cmd)
            {
                case CleanCommand.StartAutoClean:
                    //SendCMD()
                    break;
                case CleanCommand.StopAutoClean:
                    break;
                case CleanCommand.Forward:
                    break;
                case CleanCommand.Backward:
                    break;
                case CleanCommand.StopManualClean:
                    break;
            }

            return true;
            */
        }

        public static MachineStatus GetStatus()
        {
            MachineStatus status;

            if (receiver == null)
            {
                status = new MachineStatus();
                status.IsError = true;
                status.ErrorMsg = "请先启动清理机器";
            }
            else
            {
                status = receiver.SendStatus();
            }

            return status;
        }
    }
}
