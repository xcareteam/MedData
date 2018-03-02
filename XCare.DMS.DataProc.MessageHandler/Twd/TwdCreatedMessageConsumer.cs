using System.Threading.Tasks;
using MassTransit;
using XCare.DMS.DataProc.DAL;
using XCare.DMS.Message.Twd;

namespace XCare.DMS.DataProc.MessageHandler.Twd
{
    public class TwdCreatedMessageConsumer : IConsumer<TwdCreatedMessage>
    {
        private readonly TwdDataAccess _dataAccess = new TwdDataAccess();

        public Task Consume(ConsumeContext<TwdCreatedMessage> context)
        {
            return MessageConsumeHandler.Handle(() => _dataAccess.Create(context.Message.Twds), context);
        }
    }
}