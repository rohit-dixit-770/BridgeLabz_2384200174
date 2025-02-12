namespace InventoryManagementSystem
{
    class Program
    {
        static void Main()
        {
            InventoryLinkedList inventory = new InventoryLinkedList();

            // Add new items
            inventory.AddAtEnd("Laptop", 1, 4, 1000);
            inventory.AddAtEnd("Mouse", 2, 08, 50);
            inventory.AddAtEnd("Keyboard", 3, 20, 95);

            // Display all items
            Console.WriteLine("All Items:");
            inventory.DisplayAllItems();

            // Search for an item by Item ID
            Console.WriteLine("\nSearch for item with Item ID 2:");
            ItemNode item = inventory.SearchByItemID(2);
            if (item != null)
            {
                Console.WriteLine(item.ToString());
            }
            else
            {
                Console.WriteLine("Item not found.");
            }

            // Update the quantity of an item
            Console.WriteLine("\nUpdate Quantity for item with Item ID 2:");
            inventory.UpdateQuantity(2, 20);
            inventory.DisplayAllItems();

            // Calculate and display the total value of inventory
            Console.WriteLine("\nTotal Value of Inventory:");
            inventory.DisplayTotalValue();

            // Sort the inventory by Item Name in ascending order
            Console.WriteLine("\nSort Inventory by Item Name (Ascending):");
            inventory.SortByNameAscending();
            inventory.DisplayAllItems();

            // Sort the inventory by Price in descending order
            Console.WriteLine("\nSort Inventory by Price (Descending):");
            inventory.SortByPriceDescending();
            inventory.DisplayAllItems();

            // Remove an item by Item ID
            Console.WriteLine("\nRemove item with Item ID 1:");
            inventory.RemoveByItemID(1);
            inventory.DisplayAllItems();
            Console.ReadKey();
        }
    }
    }