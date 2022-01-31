using System;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using POC.Distribute.Application.Infra.Bootstrap.Kafka.EndPointsConfigurator;

namespace POC.Distribute.Application.Infra.Bootstrap
{
    public static class KafkaService
    {
        public static IServiceCollection AddKafka(this IServiceCollection services)
        {
            services.AddSilverback()
                    .WithConnectionToMessageBroker(options => options.AddKafka())
                    .AddEndpointsConfigurator<EndpointConfigurator>();
            return services;
        }
    }
}
