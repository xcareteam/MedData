using System;
using XCare.DMS.Entity;
using XCare.DMS.Message.Brxz;
using XCare.DMS.Receiving.MessageService;

namespace XCare.DMS.Receiving
{
    public class BrxzService
    {
        public void Create(YdhlBrxz brxz)
        {
            MessagePublisher.Publish(new BrxzCreatedMessage(brxz));
        }

        public void Update()
        {
            throw new NotImplementedException();
        }
    }
}