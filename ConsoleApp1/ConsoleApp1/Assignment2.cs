using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class Assignment2
    {
        public void Run()
        {
            Console.WriteLine("\n Assignment 2: Variables & Age in Days ");

    
            string name = "Sandip";
            int age = 22;
            double gpa = 3.8;
            char grade = 'A';
            bool isActive = true;

            Console.WriteLine($"Name: {name}");
            Console.WriteLine($"Age: {age}");
            Console.WriteLine($"Grade: {grade}");
            Console.WriteLine($"GPA: {gpa}");
            Console.WriteLine($"Active Student: {isActive}");

            int ageInDays = age * 365;
            Console.WriteLine($"Age in days (approx): {ageInDays}");

            Console.WriteLine($"Today's Date: {DateTime.Now.ToShortDateString()}");
        }
    }
}
