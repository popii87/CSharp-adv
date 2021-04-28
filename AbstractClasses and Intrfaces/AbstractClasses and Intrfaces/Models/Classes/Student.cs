using AbstractClasses_and_Intrfaces.Models.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace AbstractClasses_and_Intrfaces.Models.Classes
{
    public class Student : User, IStudent 
    {
        public List<int> Grades { get; set; }
        public new void PrintUser()
        {
            foreach (var grade in Grades)
            {
                Console.WriteLine($"{grade}");
            }
        
        }
        public Student(int id, string name, string username, List<int> grades) :base(id, name, username)
        {
            Grades = grades;
        }
    }
}
