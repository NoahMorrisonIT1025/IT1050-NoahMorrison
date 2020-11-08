using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Lab3._2
{
    class Program
    {
        static void Main()
        {

            {
                bool condition = true;

                if (condition)
                {
                    Console.WriteLine("It is true.");
                }
                else
                {
                    Console.WriteLine("It is false.");
                }
                Console.ReadKey();
            }
            /*
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

        }
    }
}
