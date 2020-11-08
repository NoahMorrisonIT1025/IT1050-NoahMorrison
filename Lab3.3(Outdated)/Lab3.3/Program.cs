using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab3._3
{
    class Program
    {
        static void Main()
        {
            Console.Write("Enter the amount of fahrenheit: ");
            int fahrenheit = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Celsius = {0}", (fahrenheit - 32) * 5 / 9);
            if (fahrenheit < 40)
                Console.Write("it is cold");
            if (fahrenheit > 90)
                Console.Write("it is hot");
            Console.ReadKey();
            
        }
    }
}
