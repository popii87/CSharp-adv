using System;
using System.Collections.Generic;

namespace StaticClasses_and_Polymorphism
{
    class Program
    {
        static void Main(string[] args)
        {
            //List<Vehicle> vehicles = DB.Vehicles;
            
            foreach (var item in DB.Vehicles)
            {
                item.PrintVehicle();
                Validator.Validate(item);
            }
            //Validator.Validate(DB.Vehicles[0]);

        }
    }
}
