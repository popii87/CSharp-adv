using System;
using System.Collections.Generic;
using System.Text;

namespace StaticClasses_and_Polymorphism
{
    public static class Validator
    {
        public static void Validate(Vehicle vehicle)
        {
            if (vehicle.Id != 0 && vehicle.Type != "" && vehicle.YearOfProduction != 0)
            {
                Console.WriteLine($"{vehicle.Id}, {vehicle.Type} {vehicle.YearOfProduction}");
            }
            else
            {
                Console.WriteLine("ERROR");
            }
        }
    }
}
