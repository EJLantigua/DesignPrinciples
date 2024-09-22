using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CodingReview.src.SOLID.D
{
    // Considered as a high-level module due to its dependency on IEngine and focus on broader scope
    public class DIPCar
    {
        private IEngine engine;

        public DIPCar(IEngine engine) {
            this.engine = engine;
        }

        public void StartCar() {
            engine.Start();
            System.Console.WriteLine("Car started");
        }
    }
}