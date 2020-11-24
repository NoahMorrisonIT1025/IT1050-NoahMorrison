using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ch_7_test_2
{
    class RandomIntegers
    {
        static void Main()
        {
            Random randomNumbers = new Random();
            
            for (int counter =1; counter <= 20; ++counter)
            {
                int face = randomNumbers.Next(1, 7);
                Console.Write($"{face} ");
            }
            Console.WriteLine();
            Console.ReadKey();
        }
    }
}
