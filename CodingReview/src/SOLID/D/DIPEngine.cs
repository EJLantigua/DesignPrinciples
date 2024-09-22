using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CodingReview.src.SOLID.D
{
    // Considered as a low-level module due to its dependency on IEngine and focus on narrower scope
    public class DIPEngine : IEngine
    {
        public void Start() {
            System.Console.WriteLine("Engine started");
        }
    }
}