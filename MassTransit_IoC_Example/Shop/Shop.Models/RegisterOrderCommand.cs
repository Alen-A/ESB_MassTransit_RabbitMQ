using Shop.Messages.Commands;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shop.Models
{
    public class RegisterOrderCommand : IRegisterOrderCommand
    {
        public int Id { get; set; }
        public string Name { get; set; }
    }
}
