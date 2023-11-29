using System;
using System.Collections.Generic;
using System.Text;

namespace Lab3.Models
{
    class Circle : Shape
    {
        public override void Draw()
        {
            Console.WriteLine($"Rysuję okrąg w pozycji ({X},{Y}), promień wynosi {Width / 2}");
        }
    }
}
