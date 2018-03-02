using System;
using XCare.DMS.Entity;
using XCare.DMS.Message.Ypyf;
using XCare.DMS.Receiving.MessageService;

namespace XCare.DMS.Receiving
{
    public class YpyfService
    {
        public void Create(YdhlYpyf ypyf)
        {
            MessagePublisher.Publish(new YpyfCreatedMessage(ypyf));
        }

        public void Update()
        {
            throw new NotImplementedException();
        }
    }
}