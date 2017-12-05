using CleanSys.Mode;
using CleanSys.SelfEnum;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace CleanSys.Util
{
    public class DataStatusSyncer
    {
        public delegate void UpdateUI(SyncStatusMode status);
        public UpdateUI UpdateUIDelegate;

        public delegate void AccomplishTask();
        public AccomplishTask TaskCallBack;
        private SyncStatusMode status;

        public void GetStatus()
        {
            do
            {
                status = MachinePortal.GetStatus();
                this.UpdateUIDelegate(status);
                Thread.Sleep(1000);
            }
            while (status.CleanSteps != CleanSteps.Done);

            this.TaskCallBack();
        }
    }
}
