﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Generics2
{
    public class Circle : Shape
    {
        public int Radius { get; set; }
        
        public override double GetArea()
        {

            return Math.PI * Math.Pow(Radius, 2);
        }
        public override double GetPerimeter()
        {
            return 2 * Math.PI * Radius;
        }
        
    }
}
