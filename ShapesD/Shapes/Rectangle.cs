using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShapesD.Shapes
{
    internal class Rectangle
    {
        public const int NUMBER_OF_EDGES = 4;

        private double width;
        private double height;

        private string color;

        public double Width
        {
            get { return width; }
        }

        public double Height
        {
            get { return height; }
        }

        public double Area
        {
            get
            {
                return width * height;
            }
        }

        public Rectangle(double width, double height, string color)
        {
            this.width = width;
            this.height = height;
            this.color = color;
        }
    }
}
