using Microsoft.AspNetCore.Builder;
using Microsoft.OpenApi.Models;

namespace CustomerWebAPI
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);

            // Add services to the container.

            builder.Services.AddControllers();
            builder.Services.AddEndpointsApiExplorer();
            builder.Services.AddSwaggerGen(c =>
            {
                c.SwaggerDoc("v1", new OpenApiInfo
                {
                    Title = "Customer API",
                    Version = "v1"
                });
            });

            var app = builder.Build();

            if (app.Environment.IsDevelopment())
            {
                app.UseSwagger();
                app.UseSwaggerUI(c =>
                {
                    c.SwaggerEndpoint("/swagger/v1/swagger.json", "customer api v1");
                    c.RoutePrefix = string.Empty;  
                });
            }
            // Configure the HTTP request pipeline.

            app.UseAuthorization();
            app.UseHttpsRedirection();

            app.MapControllers();

            app.Run();
        }
    }
}
