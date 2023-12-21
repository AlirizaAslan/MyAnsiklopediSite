using System.Reflection;
using Microsoft.Extensions.DependencyInjection;
using Site.Service.Services.Abstractions;
using Site.Service.Services.Concretes;

namespace Site.Service.Extantions;

public static class ServiceLayerExtantions
{

     public static IServiceCollection LoadServiceLayerExtantions(this IServiceCollection services) 
        {
            var assembly = Assembly.GetExecutingAssembly();  //assembly şuan çağrıldığı kısmı işaret ediyor ders 10 dakka 20
            services.AddScoped<IArticleService,ArticleService>();
            services.AddAutoMapper(assembly); 

            return services;
        }
}
