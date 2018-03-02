using System.Threading.Tasks;
using MassTransit;
using XCare.DMS.DataProc.DAL;
using XCare.DMS.Message.Brzd;

namespace XCare.DMS.DataProc.MessageHandler.Brzd
{
    internal class BrzdCreatedMessageConsumer : IConsumer<BrzdCreatedMessage>
    {
        private readonly BrzdDataAccess _dataAccess = new BrzdDataAccess();

        public Task Consume(ConsumeContext<BrzdCreatedMessage> context)
        {
            return MessageConsumeHandler.Handle(() => _dataAccess.Create(context.Message.Brzd), context);
        }
    }
}