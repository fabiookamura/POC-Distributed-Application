using POC.Distribute.Application.Infra.Bootstrap.Kafka.EndPointsConfigurator;
using Silverback.Messaging.Configuration.Kafka;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POC.Distribute.Application.Infra.Bootstrap.Kafka.Inbound
{
    public static class SqlInsertedInbound
    {
        public static IKafkaConsumerEndpointBuilder AddSqlInsertedInbound(this IKafkaConsumerEndpointBuilder endpoint)
        {
            return endpoint.ConsumeFrom(EndpointConfigurator.SqlInsertedEventName)
                           .Configure(config =>
                           {
                               config.GroupId = EndpointConfigurator.ConsumerGroupId;
                               config.AllowAutoCreateTopics = true;
                           })
                           .OnError(policy => policy.Retry(5));
        }
    }
}
