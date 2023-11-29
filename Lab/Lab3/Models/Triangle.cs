using System;
using System.Collections.Generic;
using System.Text;

namespace Lab3.Models
{
    class Triangle : Shape
    {
        public override void Draw()
        {
            Console.WriteLine($"Rysuję trójkąt w pozycji ({X},{Y}), wysokość wynosi {Height}, a szerokość {Width}");
        }
    }
}
