using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week_4_Assignment_6_Annotion
{
    class Animal
    {
        public virtual void MakeSound()
        {
            Console.WriteLine("animal Sound.");
        }
    }
    class Dog : Animal
    {
        public override void MakeSound()
        {
            Console.WriteLine("Dog sound.");
        }
    }
}
