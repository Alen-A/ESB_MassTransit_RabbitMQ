using MassTransit;
using Shop.Messages.Events;
using Shop.Notification.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shop.Notification.Service.Consumers
{
    public class OrderRegisteredEventConsumer : IConsumer<IOrderRegisteredEvent>
    {
        #region Constructors

        public OrderRegisteredEventConsumer()
        {

        }

        public OrderRegisteredEventConsumer(IShopNotificationRepository repository)
        {
            // structure map should user greedy constructor...
            Console.Out.WriteLine("I am using greedy constructor...");
        }

        #endregion

        #region Public Methods

        public async Task Consume(ConsumeContext<IOrderRegisteredEvent> context)
        {
            // consume message
            await Console.Out.WriteLineAsync("Consuming event...");
        }

        #endregion
    }
}
