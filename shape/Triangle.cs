using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace shape
{
    class Triangle : Shape
    {
        private double width;
        private double height;
        public Triangle(float width, float height)
        {
            this.width = width;
            this.height = height;
        }
        public override double Area()
        {
            return (this.width * this.height) / 2;
        }

        public override double Perimeter()
        {
            return 0;
        } 
    }
}
