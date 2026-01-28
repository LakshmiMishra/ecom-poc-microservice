
using eCommerce.Core.RepositoryContracts;
using eCommerce.Infrastructure.DbContext;
using eCommerce.Infrastructure.Repositories;
using Microsoft.Extensions.DependencyInjection;

namespace eCommerce.Infrastructure;

   public static class DependencyInjection
    {
    /// <summary>
    /// extends IServiceCollection to add infrastructure services.
    /// 
    public static IServiceCollection AddInfrastructure(this IServiceCollection services)
        {
        // Add infrastructure services here, e.g., database contexts, repositories, etc.
        // services.AddDbContext<ApplicationDbContext>(options =>
        //     options.UseSqlServer(configuration.GetConnectionString("DefaultConnection")));
        //Core services often include data access, caching and other low-level components.

        services.AddTransient<IUsersRepository, UsersRepository>();
        services.AddTransient<DapperDbContext>();
        return services;
    }
}

