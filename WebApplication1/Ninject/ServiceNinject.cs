using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Threading.Tasks;
using Autofac;
using fwc.netcore.demo.CommonHelper;
using Microsoft.Extensions.Configuration;
using StackExchange.Redis;
using WebApplication1.Application.Queries;
using Module = Autofac.Module;

namespace WebApplication1.Ninject
{
    public class ServiceNinject : Module
    {
        private readonly IConfiguration Configuration;
        public ServiceNinject(IConfiguration _configuration) 
        {
            Configuration = _configuration;
        }
        protected override void Load(ContainerBuilder builder)
        {
            // 注册所有Querie
            builder.RegisterAssemblyTypes(typeof(IQueries).GetTypeInfo().Assembly)
                    .Where(t => typeof(IQueries).IsAssignableFrom(t))
                    .AsImplementedInterfaces()
                    .InstancePerLifetimeScope();

            builder.RegisterType<RedisManager>().As<RedisManager>();

            base.Load(builder);
        }
    }
}
