using System;
using System.Threading.Tasks;
using MassTransit;
using XCare.DMS.DataProc.DAL;
using XCare.DMS.Message.Brxz;

namespace XCare.DMS.DataProc.MessageHandler.Brxz
{
    internal class BrxzUpdatedMessageConsumer : IConsumer<BrxzUpdatedMessage>
    {
        private readonly BrxzDataAccess _dataAccess = new BrxzDataAccess();

        public Task Consume(ConsumeContext<BrxzUpdatedMessage> context)
        {
            throw new NotImplementedException();
        }
    }
}