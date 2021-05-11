using System;
using System.Collections.Generic;
using System.Text;

namespace Generics.Entities
{
     public class Dog : Pet
    {
        public string FavoriteFood { get; set; }
        public override string PrintInfo()
        {
            return $"Dog {Name}";
        }
    }
}
