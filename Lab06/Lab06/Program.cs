using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab06
{
    class Program
    {
        static void Main()
        {
            //2. p[0], p[1], p[2], p[3]

            //3
            string[] months = new string[12] { "January", "February", "March", "April", "May", "June", "July", "August", "September", "October", "November", "December" };
            for (int i = 0; i < months.Length; i++)
            {
                Console.WriteLine(months[i]);
            }
            Console.ReadLine();

            //4
            string[] seasons = { "Spring", "Summer", "Fall", "Winter" };
            foreach (string i in seasons)
            {
                Console.WriteLine(i);
            }
            Console.ReadLine();

            //5
            var arr = new int[1000];
            Random random = new Random();
            int randomNumber;
            for (int i = 0; i < arr.Length; i++)
            {
                randomNumber = random.Next(0, 100);
                arr[i] = randomNumber;
            }
            foreach (var item in arr)
            {
                Console.WriteLine(item);

            }
            Console.ReadLine();

            //6
            string[] names = { "Al Dente", "Anna Ghrahm", "Earle Bird", "Ginger Rayle", "Iona Ford" };

            int j = 0;
            while (j < names.Length)
            {
                Console.WriteLine(names[j]);
                j++;
            }
            Console.ReadLine();

            //7
            Number7();

            //8
            Number8();

        }

        private static void Number7()
        {
            string[] names = { "Al Dente", "Anna Ghrahm", "Earle Bird", "Ginger Rayle", "Iona Ford" };
            for (int i = 0; i < names.Length; i++)
            {
                int k = i + 1;
                Console.WriteLine("{0,2}. {1}", k, names[i]);
            }
            Console.ReadLine();
        }

        private static void Number8()
        {
            string[] names = { "Al Dente", "Anna Ghrahm", "Earle Bird", "Ginger Rayle", "Iona Ford" };
            foreach (var item in names)
            {
                Console.WriteLine(item);
            }
            Console.ReadLine();
        }
    }
}
