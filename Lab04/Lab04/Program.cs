using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab04
{
    class Program
    {
        static void Main(string[] args)
        {
            // Counter-controlled repetition requires a control variable, an initial value of the control variable, an increment (or decrement) so the variable is modified in the loop, and a loop-continuation condition that determines whether looping should continue.
            // The 'for' loop used only when we already knew the number of iterations. The 'while' loop used only when the next number is not exactly known.
            // A do/while is used when you want to go through the loop at least once and repeat based on the condition. 
            {
                int i;
                for (i = 1; i <= 100; i++)
                {
                    if (i % 2 == 0)
                    {
                        Console.Write("It's even ");
                    }
                    else
                    {
                        Console.Write("It's false ");
                    }
                    Console.WriteLine($"{i} ");
                }
                Console.Write("Press enter for next program.");
                Console.WriteLine(@"
                ");
                Console.ReadLine();
            }
            {
                Console.Write("Please, enter the temperaturet: ");
                int temperature = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine();
                {
                    if (temperature < 10)
                        Console.Write("Polar Bear");
                    else if (temperature < 20)
                        Console.Write("Penguin");
                    else if (temperature < 40)
                        Console.Write("Moose");
                    else if (temperature < 50)
                        Console.Write("Reindeer");
                    else if (temperature < 60)
                        Console.Write("Deer");
                    else if (temperature < 70)
                        Console.Write("Turtle");
                    else if (temperature < 80)
                        Console.Write("Lion");
                    else if (temperature < 90)
                        Console.Write("Fish");
                    else
                        Console.Write("Bug");
                }
                Console.WriteLine(@"
                ");
                Console.Write("Press enter for next program.");
                Console.WriteLine(@"
                ");
                Console.ReadLine();
            }
            {
                int i = 10;
                while (i <= 20)
                {
                    Console.WriteLine(i);
                    i += 1;
                }
                Console.WriteLine(@"
                ");
                Console.Write("Press enter for next program.");
                Console.WriteLine(@"
                ");
                Console.ReadLine();
            }
            {
                for (int i = 0; i <= 100; i++)
                {
                    Console.WriteLine(i);
                    Console.WriteLine("********");
                }
                Console.ReadLine();
            }
        }
    }
}
