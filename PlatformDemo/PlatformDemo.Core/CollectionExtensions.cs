using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using PlatformDemo.Core.Contracts;
using PlatformDemo.Core.Implementation;

namespace PlatformDemo.Core;

public static class CollectionExtensions
{
    public static IServiceCollection AddCoreServices(this IServiceCollection services, IConfiguration configuration)
    {
        services.AddDbContext<PlatformDemoDbContext>(options =>
        {
            options.UseSqlServer(configuration.GetConnectionString("DefaultConnection"));
        });

        services.AddScoped(typeof(IRepository<>), typeof(Repository<>));
        
        return services;
    }
}