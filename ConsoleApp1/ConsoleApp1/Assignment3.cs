using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class Assignment3
    {
        public void Run()
        {
            Console.WriteLine("\n Assignment 3: Personal Information Collector ");

            Console.Write("Enter your name: ");
            string name = Console.ReadLine();

            Console.Write("Enter your age: ");
            int age = Convert.ToInt32(Console.ReadLine());

            Console.Write("Enter your city: ");
            string city = Console.ReadLine();

            Console.Write("Enter your favorite hobby: ");
            string hobby = Console.ReadLine();

            Console.WriteLine("\n Personal Information ");
            Console.WriteLine($"Name: {name}");
            Console.WriteLine($"Age: {age}");
            Console.WriteLine($"City: {city}");
            Console.WriteLine($"Favorite Hobby: {hobby}");

            int currentYear = DateTime.Now.Year;
            int birthYear = currentYear - age;
            Console.WriteLine($"Estimated Birth Year: {birthYear}");
        }
    }
}
