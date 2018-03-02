using System;
using MassTransit.RabbitMqTransport;

namespace XCare.DMS.DataProc.MessageHandler
{
    public interface IReceiveEndpointBinding
    {
        string QueueName { get; }
        Action<IRabbitMqBusFactoryConfigurator, IRabbitMqHost> Binding { get; }
    }
}