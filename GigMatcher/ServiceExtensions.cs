using Data.Repo.Implementations;
using Data.Repo.Interfaces;
using Microsoft.Extensions.DependencyInjection;


namespace GigMatcher
{
    public static class ServiceExtensions
    {
        public static void ConfigureRepositoryWrapper(this IServiceCollection services)
        {
            services.AddScoped<IRepositoryWrapper, RepositoryWrapper>();
        }
    }
}
