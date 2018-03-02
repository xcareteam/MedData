using System;
using System.Threading.Tasks;
using MassTransit;
using XCare.DMS.Message.Gyzd;

namespace XCare.DMS.DataProc.MessageHandler.Gyzd
{
    internal class GyzdUpdatedMessageConsumer : IConsumer<GyzdUpdatedMessage>
    {
        public Task Consume(ConsumeContext<GyzdUpdatedMessage> context)
        {
            throw new NotImplementedException();
        }
    }
}