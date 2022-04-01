using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.DependencyInjection.Extensions;
using NET_Project_API.BusinessLogic.Repository.Blog;
using NET_Project_API.BusinessLogic.Services.Blog;

namespace NET_Project_API.DI
{
    public static class ServiceCollectionExtensions
    {
        public static IServiceCollection AddBusinessLogic(this IServiceCollection services)
        {
            services.AddSingletonSafely<IBlogRepository, BlogRepository>();
            services.AddSingletonSafely<IBlogService, BlogService>();
            return services;
        }

        private static void AddSingletonSafely<TService, TImplementation>(this IServiceCollection services)
            where TService : class
            where TImplementation : class, TService
        {
            services.TryAddSingleton<TService, TImplementation>();
        }
    }
}
