using MassTransit;
using Shop.Messages.Events;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shop.Notification.Service.Consumers
{
    public class OrderRegisteredEventConsumer : IConsumer<IOrderRegisteredEvent>
    {
        public async Task Consume(ConsumeContext<IOrderRegisteredEvent> context)
        {
            // consume message
            await Console.Out.WriteLineAsync("Consuming event...");
        }
    }
}
