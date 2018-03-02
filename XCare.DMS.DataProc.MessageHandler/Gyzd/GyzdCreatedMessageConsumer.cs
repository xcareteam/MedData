using System.Threading.Tasks;
using MassTransit;
using XCare.DMS.DataProc.DAL;
using XCare.DMS.Message.Gyzd;

namespace XCare.DMS.DataProc.MessageHandler.Gyzd
{
    internal class GyzdCreatedMessageConsumer : IConsumer<GyzdCreatedMessage>
    {
        private readonly GyzdDataAccess _dataAccess = new GyzdDataAccess();

        public Task Consume(ConsumeContext<GyzdCreatedMessage> context)
        {
            return MessageConsumeHandler.Handle(() => _dataAccess.Create(context.Message.Gyzd), context);
        }
    }
}