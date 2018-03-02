using System.Threading.Tasks;
using MassTransit;
using XCare.DMS.DataProc.DAL;
using XCare.DMS.Message.Jbbm;

namespace XCare.DMS.DataProc.MessageHandler.Jbbm
{
    internal class JbbmCreatedMessageConsumer : IConsumer<JbbmCreatedMessage>
    {
        private readonly JbbmDataAccess _dataAccess = new JbbmDataAccess();

        public Task Consume(ConsumeContext<JbbmCreatedMessage> context)
        {
            return MessageConsumeHandler.Handle(() => _dataAccess.Create(context.Message.Jbbm), context);
        }
    }
}