using System;

namespace SampleApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("========================================");
            Console.WriteLine("    Custom CLI Calculator Utility       ");
            Console.WriteLine("========================================");

            try
            {
                Console.Write("Enter first number: ");
                double num1 = Convert.ToDouble(Console.ReadLine());

                Console.Write("Enter an operator (+, -, *, /): ");
                string op = Console.ReadLine();

                Console.Write("Enter second number: ");
                double num2 = Convert.ToDouble(Console.ReadLine());

                double result = 0;
                bool valid = true;

                switch (op)
                {
                    case "+": result = num1 + num2; break;
                    case "-": result = num1 - num2; break;
                    case "*": result = num1 * num2; break;
                    case "/":
                        if (num2 != 0) result = num1 / num2;
                        else { Console.WriteLine("Error: Division by zero."); valid = false; }
                        break;
                    default:
                        Console.WriteLine("Invalid operator.");
                        valid = false;
                        break;
                }

                if (valid)
                {
                    Console.WriteLine($"\nResult: {num1} {op} {num2} = {result}");
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"\nInput error: {ex.Message}");
            }

            Console.WriteLine("========================================");
            Console.WriteLine("Press any key to exit...");
            Console.ReadKey();
        }
    }
}