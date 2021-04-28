using AbstractClasses_and_Intrfaces.Models.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace AbstractClasses_and_Intrfaces.Models.Classes
{
    class Teacher : User, ITeacher
    {
        public List<string> Subject { get; set; }
        public new void PrintUser()
        {
            foreach (var item in Subject)
            {
                Console.WriteLine($"{item}");
            }
        }
        public Teacher(int id, string name, string username,List<string> subject) :base(id ,name, username)
        {
            Subject = subject;
        }
    }
}
