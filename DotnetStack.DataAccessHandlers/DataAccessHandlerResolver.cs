using DotnetStack.Core.Interfaces;
using DotnetStack.DataAccessHandlers.Infrastructure.EntityFramework;
using DotnetStack.DataAccessHandlers.Quotes;
using DotnetStack.Handlers.Infrastructure;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace DotnetStack.DataAccessHandlers
{
    public static class DataAccessHandlerResolver
    {
        public static IServiceCollection AddDataAccessHandlers(this IServiceCollection services, IConfiguration config)
        {
            services.AddDataAccessHandlerInfrastructure(config);

            services.AddTransient<IQuoteHandler, QuoteHandler>();

            return services;
        }

        private static IServiceCollection AddDataAccessHandlerInfrastructure(this IServiceCollection services, IConfiguration config)
        {
            services.AddTransient<DbContext, DotnetStackContext>();
            services.AddTransient<IUnitOfWork, UnitOfWork>();
            services.AddScoped(p => new DotnetStackContextAdapter(p.GetService<DbContext>()!));

            services.AddTransient(typeof(IDbContext), p => p.GetService<DotnetStackContextAdapter>()!);
            services.AddTransient(typeof(IDbSetFactory), p => p.GetService<DotnetStackContextAdapter>()!);

            services.AddDbContext<DotnetStackContext>(options =>
                options.UseSqlServer(config.GetConnectionString("DotnetStackDatabase"))
            );

            return services;
        }
    }
}
