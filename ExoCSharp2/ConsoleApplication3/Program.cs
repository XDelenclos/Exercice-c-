using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter your favorite color: ");
            string colorName = Console.ReadLine();
            ConsoleColor color;

            if (Enum.TryParse(colorName, out color))
            {
                Console.ForegroundColor = color;
                Console.WriteLine("This is your favorite color!");
            }
            else
            {
                Console.WriteLine("I'm sorry, that color is not recognized.");
            }

            Console.ReadKey();
        }
    }
}
