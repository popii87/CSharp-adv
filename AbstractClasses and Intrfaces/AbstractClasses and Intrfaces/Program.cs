using AbstractClasses_and_Intrfaces.Models.Classes;
using System;
using System.Collections.Generic;

namespace AbstractClasses_and_Intrfaces
{
    class Program
    {
        static void Main(string[] args)
        {
            Teacher teacher1 = new Teacher(111, "Viktor", "vjakovlev", new List<string>() {"C#", "JS" });
            Teacher teacher2 = new Teacher(112, "Angela", "akostadinova", new List<string>() { "C#", "JS" });
            teacher1.PrintUser();
            Console.WriteLine("=============");
            teacher2.PrintUser();
            Student student1 = new Student(123, "Robert", "rdimov", new List<int>() { 8, 6, 4 });
            Student student2 = new Student(124, "Bob", "bbobski", new List<int>() { 7, 8, 9 });
            Console.WriteLine("=============");
            student1.PrintUser();
            Console.WriteLine("=============");
            student2.PrintUser();
           
           
        }
    }
}
