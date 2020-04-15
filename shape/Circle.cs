using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace shape
{
    class Circle : Shape
    {
        private double radius;

        public Circle(double radius)
        {
            this.radius = radius;
        }
        public override double Area()
        {
            return Math.Pow(Math.PI * this.radius, 2);
        }

        public override double Perimeter()
        {
            return 2 * Math.PI * this.radius;
        }
    }
}
