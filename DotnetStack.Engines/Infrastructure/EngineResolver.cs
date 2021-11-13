using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Extensions.DependencyInjection;

namespace DotnetStack.Engines.Infrastructure
{
    public static class EngineResolver
    {
        public static IServiceCollection AddEngines(this IServiceCollection services)
        {

            return services;
        }
    }
}
