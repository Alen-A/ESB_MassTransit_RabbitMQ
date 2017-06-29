using MassTransit;
using Shop.Messages.Commands;
using Shop.Messages.Events;
using Shop.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shop.Registration.Service.Consumers
{
    public class RegisterOrderCommandConsumer : IConsumer<IRegisterOrderCommand>
    {
        public async Task Consume(ConsumeContext<IRegisterOrderCommand> context)
        {
            await Console.Out.WriteLineAsync("Command consumed...");

            var orderRegisteredEvent = new OrderRegisteredEvent(context.Message);

            await context.Publish<IOrderRegisteredEvent>(orderRegisteredEvent);
        }
    }
}
