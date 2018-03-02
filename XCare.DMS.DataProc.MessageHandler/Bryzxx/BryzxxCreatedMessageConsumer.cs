using System.Threading.Tasks;
using MassTransit;
using XCare.DMS.DataProc.DAL;
using XCare.DMS.Message.Bryzxx;

namespace XCare.DMS.DataProc.MessageHandler.Bryzxx
{
    internal class BryzxxCreatedMessageConsumer : IConsumer<BryzxxCreatedMessage>
    {
        private readonly BryzxxDataAccess _dataAccess = new BryzxxDataAccess();

        public Task Consume(ConsumeContext<BryzxxCreatedMessage> context)
        {
            return MessageConsumeHandler.Handle(() => _dataAccess.Create(context.Message.Bryzxxes), context);
        }
    }
}