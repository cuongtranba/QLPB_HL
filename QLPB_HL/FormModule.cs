using System.Windows.Forms;
using Autofac;
using Model;
using Service.Implements;
using Service.Interfaces;
using _4.Helper;

namespace QLPB_HL
{
    public class FormModule:Module
    {
        protected override void Load(ContainerBuilder builder)
        {
            builder.Register(context => new frmTonKho(context.Resolve<ICommonService>(),context.Resolve<IInventoryServices>())).Named<Form>("Số dư đầu kỳ").InstancePerMatchingLifetimeScope("FormScope");
            builder.Register(context => new frmTonKho(context.Resolve<ICommonService>(), context.Resolve<IInventoryServices>())).Named<Form>("Tồn kho cuối kỳ").InstancePerMatchingLifetimeScope("FormScope"); ;
            base.Load(builder);
        }
    }
}
