using System;
using MassTransit;
using MassTransit.RabbitMqTransport;

namespace XCare.DMS.DataProc.MessageHandler.Brxz
{
    internal class BrxzCreatedMessageReceiveEndpointBinding : IReceiveEndpointBinding
    {
        public string QueueName
        {
            get { return "xcare_dms_brxz_create"; }
        }

        public Action<IRabbitMqBusFactoryConfigurator, IRabbitMqHost> Binding
        {
            get
            {
                return
                    (cfg, host) =>
                    {
                        cfg.ReceiveEndpoint(host, QueueName, e => { e.Consumer<BrxzCreatedMessageConsumer>(); });
                    };
            }
        }
    }
}