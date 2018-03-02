using System;
using XCare.DMS.Entity;
using XCare.DMS.Message.Jbbm;
using XCare.DMS.Receiving.MessageService;

namespace XCare.DMS.Receiving
{
    public class JbbmService
    {
        public void Create(YdhlJbbm jbbm)
        {
            MessagePublisher.Publish(new JbbmCreatedMessage(jbbm));
        }

        public void Update()
        {
            throw new NotImplementedException();
        }
    }
}