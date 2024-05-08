using PimProject.Application.Domain.Interface;
using PimProject.Application.Infra.Data.Repository;
using PimProject.Application.Services;

namespace PimAPI.Extension
{
    public static class ServiceCollection
    {

        public static IServiceCollection AddFeaturesServices(this IServiceCollection services)
        {
            services.AddServices();
            services.AddRepository();
            services.AddControllers();

            return services;
        }

        public static IServiceCollection AddServices(this IServiceCollection services)
        {
           
            services.AddScoped<IFornecedoresServices, FornecedoresService>();
            services.AddScoped<IProduçãoServices, ProduçãoService>();
            services.AddScoped<IVendasServices, VendasService>();
           

            return services;
        }

        public static IServiceCollection AddRepository(this IServiceCollection services)
        {
            services.AddScoped<IColaboradoresRepository, ColaboradoresRepository>();
            services.AddScoped<IFornecedoresRepository, FornecedoresRepository>();
            services.AddScoped<IProduçãoRepository, ProduçãoRepository>();
            services.AddScoped<IVendasRepository, VendasRepository>();
            return services;
        }


    }
}
