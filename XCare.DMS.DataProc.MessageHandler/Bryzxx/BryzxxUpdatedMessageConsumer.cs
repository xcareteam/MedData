using System;
using System.Threading.Tasks;
using MassTransit;
using XCare.DMS.Message.Bryzxx;

namespace XCare.DMS.DataProc.MessageHandler.Bryzxx
{
    internal class BryzxxUpdatedMessageConsumer : IConsumer<BryzxxUpdatedMessage>
    {
        public Task Consume(ConsumeContext<BryzxxUpdatedMessage> context)
        {
            throw new NotImplementedException();
        }
    }
}