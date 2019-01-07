using System;
using Autofac;
using Helpers;

namespace MeatsApi
{
    public class AutofacModule: AutofacModuleBase
    {
       
        protected override void Load(ContainerBuilder builder)
        {
            RegisterMapperAndDefaultImplementationsAsPerScopeLifeTime(GetType().Assembly, builder);
        }
    }
}
