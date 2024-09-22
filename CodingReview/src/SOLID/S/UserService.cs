using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CodingReview.src.SOLID.S
{
    public class UserService
    {
         public void Register(User user)
        {
            // Register user logic...

            // Send email
            // Dependency relationship as the UserService class depends on the EmailSender2 class
            EmailSender2 emailSender = new EmailSender2(); 
            emailSender.SendEmail(user.Email, "Welcome to our platform!");
        }
    }
}