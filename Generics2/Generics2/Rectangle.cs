using System;
using System.Collections.Generic;
using System.Text;

namespace Generics2
{
    public class Rectangle : Shape
    {
        public int SideA { get; set; }
        public int SideB { get; set; }
        public override double GetArea()
        {
            return SideA * SideB;
        }
        public override double GetPerimeter()
        {
            return (SideA + SideB) * 2;
        }
    }
}
