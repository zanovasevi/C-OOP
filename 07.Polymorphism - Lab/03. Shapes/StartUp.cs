using System;

namespace Shapes
{
    public class StartUp
    {
        public static void Main(string[] args)
        {
            Shape rectangle = new Rectangle(2, 3);
            Shape circle = new Circle(3);

            Console.WriteLine(rectangle.CalculateArea());
            Console.WriteLine(rectangle.CalculatePerimeter());
            Console.WriteLine(rectangle.Draw());

            Console.WriteLine(circle.CalculateArea());
            Console.WriteLine(circle.CalculatePerimeter());
            Console.WriteLine(circle.Draw());
        }
    }
}
