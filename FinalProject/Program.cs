using System;
using System.Collections.Generic;

namespace InventoryAndOrderManagementSystem
{
    class Program
    {
        //Initialize Dictionary and Queue and Stack
        static Dictionary<string, (int quantity, decimal price)> inventory = new Dictionary<string, (int quantity, decimal price)>();
        static Queue<string> orders = new Queue<string>();
        //static Stack<string> salesSummary = new Stack<string>();
        static Dictionary<string, (int orderQuantity, decimal amount)> salaesSummary = new Dictionary<string, (int orderQuantity, decimal amount)>();




        #region Main method - While loop  and If..else satatment -  Use login and Main menu; 
        static void Main(string[] args)
        {
            Console.WriteLine("\n==== Welcome use Order and Inventory manager system ====\n");

            bool isLoggedIn = false;

            while (!isLoggedIn)
            {
                Console.WriteLine("Please enter your username:");
                string username = Console.ReadLine();

                Console.WriteLine("Please enter your password:");
                string password = Console.ReadLine();

                if (username == "admin" && password == "password")
                {
                    isLoggedIn = true;
                    Console.WriteLine("\n Login successful! \n");
                }
                else
                {
                    Console.WriteLine("\n \n Invalid username or password. Please try again.");
                }
            }

            Console.WriteLine("\n \n Welcome to the Inventory and Order Management System!\n \n ");

            bool isRunning = true;

            while (isRunning)
            {
                Console.WriteLine("Please choose an option:");
                Console.WriteLine("1. Inventory management system");
                Console.WriteLine("2. Order management system");
                Console.WriteLine("3. Exit");

                string option = Console.ReadLine();

                switch (option)
                {
                    case "1":
                        InventoryManager();
                        break;
                    case "2":
                        OrderManager();
                        break;
                    case "3":
                        isRunning = false;
                        Console.WriteLine("Thank you for using the Inventory and Order Management System. Goodbye!");
                        break;
                    default:
                        Console.WriteLine("Invalid option. Please choose a valid option.");
                        break;
                }
            }
        }
        #endregion;


        #region Switch  and While loop -  Inventory and Order Menu;
        //inventory management menu
        static void InventoryManager()
        {
            bool isRunning = true;

            while (isRunning)
            {
                Console.WriteLine("Please choose an option:");
                Console.WriteLine("1. Add item to inventory");
                Console.WriteLine("2. Remove item from inventory");
                Console.WriteLine("3. Update inventory");
                Console.WriteLine("4. View inventory");
                Console.WriteLine("5. Back");

                string option = Console.ReadLine();

                switch (option)
                {
                    case "1":
                        AddItemToInventory();
                        break;
                    case "2":
                        RemoveItemFromInventory();
                        break;
                    case "3":
                        UpdateInventory();
                        break;
                    case "4":
                        ViewInventory();
                        break;
                    case "5":
                        isRunning = false;
                        Console.WriteLine("Thank you for using the Inventory Management System. Goodbye!");
                        break;
                    default:
                        Console.WriteLine("Invalid option. Please choose a valid option.");
                        break;
                }
            }

        }


        //order management menu
        static void OrderManager()
        {

            bool isRunning = true;

            while (isRunning)
            {
                Console.WriteLine("Please choose an option:");
                Console.WriteLine("1. Add order");
                Console.WriteLine("2. Print order");
                Console.WriteLine("3. View sales summary");
                Console.WriteLine("4. Back");

                string option = Console.ReadLine();

                switch (option)
                {

                    case "1":
                        AddOrder();
                        break;
                    case "2":
                        PrintOrder();
                        break;
                    case "3":
                        ViewSalesSummary();
                        break;
                    case "4":
                        isRunning = false;
                        Console.WriteLine("Thank you for using the Order Management System. Goodbye!");
                        break;
                    default:
                        Console.WriteLine("Invalid option. Please choose a valid option.");
                        break;
                }
            }


        }

        #endregion


        #region Dictionary - Inventory management;

        //add item to inventory  use Dictionary 
        static void AddItemToInventory()
        {
            Console.WriteLine("Enter item name:");
            string itemName = Console.ReadLine();

            if (inventory.ContainsKey(itemName))
            {
                Console.WriteLine("Item already exists in inventory. Enter new item quantity:");
                int newItemQuantity = int.Parse(Console.ReadLine());

                Console.WriteLine("Enter new item price:");
                decimal newItemPrice = decimal.Parse(Console.ReadLine());

                inventory[itemName] = (newItemQuantity, newItemPrice);
                Console.WriteLine("Inventory updated.");
            }
            else
            {
                Console.WriteLine("Enter item quantity:");
                int itemQuantity = int.Parse(Console.ReadLine());

                Console.WriteLine("Enter item price:");
                decimal itemPrice = decimal.Parse(Console.ReadLine());

                inventory[itemName] = (itemQuantity, itemPrice);
                Console.WriteLine("Item added to inventory.");
            }
        }



        //inventory remove
        static void RemoveItemFromInventory()
        {
            Console.WriteLine("Enter item name:");
            string itemName = Console.ReadLine();

            if (inventory.ContainsKey(itemName))
            {

                inventory.Remove(itemName);
                Console.WriteLine("Item removed from inventory.\n");
            }
            else
            {
                Console.WriteLine("Item not found in inventory.");
            }
        }


        //update inventory
        static void UpdateInventory()
        {
            Console.WriteLine("Enter item name:");
            string itemName = Console.ReadLine();

            if (inventory.ContainsKey(itemName))
            {
                Console.WriteLine("Enter new item quantity:");
                int newItemQuantity = int.Parse(Console.ReadLine());

                Console.WriteLine("Enter new item price");
                decimal newitemPrice = decimal.Parse(Console.ReadLine());

                inventory[itemName] = (newItemQuantity, newitemPrice);
                Console.WriteLine("Inventory updated.");
            }
            else
            {
                Console.WriteLine("Item not found in inventory.");
            }
        }


        //print inventory list
        static void ViewInventory()
        {

            if (inventory.Count > 0)
            {
                Console.WriteLine("\n\t\t======== Current Inventory ========\n");
                Console.WriteLine($"\t\tItem\t\tQuantity\tPrice\n");
                foreach (KeyValuePair<string, (int quantity, decimal price)> item in inventory)
                {

                    Console.WriteLine($"\t\t{item.Key}\t\t{item.Value.quantity}\t\t{item.Value.price}\n");
                }

            }
            else 
            {
                Console.WriteLine("\n\t\t!!======== !!Inventory is empty!! ========!!\n");
            
            }

        }
        #endregion


        #region Queue and Stack - Order management;
        public static void AddOrder()
        {

            Console.WriteLine("Enter Customer name:");
            string customer =Console.ReadLine();

            Console.WriteLine("Enter item name:");
            string itemName = Console.ReadLine();
           
            if (inventory.ContainsKey(itemName))
            {
                Console.WriteLine("Enter order quantity:");
                int orderQuantity = int.Parse(Console.ReadLine());
                orders.Enqueue(itemName);
                int currentQuantity = inventory[itemName].quantity;
                

                if (orderQuantity <= currentQuantity)
                {
                   
                    Console.WriteLine("Order placed successfully.");
                    inventory[itemName] = (currentQuantity - orderQuantity, inventory[itemName].quantity);

                    //salaesSummary[customer] = (orderQuantity);
                }
                else
                {
                    Console.WriteLine("Insufficient quantity in inventory.");
                }
            }
            else
            {
                Console.WriteLine("Item not found in inventory.");
            }


        }


      
        static void PrintOrder()
        {
            if (orders.Count > 0)
            {
                Console.WriteLine("Printing order...");

                while (orders.Count > 0)
                {
                    string item = orders.Dequeue();
                    
                    Console.WriteLine($"Item: {item}");
               

                    //salesSummary.Push(item);
                }
            }
            else
            {
                Console.WriteLine("No orders to print.");
            }
        }


        static void ViewSalesSummary()
        {
            Console.WriteLine("Sales Summary:");

            //foreach (string item in salesSummary)
            //{
            //    Console.WriteLine($"Item: {item}");
            //}
        }
        #endregion

    }
}
