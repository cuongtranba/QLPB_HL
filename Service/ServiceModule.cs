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
            builder.Register(context => new CategoryItemService(context.Resolve<HongLienDb>())).Named<ICategoryService>(Constant.CategoryItem).InstancePerMatchingLifetimeScope("FormScope");
            builder.Register(context => new StockCategoryService(context.Resolve<HongLienDb>())).Named<ICategoryService>(Constant.CategoryStock).InstancePerMatchingLifetimeScope("FormScope");
            builder.Register(context => new LoaderCategoryService(context.Resolve<HongLienDb>())).Named<ICategoryService>(Constant.CategoryLoader).InstancePerMatchingLifetimeScope("FormScope");
            builder.Register(context => new TransportCategoryService(context.Resolve<HongLienDb>())).Named<ICategoryService>(Constant.CategoryTransport).InstancePerMatchingLifetimeScope("FormScope");
            builder.Register(context => new CustomerCategoryService(context.Resolve<HongLienDb>())).Named<ICategoryService>(Constant.CustomerCategory).InstancePerMatchingLifetimeScope("FormScope");
            builder.Register(context => new AccountCategoryService(context.Resolve<HongLienDb>())).Named<ICategoryService>(Constant.AccountCategory).InstancePerMatchingLifetimeScope("FormScope");
            builder.Register(context => new FeeCategoryService(context.Resolve<HongLienDb>())).Named<ICategoryService>(Constant.FeeCategory).InstancePerMatchingLifetimeScope("FormScope");
            builder.Register(context => new InOutReasonCategoryService(context.Resolve<HongLienDb>())).Named<ICategoryService>(Constant.InOutReasonCategory).InstancePerMatchingLifetimeScope("FormScope");
            base.Load(builder);
        }
    }
}
