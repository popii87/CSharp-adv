using System;

namespace Generics2
{
    class Program
    {
        public static Shape_DB<Circle> Circles = new Shape_DB<Circle>();
        public static Shape_DB<Rectangle> Rectangles = new Shape_DB<Rectangle>();
        static void Main(string[] args)
        {
            Circle circle1 = new Circle()
            {
                Id = 111,
                Radius = 3
            };
            Rectangle rectangle1 = new Rectangle()
            {
                Id = 222,
                SideA = 5,
                SideB = 4
            };
            Rectangle rectangle2 = new Rectangle()
            {
                Id = 223,
                SideA = 6,
                SideB = 5
            };

            Circles.Db.Add(circle1);
            Circles.PrintPerimeter(circle1);
            Console.WriteLine(circle1.GetPerimeter());
            Circles.Db.PrintInfo();
            Rectangles.Db.Add(rectangle1);
            Rectangles.Db.Add(rectangle2);
            Rectangles.PrintPerimeter(rectangle2);
            Rectangles.PrintArea(rectangle2);
            Rectangles.Db.PrintInfo();
        }
    }
}
