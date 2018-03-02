using System;
using System.Configuration;
using System.Linq;
using MassTransit;
using MassTransit.RabbitMqTransport;

namespace XCare.DMS.DataProc.MessageHandler
{
    public class MessageBus
    {
        static MessageBus()
        {
            Setup();
        }

        public static string Address { get; set; }
        public static string UserName { get; set; }
        public static string Password { get; set; }
        public static string SchedularUri { get; set; }
        public static IBusControl Bus { get; private set; }

        public static void Start()
        {
            Bus.Start();
        }

        public static void Stop()
        {
            Bus.Stop();
        }

        private static void Setup()
        {
            Address = ConfigurationManager.AppSettings["RabbitMQAddress"];
            UserName = ConfigurationManager.AppSettings["RabbitMQUserName"];
            Password = ConfigurationManager.AppSettings["RabbitMQPassword"];
            SchedularUri = ConfigurationManager.AppSettings["MessageSchedulerUri"];
            Bus = MassTransit.Bus.Factory.CreateUsingRabbitMq(cfg =>
            {
                var host = cfg.Host(new Uri(Address), settings =>
                {
                    settings.Username(UserName);
                    settings.Password(Password);
                });
                cfg.UseMessageScheduler(new Uri(SchedularUri));
                ConfigureBindings(cfg, host);
            });
        }

        private static void ConfigureBindings(IRabbitMqBusFactoryConfigurator cfg, IRabbitMqHost host)
        {
            var bindings =
                typeof (MessageBus).Assembly.GetTypes()
                    .Where(e => typeof (IReceiveEndpointBinding).IsAssignableFrom(e) && e.IsClass && !e.IsAbstract)
                    .Select(e => (IReceiveEndpointBinding) Activator.CreateInstance(e)).ToList();
            foreach (var item in bindings)
            {
                item.Binding.Invoke(cfg, host);
            }
        }
    }
}