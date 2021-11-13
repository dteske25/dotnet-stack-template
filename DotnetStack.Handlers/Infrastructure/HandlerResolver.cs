using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Extensions.DependencyInjection;

namespace DotnetStack.Handlers.Infrastructure
{
    public static class HandlerResolver
    {
        public static IServiceCollection AddHandlers(this IServiceCollection services)
        {

            return services;
        }
    }
}
