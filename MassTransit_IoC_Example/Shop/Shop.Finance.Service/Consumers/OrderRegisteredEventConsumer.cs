using MassTransit;
using Shop.Messages.Events;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Threading.Tasks;

namespace Shop.Finance.Service.Consumers
{
    public class OrderRegisteredEventConsumer : IConsumer<IOrderRegisteredEvent>
    {
        public Task Consume(ConsumeContext<IOrderRegisteredEvent> context)
        {
            // consuming event...
            return Task.FromResult(false);
        }
    }
}