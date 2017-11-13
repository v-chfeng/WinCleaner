using CleanSys.Mode;
using CleanSys.SelfEnum;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CleanSys.Util
{
    public class MockMachineReceiver
    {
        private RailID id;
        private int currentStep;//0：ready, 1:清理轨道， 2：涂润滑油，3：滴定无水乙醇
        private DateTime startTime;
        private int progress;
        private bool isDone;
        private int rate;
        private bool isSingleStep;
        private bool isAuto;
        private bool isForward;
        private bool isPause;
        

        public MockMachineReceiver()
        {
            this.Init();
        }

        public void Init()
        {
            this.currentStep = 0;
            this.startTime = DateTime.Now;
            this.progress = 0;
            this.isDone = false;
            this.rate = 10;
            this.isSingleStep = false;
            this.isAuto = false;
            this.isForward = false;
            this.isPause = true;
        }

        public SyncStatusMode SendStatus()
        {
            SyncStatusMode currentStatus = new SyncStatusMode();

            if (this.isDone)
            {
                currentStatus.CleanSteps = CleanSteps.Done;
            }
            else
            {
                if (!this.isPause)
                {
                    if (this.isAuto)
                    {
                        this.Clean(this.isSingleStep);
                    }
                    else
                    {
                        this.ManualClean(this.isForward);
                    }
                }

                currentStatus.IsError = false;
                currentStatus.ErrorMsg = string.Empty;
                currentStatus.CurrentRailID = this.id;
                currentStatus.ProgressRate = this.progress;
                currentStatus.CleanSteps = (CleanSteps)this.currentStep;
            }

            return currentStatus;
        }

        public void StartAutoClean(RailID id)
        {
            this.startTime = DateTime.Now;
            this.currentStep = 1;
            this.isAuto = true;
            this.id = id;
            this.isPause = false;
            this.isDone = false;
            this.progress = 0;
        }

        public void PauseAutoClean(RailID id)
        {
            this.id = id;
            this.isPause = true;
        }

        public void ContinueClean(RailID id)
        {
            this.startTime = DateTime.Now;
            this.id = id;
            this.isPause = false;
        }

        public void StopAutoClean(RailID id)
        {
            this.Init();
            this.id = id;
            this.isPause = true;
        }

        public void Forward(RailID id, CleanSteps step)
        {
            this.startTime = DateTime.Now;
            this.isAuto = false;
            this.isForward = true;
            this.id = id;
            this.isPause = false;
            this.currentStep = (int)step;
        }

        public void ContinueForward(RailID id, CleanSteps step)
        {
            this.startTime = DateTime.Now;
            this.id = id;
            this.isPause = false;
            this.currentStep = (int)step;
        }

        public void Backward(RailID id, CleanSteps step)
        {
            this.startTime = DateTime.Now;
            this.isAuto = false;
            this.isForward = false;
            this.id = id;
            this.isPause = false;
            this.currentStep = (int)step;
        }

        public void ContinueBackword(RailID id, CleanSteps step)
        {
            this.startTime = DateTime.Now;
            this.id = id;
            this.isPause = false;
            this.currentStep = (int)step;
        }

        public void PauseManualClean(RailID id)
        {
            this.id = id;
            this.isPause = true;
        }

        public void StopManualClean(RailID id)
        {
            this.Init();
            this.id = id;
            this.isPause = true;
        }

        private void Clean(bool isSingleStep = false)
        {
            TimeSpan span = DateTime.Now - this.startTime;
            this.startTime = DateTime.Now;
            int spanProcess = (int)span.TotalSeconds * this.rate;

            if (this.progress + spanProcess > 100)
            {
                this.currentStep++;
                if (this.currentStep > 3 || isSingleStep)
                {
                    this.isDone = true;
                    this.currentStep = 0;
                    this.progress = 0;
                }
                else
                {
                    this.progress = (this.progress + spanProcess) % 100;
                }
            }
            else
            {
                this.progress += spanProcess;
            }
        }

        private void ManualClean(bool isForward)
        {
            TimeSpan span = DateTime.Now - this.startTime;
            int spanProcess = (int)span.TotalSeconds * this.rate;
            int tempProcess = isForward ? this.progress + spanProcess : this.progress - spanProcess;
            if (tempProcess > 100)
            {
                this.isDone = true;
                this.progress = 100;
            }
            else if (tempProcess < 0)
            {
                this.isDone = true;
                this.progress = 0;
            }
            else
            {
                this.progress = tempProcess;
            }            
        }
    }
}
