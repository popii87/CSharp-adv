using System;
using System.Collections.Generic;
using System.Text;

namespace StaticClasses_and_Polymorphism
{
    public class Vehicle
    {
        public int Id { get; set; }
        public string Type { get; set; }
        public int YearOfProduction { get; set; }
        public int BatchNumber { get; set; }
        public virtual void PrintVehicle()
        {
            Console.WriteLine($"{Id}, {Type} {YearOfProduction}");
        }
        public Vehicle(int id, string type, int yearOfProduction, int batchNumber)
        {
            Id = id;
            Type = type;
            YearOfProduction = yearOfProduction;
            BatchNumber = batchNumber;
        }
    }
}
