using System;
using System.Collections.Generic;
using XCare.DMS.Entity;
using XCare.DMS.Message.Twd;
using XCare.DMS.Receiving.MessageService;

namespace XCare.DMS.Receiving
{
    public class TwdService
    {
        public void Create(IEnumerable<YdhlTwd> twds)
        {
            MessagePublisher.Publish(new TwdCreatedMessage(twds));
        }

        public void Update()
        {
            throw new NotImplementedException();
        }
    }
}