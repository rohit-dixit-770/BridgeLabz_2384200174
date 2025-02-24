using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Reflection;

namespace Week_4_Assignment_6_Annotion
{
    [AttributeUsage(AttributeTargets.Class | AttributeTargets.Method, AllowMultiple = false, Inherited = false)]
    public class TaskInfo : Attribute
    {
        public int Priority { get; }
        public string AssignTo { get; }

        public TaskInfo(int priority, string assignTo)
        {
            this.Priority = priority;
            this.AssignTo = assignTo;

        }
    }

    public class TaskManager
    {
        
        [TaskInfo(1,"computer")]
        public void DisplayData()
        {
            Console.WriteLine("the data is: ");
        }
    }

    class Display
    {
        public void ShowData()
        {
            Type type = typeof(TaskManager);
            MethodInfo method = type.GetMethod("DisplayData");
            if (method != null)
            {
                var data = (TaskInfo)Attribute.GetCustomAttribute(method, typeof(TaskInfo));
                if (data != null)
                {
                    Console.WriteLine("the priority is : " + data.Priority + " and it assign to : " + data.AssignTo);
                }
            }
        }
    }
}
