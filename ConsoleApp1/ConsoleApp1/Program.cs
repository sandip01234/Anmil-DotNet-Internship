using ConsoleApp1;
using System;

class Program
{
    static void Main()
    {
        while (true)
        {
            Console.WriteLine("\n Internship Assignments Menu ");
            Console.WriteLine("1. Assignment 2 - Variables & Age in Days");
            Console.WriteLine("2. Assignment 3 - Personal Information Collector");
            Console.WriteLine("3. Assignment 4 - Simple Calculator + Compound Interest");
            Console.WriteLine("4. Exit");
            Console.Write("Choose an option: ");

            string choice = Console.ReadLine();

            switch (choice)
            {
                case "1":
                    Assignment2 a2 = new Assignment2();
                    a2.Run();
                    break;
                case "2":
                    Assignment3 a3 = new Assignment3();
                    a3.Run();
                    break;
                case "3":
                    Assignment4 a4 = new Assignment4();
                    a4.Run();
                    break;
                case "4":
                    Console.WriteLine("Exiting program...");
                    return;
                default:
                    Console.WriteLine("Invalid choice. Try again.");
                    break;
            }
        }
    }
}
