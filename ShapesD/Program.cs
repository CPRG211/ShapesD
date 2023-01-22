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
            Triangle triangle1;

            triangle1 = new Triangle(angle1: 90, 45, 45, 10.5, 24.9, "Red");

            double angle1 = triangle1.Angle1;

            triangle1.Angle1 = 180;

            bool isValid = triangle1.IsAnglesValid;

            Console.WriteLine("Is valid: " + isValid);
        }
    }
}
