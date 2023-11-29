using System;
using System.Collections.Generic;
using System.Text;

namespace Lab5.Models
{
    public class Square : Shape
    {
        private double sideLength;

        public Square(double sideLength)
        {
            this.sideLength = sideLength;
        }

        public override double CalculateArea()
        {
            return sideLength * sideLength;
        }
    }
}
