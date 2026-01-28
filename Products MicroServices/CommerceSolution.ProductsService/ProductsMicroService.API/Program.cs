using eCommerce.ProductsService.DataAccessLayer;
using eCommerce.ProductsService.BusinessLogicLayer;
using eCommerce.ProductsMicroService.API.Middleware;
using FluentValidation.AspNetCore;
using eCommerce.ProductsMicroService.API.APIEndpoints;

namespace ProductsMicroService.API
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);
           
            //Add DAL and BLL services
            builder.Services.AddDataAccessLayer(builder.Configuration);
            builder.Services.AddBusinessLogicLayer();

            builder.Services.AddControllers();
            builder.Services.AddFluentValidationAutoValidation();

            //Add Swagger/OpenAPI
            builder.Services.AddEndpointsApiExplorer();
            builder.Services.AddSwaggerGen();

            var app = builder.Build();

            //Configure Swagger UI
            if (app.Environment.IsDevelopment())
            {
                app.UseSwagger();
                app.UseSwaggerUI();
            }

            app.UseExceptionHandlingMiddleware();
            app.UseRouting();

            app.UseAuthentication();
            app.UseAuthorization();
              
            app.MapControllers();
            app.MapProductAPIEndpoints();
            app.Run();
        }
    }
}
