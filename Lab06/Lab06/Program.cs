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
            //p[0], p[1], p[2], p[3]
            {
                string[] months = new string[12] { "January", "February", "March", "April", "May", "June", "July", "August", "September", "October", "November", "December" };
                for (int i = 0; i < months.Length; i++)
                {
                    Console.WriteLine(months[i]);
                }
                Console.ReadLine();
            }
            {
                string[] seasons = { "Spring", "Summer", "Fall", "Winter" };
                foreach (string i in seasons)
                {
                    Console.WriteLine(i);
                }
                Console.ReadLine();
            }
            {
                Random random = new Random();
                int randomNumber

                    randomNumber = random.Next(0, 100);
            }
        }
    }
}
