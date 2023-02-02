using System;

namespace TemperatureConvert
{
    class program {

        public double VarC, VarF;

        public double FtoC() {

            Console.WriteLine("Please input Fahrenheit value : ");
            VarF = Convert.ToInt32(Console.ReadLine());
            VarC = (VarF - 32) * 5 / 9;
            return VarC;
        }
        public double CtoF() {

            Console.WriteLine("Please input Celsius value : ");
            VarC = Convert.ToInt32(Console.ReadLine());
            VarF = VarC * 9 / 5 + 32;
            return VarF;
        }

        static void Main(string[] args) {

            double resultF, resultC;
            int choice;

            program n = new program();
            do
            {
                Console.WriteLine("\n====Temperature convert====\n");
                Console.WriteLine("1. Celsius to Fahrenheit");
                Console.WriteLine("2. Fahrenheit to Celsius");
                Console.WriteLine("3. Exiting program");
                Console.WriteLine("\n========\n");
                choice = Convert.ToInt32(Console.ReadLine());

                switch (choice)
                {
                    case 1:
                        resultF = n.CtoF();
                        Console.WriteLine("Fahrenheit  is : " + resultF + "°F");
                        break;
                    case 2:
                        resultC = n.FtoC();
                        Console.WriteLine("Celsius  is : " + resultC + "°C");
                        break;
                    case 3:
                        System.Environment.Exit(0);
                        break;
                    default:
                        Console.WriteLine("Invalid choice. Please try again.");
                        break;
                }

            } while (choice != 3);

            Console.ReadLine();

        }
        
    }


}