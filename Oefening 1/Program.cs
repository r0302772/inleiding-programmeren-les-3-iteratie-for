using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Oefening_1
{
    class Program
    {
        static void Main(string[] args)
        {
            //Edit window title
            Console.Title = "Exercise 1";

            //Edit screencolors
            Console.BackgroundColor = ConsoleColor.White;
            Console.ForegroundColor = ConsoleColor.Black;
            //Reset console
            Console.Clear();

            //Declare variables
            int sum = 0, quantity = 10;

            //Calculations
            for (int i = 1; i <= quantity; i++)
            {
                Console.Write($"Give a number {i}: ");
                sum += int.Parse(Console.ReadLine());
            }

            //Results
            Console.WriteLine($"\nThe sum of the {quantity} numbers is {sum}.");

            Console.WriteLine("\nPress enter to continue...");

            Console.ReadLine();
            //The program shuts down after the user presses enter
        }
    }
}
