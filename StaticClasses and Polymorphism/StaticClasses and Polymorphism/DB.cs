using System;
using System.Collections.Generic;
using System.Text;

namespace StaticClasses_and_Polymorphism
{
    public static class DB
    {
        public static List<Vehicle> Vehicles { get; set; } = GenerateVehicles();
        public static List<Vehicle> GenerateVehicles()
        {
            return new List<Vehicle>()
            {
                new Car(111, "Mercedes", 2020, 5555, 80, "Germany"),
                new Bike(222, "BMW", 2020, 1111, "blue"),
                new Vehicle(333, "Boat", 1989, 2222),
            };
        }
        
    }
}
