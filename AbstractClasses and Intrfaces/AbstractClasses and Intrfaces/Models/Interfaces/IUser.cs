using System;
using System.Collections.Generic;
using System.Text;

namespace AbstractClasses_and_Intrfaces.Models.Interfaces
{
    public interface IUser
    {
        int Id { get; set; }
        string Name { get; set; }
        string Username { get; set; }
        int Password { get; set; }
        void PrintUser();
    }
}
