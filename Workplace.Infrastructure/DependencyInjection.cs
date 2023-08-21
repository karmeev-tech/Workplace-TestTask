using Microsoft.Extensions.DependencyInjection;
using Workplace.Infrastructure.Interfaces;
using Workplace.Infrastructure.Model;
using Workplace.Infrastructure.Persistence.Repositories;

namespace Workplace.Infrastructure
{
    public static class DependencyInjection
    {
        public static IServiceCollection AddInfrastructure(this IServiceCollection services)
        {
            services.AddSingleton<IRepository<UserEntity>, UserRepository>();
            return services;
        }
    }
}
