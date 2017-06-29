using StructureMap;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shop.Notification.Service
{
    public class StructureMapBootStrapper
    {
        public static IContainer Init()
        {
            return new Container(new NotificationRegistry());
        }
    }
}
