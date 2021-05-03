using System;
using System.Collections.Generic;
using System.Text;

namespace StaticClasses_and_Polymorphism
{
    public class Car : Vehicle
    {
        public int FuelTank { get; set; }
        public string Countries { get; set; }
        public override void PrintVehicle()
        {
            Console.WriteLine($"{Type}, {Countries}");
        }
        public Car(int id, string type, int yearOfProduction, int batchNumber,int fuelTank, string countries) :base(id, type, yearOfProduction, batchNumber)
        {
            FuelTank = fuelTank;
            Countries = countries;
        }
    }
}
