using Harsco.HTS.API.Filters;
using Harsco.HTS.EmailService;
using Microsoft.AspNetCore.Authorization;

//using Harsco.Services.Security;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Authorization;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Newtonsoft.Json;
using Newtonsoft.Json.Serialization;
using System;
using Microsoft.AspNetCore.Authentication.JwtBearer;
namespace Harsco.HTS.API
{
    public class Startup
    {
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public IConfiguration Configuration { get; }

        public IServiceProvider ServiceProvider { get; }

        // This method gets called by the runtime. Use this method to add services to the container.
        public void ConfigureServices(IServiceCollection services)
        {
            var emailConfig = Configuration
              .GetSection("EmailConfiguration")
              .Get<EmailConfiguration>();
            services.AddSingleton(emailConfig);

            //services.AddCors(c =>
            //{
            //    c.AddPolicy("AllowOrigin", options => options.AllowAnyOrigin().AllowAnyMethod().AllowAnyHeader());
            //});

            services.AddMvc()
              .AddMvcOptions(options =>
              {
                  options.EnableEndpointRouting = false;
                  //options.Filters.Add<AssertAutherizationAttribute>();
                  options.Filters.Add<ApiExceptionFilter>();
              })
              .SetCompatibilityVersion(CompatibilityVersion.Version_3_0);
            services.AddControllers(options =>
             {
                 var policy = new AuthorizationPolicyBuilder()
                     .RequireAuthenticatedUser()
                     .Build();
                 options.Filters.Add(new AuthorizeFilter(policy));
             });

            services.AddControllers()
            .AddNewtonsoftJson(options =>
            {
                options.SerializerSettings.ContractResolver = new DefaultContractResolver();
                options.SerializerSettings.Formatting = Newtonsoft.Json.Formatting.Indented;
                options.SerializerSettings.ReferenceLoopHandling = ReferenceLoopHandling.Ignore;
                
            });
                    services.AddAuthentication(JwtBearerDefaults.AuthenticationScheme)
          .AddJwtBearer(options =>
          {
              options.Authority = "https://login.microsoftonline.com/320c95f3-6f40-4b25-aa05-5c3137575fe9/";
              options.Audience = "api://52e69793-4e54-451c-b03a-f93af310d05c"; //api://52e69793-4e54-451c-b03a-f93af310d05c

          });
            services.AddAuthorization();
            services.AddScoped<IEmailService, Harsco.HTS.EmailService.EmailService>();

            services.AddScoped<IServiceProvider, ServiceProvider>();

            //services.AddHarscoSecuritySupport(this.ServiceProvider, this.Configuration);

            if (Convert.ToBoolean(Configuration["AppSettings:CORSAllowAll"]))
            {
                services.AddCors(c =>
                {
                    c.AddPolicy("AllowOrigin", options =>
                    {
                        options.AllowAnyOrigin()
                        .AllowAnyMethod() //AllowAllMethods;  
                        .AllowAnyHeader();
                    });
                });
            }

            // Registering Dependency Injection of IAM Core Services
            services.RegisterIAMCoreServices(this.ServiceProvider, this.Configuration);
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            //app.UseCors(options => options.AllowAnyOrigin());
            //app.UseCors(options => options.WithOrigins("https://localhost:4200"));

            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }   

             app.UseHttpsRedirection();

            app.UseRouting();

            app.UseCors(x => x.AllowAnyOrigin().AllowAnyMethod().AllowAnyHeader());
            app.UseAuthentication();
            app.UseAuthorization();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllers();
            });
        }
    }
}