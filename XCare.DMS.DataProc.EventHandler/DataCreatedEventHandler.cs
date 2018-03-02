using System;
using XCare.DMS.DataProc.Event;
using XCare.DMS.Entity;
using XCare.DMS.Utilities.Event;

namespace XCare.DMS.DataProc.EventHandler
{
    public class DataCreatedEventHandler : IEventHandler<DataCreatedEvent<Guid>>
    {
        public void Handle(DataCreatedEvent<Guid> @event)
        {
             
        }
    }
}