using eCommerce.API.Middlewares;
using eCommerce.Core;
using eCommerce.Infrastructure;

namespace eCommerce.API
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);
            var app = builder.Build();

            builder.Services.AddInfrastructure();
            builder.Services.AddCore();
            //Add Controllers
            builder.Services.AddControllers();
            //Commit TestService

            app.UseExceptionHandlingMiddleware();
            app.UseRouting();

            app.UseAuthentication();
            app.UseAuthorization();

            app.MapControllers();
            app.Run();
        }
    }
}
