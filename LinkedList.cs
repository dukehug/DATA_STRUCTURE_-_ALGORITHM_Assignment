using System;
using System.Collections.Generic;

namespace Machine_Problem_3_midtrem
{
    class Program
    {
        static void Main(string[] arg)
        {
            //initialization a string linkedlist
            LinkedList<string> musiclist = new LinkedList<string>();
          
            //use addLast , add songs to musiclist
            musiclist.AddLast("TIAN MIMI");
            musiclist.AddLast("I'M Still loving you");
            musiclist.AddLast("MEI HUA");
            musiclist.AddLast("TSUGUNAI");
            musiclist.AddLast("GOOD NEW YEAR");
            musiclist.AddLast("QIAN YAN WAN YU");

            Console.WriteLine("\n\tTeresa teng songs:\n");
          
            foreach (string play in musiclist)
            {
                
                Console.WriteLine(play);

            }
          
            //use find() method to find TIANMIMI node
            var node = musiclist.Find("TIAN MIMI");

            //conditional statement
            if (node != null)
            {
              	//add the YOU ARE IN MY HEART before TIANMIMI
                musiclist.AddBefore(node, "YOU ARE IN MY HEART"); 
								
             		//add the The Moon Represents My Heart after TIANMIMI
                musiclist.AddAfter(node, "The Moon Represents My Heart");  

            }

            //output:   YOU ARE IN MY HEART  TIAN MIMI  The Moon Represents My Heart..........QIAN YAN WAN YU 
            Console.WriteLine("\n\tCurrent Teresa teng songs is:\n");
            foreach (string play in musiclist)
            {
                Console.WriteLine(play);

            }

            Console.WriteLine("\n=======================");

            Console.ReadLine();
        }

    }

}
