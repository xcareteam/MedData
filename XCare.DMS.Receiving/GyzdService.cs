using System;
using XCare.DMS.Entity;
using XCare.DMS.Message.Gyzd;
using XCare.DMS.Receiving.MessageService;

namespace XCare.DMS.Receiving
{
    public class GyzdService
    {
        public void Create(YdhlGyzd zd)
        {
            MessagePublisher.Publish(new GyzdCreatedMessage(zd));
        }

        public void Update()
        {
            throw new NotImplementedException();
        }
    }
}