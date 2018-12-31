
using Helpers;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;
using Newtonsoft.Json.Converters;
using Newtonsoft.Json.Serialization;
using Microsoft.EntityFrameworkCore;
using Autofac;
//using Photoweb.App.Services.Catalog.DomainAdapters.Persistence;
//using Photoweb.Authentication.Core;



namespace apiA
{
    public class Startup
    {
        private readonly IHostingEnvironment _hostingEnv;


        public Startup(IHostingEnvironment env, IConfiguration configuration)
        {
            Configuration = configuration;
            _hostingEnv = env;
        }

        public IConfiguration Configuration { get; }

        // This method gets called by the runtime. Use this method to add services to the container.
        public void ConfigureServices(IServiceCollection services)
        {
            if (_hostingEnv.IsDevelopment() || _hostingEnv.IsStaging())
            {
                services.AddCors();
            }
            //services.AddDbContextPwb<IAppParametersContext, AppParametersContext>(opt =>
            //  opt.UseMySql(Configuration[EnvionmentVariables.AppParametersDatabaseConnectionString]));

            //services.AddDbContextPwb<MigrationAppParametersContext, MigrationAppParametersContext>(opt => opt.UseMySql(Configuration[EnvionmentVariables.MigrationAppparametersDatabaseConnectionString]));
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
