using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Shop.Messages;
using Shop.Messages.Commands;

namespace Shop.Registration.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public async Task<IActionResult> Registered()
        {

            var bus = BusConfigurator.ConfigureBus();
            
            var sendToUri = new Uri($"{RabbitMqConstants.RabbitMqUri}" +
                $"{RabbitMqConstants.RegisterOrderServiceQueue}");

            var endPoint = await bus.GetSendEndpoint(sendToUri);

            await endPoint.Send<IRegisterOrderCommand>(new
            {
                Id = 1,
                Name = "test"
            });

            return View();
        }

    }
}
