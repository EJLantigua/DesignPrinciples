using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CodingReview.src.OopPrinciples.Polymorphism
{
    public class Motorcycle : Vehicle2
    {
        public int NumberOfWheels { get; set; }

        public override void Start() {
            Console.WriteLine("Motorcycle is starting");
        }

        public override void Stop() {
            Console.WriteLine("Motorcycle is stopping");
        }
    }
}