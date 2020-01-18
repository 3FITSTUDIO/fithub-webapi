using FitHubWebApi.Infrastructure.IoC;
using Microsoft.Extensions.DependencyInjection;

namespace FitHubWebApi.IoC
{
    public static class DependencyResolver
    {
        public static void ResolveDependencies(IServiceCollection services)
        {
            InfrastructureDependencyManager.AddServices(services);
            InfrastructureDependencyManager.AddRepositories(services);
        }
    }
}
