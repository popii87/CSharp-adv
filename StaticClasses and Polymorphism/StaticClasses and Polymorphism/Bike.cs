using System;
using System.Collections.Generic;
using System.Text;

namespace StaticClasses_and_Polymorphism
{
    public class Bike : Vehicle
    {
        public string Color { get; set; }
        public override void PrintVehicle()
        {
            Console.WriteLine($"{Type}, {YearOfProduction}, {Color}");
        }
        public Bike(int id, string type, int yearOfProduction, int batchNumber, string color) :base(id, type, yearOfProduction, batchNumber)
        {
            Color = color;
        }
    }
}
