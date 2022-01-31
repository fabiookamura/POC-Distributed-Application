using POC.Distribute.Application.Business.Domain.Event;
using Silverback.Messaging.Messages;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POC.Distribute.Application.Business.Application.Consumers
{
    public class MongoInsertConsumer
    {
        public async Task OnSqlInsertedEventAsync(IInboundEnvelope<SqlInsertedEvent> sqlInsertedEvent)
        {
            // ...your message handling logic...
        }

    }
}
