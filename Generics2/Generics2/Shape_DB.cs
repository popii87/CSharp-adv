using System;
using System.Collections.Generic;
using System.Text;

namespace Generics2
{
    public  class Shape_DB<T> where T : Shape
    {
        public List<T> Db;
        public Shape_DB()
        {
            Db = new List<T>();
        }

        public void PrintArea(T item)
        {
            Console.WriteLine($"{item.GetArea()}");
        }
        public void PrintPerimeter(T item)
        {
            Console.WriteLine($"{item.GetPerimeter()}");
        }
    }
}
