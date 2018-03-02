using System;
using System.Threading.Tasks;
using MassTransit;
using XCare.DMS.Message.Ypzd;

namespace XCare.DMS.DataProc.MessageHandler.Ypzd
{
    internal class YpzdUpdatedMessageConsumer : IConsumer<YpzdUpdatedMessage>
    {
        public Task Consume(ConsumeContext<YpzdUpdatedMessage> context)
        {
            throw new NotImplementedException();
        }
    }
}