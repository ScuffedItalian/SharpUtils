using System;

namespace Calculator
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Give paramater 1\n");
            double x = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Give paramater 2\n");
            double y = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Give your operator\n");
            string op = Console.ReadLine();

            double opOut;

            switch(op)
            {
                case "+":
                    opOut = x + y;
                    break;
                case "-":
                    opOut = x - y;
                    break;
                case "*":
                    opOut = x * y;
                    break;
                case "/":
                    opOut = x / y;
                    break;
                default:
                    Console.WriteLine("INVALID");
                    return;
            }
            Console.BackgroundColor = ConsoleColor.Green;
            Console.WriteLine("The answer is: " + opOut);
        }
    }
}
