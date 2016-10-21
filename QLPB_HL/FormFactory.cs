using System.Windows.Forms;
using Autofac;

namespace QLPB_HL
{
    public static class FormFactory
    {
        public static TForm CreateForm<TForm>() where TForm : Form
        {
            var formScope = Program.Container.BeginLifetimeScope("FormScope");
            var form = formScope.Resolve<TForm>();
            form.Closed += (s, e) => formScope.Dispose();
            return form;
        }
    }
}
