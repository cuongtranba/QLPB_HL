using System.Data;
using Autofac;
using Model;
using Service.Implements;
using Service.Interfaces;
using _4.Helper;

namespace Service
{
    public class ServiceModule : Module
    {
        protected override void Load(ContainerBuilder builder)
        {
            builder.RegisterAssemblyTypes(ThisAssembly).Where(c => c.Name.EndsWith("Service")).AsImplementedInterfaces().PropertiesAutowired().InstancePerMatchingLifetimeScope("FormScope");
            builder.Register(context => new CategoryItemService(context.Resolve<HongLienDb>())).Named<ICategoryService>(Constant.DanhMucHangHoa).InstancePerMatchingLifetimeScope("FormScope"); 
            base.Load(builder);
        }
    }
}
