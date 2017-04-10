using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Week3
{
    class Car
    {
        //fields
        private string model;
        private string make;
        private string color;
        private string year;
        private int numOfDoors;
        private int numOfSeats;
        private string VIN;

        //properties
        public string Model
        {
            get { return this.model; }
            set
            {
                if (value.ToLower() == "phantom")
                {
                    model = "Venom";
                }

                else
                {
                    model = value;
                }
                
            }
        }

        

        public string Make
        {
            get { return this.make; }
            
        }

        public string CarName
        {
            get { return this.make + " " + this.model; }
        }


        //constructors
        //create a constructor; constructors are always public
        public Car(string model, string make, string color, string year, int numOfDoors, int numOfSeats, string VIN)
        {
            this.model = model;
            this.make = make;
            this.color = color;
            this.year = year;
            this.numOfDoors = numOfDoors;
            this.numOfSeats = numOfSeats;
            this.VIN = VIN;

        }

        //methods

        public void PrintCarInfo()
        {
            Console.WriteLine("This car is a " + CarName+ " that is "+color+".");
            Console.WriteLine("It has " + numOfDoors + " doors and " + numOfSeats+" seats.");
            Console.WriteLine("The VIN # is " + VIN+".");

        }

        public void TrashCompactor(int countDown)
        {
            for (int i = countDown; i >= 0; i--)
            {
                Console.WriteLine("Trash compactor starting in: " + i);
            }

            color = "crunched";
            make = "smashed.. :(";
            model = "cubed";
            numOfDoors = -2;
            numOfSeats = 0;
            VIN = "Doesn't matter anymore.";

            Console.WriteLine("Thank you for recycling your car!");
        }

    }
}
