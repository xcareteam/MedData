using System.Threading.Tasks;
using MassTransit;
using XCare.DMS.DataProc.DAL;
using XCare.DMS.Message.Jcbg;

namespace XCare.DMS.DataProc.MessageHandler.Jcbg
{
    public class JcbgCreatedMessageConsumer : IConsumer<JcbgCreatedMessage>
    {
        private readonly JcbgDataAccess _dataAccess = new JcbgDataAccess();

        public Task Consume(ConsumeContext<JcbgCreatedMessage> context)
        {
            return MessageConsumeHandler.Handle(() => _dataAccess.Create(context.Message.Jcbgs), context);
        }
    }
}