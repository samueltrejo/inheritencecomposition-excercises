using System;
using System.Collections.Generic;
using System.Text;

namespace Inheritance_Composition_Excercises.Vehicles
{
    abstract class Aircraft : Vehicle
    {
        public override abstract void Refuel();
        public override abstract void Drive();
        public override abstract void Brake();
        public override abstract void Park();
    }
}
