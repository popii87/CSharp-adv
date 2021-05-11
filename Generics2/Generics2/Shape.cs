using System;
using System.Collections.Generic;
using System.Text;

namespace Generics2
{
    public abstract class Shape
    {
        public int Id { get; set; }
        public abstract double GetArea();
        public abstract double GetPerimeter(); 
    }
}
