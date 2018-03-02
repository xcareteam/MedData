using System;
using System.Collections.Generic;
using XCare.DMS.Entity;
using XCare.DMS.Message.Jcbg;
using XCare.DMS.Receiving.MessageService;

namespace XCare.DMS.Receiving
{
    public class JcbgService
    {
        public void Create(IEnumerable<YdhlJcbg> jcbgs)
        {
            MessagePublisher.Publish(new JcbgCreatedMessage(jcbgs));
        }

        public void Update()
        {
            throw new NotImplementedException();
        }
    }
}