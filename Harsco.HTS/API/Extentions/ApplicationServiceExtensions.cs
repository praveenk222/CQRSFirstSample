using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Application.Activites;
using MediatR;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using Persistence;
using Persistence.Models;
namespace API.Extentions
{
   

    public static class ApplicationServiceExtensions
    {
//why this not taken paramterin program.cs how return expecting check.
        public static IServiceCollection AddApplicationServices(this IServiceCollection services,
            IConfiguration config)
        {
            // Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
            services.AddEndpointsApiExplorer();
            services.AddSwaggerGen();
            services.AddDbContext<dbtatContext>(opt =>
            {
                opt.UseSqlServer(config.GetConnectionString("con"));
            });
            //services.AddDbContext<DataContext>(options =>
            //{
            //    var env = Environment.GetEnvironmentVariable("ASPNETCORE_ENVIRONMENT");

            //    string connStr;

            //    // Depending on if in development or production, use either FlyIO
            //    // connection string, or development connection string from env var.
            //    if (env == "Development")
            //    {
            //        // Use connection string from file.
            //        connStr = config.GetConnectionString("DefaultConnection");
            //    }
            //    else
            //    {
            //        // Use connection string provided at runtime by Flyio.
            //        var connUrl = Environment.GetEnvironmentVariable("DATABASE_URL");

            //        // Parse connection URL to connection string for Npgsql
            //        connUrl = connUrl.Replace("postgres://", string.Empty);
            //        var pgUserPass = connUrl.Split("@")[0];
            //        var pgHostPortDb = connUrl.Split("@")[1];
            //        var pgHostPort = pgHostPortDb.Split("/")[0];
            //        var pgDb = pgHostPortDb.Split("/")[1];
            //        var pgUser = pgUserPass.Split(":")[0];
            //        var pgPass = pgUserPass.Split(":")[1];
            //        var pgHost = pgHostPort.Split(":")[0];
            //        var pgPort = pgHostPort.Split(":")[1];

            //        connStr = $"Server={pgHost};Port={pgPort};User Id={pgUser};Password={pgPass};Database={pgDb};";
            //    }

            //    // Whether the connection string came from the local development configuration file
            //    // or from the environment variable from FlyIO, use it to set up your DbContext.
            //    options.UseNpgsql(connStr);
            //});
            services.AddCors(opt =>
            {
                opt.AddPolicy("CorsPolicy", policy =>
                {
                    policy
                        .AllowAnyMethod()
                        .AllowAnyHeader()
                        .AllowCredentials()
                        .WithOrigins("http://localhost:5173"); // Specify allowed origins
                });
            });


            //services.AddMediatR(typeof(List.Handler));
            //   services.AddAutoMapper(typeof(MappingProfiles).Assembly);
            // services.AddFluentValidationAutoValidation();
            //services.AddValidatorsFromAssemblyContaining<Create>();
            services.AddHttpContextAccessor();
           
            services.AddSignalR();

            return services;
        }
    }
}