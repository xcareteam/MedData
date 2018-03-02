using System;
using XCare.DMS.DataProc.Common;

namespace XCare.DMS.DataProc.Daemon
{
    internal class DataChangedEventNotificationDistributor
    {
        public static void Distribute(DataChangedEventNotification notification)
        {
            if (notification.ApplicationName == DbHelper.ApplicationName)
            {
            }
            else
            {
                switch (notification.Action)
                {
                    case DataManipulationOption.Insert:
                        break;
                    case DataManipulationOption.Update:
                        break;
                    case DataManipulationOption.Delete:
                        break;
                }
            }
        }
    }
}