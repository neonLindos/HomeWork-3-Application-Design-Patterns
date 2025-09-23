using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork_3.task1.controller
{
    public class NotificationController
    {
        public void SendConfirmationEmail(string email)
        {
            Console.WriteLine($"Confirmation email sent to: {email}");
        }
    }
}
