using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShapesD.Shapes
{
    /// <summary>
    /// Represents a Triangle
    /// </summary>
    /// <remarks>Author: Joe Blow</remarks>
    /// <remarks>Date: Jan 20, 2023</remarks>
    internal class Triangle : Shape
    {
        public const int NUMBER_OF_EDGES = 3;

        private double angle1;
        private double angle2;
        private double angle3;

        private double @base;
        private double height;

        private string color;

        public double Angle1
        {
            get
            {
                return this.angle1;
            }
            set
            {
                if (value > 0 && value < 180)
                {
                    this.angle1 = value;
                }

                
            }
        }

        public double Angle2
        {
            get
            {
                return this.angle2;
            }
            set
            {
                if (value > 0 && value < 180)
                {
                    this.angle2 = value;
                }


            }
        }

        public double Angle3
        {
            get
            {
                return angle3;
            }
        }

        public double Base
        {
            get
            {
                return this.@base;
            }
        }

        public double Height
        {
            get
            {
                return this.height;
            }
        }

        public string Color
        {
            get
            {
                return this.color;
            }
        }

        /// <summary>
        /// Checks the angles add up to 180
        /// </summary>
        public bool IsAnglesValid
        {
            get
            {
                double sum;

                sum = this.angle1 + this.angle2 + this.angle3;

                /*bool isValid;

                if (sum == 180)
                {
                    isValid = true;
                }
                else
                {
                    isValid = false;
                }

                return isValid;*/

                return sum == 180 ? true : false;
                //return sum == 180;
            }
        }

        public double Area
        {
            get
            {
                double area;

                area = this.Base * this.Height / 2;

                return area;
            }
        }

        public Triangle() : this(90, 45, 45, 1, 1, "blue")
        {
        }

        public Triangle(double angle1, double angle2, double angle3, double baseLength, double height, string color)
        {
            this.angle1 = angle1;
            this.angle2 = angle2;
            this.angle3 = angle3;
            @base = baseLength;
            this.height = height;
            this.color = color;
        }
    }
}
