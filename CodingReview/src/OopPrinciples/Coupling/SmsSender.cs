using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CodingReview.src.OopPrinciples.Coupling
{
    public class SmsSender : INotificationService
    {
        public void SendNotification(string message) {
            //SMS sending logic
            System.Console.WriteLine("SMS sent: " + message);
        }
    }
}