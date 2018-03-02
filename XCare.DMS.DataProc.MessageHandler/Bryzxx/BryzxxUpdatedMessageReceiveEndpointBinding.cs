using System;
using MassTransit;
using MassTransit.RabbitMqTransport;

namespace XCare.DMS.DataProc.MessageHandler.Bryzxx
{
    internal class BryzxxUpdatedMessageReceiveEndpointBinding : IReceiveEndpointBinding
    {
        public string QueueName
        {
            get { return "xcare_dms_bryzxx_udt"; }
        }

        public Action<IRabbitMqBusFactoryConfigurator, IRabbitMqHost> Binding
        {
            get
            {
                return
                    (cfg, host) =>
                    {
                        cfg.ReceiveEndpoint(host, QueueName, e => { e.Consumer<BryzxxUpdatedMessageConsumer>(); });
                    };
            }
        }
    }
}