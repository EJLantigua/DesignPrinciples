using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CodingReview.src.OopPrinciples.Polymorphism
{
    public class Car2 : Vehicle2
    {
        public int NumberOfDoors { get; set; }

        public override void Start() {
            Console.WriteLine("Car is starting");
        }

        public override void Stop() {
            Console.WriteLine("Car is stopping");
        }
    }
}