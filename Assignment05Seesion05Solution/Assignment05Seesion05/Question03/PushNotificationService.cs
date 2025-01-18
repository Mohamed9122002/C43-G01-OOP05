using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment05Seesion05.Question03
{
    internal class PushNotificationService : INotificationService
    {
        void INotificationService.SendNotification(string message, string recipient)
        {
            Console.WriteLine($"PushNotification send To \n{message} ,{recipient}");
        }
    }
}
