using Autofac;

namespace Service
{
    public class ServiceModule:Module
    {
        protected override void Load(ContainerBuilder builder)
        {
            builder.RegisterAssemblyTypes(ThisAssembly).Where(c => c.Name.EndsWith("Service"))
                .AsImplementedInterfaces().PropertiesAutowired().InstancePerMatchingLifetimeScope("FormScope");
            base.Load(builder);
        }
    }
}
