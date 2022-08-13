using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Oefening_6
{
    class Program
    {
        static void Main(string[] args)
        {
            //Edit window title
            Console.Title = "Exercise 6";

            //Edit screencolors
            Console.BackgroundColor = ConsoleColor.White;
            Console.ForegroundColor = ConsoleColor.Black;
            //Reset console
            Console.Clear();

            //Declare variables
            int number1, number2, start;
            string message = "";

            Console.Write("Choose a number: ");
            number1 = int.Parse(Console.ReadLine());

            Console.Write("Choose a second number: ");
            number2 = int.Parse(Console.ReadLine());

            if (number1 < number2)
            {
                if (number1 % 2 == 0)
                {
                    start = number1;
                }
                else
                {
                    start = number1 + 1;
                }

                for (int i = start; i < number2; i += 2)
                {
                    if (i == start)
                    {
                        message += $"{start}";
                    }
                    else
                    {
                        message += $" * {i}";
                    }
                }
            }
            else
            {
                if (number1 % 2 == 0)
                {
                    start = number1;
                }
                else
                {
                    start = number1 - 1;
                }

                for (int i = start; i >= number2; i -= 2)
                {
                    if (i == start)
                    {
                        message += $"{start}";
                    }
                    else
                    {
                        message += $" * {i}";
                    }
                }
            }

            Console.WriteLine($"\n{message}");

            Console.WriteLine("\nPress enter to continue...");

            Console.ReadLine();
            //The program shuts down after the user presses enter
        }
    }
}
