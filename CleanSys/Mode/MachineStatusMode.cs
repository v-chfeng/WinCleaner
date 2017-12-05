using CleanSys.SelfEnum;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CleanSys.Mode
{
    public class MachineStatus
    {
        private List<int> _stepsList;

        public int machineNum { get; set; }

        public int stepNum { get; set; }

        public bool IsError { get; set; }

        public bool AllDone { get; set; }

        public string ErrorMsg { get; set; }

        // 清理轨道进度
        public int stepOneProcess { get; set; }

        // 滴定无水乙醇
        public int stepTwoProcess { get; set; }

        // 涂润滑油
        public int stepThreeProcess { get; set; }

        // 进度list
        public List<int> StepsList
        {
            get
            {
                this._stepsList = new List<int>();
                this._stepsList.Add(stepOneProcess);
                this._stepsList.Add(stepTwoProcess);
                this._stepsList.Add(stepThreeProcess);

                return this._stepsList;
            }
        }
    }

    public class SyncStatusMode
    {
        public RailID CurrentRailID;
        public CleanSteps CleanSteps;

        /// <summary>
        /// 有可能是回传的小车的轨道距离
        /// </summary>
        public float ProgressRate;

        public bool IsError;
        public string ErrorMsg;
    }
}
