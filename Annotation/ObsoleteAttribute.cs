using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week_4_Assignment_6_Annotion
{
    class LegacyAPI
    {
        [Obsolete("use method OldMethod", true)] //show a warning when this function is about to execute
        public void OldFeature() {
            Console.WriteLine("This is old Method.");    //message of old feature method
        }
        public void NewFeature()
        {
            Console.WriteLine("this is new method.");

        }

    }
}
