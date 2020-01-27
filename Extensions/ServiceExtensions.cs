using CarsCatalogue.Contracts;
using CarsCatalogue.Repository;
using Microsoft.Extensions.DependencyInjection;

namespace CarsCatalogue.Extensions
{
    //CODEREV: Не видно смысла в еще большем разбиении конфигурации из одного файла в несколько
    public static class ServiceExtensions
    {
        public static void ConfigureCors(this IServiceCollection services)
        {
            services.AddCors(options =>
            {
                options.AddPolicy("CorsPolicy",
                    builder => builder.AllowAnyOrigin()
                        .AllowAnyOrigin() 
                        .AllowAnyMethod() 
                        .AllowAnyHeader() 
                        .AllowCredentials()
                );
            });
        }
        
        public static void ConfigureRepositoryWrapper(this IServiceCollection services)
        {
            services.AddScoped<IRepositoryWrapper, RepositoryWrapper>();
        }
    }
}