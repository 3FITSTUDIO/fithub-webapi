using FitHubWebApi.Core.Repositories;
using FitHubWebApi.Infrastructure.Repositories;
using FitHubWebApi.Infrastructure.Services.Abstraction;
using FitHubWebApi.Infrastructure.Services.Implementation;
using Microsoft.Extensions.DependencyInjection;


namespace FitHubWebApi.Infrastructure.IoC
{
    public static class InfrastructureDependencyManager
    {
        public static void AddRepositories(IServiceCollection services)
        {
            services.AddTransient<IUsersRepository, UsersRepository>();
        }

        public static void AddServices(IServiceCollection services)
        {
            services.AddTransient<IUsersService, UsersService>();
        }
    }
}
