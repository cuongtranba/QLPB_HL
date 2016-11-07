using System;
using System.Reflection;
using System.Windows.Forms;
using Autofac;
using AutoMapper;
using Model;
using Model.ViewModel;
using Service;

namespace QLPB_HL
{
    static class Program
    {
        public static IContainer Container;

        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
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
                mainForm.ShowDialog();
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

                cfg.CreateMap<tblIndexTransport,TransportViewModel>();
                cfg.CreateMap<UpdateTransportViewModel, tblIndexTransport>();
                cfg.CreateMap<AddTransportViewModel, tblIndexTransport>();

                cfg.CreateMap<tblIndexObject, ObjectViewModel>();
                cfg.CreateMap<UpdateObjectViewModel, tblIndexObject>();
                cfg.CreateMap<CreateObjectViewModel, tblIndexObject>();
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
            //register form
            var assembly = Assembly.GetExecutingAssembly();
            builder.RegisterAssemblyTypes(assembly)
                .Where(type => type.IsSubclassOf(typeof(Form))).InstancePerMatchingLifetimeScope("FormScope");

            var container = builder.Build();
            return container;
        }
    }
}
