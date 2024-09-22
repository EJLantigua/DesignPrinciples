using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CodingReview.src.SOLID.S
{
    public class EmailSender2
    {
        public void SendEmail(string email, string message) {
            Console.WriteLine($"Email sent to {email} with message: {message}");
        }
    }
}