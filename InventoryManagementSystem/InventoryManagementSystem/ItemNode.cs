using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InventoryManagementSystem
{
    public class ItemNode
    {
        public string ItemName;
        public int ItemID;
        public int Quantity;
        public double Price;
        public ItemNode Next;

        public ItemNode(string itemName, int itemID, int quantity, double price)
        {
            ItemName = itemName;
            ItemID = itemID;
            Quantity = quantity;
            Price = price;
            Next = null;
        }

        public override string ToString()
        {
            return $"Item Name: {ItemName}, Item ID: {ItemID}, Quantity: {Quantity}, Price: {Price:C}";
        }
    }

}
