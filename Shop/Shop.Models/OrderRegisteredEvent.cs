using Shop.Messages.Commands;
using Shop.Messages.Events;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shop.Models
{
    public class OrderRegisteredEvent : IOrderRegisteredEvent
    {
        public OrderRegisteredEvent(IRegisterOrderCommand command)
        {
            this.Id = command.Id;
            this.Name = command.Name;
        }

        public int Id { get; set; }
        public string Name { get; set; }
    }
}
