//C sharp math method 

using System;

namespace Hanoi {

  class program {
  
    // formula method
    static double hanoi(double n)
    {
    double t;
    t = Math.Pow(2, n) - 1; //c sharp Math.Pow
    return t;
    }
    //main method
    static void Main(string[] args) {
    Console.WriteLine("Tower of Hanoi Formula is 2^n -1 ");
    Console.WriteLine("======================\n");
    Console.WriteLine("Please enter Value of N: ");
    //get value of N
    double i = double.Parse(Console.ReadLine());
    Console.WriteLine("\nThe Result is :" + hanoi(i));
    Console.ReadLine();
    }
  }
}
