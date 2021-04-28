using AbstractClasses_and_Intrfaces.Models.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace AbstractClasses_and_Intrfaces.Models.Classes
{
    public abstract class User : IUser

    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Username { get; set; }
        public int Password { get; set; }
        public void PrintUser()
        {
            Console.WriteLine($"{Id}, {Name} {Username}");
        }
        public User(int id, string name, string username)
        {
            Id = id;
            Name = name;
            Username = username;

        }
    }
}
