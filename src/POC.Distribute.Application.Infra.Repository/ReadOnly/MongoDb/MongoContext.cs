using Microsoft.Extensions.Configuration;
using MongoDB.Bson.Serialization;
using MongoDB.Bson.Serialization.Attributes;
using MongoDB.Driver;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POC.Distribute.Application.Infra.Repository.ReadOnly.MongoDb
{
    public class MongoContext
    {
        private readonly string _connectionString;
        public MongoContext(IConfiguration configuration)
        {
            _connectionString = configuration.GetConnectionString("MongoDb");
        }

        public string ConnectionString => _connectionString;

        public MongoUrl url => new MongoUrl(_connectionString);

        public MongoClient client => new MongoClient(url);

        public IMongoDatabase database => client.GetDatabase("poc-distributed-application");

        public string GetCollectionName<TEntity>()
        {
            if (Attribute.GetCustomAttribute(typeof(TEntity), typeof(BsonDiscriminatorAttribute)) != null)
            {
                var cm = BsonClassMap.LookupClassMap(typeof(TEntity));
                if (!string.IsNullOrWhiteSpace(cm.Discriminator))
                    return cm.Discriminator;
            }

            var name = typeof(TEntity).Name;
            if (MongoGlobalOptions.EnableCamelCaseCollectionName)
                name = char.ToLower(name[0]) + name.Substring(1);
            return name;
        }
    }
}
