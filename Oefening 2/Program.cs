using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Oefening_2
{
    class Program
    {
        static void Main(string[] args)
        {
            //Edit window title
            Console.Title = "Exercise 2";

            //Edit screencolors
            Console.BackgroundColor = ConsoleColor.White;
            Console.ForegroundColor = ConsoleColor.Black;
            //Reset console
            Console.Clear();

            //Declare variables
            string name, message;
            int luckynumber;

            Console.Write("Enter your name: ");
            name = Console.ReadLine();

            Console.Write("What is your lucky number? ");
            luckynumber = int.Parse(Console.ReadLine());

            //Calculations
            message = $"\n{luckynumber}";

            for (int i = 1; i <= luckynumber; i++)
            {
                message += $" {name}";
            }

            //Results
            Console.WriteLine(message);

            Console.WriteLine("\nPress enter to continue...");

            Console.ReadLine();
            //The program shuts down after the user presses enter
        }
    }
}
