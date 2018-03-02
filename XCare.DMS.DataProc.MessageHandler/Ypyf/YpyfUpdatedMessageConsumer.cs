using System;
using System.Threading.Tasks;
using MassTransit;
using XCare.DMS.Message.Ypyf;

namespace XCare.DMS.DataProc.MessageHandler.Ypyf
{
    internal class YpyfUpdatedMessageConsumer : IConsumer<YpyfUpdatedMessage>
    {
        public Task Consume(ConsumeContext<YpyfUpdatedMessage> context)
        {
            throw new NotImplementedException();
        }
    }
}