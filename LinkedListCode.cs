using System;
using System.Collections.Generic;

namespace LinkedListCode
{
    class program
    {
        static void Main(string[] arg)
        {
        
            LinkedList<string> cart = new LinkedList<string>();

            cart.AddFirst("Egg");
            cart.AddFirst("Potato");
            cart.AddLast("Pork");
            cart.AddLast("Spicy");
            cart.AddLast("Fish");


            Console.WriteLine("Cart List: ");
            foreach (var item in cart) 
            {
                Console.WriteLine(item);

            }
            Console.WriteLine("\n==================\n");

            LinkedListNode<string> node = cart.Find("Spicy");

            if(node != null)
            {
                cart.AddBefore(node,"Beef");
                cart.AddAfter(node,"Chiken leg");
            }


            Console.WriteLine("Cureet Cart List: ");
            foreach (var item in cart)
            {
                Console.WriteLine(item);
            }


            Console.ReadLine();
        }
    }
}
