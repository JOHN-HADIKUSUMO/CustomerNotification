using System;
using System.Threading.Tasks;

namespace CustomerNotification.Services
{
    public class MessagingService
    {
        public async Task SendMessageAsync(string customerId, string messageBody)
        {
            //this is a mock method and candidates don't need to chage this
            await Task.Delay(1000);
            Console.WriteLine($"sending customer id: {customerId}, the following message {messageBody}");
        }
    }
}