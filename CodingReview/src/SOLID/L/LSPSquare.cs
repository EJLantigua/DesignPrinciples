using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CodingReview.src.SOLID.L
{
    public class LSPSquare : LSPShape
    {
        public double Side { get; set; }

        public override double Area => Side * Side;
        
    }
}