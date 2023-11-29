using System;
using System.Collections.Generic;
using System.Text;

namespace Lab3.Models
{
    class Rectangle : Shape
    {
        public override void Draw()
        {
            Console.WriteLine($"Rysuję prostokąt w pozycji ({X},{Y}), wysokość wynosi {Height}, a szerokość {Width}");
        }
    }
}
