using System.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Namespace;


namespace Site.Data.DataLayerExtantions;

public static class DataLayerExtantions
{
    
        public static IServiceCollection LoadDataLayerExtension(this IServiceCollection services,IConfiguration config) 
        {
            services.AddDbContext<AppDbContext>(opt => opt.UseNpgsql(config.GetConnectionString("DefaultConnection"),b => b.MigrationsAssembly("Site.Web")));
         
            return services;
        }
    
}
