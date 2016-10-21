﻿using System;
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
        List<string> ButtonDanhMucHangHoa = new List<string>()
        {
            "Danh mục hàng hóa","Danh mục kho","Danh mục bốc xếp","Danh mục phương tiện","Danh mục khách hàng","Danh mục tài khoản","Danh mục chi phí","Lý do nhập xuất","Danh mục"
        };
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
            HandleDanhMucHangHoa(btn.Name, ButtonDanhMucHangHoa);
            btn.Checked = true;
        }

        private void HandleDanhMucHangHoa(string btnName, List<string> buttonDanhMucHangHoa)
        {
            var panel = this.Controls.OfType<Panel>().FirstOrDefault(c => c.Name.Contains(btnName.Substring(3)));
            if (panel != null)
            {
                var panelButtons = panel.Controls.OfType<Button>().ToList();
                panelButtons.ForEach(button =>
                {
                    if (buttonDanhMucHangHoa.Contains(button.Text))
                    {
                        button.Click += Button_Click;
                    }
                });
            }
        }

        private void Button_Click(object sender, EventArgs e)
        {
            Cursor.Current = Cursors.WaitCursor;
            var formDanhMuc = FormFactory.CreateForm<frmDanhMuc>();
            formDanhMuc.MdiParent = Global.clsVar.fMain;
            formDanhMuc.Text = ((Button) sender).Text;
            
            formDanhMuc.Show();
        }

        private void ShowPanel(string spanel)
        {
            foreach (Control pnl in this.Controls)
            {
                try
                {
                    if (pnl.GetType().ToString().Contains("Panel"))
                    {
                        pnl.Visible = false;
                        if (pnl.Name.Contains(spanel.Substring(3)))
                            pnl.Visible = true;
                    }
                }
                catch (Exception ex)
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
            //var frmDocument = FormFactory.CreateForm<frmDocument>();
            //frmDocument.MdiParent = Global.clsVar.fMain;
            //frmDocument.Text = ((Button)sender).Text;
            //frmDocument.Show();
        }
    }
}
