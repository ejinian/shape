using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace shape
{
    class Program
    {
        static void Main(string[] args)
        {
            Rectangle rectangle = new Rectangle(2, 5);
            Circle circle = new Circle(2);
            Triangle triangle = new Triangle(2, 3);
            double rectangleArea = rectangle.Area();
            double rectanglePerimeter = rectangle.Perimeter();
            double circleArea = circle.Area();
            double circleCircumference = circle.Perimeter();
            double triangleArea = triangle.Area();
            Console.WriteLine("Rectangle area: " + rectangleArea);
            Console.WriteLine("Rectangle perimeter: " + rectanglePerimeter);
            Console.WriteLine("Circle area: " + circleArea);
            Console.WriteLine("Circle circumference: " + circleCircumference);
            Console.WriteLine("Triangle area: " + triangleArea);
            Console.ReadLine();
        }
    }
}
