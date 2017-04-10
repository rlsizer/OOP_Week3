using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Week3
{
    class Program
    {
        static void Main(string[] args)
        {

            Car car1 = new Car("Phantom","Rolls-Royce","emerald green","2013",4,5,"RR21GT7V34753");

            Console.WriteLine("My car is an " +car1.color+" "+ car1.year + " " + car1.make + " " + car1.model+".");

            car1.make = "Dodge";
            car1.model = "Viper";
            car1.color = "scarlet red";
            car1.year = "2008";

            Console.WriteLine("My car is a " + car1.color + " " + car1.year + " " + car1.make + " " + car1.model + ".");

        }
    }
}
