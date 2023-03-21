/*
Machine Problem 2 - Midterm
Author: Duke Hsu
Date: 08 PM, Mar,15 2023
*/

using System;
using System.Collections.Generic;

namespace InventoryManagement
{
    class Program
    {
        static void Main(string[] args)
        {

            //stack and queue example for inventory and order 

            //initialize Stack and Queue
            Stack<string> inventory = new Stack<string>();  //stack:   last in ,frist out;  frist in , last out;
            Queue<string> orders = new Queue<string>();     //queue:   frist in , frist out; last in ,last out;

            // use push add items to inventory
            inventory.Push("Huawei LCD");
            inventory.Push("Xiaomi Battery");
            inventory.Push("iPhone Case");
            inventory.Push("Repair Tools");

            // print inventory
            Console.WriteLine("==== Inventory: ====");
            foreach (var item in inventory)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine();

            // use enqueue add orders
            orders.Enqueue("Order 1");
            orders.Enqueue("Order 2");
            orders.Enqueue("Order 3");

            // process orders
            Console.WriteLine("==== Processing orders: ====");
            while (orders.Count > 0)
            {
                var order = orders.Dequeue(); //use dequeue  operation orders
                Console.WriteLine("Processing order: " + order + " ↓"); 

                if (inventory.Count > 0)
                {
                    var item = inventory.Pop(); ////use pop operation inventory
                    Console.WriteLine("Order with item: " + item);
                }
                else
                {
                    Console.WriteLine("The order cannot be fulfilled due to insufficient inventory.");
                }

            }
            //update latest inventory 
            Console.WriteLine("\n==== Latest inventory list : ====\n");

            foreach (var item in inventory)
            {
                Console.WriteLine(item);
            }

            Console.WriteLine("\nInventory amount : " + inventory.Count());
            Console.WriteLine("================");

            Console.ReadLine();
        }
    }
}

