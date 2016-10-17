using Autofac;

namespace Model
{
    public class ORMModule:Module
    {
        protected override void Load(ContainerBuilder builder)
        {
            builder.Register(c => new HongLienDb()).AsSelf().InstancePerMatchingLifetimeScope("FormScope");
            base.Load(builder);
        }
    }
}
