using System.Threading.Tasks;
using MassTransit;
using XCare.DMS.DataProc.DAL;
using XCare.DMS.Message.Brxz;

namespace XCare.DMS.DataProc.MessageHandler.Brxz
{
    internal class BrxzCreatedMessageConsumer : IConsumer<BrxzCreatedMessage>
    {
        private readonly BrxzDataAccess _dataAccess = new BrxzDataAccess();

        public Task Consume(ConsumeContext<BrxzCreatedMessage> context)
        {
            return MessageConsumeHandler.Handle(() => { _dataAccess.Create(context.Message.Brxz); }, context);
        }
    }
}