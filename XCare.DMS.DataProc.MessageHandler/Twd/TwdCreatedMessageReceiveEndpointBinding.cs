using System;
using MassTransit;
using MassTransit.RabbitMqTransport;

namespace XCare.DMS.DataProc.MessageHandler.Twd
{
    internal class TwdCreatedMessageReceiveEndpointBinding : IReceiveEndpointBinding
    {
        public string QueueName
        {
            get { return "xcare_dms_twd_create"; }
        }

        public Action<IRabbitMqBusFactoryConfigurator, IRabbitMqHost> Binding
        {
            get
            {
                return
                    (cfg, host) =>
                    {
                        cfg.ReceiveEndpoint(host, QueueName, e => { e.Consumer<TwdCreatedMessageConsumer>(); });
                    };
            }
        }
    }
}