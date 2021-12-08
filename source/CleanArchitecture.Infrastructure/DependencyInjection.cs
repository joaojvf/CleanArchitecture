using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace CleanArchitecture.Infrastructure.CrossCutting
{
    public static class DependencyInjection
    {
        public static IServiceCollection RegisterInfrastructerServices(
             this IServiceCollection service,
             IConfiguration configuration)
        {
            return service;
        }
    }
}
