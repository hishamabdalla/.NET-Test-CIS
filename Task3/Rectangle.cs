using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task3
{
    class Rectangle:Shape
    {
        public double Length {  get; set; }
        public double Width { get; set; }

        public Rectangle(double length,double width )
        {
            Width = width;
            Length = length;
        }

        public override double CalculateArea() => Length * Width;

        public override void Display()
        {
            Console.WriteLine($"The Area Of Rectangle = {CalculateArea()}");
        }


    }
}
