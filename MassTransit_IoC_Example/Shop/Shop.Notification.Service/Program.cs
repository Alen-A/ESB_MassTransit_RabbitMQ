using MassTransit;
using Shop.Messages;
using StructureMap;
using System;

namespace Shop.Notification.Service
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Notification";

            IContainer container = StructureMapBootStrapper.Init();

            var bus = BusConfigurator.ConfigureBus((cfg, host) =>
            {
                cfg.ReceiveEndpoint(host, RabbitMqConstants.NotificationServiceQueue, e =>
                {                    
                    e.LoadFrom(container);
                });
            });

            bus.Start();

            Console.WriteLine("Listening for Order registered events...");
            Console.ReadLine();

            bus.Stop();
        }
    }
}
