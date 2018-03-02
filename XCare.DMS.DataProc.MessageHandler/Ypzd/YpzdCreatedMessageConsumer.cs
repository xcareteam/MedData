using System.Threading.Tasks;
using MassTransit;
using XCare.DMS.DataProc.DAL;
using XCare.DMS.Message.Ypzd;

namespace XCare.DMS.DataProc.MessageHandler.Ypzd
{
    public class YpzdCreatedMessageConsumer : IConsumer<YpzdCreatedMessage>
    {
        private readonly YpzdDataAccess _dataAccess = new YpzdDataAccess();

        public Task Consume(ConsumeContext<YpzdCreatedMessage> context)
        {
            return MessageConsumeHandler.Handle(() => _dataAccess.Create(context.Message.Yp), context);
        }
    }
}