using System;
using System.Reflection;
using System.Windows.Forms;
using Autofac;
using Model;
using Service;

namespace QLPB_HL
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            var container = RegisterIOC();
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.DoEvents();
            var formFactory = new FormFactory(container);
            var loginForm = formFactory.CreateForm<frmLogin>();
            loginForm.ShowDialog();
            if (loginForm.DialogResult == DialogResult.OK)
            {
                var mainForm = formFactory.CreateForm<frmMidi>();
                Global.clsVar.fMain = mainForm;
                mainForm.ShowDialog();
            }
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
