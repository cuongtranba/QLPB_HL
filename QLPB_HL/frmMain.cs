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
    public partial class frmMain : Form
    {
        string sImageAlign = "C";
        public frmMain()
        {
            InitializeComponent();
        }

        private void mnuKeToanL_Click(object sender, EventArgs e)
        {
            foreach (ToolStripItem item in mainTool.Items)
            {
                ((ToolStripButton)item).Checked = false;
            }
            ToolStripButton btn = sender as ToolStripButton;
            ShowPanel(btn.Name);
            btn.Checked = true;
        }

        private void ShowPanel(string spanel)
        {
            foreach(Control pnl in this.Controls)
            {
                try
                {
                    if(pnl.GetType().ToString().Contains("Panel"))
                    {
                        pnl.Visible = false;
                        if (pnl.Name.Contains(spanel.Substring(3)))
                            pnl.Visible = true;
                    }
                }
                catch(Exception ex)
                {
                }
            }
        }
        private void cmdImageAlign(Button cmdButton, string NameMethode, string sAlign)
        {
            if (NameMethode.Contains("MouseEnter"))
            {
                if (sAlign == "T")
                    cmdButton.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
                else if (sAlign == "C")
                    cmdButton.ImageAlign = System.Drawing.ContentAlignment.BottomRight;
            }
            else if (NameMethode.Contains("MouseLeave"))
            {
                if (sAlign == "T")
                    cmdButton.ImageAlign = System.Drawing.ContentAlignment.BottomRight;
                else if (sAlign == "C")
                    cmdButton.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            }
        }

        private void btn_MouseEnter(object sender, EventArgs e)
        {
            cmdImageAlign((Button)sender, System.Reflection.MethodBase.GetCurrentMethod().Name, sImageAlign);
        }

        private void btn_MouseLeave(object sender, EventArgs e)
        {
            cmdImageAlign((Button)sender, System.Reflection.MethodBase.GetCurrentMethod().Name, sImageAlign);
        }

        private void frmMain_Load(object sender, EventArgs e)
        {
            mnuKeToanL.PerformClick();
        }

        private void btnHH1_Click(object sender, EventArgs e)
        {
            //Phiếu nhập
        }
    }
}
