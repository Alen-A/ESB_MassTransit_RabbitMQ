using Shop.Notification.Models;
using Shop.Notification.Repository;
using Shop.Notification.Service.Consumers;
using StructureMap;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shop.Notification.Service
{
    public class NotificationRegistry : Registry
    {
        public NotificationRegistry()
        {
            // register consumer...
            ForConcreteType<OrderRegisteredEventConsumer>();

            // register repository...
            For<IShopNotificationRepository>().Use<ShopNotificationRepository>();
        }
    }
}
