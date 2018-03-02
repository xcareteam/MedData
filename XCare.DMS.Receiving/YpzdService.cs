using System;
using XCare.DMS.Entity;
using XCare.DMS.Message.Ypzd;
using XCare.DMS.Receiving.MessageService;

namespace XCare.DMS.Receiving
{
    public class YpzdService
    {
        public void Create(YdhlYpzd zd)
        {
            MessagePublisher.Publish(new YpzdCreatedMessage(zd));
        }

        public void Update()
        {
            throw new NotImplementedException();
        }
    }
}