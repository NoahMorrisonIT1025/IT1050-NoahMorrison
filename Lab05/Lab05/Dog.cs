using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab05
{
    public class Dog
    {
        public string Name { get; set; }

        // Add bark() method
        public void Bark()
        {
            Console.WriteLine("{0} is Barking...", this.Name);
        }

        // Add doTrick() method
        public void DoTrick(string trickName)
        {
            Console.WriteLine("{0} is so smart! {0} is doing a(n) {1}", this.Name, trickName);
        }
    }
}
