using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Extensions.DependencyInjection;

namespace DotnetStack.Managers.Infrastructure
{
    public static class ManagerResolver
    {
        public static IServiceCollection AddManagers(this IServiceCollection services)
        {

            return services;
        }
    }
}
