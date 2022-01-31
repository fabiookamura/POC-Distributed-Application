using Microsoft.Extensions.Configuration;
using POC.Distribute.Application.Infra.Bootstrap.Kafka.Inbound;
using Silverback.Messaging.Configuration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POC.Distribute.Application.Infra.Bootstrap.Kafka.EndPointsConfigurator
{
    public class EndpointConfigurator : IEndpointsConfigurator
    {
        internal const string SqlInsertedEventName = "sql-inserted-event";
        internal const string ConsumerGroupId = "poc-distributed-application";
        private readonly IConfiguration _configuration;

        public EndpointConfigurator(IConfiguration configuration)
        {
            _configuration = configuration;
        }

        public void Configure(IEndpointsConfigurationBuilder builder)
        {
            builder.AddKafkaEndpoints(endpoints => endpoints
                    .Configure(config =>
                    {
                        config.BootstrapServers = _configuration.GetConnectionString("kafka");
                    })
                    .AddInbound(endpoint => endpoint.AddSqlInsertedInbound())
                    .AddOutbound<object>(x => x.ProduceTo(SqlInsertedEventName)));
        }
    }
}
