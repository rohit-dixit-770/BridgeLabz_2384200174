using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Week_4_Assignment_6_Annotion
{
    
    class UncheckedOperation
    {
        public void Operation()
        {
            #pragma warning disable CS7036
            ArrayList list = new ArrayList();
            list.Add(1);
            list.Add("hi");
            list.Add(3.14);

            foreach (var item in list)
            {
                Console.WriteLine(item);
            }

            
        }
    }

}
