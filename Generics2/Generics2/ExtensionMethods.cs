using System;
using System.Collections.Generic;
using System.Text;

namespace Generics2
{
    public static class ExtensionMethods 
    {
        public static void PrintInfo<T>(this List<T> items) where T : Shape
        {
            foreach (T item in items)
            {
                Console.WriteLine($"{item.Id}");
            }
        }
    }
}