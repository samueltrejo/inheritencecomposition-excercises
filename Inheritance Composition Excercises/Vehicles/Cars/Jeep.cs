using System;
using System.Collections.Generic;
using System.Text;

namespace Inheritance_Composition_Excercises.Vehicles.Cars
{
    class Jeep : Car
    {
        public string Model { get; set; }
        public int Year { get; set; }

        public Jeep(string model, int year)
        {
            Model = model;
            Year = year;
        }

        public override void Refuel()
        {
            throw new NotImplementedException();
        }
        public override void Drive()
        {
            throw new NotImplementedException();
        }
        public override void Brake()
        {
            throw new NotImplementedException();
        }
        public override void Park()
        {
            throw new NotImplementedException();
        }
    }
}
