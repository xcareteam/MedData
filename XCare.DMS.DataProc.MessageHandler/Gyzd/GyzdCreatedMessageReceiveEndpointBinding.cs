using System;
using MassTransit;
using MassTransit.RabbitMqTransport;

namespace XCare.DMS.DataProc.MessageHandler.Gyzd
{
    internal class GyzdCreatedMessageReceiveEndpointBinding : IReceiveEndpointBinding
    {
        public string QueueName
        {
            get { return "xcare_dms_gyzd_create"; }
        }

        public Action<IRabbitMqBusFactoryConfigurator, IRabbitMqHost> Binding
        {
            get
            {
                return
                    (cfg, host) =>
                    {
                        cfg.ReceiveEndpoint(host, QueueName, e => { e.Consumer<GyzdCreatedMessageConsumer>(); });
                    };
            }
        }
    }
}