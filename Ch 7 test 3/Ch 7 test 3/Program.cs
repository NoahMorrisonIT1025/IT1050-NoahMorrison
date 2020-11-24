using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ch_7_test_3
{
    class Program
    {
        static void Main()
        {
            int x = 10;
            Console.WriteLine($"x squared: {Square(x)}");
            Console.ReadKey();
        }
        static int Square(int y)
        {
            return y * y;
        }
    }
}
