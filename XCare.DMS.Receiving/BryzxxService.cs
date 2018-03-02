using System;
using System.Collections.Generic;
using XCare.DMS.Entity;
using XCare.DMS.Message.Bryzxx;
using XCare.DMS.Receiving.MessageService;

namespace XCare.DMS.Receiving
{
    public class BryzxxService
    {
        public void Create(IEnumerable<YdhlBryzxx> bryzxxes)
        {
            MessagePublisher.Publish(new BryzxxCreatedMessage(bryzxxes));
        }

        public void Update()
        {
            throw new NotImplementedException();
        }
    }
}