using System.Threading.Tasks;
using MassTransit;
using XCare.DMS.DataProc.DAL;
using XCare.DMS.Message.Jybg;

namespace XCare.DMS.DataProc.MessageHandler.Jybg
{
    public class JybgCreatedMessageConsumer : IConsumer<JybgCreatedMessage>
    {
        private readonly JybgDataAccess _dataAccess = new JybgDataAccess();

        public Task Consume(ConsumeContext<JybgCreatedMessage> context)
        {
            return MessageConsumeHandler.Handle(() => _dataAccess.Create(context.Message.Jybgs), context);
        }
    }
}