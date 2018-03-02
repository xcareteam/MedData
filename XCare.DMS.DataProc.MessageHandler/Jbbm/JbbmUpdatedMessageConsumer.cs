using System;
using System.Threading.Tasks;
using MassTransit;
using XCare.DMS.Message.Jbbm;

namespace XCare.DMS.DataProc.MessageHandler.Jbbm
{
    internal class JbbmUpdatedMessageConsumer : IConsumer<JbbmUpdatedMessage>
    {
        public Task Consume(ConsumeContext<JbbmUpdatedMessage> context)
        {
            throw new NotImplementedException();
        }
    }
}