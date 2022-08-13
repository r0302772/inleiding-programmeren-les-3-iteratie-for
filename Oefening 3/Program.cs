using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Oefening_3
{
    class Program
    {
        static void Main(string[] args)
        {
            //Edit window title
            Console.Title = "Exercise 3";

            //Edit screencolors
            Console.BackgroundColor = ConsoleColor.White;
            Console.ForegroundColor = ConsoleColor.Black;
            //Reset console
            Console.Clear();

            //Declare variables
            int positiveNumber;
            string message = "";

            Console.Write("Enter a positive number: ");
            positiveNumber = int.Parse(Console.ReadLine());

            //Calculations
            for (int i = positiveNumber; i >= 1; i--)
            {
                message += $"\n {Math.Pow(i, 2)}";
            }

            //Results
            Console.WriteLine(message);

            Console.WriteLine("\nPress enter to continue...");

            Console.ReadLine();
            //The program shuts down after the user presses enter
        }
    }
}
