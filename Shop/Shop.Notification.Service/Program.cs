using MassTransit;
using Shop.Messages;
using Shop.Notification.Service.Consumers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shop.Notification.Service
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Notification";

            var bus = BusConfigurator.ConfigureBus((cfg, host) =>
            {
                cfg.ReceiveEndpoint(host, RabbitMqConstants.NotificationServiceQueue, e =>
                {
                    e.Consumer<OrderRegisteredEventConsumer>(); 
                });
            });

            bus.Start();

            Console.WriteLine("Listening for Order registered events...");
            Console.ReadLine();

            bus.Stop();
        }
    }
}
