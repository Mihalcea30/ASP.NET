using lab4.Repositories.CarRepository;

namespace lab4.Helper.Extensions
{
    public static class ServiceExtensions
    {
        public static IServiceCollection AddRepositories(this IServiceCollection services)
        {
            services.AddTransient<ICarRepository, CarRepository>();

            return services;
        }

        public static IServiceCollection AddServices(this IServiceCollection services)
        {
            services.AddTransient<ICarRepository, CarRepository>();

            return services;
        }

    }
}
