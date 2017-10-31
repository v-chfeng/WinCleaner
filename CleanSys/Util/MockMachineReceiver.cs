using CleanSys.Mode;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CleanSys.Util
{
    public class MockMachineReceiver
    {
        private int currentWorkingMachineNum;
        private const int MachineCount = 4;

        // 清理速率 1% / 1s
        private int rate = 10;

        private int currentStepNum;
        private const int StepCount = 3;
        private DateTime startTime;
        private int currentProcess;
        private bool isDone;

        public MockMachineReceiver()
        {
            this.Init();
        }

        public void Init()
        {
            this.currentWorkingMachineNum = 1;
            this.currentStepNum = 1;
            this.startTime = DateTime.Now;
            this.currentProcess = 0;
            this.isDone = false;
        }

        public MachineStatus SendStatus()
        {
            this.Clean();

            MachineStatus currentStatus = new MachineStatus();

            if (this.isDone)
            {
                currentStatus.AllDone = true;
            }
            else
            {
                currentStatus.machineNum = this.currentWorkingMachineNum;
                currentStatus.stepNum = this.currentStepNum;
                currentStatus.stepOneProcess = currentStepNum > 1 ? 100 : this.currentProcess;
                currentStatus.stepTwoProcess = currentStepNum > 2 ? 100 : currentStepNum == 2 ? this.currentProcess : 0;
                currentStatus.stepThreeProcess = currentStepNum != 3 ? 0 : this.currentProcess;
                currentStatus.IsError = false;
                currentStatus.ErrorMsg = string.Empty;
            }

            return currentStatus;
        }

        public void Clean()
        {
            TimeSpan span = DateTime.Now - this.startTime;
            int spanProcess = (int)span.TotalSeconds * this.rate;

            if (this.currentProcess + spanProcess > 100)
            {
                if (this.currentStepNum + 1 > MockMachineReceiver.StepCount)
                {
                    if (this.currentWorkingMachineNum + 1 > MockMachineReceiver.MachineCount)
                    {
                        this.isDone = true;
                        //this.Init();
                    }
                    else
                    {
                        this.startTime = DateTime.Now;
                        this.currentWorkingMachineNum++;
                        this.currentStepNum = 1;
                        this.currentProcess = this.currentProcess + spanProcess - 100;
                    }
                }
                else
                {
                    this.startTime = DateTime.Now;
                    this.currentStepNum++;
                    this.currentProcess = this.currentProcess + spanProcess - 100;

                }
            }
            else
            {
                this.startTime = DateTime.Now;
                this.currentProcess = this.currentProcess + spanProcess;
            }
        }
    }
}
