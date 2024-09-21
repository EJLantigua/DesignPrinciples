using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CodingReview.src.OopPrinciples.Coupling
{
    public class EmailSender : INotificationService
    {
        public void SendNotification(string message) {
            //Email sending logic
            System.Console.WriteLine("Email sent: " + message);
        }

        
    }
}