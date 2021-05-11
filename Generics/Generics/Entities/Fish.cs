using System;
using System.Collections.Generic;
using System.Text;

namespace Generics.Entities
{
    public class Fish : Pet
    {
        public string Color { get; set; }
        public int Size { get; set; }
        public override string PrintInfo()
        {
            return $"Fish {Name}";
        }
    }
}
