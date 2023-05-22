using System;
using System.Collections.Generic;

namespace InventoryAndOrderManagementSystem
{
    class Program
    {
        //Initialize Dictionary and List   inventory and Order
        static Dictionary<string, (int quantity, decimal price)> inventory = new Dictionary<string, (int quantity, decimal price)>();
        static List<Order> orderList = new List<Order>();

        #region Main method - While loop  and If..else satatment -  User login and Main menu; 
        static void Main(string[] args)
        {
            Console.WriteLine(@"


           __
      (___()'`;     Welcome ! 
      /,    /`
      \\""--\\


");
            Console.WriteLine("================================================================");
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
                    Console.WriteLine("\n ============= Login successful! =============\n");
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
                Console.WriteLine("\t Please choose an option:\t \n");
                Console.WriteLine("1. Inventory management system");
                Console.WriteLine("2. Order management system");
                Console.WriteLine("3. Exit");

                int option = Convert.ToInt32(Console.ReadLine());

                switch (option)
                {
                    case 1:
                        InventoryManager();
                        break;
                    case 2:
                        OrderManager();
                        break;
                    case 3:
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
                Console.WriteLine(@"

██ ███    ██ ██    ██ ███████ ███    ██ ████████  ██████  ██████  ██    ██ 
██ ████   ██ ██    ██ ██      ████   ██    ██    ██    ██ ██   ██  ██  ██  
██ ██ ██  ██ ██    ██ █████   ██ ██  ██    ██    ██    ██ ██████    ████   
██ ██  ██ ██  ██  ██  ██      ██  ██ ██    ██    ██    ██ ██   ██    ██    
██ ██   ████   ████   ███████ ██   ████    ██     ██████  ██   ██    ██    
                                                                           
                                                                           
");
                Console.WriteLine("================================================================");
                Console.WriteLine("Please choose an option:\n");
                Console.WriteLine("1. Add item to inventory");
                Console.WriteLine("2. Remove item from inventory");
                Console.WriteLine("3. Update inventory");
                Console.WriteLine("4. View inventory");
                Console.WriteLine("5. Back");

                int option = Convert.ToInt32(Console.ReadLine());

                switch (option)
                {
                    case 1:
                        AddItemToInventory();
                        break;
                    case 2:
                        RemoveItemFromInventory();
                        break;
                    case 3:
                        UpdateInventory();
                        break;
                    case 4:
                        ViewInventory();
                        break;
                    case 5:
                        isRunning = false;
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
                Console.WriteLine(@"

 ██████  ██████  ██████  ███████ ██████  
██    ██ ██   ██ ██   ██ ██      ██   ██ 
██    ██ ██████  ██   ██ █████   ██████  
██    ██ ██   ██ ██   ██ ██      ██   ██ 
 ██████  ██   ██ ██████  ███████ ██   ██ 
                                         
                                         

");
                Console.WriteLine("Please choose an option:");
                Console.WriteLine("1. Add order");
                Console.WriteLine("2. Print order");
                Console.WriteLine("3. View sales summary");
                Console.WriteLine("4. View inventory");
                Console.WriteLine("5. Back");

                int option = Convert.ToInt32(Console.ReadLine());

                switch (option)
                {

                    case 1:
                        AddOrder();
                        break;
                    case 2:
                        PrintOrders();
                        break;
                    case 3:
                        ViewSalesSummary();
                        break;
                    case 4:
                        ViewInventory();
                        break;
                    case 5:
                        isRunning = false;
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

                //dictionary key        value
                inventory[itemName] = (newItemQuantity, newItemPrice);
                Console.WriteLine("Inventory updated.");
            }
            else
            {
                Console.WriteLine("Enter item quantity:");
                int itemQuantity = int.Parse(Console.ReadLine());

                Console.WriteLine("Enter item price:");
                decimal itemPrice = int.Parse(Console.ReadLine());

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
                //dictionary.remove()
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
            //dictionary.count();
            if (inventory.Count > 0)
            {
                Console.WriteLine("\n\t\t======== Current Inventory ========\n");
                Console.WriteLine($"\t\tItem\t\tQuantity\tPrice\n");
                //use foreach display all item and quantity and price 
                foreach (KeyValuePair<string, (int quantity, decimal price)> item in inventory)
                {

                    Console.WriteLine($"\t\t{item.Key}\t\t{item.Value.quantity}\t\t{item.Value.price}\n");
                }

            }
            else
            {
                Console.WriteLine("\n\t\t!!======== !!Inventory is empty!! ========!!\n");

            }

            Console.ReadLine();

        }
        #endregion

        #region List  and Dictionary - Order management;


        //order class  for AddOrder 
        class Order
        {
            //get
            public string CustomerName { get; }
            public string ProductName { get; }
            public int ProductQuantity { get; }
            public decimal ProductPrice { get; }
            public decimal TotalPrice { get; }

            //function to set value
            public Order(string customerName, string productName, int productQuantity, decimal productPrice, decimal totalPrice)
            {

                //set
                CustomerName = customerName;
                ProductName = productName;
                ProductQuantity = productQuantity;
                ProductPrice = productPrice;
                TotalPrice = totalPrice;
            }
        }

        //addorder
        static void AddOrder()
        {
            Console.WriteLine("Enter customer name:");
            string customerName = Console.ReadLine();


            bool addProduct = true;

            while (addProduct)
            {
                Console.WriteLine("Enter product name:");
                string productName = Console.ReadLine();

                Console.WriteLine("Enter product quantity:");
                int productQuantity = int.Parse(Console.ReadLine());

                //Console.WriteLine("Enter product price:");
                //decimal productPrice = decimal.Parse(Console.ReadLine());

                if (inventory.ContainsKey(productName))
                {
                    var (quantity, price) = inventory[productName];

                    if (quantity >= productQuantity)
                    {
                        // calculate the total price for the order
                        decimal totalPrice = price * productQuantity;

                        // reduce the quantity in the inventory  
                        quantity -= productQuantity;

                        // display order details
                        Console.WriteLine("Order placed successfully!\n");
                        Console.WriteLine("==========================");
                        Console.WriteLine("\n\t\t ======== Order Receipt ======== \n");
                        Console.WriteLine("Customer Name\t Product Name \t Product Quantity\t Product Price");
                        Console.WriteLine($"\n{customerName}\t\t\t{productName}\t\t{productQuantity}\t\t\t{price}");
                        Console.WriteLine("\nTotal amount: " + totalPrice.ToString("N")); 
                        Console.WriteLine("---------------------------\n");

                        // update the inventory in the dictionary
                        inventory[productName] = (quantity,price);

                        // create a new order and add it to the order list (List<>)
                        Order newOrder = new Order(customerName, productName, productQuantity, price, totalPrice);
                        orderList.Add(newOrder);

                        Console.WriteLine("Order placed successfully.");
                        
                    }
                    else
                    {
                        Console.WriteLine("Insufficient quantity in the inventory.");
                    }
                }
                else
                {
                    Console.WriteLine("Product not found in the inventory.");

                }
                Console.Write("Add another Product to the order? (Y/N): ");
                string addAnother = Console.ReadLine();

                if (addAnother.ToUpper() != "Y")
                {
                    addProduct = false;
                }
            }

           
        }

        //printer all custoemr order
        static void PrintOrders()
        {
            //use list.count to check List 
            if (orderList.Count > 0)
            {
                Console.WriteLine("\n\t\t======== Customer Orders ========\n");
                foreach (var order in orderList)
                {
                    Console.WriteLine("Customer Name\t Product Name \t Product Quantity\t Product Price");
                    Console.WriteLine($"\n{order.CustomerName}\t\t\t{order.ProductName}\t\t{order.ProductQuantity}\t\t\t{order.ProductPrice}");
                    Console.WriteLine("\nTotal amount: " + order.TotalPrice.ToString("N"));
                    Console.WriteLine("------------------------");
                }
            }
            else
            {
                Console.WriteLine("\n\t\t!!======== !!Orderlist is empty!! ========!!\n");

            }

            Console.ReadKey();
        }

        //summary sales
        static void ViewSalesSummary()
        {
            Dictionary<string, decimal> customerSales = new Dictionary<string, decimal>();

            //check if have order
            if (orderList.Count > 0 )
            {
                foreach (var order in orderList)
                {
                    if (customerSales.ContainsKey(order.CustomerName))
                    {
                        customerSales[order.CustomerName] += order.TotalPrice;
                    }
                    else
                    {
                        //add customersales to Dictionary
                        customerSales.Add(order.CustomerName, order.TotalPrice);
                    }
                }

                Console.WriteLine("\n\t\t======== Sales Summary ========\n");

                decimal totalSales = 0;
                //display summary
                foreach (var entry in customerSales)
                {
                    Console.WriteLine("Customer Name \t Amount ");
                    Console.WriteLine($"\n{entry.Key}\t\t{entry.Value.ToString("N")}");
                    Console.WriteLine("------------------------");
                    totalSales += entry.Value;
                }

                Console.WriteLine("\nTotal Amount (All Customers): " + totalSales.ToString("N"));
            }
            else
            {
                Console.WriteLine("\n\t\t!!======== !!No customer order!! ========!!\n");
            }
            Console.ReadKey();
        }
        #endregion
    }
   
}
