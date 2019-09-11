using Inheritance_Composition_Excercises.Default_Values;
using System;
using System.Collections.Generic;
using System.Text;

namespace Inheritance_Composition_Excercises.Vehicles
{
    abstract class Car : Vehicle
    {
        public override abstract void Refuel();
        public override abstract void Drive();
        public override abstract void Brake();
        public abstract override void Park();
    }
}
