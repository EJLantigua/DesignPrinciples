using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CodingReview.src.SOLID.O
{
    public class Rectangle : Shape
    {
        public double Width { get; set; }
        public double Length { get; set; }

        public override double CalculateArea() {
            return Width * Length;
        }
    }
}