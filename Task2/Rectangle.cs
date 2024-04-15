using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task2
{
    class Rectangle
    {
        public int Length {  get; set; }
        public int Width { get; set; }

        public Rectangle(int length, int width)
        {
            Length = length;
            Width = width;
        }
        public int CalculateArea() => Length * Width;
        public int Calculateperimeter() => 2*( Length * Width);

        public void Display(string message)
        {
            Console.WriteLine($"======{ message.ToUpper()}======");
            Console.WriteLine($"The Area Of Rectangle = {CalculateArea()}\n" +
                $" The Perimeter Of Rectangle = {Calculateperimeter()}\n");
            
        }



    }
}
