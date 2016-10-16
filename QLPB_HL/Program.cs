using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

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
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.DoEvents();

            frmLogin f = new frmLogin();
            //fSysLogin f = new fSysLogin();
            f.ShowDialog();
            if (f.DialogResult == DialogResult.OK)
            {
                Global.clsVar.fMain = new frmMidi();
                Global.clsVar.fMain.ShowDialog();
            }
        }
    }
}
