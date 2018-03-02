using System;
using XCare.DMS.Entity;
using XCare.DMS.Message.Jbxx;
using XCare.DMS.Receiving.MessageService;

namespace XCare.DMS.Receiving
{
    public class JbxxService
    {
        public void Create(YdhlJbxx jbxx)
        {
            MessagePublisher.Publish(new JbxxCreatedMessage(jbxx));
        }

        public void Update()
        {
            throw new NotImplementedException();
        }
    }
}