using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab3
{
    class Program
    {
        static void Main()
        {
            {
                /* The if single-selection statement is a single-entry/single-exit control statement. 
                 * The while repetition (or looping) statement allows you to specify that a program should repeat an action while some condition remains true.
                 * 
                */

                int speedLimit;
                int speed;

                speedLimit = 35;
                speed = 42;
                if (speed > speedLimit)
                    Console.Write("SLOW DOWN, NOW!!!");
                else if (speed <= speedLimit)
                {
                    Console.Write("Your following the speed limit.");
                }

                Console.ReadKey();
            }
        }
    }
}
/*
{
    int isTrue;
    int isFalse;
}
{
    double fahrenheit = Convert.ToDouble(Console.ReadLine());
    double celsius = (fahrenheit - 32) * 5 / 9;

}
{
    int fahrenheit;
    int celsius;
    fahrenheit = 65;
    celsius = (fahrenheit - 32) * 5 / 9;
    if (celsius < 40)
        Console.Write("it is cold");
    if (celsius > 90)
        Console.Write("it is hot");
    Console.ReadKey();
}



int temp;
temp = 90;
if (temp > 90)
    Console.WriteLine("This porridge is too hot.");
if (temp < 70)
    Console.WriteLine("This porridge is too cold.");
if (temp == 80)
    Console.WriteLine("This porridge is just right!");

int counter;
counter = 1;
while (counter > 20)
{
    // body of loop
    counter = counter + 1;
}  // end while
*/
