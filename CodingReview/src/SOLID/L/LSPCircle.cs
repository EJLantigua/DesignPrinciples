using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CodingReview.src.SOLID.L
{
    public class LSPCircle : LSPShape
    {
        public double Radius { get; set; }

        public override double Area => Math.PI * Math.Pow(Radius, 2);
    }
}