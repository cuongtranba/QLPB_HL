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
            var f = FormFactory.CreateForm<frmMain>();
            f.MdiParent = Global.clsVar.fMain;
            //f.ClientSize = new System.Drawing.Size(iWidth, iHeight);
            f.Dock = DockStyle.Fill;
            f.Show();
            f.BringToFront();
        }
    }
}
