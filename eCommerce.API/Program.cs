using eCommerce.API.Middlewares;
using eCommerce.Core;
using eCommerce.Infrastructure;
using System.Text.Json.Serialization;

namespace eCommerce.API
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);
      

            builder.Services.AddInfrastructure();
            builder.Services.AddCore();
            //Add Controllers
            builder.Services.AddControllers().AddJsonOptions(options =>
            {
                options.JsonSerializerOptions.Converters.Add(new JsonStringEnumConverter());
            });
            //Commit TestService
            var app = builder.Build();
            app.UseExceptionHandlingMiddleware();
            app.UseRouting();

            app.UseAuthentication();
            app.UseAuthorization();

            app.MapControllers();
                
            app.Run();
        }
    }
}
