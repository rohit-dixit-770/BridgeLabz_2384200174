using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week_4_Assignment_5and6_Testing
{
    public class TImeOutProblem
    {
        public string LongRunningTask()
        {
            Thread.Sleep(3000); // Simulate a long-running task (3 seconds)
            return "Completed";
        }
    }
}
