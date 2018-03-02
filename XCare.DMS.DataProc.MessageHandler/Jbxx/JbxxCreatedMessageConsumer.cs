using System.Threading.Tasks;
using MassTransit;
using XCare.DMS.DataProc.DAL;
using XCare.DMS.Message.Jbxx;

namespace XCare.DMS.DataProc.MessageHandler.Jbxx
{
    internal class JbxxCreatedMessageConsumer : IConsumer<JbxxCreatedMessage>
    {
        private readonly JbxxDataAccess _dataAccess = new JbxxDataAccess();

        public Task Consume(ConsumeContext<JbxxCreatedMessage> context)
        {
            return MessageConsumeHandler.Handle(() => _dataAccess.Create(context.Message.Jbxx), context);
        }
    }
}