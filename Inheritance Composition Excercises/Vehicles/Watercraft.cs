using System;
using System.Collections.Generic;
using System.Text;

namespace Inheritance_Composition_Excercises.Vehicles
{
    abstract class Watercraft : Vehicle
    {
        public override abstract void Refuel();
        public override abstract void Drive();
        public override abstract void Brake();
        public abstract override void Park();
    }
}
