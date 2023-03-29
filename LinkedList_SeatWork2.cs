using System;
using System.Collections.Generic;

namespace LinkedList
{
    class program
    {
		//initialize a cartList linkedlist
        static LinkedList<string> cartList = new LinkedList<string>();
        
        static void Main(string[] args)
        {
            bool running = true;

            while (running)
            {
                Console.Clear();
                Console.WriteLine("=== Shopping Cart Manager ===");
                Console.WriteLine("1. Add item");
                Console.WriteLine("2. Remove first item");
                Console.WriteLine("3. Remove last item");
                Console.WriteLine("4. Clear cart");
                Console.WriteLine("5. View cart");
                Console.WriteLine("6. Exit");

                Console.Write("\nEnter your choice: ");
                //accept user input
                string inputvar = Console.ReadLine();
                int choice;


                // check if user input is int
                bool canConvert = int.TryParse(inputvar, out choice); 


                //conditional statements
                if (canConvert == false)
                {
                    Console.WriteLine("Please enter a number! 1-6");
                    Console.ReadLine();
                }
                else 
                {
                    //menu 
                    switch (choice)
                    {
                        case 1:
                            AddItem();
                            break;
                        case 2:
                            RemoveFirstItem();
                            break;
                        case 3:
                            RemoveLastItem();
                            break;
                        case 4:
                            ClearCart();
                            break;
                        case 5:
                            ViewCart();
                            break;
                        case 6:
                            Environment.Exit(0); 
                            break;
                        default:
                            Console.WriteLine("Invalid choice. Please enter 1-6");
                            break;

                    }

                    Console.WriteLine("\n Press any key to continue.....");
                    Console.ReadKey();
                }
            }
            Console.ReadLine();
        }

        //linkedList addLast
        static void AddItem()
        {
            Console.Write("\nEnter item name: ");
            string item = Console.ReadLine();
            cartList.AddLast(item); //addLast
            Console.WriteLine($"{item} has been added to the cart.");
        }
        
        //linkedList removeFirst
        static void RemoveFirstItem()
        {
            if (cartList.Count == 0)
            {
                Console.WriteLine("Cart is empty");
            }
            else
            {
                string item = cartList.First.Value;
                cartList.RemoveFirst(); //removeFirst
                Console.WriteLine($"{item} has been removed from the cart.");

            }
        }

        //linkedList removeLast
        static void RemoveLastItem()
        {
            if (cartList.Count == 0)
            {
                Console.WriteLine("Cart is empty");
            }
            else
            {
                string item = cartList.Last.Value;
                cartList.RemoveLast();//removeLast
                Console.WriteLine($"{item} has been removed from the cart.");
            }
        }

        //linkedList clear
        static void ClearCart()
        {

            if (cartList.Count == 0)
            {
                Console.WriteLine("Cart is empty");

            }
            else
            {
                cartList.Clear(); //clear
                Console.WriteLine("Cart has been cleared.");
            }
        }

        //use foreach to display cartlist 
        static void ViewCart()
        {

            if (cartList.Count == 0)
            {
                Console.WriteLine("Cart is empty");

            }
            else
            {
                Console.WriteLine("Items in cart: ");
                foreach (string item in cartList)
                {
                    Console.WriteLine("- " + item);
                }
            }
        }

    }
}
