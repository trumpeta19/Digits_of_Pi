using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Digits_of_Pi_2
{
    class Program
    {
        static void Main()
        {
            const int MAX = 14;
            int digits;

            do
            {
                Console.WriteLine();
                Console.WriteLine("Enter digits of pi to print");
                Console.WriteLine("Limit is " + MAX);
                if (int.TryParse(Console.ReadLine(), out digits))
                {
                    if (digits > MAX)
                    {
                        Console.WriteLine(Math.Round(Math.PI, MAX));
                    }
                    else
                    {
                        Console.WriteLine(Math.Round(Math.PI, digits));
                    }
                }
                else
                {
                    Console.WriteLine("Invalid Entry");
                }

                Console.WriteLine("Press any key to continue or 'Esc' to exit");

            } while (Console.ReadKey().Key != ConsoleKey.Escape);
        }
    }
}
