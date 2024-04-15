using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task3
{
    internal class Circle:Shape
    {
        const double PI = 3.141592653;
        public double Radius {  get; set; }

        public Circle(double radius)
        {
            Radius = radius;
        }
        public override double CalculateArea() => PI * Radius * Radius;

        public override void Display()
        {
            Console.WriteLine($"The Area Of Circle = {CalculateArea()}");
        }

    }
}
