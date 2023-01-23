using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShapesD.Shapes
{
    internal class Circle : Shape
    {
        public const int NUMBER_OF_EDGES = 1;

        private double radius;

        private string color;

        public double Radius
        {
            get { return radius; }
        }

        public string Color
        {
            get { return color; }
        }

        public double Area
        {
            get { return Math.PI * Math.Pow(this.radius, 2); }
        }

        public Circle(double radius, string color)
        {
            this.radius = radius;
            this.color = color;
        }
    }
}
