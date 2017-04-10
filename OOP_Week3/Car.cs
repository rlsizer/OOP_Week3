using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Week3
{
    class Car
    {

        private string model;
        private string make;
        private string color;
        private string year;
        private int numOfDoors;
        private int numOfSeats;
        private string VIN;

        //Add a property
        public string Model
        {
            get { return this.model; }
            set
            {
                if (value.ToLower() == "rolls-royce")
                {
                    model = "Aston Martin";
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
            set { make = value; }
        }

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




    }
}
