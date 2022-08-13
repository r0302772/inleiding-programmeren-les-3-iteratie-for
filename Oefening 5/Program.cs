using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Oefening_5
{
    class Program
    {
        static void Main(string[] args)
        {
            //Edit window title
            Console.Title = "Exercise 5";

            //Edit screencolors
            Console.BackgroundColor = ConsoleColor.White;
            Console.ForegroundColor = ConsoleColor.Black;
            //Reset console
            Console.Clear();

            //Declare variables
            int number1, number2;

            Console.Write("Choose a number: ");
            number1 = int.Parse(Console.ReadLine());

            Console.Write("Choose a number that's at least 5 lower: ");
            number2 = int.Parse(Console.ReadLine());

            Console.WriteLine();
            for (int i = number1; i >= number2; i--)
            {
                if (i != number2)
                {
                    Console.Write($"{i} * ");
                }
                else
                {
                    Console.Write($"{i}\n");
                }
            }

            Console.WriteLine("\nPress enter to continue...");

            Console.ReadLine();
            //The program shuts down after the user presses enter
        }
    }
}
