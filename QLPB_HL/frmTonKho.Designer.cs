namespace QLPB_HL
{
    partial class frmTonKho
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
            this.panel_tonkho = new System.Windows.Forms.TableLayoutPanel();
            this.panel_title = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.comboBox_loaihang = new System.Windows.Forms.ComboBox();
            this.comboBox_kho = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label_perior = new System.Windows.Forms.Label();
            this.label_title = new System.Windows.Forms.Label();
            this.dataGridView_ton = new System.Windows.Forms.DataGridView();
            this.panel1 = new System.Windows.Forms.Panel();
            this.TotalAmount = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.panel_tonkho.SuspendLayout();
            this.panel_title.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_ton)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel_tonkho
            // 
            this.panel_tonkho.ColumnCount = 2;
            this.panel_tonkho.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 70F));
            this.panel_tonkho.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 30F));
            this.panel_tonkho.Controls.Add(this.panel_title, 0, 0);
            this.panel_tonkho.Controls.Add(this.dataGridView_ton, 0, 1);
            this.panel_tonkho.Controls.Add(this.panel1, 0, 2);
            this.panel_tonkho.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel_tonkho.Location = new System.Drawing.Point(0, 0);
            this.panel_tonkho.Name = "panel_tonkho";
            this.panel_tonkho.RowCount = 3;
            this.panel_tonkho.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 11.22995F));
            this.panel_tonkho.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 88.77005F));
            this.panel_tonkho.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 38F));
            this.panel_tonkho.Size = new System.Drawing.Size(784, 561);
            this.panel_tonkho.TabIndex = 0;
            // 
            // panel_title
            // 
            this.panel_title.AutoSize = true;
            this.panel_title.Controls.Add(this.label2);
            this.panel_title.Controls.Add(this.comboBox_loaihang);
            this.panel_title.Controls.Add(this.comboBox_kho);
            this.panel_title.Controls.Add(this.label1);
            this.panel_title.Controls.Add(this.label_perior);
            this.panel_title.Controls.Add(this.label_title);
            this.panel_title.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel_title.Location = new System.Drawing.Point(3, 3);
            this.panel_title.Name = "panel_title";
            this.panel_title.Size = new System.Drawing.Size(542, 52);
            this.panel_title.TabIndex = 0;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(291, 33);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(54, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "Loại hàng";
            // 
            // comboBox_loaihang
            // 
            this.comboBox_loaihang.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.comboBox_loaihang.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox_loaihang.FormattingEnabled = true;
            this.comboBox_loaihang.Location = new System.Drawing.Point(351, 30);
            this.comboBox_loaihang.Name = "comboBox_loaihang";
            this.comboBox_loaihang.Size = new System.Drawing.Size(188, 21);
            this.comboBox_loaihang.TabIndex = 6;
            // 
            // comboBox_kho
            // 
            this.comboBox_kho.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.comboBox_kho.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox_kho.FormattingEnabled = true;
            this.comboBox_kho.Location = new System.Drawing.Point(41, 30);
            this.comboBox_kho.Name = "comboBox_kho";
            this.comboBox_kho.Size = new System.Drawing.Size(174, 21);
            this.comboBox_kho.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(26, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Kho";
            // 
            // label_perior
            // 
            this.label_perior.AutoSize = true;
            this.label_perior.Location = new System.Drawing.Point(50, 6);
            this.label_perior.Name = "label_perior";
            this.label_perior.Size = new System.Drawing.Size(35, 13);
            this.label_perior.TabIndex = 3;
            this.label_perior.Text = "label2";
            // 
            // label_title
            // 
            this.label_title.AutoSize = true;
            this.label_title.Location = new System.Drawing.Point(9, 6);
            this.label_title.Name = "label_title";
            this.label_title.Size = new System.Drawing.Size(35, 13);
            this.label_title.TabIndex = 2;
            this.label_title.Text = "label1";
            // 
            // dataGridView_ton
            // 
            this.dataGridView_ton.AllowUserToDeleteRows = false;
            this.dataGridView_ton.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_ton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView_ton.Location = new System.Drawing.Point(3, 61);
            this.dataGridView_ton.Name = "dataGridView_ton";
            this.dataGridView_ton.Size = new System.Drawing.Size(542, 458);
            this.dataGridView_ton.TabIndex = 1;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.TotalAmount);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(3, 525);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(542, 33);
            this.panel1.TabIndex = 2;
            // 
            // TotalAmount
            // 
            this.TotalAmount.AutoSize = true;
            this.TotalAmount.Location = new System.Drawing.Point(409, 0);
            this.TotalAmount.Name = "TotalAmount";
            this.TotalAmount.Size = new System.Drawing.Size(0, 13);
            this.TotalAmount.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(348, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(55, 13);
            this.label3.TabIndex = 0;
            this.label3.Text = "Cộng tiền:";
            // 
            // frmTonKho
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 561);
            this.Controls.Add(this.panel_tonkho);
            this.Name = "frmTonKho";
            this.Text = "frmTonKho";
            this.Load += new System.EventHandler(this.frmTonKho_Load);
            this.panel_tonkho.ResumeLayout(false);
            this.panel_tonkho.PerformLayout();
            this.panel_title.ResumeLayout(false);
            this.panel_title.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_ton)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel panel_tonkho;
        private System.Windows.Forms.Panel panel_title;
        private System.Windows.Forms.DataGridView dataGridView_ton;
        private System.Windows.Forms.Label label_perior;
        private System.Windows.Forms.Label label_title;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox comboBox_kho;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox comboBox_loaihang;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label TotalAmount;
        private System.Windows.Forms.Label label3;
    }
}