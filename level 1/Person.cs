using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConstructorVariableModifier
{
    // Person Class (Copy Constructor)
    class Person
    {
        public string name;
        public int age;

        // Parameterized Constructor
        public Person(string name, int age)
        {
            this.name = name;
            this.age = age;
        }

        // Copy Constructor
        public Person(Person other) 
        {
            this.name = other.name;
            this.age = other.age;
        }

        public void DisplayDetails()
        {
            Console.WriteLine("Person name: " + this.name);
            Console.WriteLine("Person age: " + this.age);
        }

        public static void Main()
        {
            // create object of Person class
            Person person1 = new Person("Rohit", 24);
            Person person2 = new Person(person1);

            person1.DisplayDetails();
            person2.DisplayDetails();
        }
    }

}
