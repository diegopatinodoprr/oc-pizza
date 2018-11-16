using System;
using System.Collections.Generic;
using System.Reflection;
using System.Text;
using Autofac;
using AutoMapper;
using NLog;
using Module = Autofac.Module;

namespace Helpers
{
    public class AutofacModule : AutofacModuleBase
    {
        protected override void Load(ContainerBuilder builder)
        {
            RegisterMapperAndDefaultImplementationsAsPerScopeLifeTime(GetType().Assembly, builder);
        }
    }
    public abstract class AutofacModuleBase : Module
    {
        protected void RegisterMapperAndDefaultImplementationsAsPerScopeLifeTime(Assembly assembly,
            ContainerBuilder builder)
        {
            var mapper = CreateMapperForAssembly(assembly);

            builder.RegisterInstance(mapper).As<IMapper>();
            builder.RegisterInstance(LogManager.GetCurrentClassLogger()).As<ILogger>();

            builder.RegisterAssemblyTypes(assembly)
                .AsImplementedInterfaces()
                .InstancePerLifetimeScope();
        }

        private IMapper CreateMapperForAssembly(Assembly assembly)
        {
            var config = new MapperConfiguration(c => c.AddProfiles(assembly.FullName));
            config.AssertConfigurationIsValid();
            var mapper = config.CreateMapper();
            return mapper;
        }
    }
}
