using DotnetStack.Managers.Quotes;
using Microsoft.Extensions.DependencyInjection;

namespace DotnetStack.Managers.Infrastructure
{
    public static class ManagerResolver
    {
        public static IServiceCollection AddManagers(this IServiceCollection services)
        {
            services.AddTransient<IQuoteManager, QuoteManager>();

            return services;
        }
    }
}
