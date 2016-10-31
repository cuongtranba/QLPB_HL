using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QLPB_HL
{
    public partial class frmMidi : Form
    {
        public frmMidi()
        {
            InitializeComponent();
        }

        private void frmMidi_Load(object sender, EventArgs e)
        {
            var mainForm = FormFactory.CreateForm<frmMain>();
            mainForm.MdiParent = Global.clsVar.fMain;
            //f.ClientSize = new System.Drawing.Size(iWidth, iHeight);
            mainForm.Dock = DockStyle.Fill;
            mainForm.Show();
            mainForm.BringToFront();
            Program.DeactivePanel();
        }
    }
}
