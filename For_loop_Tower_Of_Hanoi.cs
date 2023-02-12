//Forloop 

using System;

namespace TowerofHanoi 
{ 
    public class Program
    {

        public static void Main(String[] args)
        {
        double x = 2;
        double result = 1;

        Console.WriteLine("T formula is 2^n - 1 \n");
        Console.WriteLine("Plasea enter value of N: ");

        double n = Convert.ToDouble(Console.ReadLine());

        for (int i = 0; i < n; i++) { 
        
            result *= x;
        
            }

        double t = result -1;

        Console.WriteLine("Result is " + t);

        Console.ReadLine();
        }
    }
}
