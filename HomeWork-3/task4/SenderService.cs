using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork_3.task4
{
    internal class SenderService
    {
        public interface INotificationSender
        {
            void Send(string message);
        }

        public class EmailSender : INotificationSender
        {
            public void Send(string message)
            {
                Console.WriteLine("Email sent: " + message);
            }
        }

        public class SmsSender : INotificationSender
        {
            public void Send(string message)
            {
                Console.WriteLine("SMS sent: " + message);
            }
        }

        public class NotificationService
        {
            private readonly List<INotificationSender> _senders;

            public NotificationService(List<INotificationSender> senders)
            {
                _senders = senders;
            }

            public void SendNotification(string message)
            {
                foreach (var sender in _senders)
                {
                    sender.Send(message);
                }
            }
        }

    }
}
