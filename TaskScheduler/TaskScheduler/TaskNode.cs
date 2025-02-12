using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TaskScheduler
{
    public class TaskNode
    {
        public int TaskID;
        public string TaskName;
        public int Priority;
        public DateTime DueDate;
        public TaskNode Next;

        public TaskNode(int taskID, string taskName, int priority, DateTime dueDate)
        {
            TaskID = taskID;
            TaskName = taskName;
            Priority = priority;
            DueDate = dueDate;
            Next = null;
        }

        public override string ToString()
        {
            return $"TaskID: {TaskID}, TaskName: {TaskName}, Priority: {Priority}, DueDate: {DueDate:yyyy-MM-dd}";
        }
    }

}
