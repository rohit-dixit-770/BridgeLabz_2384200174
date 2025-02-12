using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RoundRobinSchedulingAlgorithm
{
    class ProcessNode
    {
        public int ProcessID;
        public int BurstTime;
        public int Priority;
        public ProcessNode Next;

        public ProcessNode(int processID, int burstTime, int priority)
        {
            ProcessID = processID;
            BurstTime = burstTime;
            Priority = priority;
            Next = null;
        }
    }

}
