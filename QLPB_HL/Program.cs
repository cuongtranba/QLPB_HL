using System;
using System.Reflection;
using System.Threading;
using System.Windows.Forms;
using Autofac;
using AutoMapper;
using log4net;
using log4net.Config;
using Model;
using Model.ViewModel;
using Service;
namespace QLPB_HL
{
    static class Program
    {
        public static IContainer Container;
        private static readonly ILog log = LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            XmlConfigurator.Configure();
            Container = RegisterIOC();
            RegisterAutoMapper();
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.DoEvents();
            var loginForm = FormFactory.CreateForm<frmLogin>();
            loginForm.ShowDialog();
            if (loginForm.DialogResult == DialogResult.OK)
            {
                var mainForm = FormFactory.CreateForm<frmMidi>();
                Global.clsVar.fMain = mainForm;
                try
                {
                    mainForm.ShowDialog();
                }
                catch (Exception exception)
                {
                    log.Error(exception.Message, exception);
                    MessageBox.Show(exception.Message, "lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private static void RegisterAutoMapper()
        {
            Mapper.Initialize(cfg =>
            {
                cfg.CreateMap<tblIndexItem, ItemViewModel>();
                cfg.CreateMap<UpdateItemViewModel, tblIndexItem>();
                cfg.CreateMap<AddItemViewModel, tblIndexItem>();

                cfg.CreateMap<tblIndexStock, StockViewModel>();
                cfg.CreateMap<AddStockViewModel, tblIndexStock>();
                cfg.CreateMap<UpdateStockViewModel, tblIndexStock>();

                cfg.CreateMap<tblIndexLoader, LoaderViewModel>();
                cfg.CreateMap<UpdateLoaderViewModel, tblIndexLoader>();
                cfg.CreateMap<SearchLoaderViewModel, tblIndexLoader>();
                cfg.CreateMap<AddLoaderViewModel, tblIndexLoader>();

                cfg.CreateMap<tblIndexTransport, TransportViewModel>();
                cfg.CreateMap<UpdateTransportViewModel, tblIndexTransport>();
                cfg.CreateMap<AddTransportViewModel, tblIndexTransport>();

                cfg.CreateMap<tblIndexObject, ObjectViewModel>();
                cfg.CreateMap<UpdateObjectViewModel, tblIndexObject>();
                cfg.CreateMap<CreateObjectViewModel, tblIndexObject>();

                cfg.CreateMap<tblIndexAccount, AccountViewModel>();
                cfg.CreateMap<UpdateAccountViewMode, tblIndexAccount>();
                cfg.CreateMap<AddAccountViewModel, tblIndexAccount>();

                cfg.CreateMap<UpdateFeeViewModel, tblIndexFee>();
                cfg.CreateMap<CreateFeeViewModel, tblIndexFee>();

                cfg.CreateMap<UpdateInOutReasonViewModel, tblIndexInOutReason>();
                cfg.CreateMap<CreateInOutReasonViewModel, tblIndexInOutReason>();

                cfg.CreateMap<WorkingPeriodViewModel, tblSysWorkingPeriod>();
            });
        }

        public static void DeactivePanel()
        {
            Global.clsVar.fMain.panel1.SendToBack();
        }

        private static IContainer RegisterIOC()
        {
            var builder = new ContainerBuilder();
            builder.RegisterModule<ServiceModule>();
            builder.RegisterModule<ORMModule>();
            var assembly = Assembly.GetExecutingAssembly();
            builder.RegisterAssemblyTypes(assembly)
                .Where(type => type.IsSubclassOf(typeof(Form))).InstancePerMatchingLifetimeScope("FormScope");
            builder.RegisterModule<FormModule>();
            var container = builder.Build();
            return container;
        }

    }
}
