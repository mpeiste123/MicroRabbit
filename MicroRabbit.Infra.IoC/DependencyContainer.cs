﻿using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Text;
using MicroRabbit.Domain.Core.Bus;
using MicroRabbit.Infra.Bus;

namespace MicroRabbit.Infra.IoC
{
   public  class DependencyContainer
    {
        public static void RegisterServices(IServiceCollection services)
        {
            //Domain Bus

            services.AddTransient<IEventBus, RabbitMQBus>();
        }
    }
}