using System;

namespace ConsoleApp1
{
    public class Assignment4
    {
        public void Run()
        {
            Console.WriteLine("\n Assignment 4: Simple Calculator");

            Console.Write("Enter first number: ");
            double num1 = Convert.ToDouble(Console.ReadLine());

            Console.Write("Enter second number: ");
            double num2 = Convert.ToDouble(Console.ReadLine());

            Console.Write("Choose operation (+, -, *, /): ");
            string op = Console.ReadLine();

            double result = 0;

            if (op == "+")
                result = num1 + num2;
            else if (op == "-")
                result = num1 - num2;
            else if (op == "*")
                result = num1 * num2;
            else if (op == "/")
            {
                if (num2 == 0)
                    Console.WriteLine("Error: Division by zero is not allowed!");
                else
                    result = num1 / num2;
            }
            else
                Console.WriteLine("Invalid operation!");

            Console.WriteLine($"Result: {result}");

            // Ask if user wants compound interest calculation
            Console.Write("\nDo you want to calculate Compound Interest? (yes/no): ");
            string choice = Console.ReadLine().ToLower();

            if (choice == "yes" || choice == "y")
            {
                Console.WriteLine("\n--- Compound Interest Calculator ---");

                Console.Write("Enter principal amount (P): ");
                double P = Convert.ToDouble(Console.ReadLine());

                Console.Write("Enter annual interest rate (in %): ");
                double ratePercent = Convert.ToDouble(Console.ReadLine());
                double r = ratePercent / 100; // convert percent to decimal

                Console.Write("Enter number of times interest is compounded per year (n): ");
                int n = Convert.ToInt32(Console.ReadLine());

                Console.Write("Enter time in years (t): ");
                int t = Convert.ToInt32(Console.ReadLine());

                // Formula: A = P * (1 + r/n)^(n*t)
                double A = P * Math.Pow((1 + r / n), n * t);

                Console.WriteLine($"Future Value (A): {A:F2}");
            }
            else
            {
                Console.WriteLine("Compound Interest calculation skipped.");
            }
        }
    }
}
