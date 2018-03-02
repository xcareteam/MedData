using System.Threading.Tasks;
using MassTransit;
using XCare.DMS.DataProc.DAL;
using XCare.DMS.Message.Ypyf;

namespace XCare.DMS.DataProc.MessageHandler.Ypyf
{
    public class YpyfCreatedMessageConsumer : IConsumer<YpyfCreatedMessage>
    {
        private readonly YpyfDataAccess _dataAccess = new YpyfDataAccess();

        public Task Consume(ConsumeContext<YpyfCreatedMessage> context)
        {
            return MessageConsumeHandler.Handle(() => _dataAccess.Create(context.Message.Ypyf), context);
        }
    }
}