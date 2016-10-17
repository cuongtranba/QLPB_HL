using System.Windows.Forms;
using Autofac;

namespace QLPB_HL
{
    public class FormFactory
    {
        //test1
        //test2
        //test31
        readonly ILifetimeScope scope;

        public FormFactory(ILifetimeScope scope)
        {
            this.scope = scope;
        }

        public TForm CreateForm<TForm>() where TForm : Form
        {
            var formScope = scope.BeginLifetimeScope("FormScope");
            var form = formScope.Resolve<TForm>();
            form.Closed += (s, e) => formScope.Dispose();
            return form;
        }
    }
}
