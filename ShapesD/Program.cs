using ShapesD.Shapes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShapesD
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Triangle emptyTriangle;

            emptyTriangle = new Triangle();

            Shape shape1;

            shape1 = emptyTriangle;



            if (shape1 is Rectangle)
            {
                Console.WriteLine("shape1 is rectangle");
            } else
            {
                Console.WriteLine("shape1 is not a rectangle");
            }

            if (shape1 is Triangle triangle)
            {
                //Triangle triangle = (Triangle) shape1;

                Console.WriteLine("shape1 is Triangle");
                Console.WriteLine("shape1 base: " + triangle.Base);
            }
            else if ((shape1 is Triangle) == false)
            {
                Console.WriteLine("shape1 is not a Triangle");
            }


            /*Triangle triangle1;

            triangle1 = new Triangle(angle1: 90, 45, 45, 10.5, 24.9, "Red");

            double angle1 = triangle1.Angle1;

            triangle1.Angle1 = 180;

            bool isValid = triangle1.IsAnglesValid;

            Console.WriteLine("Is valid: " + isValid);*/
        }
    }
}
