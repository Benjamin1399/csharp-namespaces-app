using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//using ConsoleUI.Models;
//using ConsoleUI.CalculationLibrary.Calculations; 

namespace ConsoleUI
{
    class Program
    {
        static void Main(string[] args)
        {
            Models.PersonModel person = new Models.PersonModel("Benjamin", "Naidoo");

            Console.WriteLine($"My name is {person.FirstName} {person.LastName}");

            double result = CalculationLibrary.Calculations.Add(3.5, 4.5);
            Console.WriteLine($"Result of 3.5 and 4.5 is {result}");

            Console.ReadLine();
        }
    }
}
