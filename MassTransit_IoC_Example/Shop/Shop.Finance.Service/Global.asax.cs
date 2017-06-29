using MassTransit;
using Shop.Finance.Service.Consumers;
using Shop.Messages;
using StructureMap;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Security;
using System.Web.SessionState;

namespace Shop.Finance.Service
{
    public class Global : System.Web.HttpApplication
    {
        private IBusControl _bus;
        protected void Application_Start(object sender, EventArgs e)
        {
            _bus = BusConfigurator.ConfigureBus((cfg, host) =>
            {
                cfg.ReceiveEndpoint(host, RabbitMqConstants.FinanceServiceQueue, ep =>
                {
                    ep.Consumer<OrderRegisteredEventConsumer>();
                });

            });

            _bus.Start();
        }

        protected void Session_Start(object sender, EventArgs e)
        {

        }

        protected void Application_BeginRequest(object sender, EventArgs e)
        {

        }

        protected void Application_AuthenticateRequest(object sender, EventArgs e)
        {

        }

        protected void Application_Error(object sender, EventArgs e)
        {

        }

        protected void Session_End(object sender, EventArgs e)
        {

        }

        protected void Application_End(object sender, EventArgs e)
        {
            _bus.Stop();
        }
    }
}