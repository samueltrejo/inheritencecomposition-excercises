using Inheritance_Composition_Excercises.Vehicles.Cars;
using System;

namespace Inheritance_Composition_Excercises
{
    class Program
    {
        static void Main(string[] args)
        {
            var jeepWrangler = new Jeep("Wrangler", 1995);
            Console.WriteLine(jeepWrangler.Model);
        }
    }
}
