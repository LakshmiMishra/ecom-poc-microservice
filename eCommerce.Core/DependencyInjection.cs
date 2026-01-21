using eCommerce.Core.ServiceContracts;
using eCommerce.Core.Services;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace eCommerce.Core;

 public static class DependencyInjection
    {
    /// <summary>
    /// extends IServiceCollection to add core services.    
    public static IServiceCollection AddCore(this IServiceCollection services)
        {
        // Add core services here, e.g., domain services, business logic, etc.
        //Core services often include data access, caching and other low-level components.

        services.AddTransient<IUsersService, UsersService>();
        return services;
    }
}

