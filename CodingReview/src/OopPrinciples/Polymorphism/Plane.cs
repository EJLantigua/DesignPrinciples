using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CodingReview.src.OopPrinciples.Polymorphism
{
    public class Plane : Vehicle2
    {
        public override void Start() {
            Console.WriteLine("Plane is starting");
        }

        public override void Stop() {
            Console.WriteLine("Plane is stopping");
        }
    }
}