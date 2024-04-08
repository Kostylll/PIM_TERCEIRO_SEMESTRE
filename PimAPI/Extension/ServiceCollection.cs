namespace PimAPI.Extension
{
    public static class ServiceCollection
    {
        public static IServiceCollection AddFeaturesServices(this IServiceCollection services)
        {
            services.AddRepository();
            services.AddControllers();
            services.AddServices();

            return services;
        }

        public static IServiceCollection AddServices(this IServiceCollection services)
        {

            return services;
        }

        public static IServiceCollection AddRepository(this IServiceCollection services)
        {
            return services;
        }




    }
}
