using MassTransit;
using Shop.Messages;
using Shop.Registration.Service.Consumers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shop.Registration.Service
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Registration";

            var bus = BusConfigurator.ConfigureBus((cfg, host) =>
            {
                cfg.ReceiveEndpoint(host, RabbitMqConstants.RegisterOrderServiceQueue, e =>
                {
                    e.Consumer<RegisterOrderCommandConsumer>();
                });
            });




            bus.Start();

            Console.WriteLine("Listening for Register order commands... ");
            Console.ReadLine();

            bus.Stop();
        }
    }
}
