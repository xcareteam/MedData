using System;
using XCare.DMS.Entity;
using XCare.DMS.Message.Brzd;
using XCare.DMS.Receiving.MessageService;

namespace XCare.DMS.Receiving
{
    public class BrzdService
    {
        public void Create(YdhlBrzd brzd)
        {
            MessagePublisher.Publish(new BrzdCreatedMessage(brzd));
        }

        public void Update()
        {
            throw new NotImplementedException();
        }
    }
}