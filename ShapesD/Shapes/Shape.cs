using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShapesD.Shapes
{
    /// <summary>
    /// Generalized shape
    /// </summary>
    internal class Shape
    {
        protected string defaultColor;

        public string Color
        {
            get
            { 
                return defaultColor;
            }
        }

        public double Area
        {
            get;
        }

        /// <summary>
        /// No-arg constructor
        /// </summary>
        public Shape()
        {
            this.defaultColor = "white";
        }

        /// <summary>
        /// User-defined constructor
        /// </summary>
        /// <param name="defaultColor"></param>
        public Shape(string defaultColor)
        {
            this.defaultColor = defaultColor;
        }

        public virtual void DisplayArea()
        {
            Console.WriteLine("Area: " + Area);
        }
    }
}
