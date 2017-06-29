using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shop.Messages.Events
{
    public interface IOrderRegisteredEvent
    {
        int Id { get; set; }
        string Name { get; set; }
    }
}
