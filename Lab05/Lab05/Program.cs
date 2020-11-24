using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab05
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
             * public double getArea(double height, double width)
             * {
             *     return height * width;
             * }
             * 
             * 2.
             *      a.	"public" is a Scope: the portion of the app that can refer to the declared entity by its unqualified name. 
             *      b.	Static vs. Non-Static: static methods can by accessed directly from the class. non-static methods have to be accessed from an instance. 
             *      c.	"double" is a Return Type: The data type of the value the method returns. If the method does not return any value
             *      d.	"getArea" is a Method Name (Identifier): It cannot be same as any other identifier declared in the class. 
             *      e.	"(double height, double width)" are the Parameters: used to pass and receive data from a method. 
             *      f.	"return height * width;" is a Method Body: This contains the set of instructions needed to complete the required activity.
             * 
             * 3.   User defined method is written by the user and are hidden from other methods. Methods provided by the framework are able to be reused from several locations in an app.
             * 
             * 4.   A static method belongs inside a class and a non-static method belongs in each class instance.
             * 
             */
            {
                Dog myDog = new Dog();
                myDog.Name = "Fido";
                myDog.Bark();
                myDog.DoTrick("Fetch");

                // To do: uncomment the following lines of code to call the methods
                // myDog.bark();
                // myDog.doTrick("Fetch");
                Console.ReadKey();
            }
        }
    }
}

