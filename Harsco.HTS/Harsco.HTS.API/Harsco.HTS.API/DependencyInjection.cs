using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Harsco.HTS.API
{
    public static class DependencyInjection
    {
        /// <summary>
        /// Registers the core services.
        /// </summary>
        /// <param name="services">The services.</param>
        /// <param name="serviceResolver">The service resolver.</param>
        /// <returns>The Value</returns>
        public static IServiceCollection RegisterIAMCoreServices(this IServiceCollection services, IServiceProvider serviceResolver, IConfiguration configuration)
        {   
            ////Configurations
            //services.AddSingleton<IAppConfigProvider, AppConfigProvider>();

            ////Logger
            ////services.AddScoped<ILogger, TelemetryLogger>()
            ////var serviceProvider2 = services.BuildServiceProvider();

            //services.AddSingleton<ILogger>(serviceProvider =>
            //{
            //    var config = serviceProvider.GetService<IAppConfigProvider>();

            //    //// Telemetry config initializer.
            //    TelemetryConfiguration.Active.InstrumentationKey = config.AppInsights[AppKeys.InstrumentationKey];

            //    TelemetryConfiguration.Active.TelemetryInitializers.Add(new TelemetryConfigInitializer(
            //                config.AppInsights[AppKeys.TelemetryAppVersion],
            //                config.AppInsights[AppKeys.TelemetryTags]));

            //    var loggers = new List<ILogger>();
            //    var telemetry = new TelemetryLogger(TelemetryConfiguration.Active);
            //    loggers.Add(telemetry);
            //    ////Adding SemanticLogger is pending, will add based on the requirement

            //    var logger = new Logger((LogLevel)Enum.Parse(typeof(LogLevel), config.AppInsights[AppKeys.LogLevel], true));
            //    logger.InitializeLoggers(loggers.ToArray());
            //    return logger;
            //});

            // Initialize EF Database Context and Register Reposity Services
            //string iamCoreDbConnectionString = serviceResolver.GetService<IConfiguration>()["ConnectionStrings:IAMCoreDbConnectionString"].ToString();
            //services.AddDbContext<CoreDbContext>(options => options.UseSqlServer(iamCoreDbConnectionString));           

            
            

            //// and a lot more Services

            return services;
        }
    }
}
