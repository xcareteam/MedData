using System;
using System.Configuration;
using System.Threading;
using System.Threading.Tasks;
using GreenPipes;
using MassTransit;

namespace XCare.DMS.Receiving.MessageService
{
    public class MessagePublisher
    {
        static MessagePublisher()
        {
            Setup();
        }

        public static string Address { get; set; }
        public static string UserName { get; set; }
        public static string Password { get; set; }
        public static IBusControl Bus { get; private set; }

        public static void Start()
        {
            Bus.Start();
        }

        public static void Stop()
        {
            Bus.Stop();
        }

        public static Task Publish<T>(T message, CancellationToken token = default(CancellationToken)) where T : class
        {
            return Bus.Publish(message, token);
        }

        public static Task Publish<T>(T message, IPipe<PublishContext> publishPipe,
            CancellationToken token = default(CancellationToken)) where T : class
        {
            return Bus.Publish(message, publishPipe, token);
        }

        public static Task Publish<T>(T message, IPipe<PublishContext<T>> publishPipe,
            CancellationToken token = default(CancellationToken)) where T : class
        {
            return Bus.Publish(message, publishPipe, token);
        }

        private static void Setup()
        {
            Address = ConfigurationManager.AppSettings["RabbitMQAddress"];
            UserName = ConfigurationManager.AppSettings["RabbitMQUserName"];
            Password = ConfigurationManager.AppSettings["RabbitMQPassword"];
            Bus = MassTransit.Bus.Factory.CreateUsingRabbitMq(cfg =>
            {
                cfg.Host(new Uri(Address), settings =>
                {
                    settings.Username(UserName);
                    settings.Password(Password);
                });
            });
        }
    }
}