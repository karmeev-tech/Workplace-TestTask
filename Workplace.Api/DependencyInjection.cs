using Microsoft.Extensions.DependencyInjection;
using Workplace.Application.Services.Commands;
using Workplace.Application.Services.Queries;

namespace Workplace.Api
{
    public static class DependencyInjection
    {
        public static IServiceCollection AddApplication(this IServiceCollection services)
        {
            services.AddSingleton<IQueriesService, QueriesService>();
            services.AddSingleton<ICommandsService, CommandService>();
            return services;
        }
    }
}
