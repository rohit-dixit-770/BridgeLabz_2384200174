using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week_4_Assignment1
{
    public abstract class WareHouseManagement
    {
        public string Name { get; set; }
        public WareHouseManagement(string name)
        {
            this.Name = name;
        }

        public virtual void DisplayItemName()
        {
            Console.WriteLine(Name);
        }
    }

    class Electronics : WareHouseManagement
    {
        public Electronics(string name) : base(name)
        {
            this.Name = name;
        }

        public override void DisplayItemName()
        {
            Console.WriteLine(Name);
        }
    }

    class Groceries : WareHouseManagement
    {
        public Groceries(string name) : base(name)
        {
            this.Name = name;
        }
        public override void DisplayItemName()
        {
            Console.WriteLine(Name);
        }
    }

    class Furniture : WareHouseManagement
    {
        public Furniture(string name) : base(name)
        {
            this.Name = name;
        }
        public override void DisplayItemName()
        {
            Console.WriteLine(Name);
        }

    }

    class Storage<T> where T : WareHouseManagement
    {
        public List<T> list = new List<T>();

        public void AddItem(T name)
        {
            list.Add(name);

        }

        public void DisplayItem()
        {
            foreach (var name in list)
            {
                name.DisplayItemName();
            }
        }
    }
}

   
