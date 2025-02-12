using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InventoryManagementSystem
{
    public class InventoryLinkedList
    {
        private ItemNode head; 

        public InventoryLinkedList()
        {
            head = null;
        }

        // Add an item at the beginning
        public void AddAtBeginning(string itemName, int itemID, int quantity, double price)
        {
            ItemNode newNode = new ItemNode(itemName, itemID, quantity, price);
            newNode.Next = head;
            head = newNode;
        }

        // Add an item at the end
        public void AddAtEnd(string itemName, int itemID, int quantity, double price)
        {
            ItemNode newNode = new ItemNode(itemName, itemID, quantity, price);
            if (head == null)
            {
                head = newNode;
                return;
            }

            ItemNode current = head;
            while (current.Next != null)
            {
                current = current.Next;
            }

            current.Next = newNode;
        }

        // Add an item at a specific position
        public void AddAtPosition(string itemName, int itemID, int quantity, double price, int position)
        {
            if (position == 0)
            {
                AddAtBeginning(itemName, itemID, quantity, price);
                return;
            }

            ItemNode newNode = new ItemNode(itemName, itemID, quantity, price);
            ItemNode current = head;
            for (int i = 0; i < position - 1; i++)
            {
                if (current == null)
                {
                    Console.WriteLine("Position out of bounds.");
                    return;
                }

                current = current.Next;
            }

            newNode.Next = current.Next;
            current.Next = newNode;
        }

        // Remove an item based on Item ID
        public void RemoveByItemID(int itemID)
        {
            if (head == null)
            {
                Console.WriteLine("List is empty.");
                return;
            }

            if (head.ItemID == itemID)
            {
                head = head.Next;
                return;
            }

            ItemNode current = head;
            while (current.Next != null && current.Next.ItemID != itemID)
            {
                current = current.Next;
            }

            if (current.Next == null)
            {
                Console.WriteLine("Item with given ID not found.");
                return;
            }

            current.Next = current.Next.Next;
        }

        // Update the quantity of an item by Item ID
        public void UpdateQuantity(int itemID, int newQuantity)
        {
            ItemNode item = head;
            while (item != null)
            {
                if (item.ItemID == itemID)
                {
                    item.Quantity = newQuantity;
                    return;
                }
                item = item.Next;
            }

            Console.WriteLine("Item with given ID not found.");
        }

        // Search for an item based on Item ID
        public ItemNode SearchByItemID(int itemID)
        {
            ItemNode current = head;
            while (current != null)
            {
                if (current.ItemID == itemID)
                {
                    return current;
                }

                current = current.Next;
            }

            return null;
        }

        // Search for an item based on Item Name
        public ItemNode SearchByItemName(string itemName)
        {
            ItemNode current = head;
            while (current != null)
            {
                if (current.ItemName.Equals(itemName, StringComparison.OrdinalIgnoreCase))
                {
                    return current;
                }

                current = current.Next;
            }

            return null;
        }

        // Calculate and display the total value of inventory
        public void DisplayTotalValue()
        {
            double totalValue = 0;
            ItemNode current = head;
            while (current != null)
            {
                totalValue += current.Price * current.Quantity;
                current = current.Next;
            }

            Console.WriteLine($"Total value of inventory: {totalValue:C}");
        }

        // Display all items
        public void DisplayAllItems()
        {
            ItemNode current = head;
            while (current != null)
            {
                Console.WriteLine(current.ToString());
                current = current.Next;
            }
        }

        // Sort the inventory based on Item Name in ascending order
        public void SortByNameAscending()
        {
            if (head == null)
            {
                return;
            }

            for (ItemNode i = head; i.Next != null; i = i.Next)
            {
                for (ItemNode j = i.Next; j != null; j = j.Next)
                {
                    if (string.Compare(i.ItemName, j.ItemName, StringComparison.OrdinalIgnoreCase) > 0)
                    {
                        Swap(i, j);
                    }
                }
            }
        }

        // Sort the inventory based on Item Name in descending order
        public void SortByNameDescending()
        {
            if (head == null)
            {
                return;
            }

            for (ItemNode i = head; i.Next != null; i = i.Next)
            {
                for (ItemNode j = i.Next; j != null; j = j.Next)
                {
                    if (string.Compare(i.ItemName, j.ItemName, StringComparison.OrdinalIgnoreCase) < 0)
                    {
                        Swap(i, j);
                    }
                }
            }
        }

        // Sort the inventory based on Price in ascending order
        public void SortByPriceAscending()
        {
            if (head == null)
            {
                return;
            }

            for (ItemNode i = head; i.Next != null; i = i.Next)
            {
                for (ItemNode j = i.Next; j != null; j = j.Next)
                {
                    if (i.Price > j.Price)
                    {
                        Swap(i, j);
                    }
                }
            }
        }

        // Sort the inventory based on Price in descending order
        public void SortByPriceDescending()
        {
            if (head == null)
            {
                return;
            }

            for (ItemNode i = head; i.Next != null; i = i.Next)
            {
                for (ItemNode j = i.Next; j != null; j = j.Next)
                {
                    if (i.Price < j.Price)
                    {
                        Swap(i, j);
                    }
                }
            }
        }

        // Helper method to swap data between two nodes
        private void Swap(ItemNode a, ItemNode b)
        {
            string tempName = a.ItemName;
            int tempID = a.ItemID;
            int tempQuantity = a.Quantity;
            double tempPrice = a.Price;

            a.ItemName = b.ItemName;
            a.ItemID = b.ItemID;
            a.Quantity = b.Quantity;
            a.Price = b.Price;

            b.ItemName = tempName;
            b.ItemID = tempID;
            b.Quantity = tempQuantity;
            b.Price = tempPrice;
        }
    }

}
