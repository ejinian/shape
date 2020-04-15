using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace shape
{
    class Rectangle : Shape
    {
        private double width;
        private double height;

        public Rectangle(float width, float height)
        {
            this.width = width;
            this.height = height;
        }

        public override double Area()
        {
            return this.width * this.height;
        }

        public override double Perimeter()
        {
            return this.height + this.width;
        }
    }
}
