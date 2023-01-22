using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShapesD.Shapes
{
    internal class Square
    {
        public const int NUMBER_OF_EDGES = 4;
        private double sideLength;
        private string color;

        public double SideLength
        {
            get { return sideLength; }
        }

        public string Color
        {
            get { return color; }
        }

        public double Area
        {
            get { return Math.Sqrt(this.SideLength); }
        }

        public Square(double sideLength, string color)
        {
            //this.edges = 4;
            this.sideLength = sideLength;
            this.color = color;
        }
    }
}
