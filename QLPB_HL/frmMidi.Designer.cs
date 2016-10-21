namespace QLPB_HL
{
    partial class frmMidi
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.mnuDanhMuc = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuHangHoa = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuTaiSan = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuGiaThanh = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuKeToan = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuVonTien = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuCongNo = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuBaoCao = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuHeThong = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // statusStrip1
            // 
            this.statusStrip1.Location = new System.Drawing.Point(0, 454);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(1150, 22);
            this.statusStrip1.TabIndex = 1;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuDanhMuc,
            this.mnuHangHoa,
            this.mnuTaiSan,
            this.mnuGiaThanh,
            this.mnuKeToan,
            this.mnuVonTien,
            this.mnuCongNo,
            this.mnuBaoCao,
            this.mnuHeThong});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1150, 24);
            this.menuStrip1.TabIndex = 2;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // mnuDanhMuc
            // 
            this.mnuDanhMuc.Name = "mnuDanhMuc";
            this.mnuDanhMuc.Size = new System.Drawing.Size(74, 20);
            this.mnuDanhMuc.Text = "Danh mục";
            // 
            // mnuHangHoa
            // 
            this.mnuHangHoa.Name = "mnuHangHoa";
            this.mnuHangHoa.Size = new System.Drawing.Size(71, 20);
            this.mnuHangHoa.Text = "Hàng hóa";
            // 
            // mnuTaiSan
            // 
            this.mnuTaiSan.Name = "mnuTaiSan";
            this.mnuTaiSan.Size = new System.Drawing.Size(55, 20);
            this.mnuTaiSan.Text = "Tài sản";
            // 
            // mnuGiaThanh
            // 
            this.mnuGiaThanh.Name = "mnuGiaThanh";
            this.mnuGiaThanh.Size = new System.Drawing.Size(70, 20);
            this.mnuGiaThanh.Text = "Giá thành";
            // 
            // mnuKeToan
            // 
            this.mnuKeToan.Name = "mnuKeToan";
            this.mnuKeToan.Size = new System.Drawing.Size(59, 20);
            this.mnuKeToan.Text = "Kế toán";
            // 
            // mnuVonTien
            // 
            this.mnuVonTien.Name = "mnuVonTien";
            this.mnuVonTien.Size = new System.Drawing.Size(63, 20);
            this.mnuVonTien.Text = "Vốn tiền";
            // 
            // mnuCongNo
            // 
            this.mnuCongNo.Name = "mnuCongNo";
            this.mnuCongNo.Size = new System.Drawing.Size(65, 20);
            this.mnuCongNo.Text = "Công nợ";
            // 
            // mnuBaoCao
            // 
            this.mnuBaoCao.Name = "mnuBaoCao";
            this.mnuBaoCao.Size = new System.Drawing.Size(61, 20);
            this.mnuBaoCao.Text = "Báo cáo";
            // 
            // mnuHeThong
            // 
            this.mnuHeThong.Name = "mnuHeThong";
            this.mnuHeThong.Size = new System.Drawing.Size(69, 20);
            this.mnuHeThong.Text = "Hệ thống";
            // 
            // toolStrip1
            // 
            this.toolStrip1.Location = new System.Drawing.Point(0, 24);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(1150, 25);
            this.toolStrip1.TabIndex = 3;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // frmMidi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1150, 476);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.menuStrip1);
            this.IsMdiContainer = true;
            this.KeyPreview = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "frmMidi";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Nhà máy sản xuất phân bón Hồng Liên";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frmMidi_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripMenuItem mnuDanhMuc;
        private System.Windows.Forms.ToolStripMenuItem mnuHangHoa;
        private System.Windows.Forms.ToolStripMenuItem mnuTaiSan;
        private System.Windows.Forms.ToolStripMenuItem mnuGiaThanh;
        private System.Windows.Forms.ToolStripMenuItem mnuKeToan;
        private System.Windows.Forms.ToolStripMenuItem mnuVonTien;
        private System.Windows.Forms.ToolStripMenuItem mnuCongNo;
        private System.Windows.Forms.ToolStripMenuItem mnuBaoCao;
        private System.Windows.Forms.ToolStripMenuItem mnuHeThong;
    }
}