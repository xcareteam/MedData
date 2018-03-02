using System;
using System.Data.SqlClient;
using System.IO;
using System.Threading.Tasks;
using MassTransit;

namespace XCare.DMS.DataProc.MessageHandler
{
    internal class MessageConsumeHandler
    {
        private static readonly TimeSpan RedeliverInterval = TimeSpan.FromSeconds(30);

        public static Task Handle<T>(Action action, ConsumeContext<T> context) where T : class, new()
        {
            try
            {
                action.Invoke();
                return Task.CompletedTask;
            }
            catch (SqlException e)
            {
                return context.Redeliver(RedeliverInterval);
            }
            catch (IOException e)
            {
                return context.Redeliver(RedeliverInterval);
            }
            catch (Exception e)
            {
                return context.Redeliver(RedeliverInterval);
            }
        }
    }
}