using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab03
{
    class Program
    {
        static void Main(string[] args)
        {
            {
                /* 2.
                 * The if single-selection statement is a single-entry/single-exit control statement. 
                 * The while repetition (or looping) statement allows you to specify that a program should repeat an action while some condition remains true.
                 * They both use Boolean expressions
                 * An if statement identifies which statement to run, and a while statement that executes a statement while a Boolean expression evaluates to true.
                */

                //3.3
                int speedLimit;
                int speed;

                speedLimit = 35;
                speed = 42;
                if (speed > speedLimit)
                    Console.Write("SLOW DOWN, NOW!!!");
                Console.WriteLine(@"
                ");
                Console.Write("Press enter for next program." + " 3.4");
                Console.WriteLine(@"
                ");
                Console.ReadLine();
            }
            {
                //3.4
                bool condition = true;

                if (condition)
                {
                    Console.WriteLine("It is true.");
                }
                else
                {
                    Console.WriteLine("It is false.");
                }
                Console.WriteLine(@"
                ");
                Console.Write("Press enter for next program." + " 3.5");
                Console.WriteLine(@"
                ");
                Console.ReadLine();
            }
            {
                Console.Write("Enter the amount of fahrenheit: ");
                int fahrenheit = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("Celsius = {0}", (fahrenheit - 32) * 5 / 9);
                if (fahrenheit <= 40)
                    Console.Write("it is cold");
                if (fahrenheit >= 90)
                    Console.Write("it is hot");
                Console.WriteLine(@"
                ");
                Console.Write("Press enter for next program." + " 3.6");
                Console.WriteLine(@"
                ");
                Console.ReadLine();
            }
            {
                int i = 1;
                while (i <= 10)
                {
                    {
                    Console.Write("While statement ");
                    Console.WriteLine(i);
                    i += 1;
                    }
                }
                Console.WriteLine(@"
                ");
                Console.Write("Press enter for next program." + " 3.7");
                Console.WriteLine(@"
                ");
                Console.ReadLine();
            }
            {
                int i = 60;
                while (i >= 20)
                {
                    Console.Write("While statement ");
                    // Write the index to the screen.
                    Console.WriteLine(i);
                    i -= 5;
                }
                Console.WriteLine(@"
                ");
                Console.Write("Press enter for next program." + " 3.8");
                Console.WriteLine(@"
                ");
                Console.ReadLine();
            }
            {
                int i = 10;
                while (i <= 20)
                {
                    Console.Write("While statement ");
                    Console.WriteLine(i);
                    i += 2;
                }
                Console.ReadLine();
            }
        }
    }
}
