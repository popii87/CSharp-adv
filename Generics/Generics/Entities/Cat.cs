using System;
using System.Collections.Generic;
using System.Text;

namespace Generics.Entities
{
    public class Cat : Pet
    {
        public bool islazy { get; set; }
        public int LivesLeft { get; set; }
        public override string PrintInfo()
        {
            return $"Cat {Name}";
        }
    }
}
