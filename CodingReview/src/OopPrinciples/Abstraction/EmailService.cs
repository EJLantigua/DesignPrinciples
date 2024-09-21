using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CodingReview.src.OopPrinciples.Abstraction
{
    public class EmailService
    {
        public void SendEmail() {
            Connect();
            Authenticate();
            System.Console.WriteLine("Sending Email...");
            Disconnect();
        }

        private void Connect() {
            System.Console.WriteLine("Connecting to Email Server...");
        }

        private void Authenticate() {
            System.Console.WriteLine("Authenticating Email Server...");
        }

        private void Disconnect() {
            System.Console.WriteLine("Disconnecting from Email Server...");
        }

    }
}