using MediatR;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using POC.Distribute.Application.Business.Application.UseCases.User;
using POC.Distribute.Application.Infra.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace POC.Distribute.Application.Presentation.Api
{
    public static class ConfigureBaseServices
    {
        private static IList<string> LocalEnviroments = new List<string> { "Local", "Dev" };
        public static IServiceCollection ConfigureBaseService(this IServiceCollection service)
        {
            service.AddSwaggerGen();
            service.AddMediatR(typeof(InsertUserCommandHandler));
            service.AddRepository();

            return service;
        }

        public static bool IsDevelopmentOrLocal(this IHostEnvironment hostEnvironment) => LocalEnviroments.Contains(hostEnvironment.EnvironmentName);
    }
}
