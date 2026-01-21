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
        return services;
    }
}

