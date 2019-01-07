using Autofac;
using Helpers;
using MeatsApi.DomainAdapters.Persistance;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;
using Newtonsoft.Json.Converters;
using Newtonsoft.Json.Serialization;

namespace MeatsApi
{
    public class Startup
    {
        private readonly IHostingEnvironment _hostingEnv;
        private IConfiguration Configuration { get; }


        public Startup(IHostingEnvironment env, IConfiguration configuration)
        {
            Configuration = configuration;
            _hostingEnv = env;
        }

       
        // This method gets called by the runtime. Use this method to add services to the container.
        public void ConfigureServices(IServiceCollection services)
        {
            if (_hostingEnv.IsDevelopment() || _hostingEnv.IsStaging())
            {
                services.AddCors();
            }
            services.AddDbContextDoprr<IMeatsContext, MeatsContext>(opt =>
                opt.UseMySql(Configuration[EnvionmentVariables.MeatsDatabaseConnectionString]));


            services.AddDbContextDoprr<MigrationMeatsContext, MigrationMeatsContext>(opt => opt.UseMySql(Configuration[EnvionmentVariables.MigrationMeatsDatabaseConnectionString]));
            services
                .AddMvc()
                .AddJsonOptions(opts =>
                {
                    opts.SerializerSettings.ContractResolver = new CamelCasePropertyNamesContractResolver();
                    opts.SerializerSettings.Converters.Add(new StringEnumConverter
                    {
                        NamingStrategy = new CamelCaseNamingStrategy()
                    });
                });

        }
        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IHostingEnvironment env, ILoggerFactory loggerFactory)
        {
            if (env.IsDevelopment() || env.IsStaging())
            {
                app.UseCors(builder =>
                    builder.AllowAnyHeader().AllowAnyMethod().AllowAnyOrigin());
            }
            app.UseMiddleware(typeof(ErrorHandlingMiddleware));

            app
                .UseMvc()
                .UseDefaultFiles()
                .UseStaticFiles();

            using (var serviceScope = app.ApplicationServices.GetRequiredService<IServiceScopeFactory>().CreateScope())
            {
                if (!serviceScope.ServiceProvider.GetService<MigrationMeatsContext>().AllMigrationsApplied())
                {
                    serviceScope.ServiceProvider.GetService<MigrationMeatsContext>().Database.Migrate();
                }
                serviceScope.ServiceProvider.GetService<MigrationMeatsContext>().Seed(_hostingEnv);
            }
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }
        }

        public void ConfigureContainer(ContainerBuilder builder)
        {
            builder.RegisterModule(new Helpers.AutofacModule());
            builder.RegisterModule(new AutofacModule());
        }
    }
}
