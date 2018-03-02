using System;
using System.Collections.Generic;
using XCare.DMS.Entity;
using XCare.DMS.Message.Jybg;
using XCare.DMS.Receiving.MessageService;

namespace XCare.DMS.Receiving
{
    public class JybgService
    {
        public void Create(IEnumerable<YdhlJybg> jybgs)
        {
            MessagePublisher.Publish(new JybgCreatedMessage(jybgs));
        }

        public void Update()
        {
            throw new NotImplementedException();
        }
    }
}