using System;
using System.Threading.Tasks;
using MassTransit;
using XCare.DMS.Message.Jcbg;

namespace XCare.DMS.DataProc.MessageHandler.Jcbg
{
    internal class JcbgUpdatedMessageConsumer : IConsumer<JcbgUpdatedMessage>
    {
        public Task Consume(ConsumeContext<JcbgUpdatedMessage> context)
        {
            throw new NotImplementedException();
        }
    }
}