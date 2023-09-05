using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classes
{
    class Car
    {
        public Car()
        {

        }

        public Car(string make, string model, int year)
        {
            Make = make;
            Model = model;
            Year = year;
        }

        public string Make { get; set; } = "Jeep";
        public string Model { get; set; } = "Compass";
        public int Year { get; set; } = 2012;



    }
}
