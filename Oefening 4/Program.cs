using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Oefening_4
{
    class Program
    {
        static void Main(string[] args)
        {
            //Edit window title
            Console.Title = "Exercise 4";

            //Edit screencolors
            Console.BackgroundColor = ConsoleColor.White;
            Console.ForegroundColor = ConsoleColor.Black;
            //Reset console
            Console.Clear();

            //Declare variables
            int length, width;
            string title = "Supporterscraf", symbol1, symbol2;

            Console.WriteLine(title);
            Console.WriteLine(new string('*', title.Length));

            Console.Write("Choose symbol 1: ");
            symbol1 = Console.ReadLine();

            Console.Write("Choose symbol 2: ");
            symbol2 = Console.ReadLine();

            Console.Write("How long does the scarf has to be? ");
            length = int.Parse(Console.ReadLine());

            Console.Write("How wide does the scarf has to be? ");
            width = int.Parse(Console.ReadLine());

            for (int i = length; i > 0; i--)
            {
                for (int i2 = width; i2 > 0; i2--)
                {
                    if (i % 2 == 0)
                    {
                        Console.Write(symbol1);
                    }
                    else
                    {
                        Console.Write(symbol2);
                    }
                }

                Console.WriteLine();
            }

            Console.WriteLine("\nPress enter to continue...");

            Console.ReadLine();
            //The program shuts down after the user presses enter
        }
    }
}
