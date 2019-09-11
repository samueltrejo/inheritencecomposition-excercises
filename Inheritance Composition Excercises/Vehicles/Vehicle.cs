using Inheritance_Composition_Excercises.Default_Values;
using System;
using System.Collections.Generic;
using System.Text;

namespace Inheritance_Composition_Excercises.Vehicles
{
    abstract class Vehicle
    {
        public Percent FuelPercentage { get; set; }
        public CarColor CarColor { get; set; }
        public int MaxPassengers { get; set; }

        public abstract void Refuel();
        public abstract void Drive();
        public abstract void Brake();
        public abstract void Park();
    }
}
