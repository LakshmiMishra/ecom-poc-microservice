using eCommerce.API.Middlewares;
using eCommerce.Core;
using eCommerce.Core.Mapper;
using eCommerce.Infrastructure;
using Microsoft.Extensions.DependencyInjection;
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
            builder.Services.AddAutoMapper(typeof(ApplicationUserMappingProfile).Assembly);
            builder.Services.AddEndpointsApiExplorer();
            builder.Services.AddCors(options=>
            {
                options.AddDefaultPolicy(policy =>
                {
                    policy.WithOrigins("http://localhost:4200")
                          .AllowAnyHeader()
                          .AllowAnyMethod();
                });
            });
            //Add Swagger
            builder.Services.AddSwaggerGen();



            var app = builder.Build();
            app.UseExceptionHandlingMiddleware();
            app.UseRouting();
            app.UseSwagger();
            app.UseSwaggerUI();

            app.UseCors();

            app.UseAuthentication();
            app.UseAuthorization();

            app.MapControllers();
                
            app.Run();
        }
    }
}
