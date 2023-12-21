using System.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Namespace;
using Site.Data.Repositories.Abstractions;
using Site.Data.Repositories.Concretes;
using Site.Data.UnitOfWorks;


namespace Site.Data.DataLayerExtantions;

public static class DataLayerExtantions
{
    
        public static IServiceCollection LoadDataLayerExtension(this IServiceCollection services,IConfiguration config) 
        {
            services.AddScoped(typeof(IRepository<>),typeof(Repository<>));
            services.AddDbContext<AppDbContext>(opt => opt.UseNpgsql(config.GetConnectionString("DefaultConnection"),b => b.MigrationsAssembly("Site.Web")));
            services.AddScoped<IUnitOfWork,UnitOfWork>();
            return services;
        }
    
}
