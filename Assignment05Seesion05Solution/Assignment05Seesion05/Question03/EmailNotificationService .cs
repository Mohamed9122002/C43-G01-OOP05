using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment05Seesion05.Question03
{
    internal class EmailNotificationService : INotificationService
    {
        void INotificationService.SendNotification(string message, string recipient)
        {
            Console.WriteLine($"Email set To \n{message},{recipient}");
        }
    }
}
