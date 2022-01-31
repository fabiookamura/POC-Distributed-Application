using Microsoft.Extensions.DependencyInjection;
using POC.Distribute.Application.Business.Domain.Interfaces;
using POC.Distribute.Application.Infra.Repository.WriteOnly;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POC.Distribute.Application.Infra.Repository
{
    public static class PersistenceConfiguration
    {
        public static IServiceCollection AddRepository(this IServiceCollection service)
        {
            service.AddScoped<IUserRepository, UserWriteOnlyRepository>();
            return service;
        }
    }
}
