using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CodingReview.src.OopPrinciples.Polymorphism
{
    public class Vehicle2
    {
        public string Brand { get; set; }
        public string Model { get; set; }
        public int Year { get; set; }

        public virtual void Start() {
            Console.WriteLine("Vehicle is starting");
        }

        public virtual void Stop() {
            Console.WriteLine("Vehicle is stopping");
        }
    }
}