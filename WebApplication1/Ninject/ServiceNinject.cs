using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Threading.Tasks;
using Autofac;
using WebApplication1.Application.Queries;
using Module = Autofac.Module;

namespace WebApplication1.Ninject
{
    public class ServiceNinject : Module
    {
        protected override void Load(ContainerBuilder builder)
        {
            // 注册所有Querie
            builder.RegisterAssemblyTypes(typeof(IQueries).GetTypeInfo().Assembly)
                .Where(t => typeof(IQueries).IsAssignableFrom(t))
                .AsImplementedInterfaces()
                .InstancePerLifetimeScope();

            base.Load(builder);
        }
    }
}
