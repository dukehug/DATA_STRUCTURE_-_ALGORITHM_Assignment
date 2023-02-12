using System;

namespace Greatest_Common_Divisor{

    class program {

        //gcd formula 
        static int GCD(int num1, int num2) {

            int reminder;
            while(num2!= 0){ 
                reminder = num1 % num2;
                num1 = num2;

                num2= reminder;
            
            }

            return num1;

        }

        //main method
        static void Main(string[] args) { 
        
            int x , y;
            Console.WriteLine("Greatest Common Divisor formula is : GCD(a,b) = (a*b) / LCM (a , b)");

            Console.WriteLine("Plases enter first number: ");
            x = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Plases enter first number: ");
            y = Convert.ToInt32(Console.ReadLine());
            Console.Write("\nThe Greatest Common Divisor of  ");
            Console.WriteLine("{0} and {1} is {2}",x,y,GCD(x,y));

            Console.ReadLine();

        }
    
    }    

}
