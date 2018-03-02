using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Xml.Serialization;
using log4net;
using Quartz;
using ServiceBroker.Net;
using XCare.DMS.DataProc.Common;

namespace XCare.DMS.DataProc.Daemon
{
    [DisallowConcurrentExecution]
    internal class DataChangedEventNotificationReceiveJob : IJob
    {
        private static readonly XmlSerializer MessageDeserializer =
            new XmlSerializer(typeof (DataChangedEventNotification));

        private static readonly ILog DmlMsgLog = LogManager.GetLogger("DMLMsgLogger");
        private static readonly ILog ErrorLog = LogManager.GetLogger("ErrorLogger");

        public void Execute(IJobExecutionContext context)
        {
            using (var conn = DbHelper.GetDbConnection())
            {
                if (conn.State == ConnectionState.Closed)
                    conn.Open();
                using (var trans = conn.BeginTransaction())
                {
                    var messages = Receive(trans);
                    if (messages.Any())
                    {
                        Distribute(messages);
                    }
                    trans.Commit();
                }
            }
        }

        private static void Distribute(IEnumerable<Message> messages)
        {
            foreach (var message in messages)
            {
                try
                {
                    var notification = Deserialize(message);
                    DataChangedEventNotificationDistributor.Distribute(notification);
                    if (DmlMsgLog.IsInfoEnabled)
                        DmlMsgLog.Info(notification.ToLog());
                }
                catch (Exception e)
                {
                    if (ErrorLog.IsErrorEnabled)
                        ErrorLog.Error("分发DML消息失败", e);
                }
            }
        }

        private static List<Message> Receive(IDbTransaction trans)
        {
            List<Message> messages = null;
            try
            {
                messages = ServiceBrokerWrapper.WaitAndReceive(trans, "DataChangedEventNotificationQueue", 1000, 2000)
                    .ToList();
            }
            catch (Exception e)
            {
                if (ErrorLog.IsErrorEnabled)
                    ErrorLog.Error("接收DML事件通知失败", e);
            }
            return messages;
        }

        public static DataChangedEventNotification Deserialize(Message message)
        {
            return (DataChangedEventNotification) MessageDeserializer.Deserialize(message.BodyStream);
        }
    }
}