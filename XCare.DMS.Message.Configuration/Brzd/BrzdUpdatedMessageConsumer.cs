﻿using System;
using System.Threading.Tasks;
using MassTransit;
using XCare.DMS.Message.Brzd;

namespace XCare.DMS.Message.Configuration.Brzd
{
    internal class BrzdUpdatedMessageConsumer : IConsumer<BrzdUpdatedMessage>
    {
        public Task Consume(ConsumeContext<BrzdUpdatedMessage> context)
        {
            throw new NotImplementedException();
        }
    }
}