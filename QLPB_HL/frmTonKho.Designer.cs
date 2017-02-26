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
            this.dataGridView_ton = new System.Windows.Forms.DataGridView();
            this.panel1 = new System.Windows.Forms.Panel();
            this.TotalAmount = new System.Windows.Forms.Label();
            this.Total_label = new System.Windows.Forms.Label();
            this.panel_search = new System.Windows.Forms.TableLayoutPanel();
            this.label_title = new System.Windows.Forms.Label();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.label1 = new System.Windows.Forms.Label();
            this.StockId = new System.Windows.Forms.ComboBox();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.label2 = new System.Windows.Forms.Label();
            this.GroupID = new System.Windows.Forms.ComboBox();
            this.btn_search = new System.Windows.Forms.Button();
            this.label_date = new System.Windows.Forms.Label();
            this.colorDialog1 = new System.Windows.Forms.ColorDialog();
            this.panel_tonkho.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_ton)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel_search.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.tableLayoutPanel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel_tonkho
            // 
            this.panel_tonkho.ColumnCount = 2;
            this.panel_tonkho.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 82.52551F));
            this.panel_tonkho.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 17.47449F));
            this.panel_tonkho.Controls.Add(this.dataGridView_ton, 0, 1);
            this.panel_tonkho.Controls.Add(this.panel1, 0, 2);
            this.panel_tonkho.Controls.Add(this.panel_search, 0, 0);
            this.panel_tonkho.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel_tonkho.Location = new System.Drawing.Point(0, 0);
            this.panel_tonkho.Name = "panel_tonkho";
            this.panel_tonkho.RowCount = 3;
            this.panel_tonkho.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 18.00766F));
            this.panel_tonkho.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 81.99234F));
            this.panel_tonkho.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 38F));
            this.panel_tonkho.Size = new System.Drawing.Size(784, 561);
            this.panel_tonkho.TabIndex = 0;
            // 
            // dataGridView_ton
            // 
            this.dataGridView_ton.AllowUserToAddRows = false;
            this.dataGridView_ton.AllowUserToDeleteRows = false;
            this.dataGridView_ton.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_ton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView_ton.Location = new System.Drawing.Point(3, 97);
            this.dataGridView_ton.Name = "dataGridView_ton";
            this.dataGridView_ton.Size = new System.Drawing.Size(641, 422);
            this.dataGridView_ton.TabIndex = 1;
            this.dataGridView_ton.CellValueChanged += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView_ton_CellValueChanged);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.TotalAmount);
            this.panel1.Controls.Add(this.Total_label);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(3, 525);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(641, 33);
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
            // Total_label
            // 
            this.Total_label.AutoSize = true;
            this.Total_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Total_label.Location = new System.Drawing.Point(348, 0);
            this.Total_label.Name = "Total_label";
            this.Total_label.Size = new System.Drawing.Size(91, 20);
            this.Total_label.TabIndex = 0;
            this.Total_label.Text = "Cộng tiền:";
            // 
            // panel_search
            // 
            this.panel_search.ColumnCount = 3;
            this.panel_search.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 38.4375F));
            this.panel_search.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 43.28125F));
            this.panel_search.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 18.28125F));
            this.panel_search.Controls.Add(this.label_title, 0, 0);
            this.panel_search.Controls.Add(this.tableLayoutPanel2, 0, 1);
            this.panel_search.Controls.Add(this.tableLayoutPanel3, 1, 1);
            this.panel_search.Controls.Add(this.btn_search, 2, 1);
            this.panel_search.Controls.Add(this.label_date, 1, 0);
            this.panel_search.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel_search.Location = new System.Drawing.Point(3, 3);
            this.panel_search.Name = "panel_search";
            this.panel_search.RowCount = 2;
            this.panel_search.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.panel_search.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.panel_search.Size = new System.Drawing.Size(641, 88);
            this.panel_search.TabIndex = 3;
            // 
            // label_title
            // 
            this.label_title.AutoSize = true;
            this.label_title.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_title.Location = new System.Drawing.Point(3, 0);
            this.label_title.Name = "label_title";
            this.label_title.Size = new System.Drawing.Size(38, 22);
            this.label_title.TabIndex = 4;
            this.label_title.Text = "title";
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 2;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 21.98582F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 78.01418F));
            this.tableLayoutPanel2.Controls.Add(this.label1, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.StockId, 1, 0);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(3, 47);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 1;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 38F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(240, 38);
            this.tableLayoutPanel2.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(3, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(40, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Kho";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // StockId
            // 
            this.StockId.Dock = System.Windows.Forms.DockStyle.Fill;
            this.StockId.FormattingEnabled = true;
            this.StockId.Location = new System.Drawing.Point(55, 3);
            this.StockId.Name = "StockId";
            this.StockId.Size = new System.Drawing.Size(182, 21);
            this.StockId.TabIndex = 1;
            // 
            // tableLayoutPanel3
            // 
            this.tableLayoutPanel3.ColumnCount = 2;
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 23.58079F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 76.41921F));
            this.tableLayoutPanel3.Controls.Add(this.label2, 0, 0);
            this.tableLayoutPanel3.Controls.Add(this.GroupID, 1, 0);
            this.tableLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel3.Location = new System.Drawing.Point(249, 47);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 1;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 38F));
            this.tableLayoutPanel3.Size = new System.Drawing.Size(271, 38);
            this.tableLayoutPanel3.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(3, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(49, 38);
            this.label2.TabIndex = 0;
            this.label2.Text = "Loại hàng";
            // 
            // GroupID
            // 
            this.GroupID.Dock = System.Windows.Forms.DockStyle.Fill;
            this.GroupID.FormattingEnabled = true;
            this.GroupID.Location = new System.Drawing.Point(66, 3);
            this.GroupID.Name = "GroupID";
            this.GroupID.Size = new System.Drawing.Size(202, 21);
            this.GroupID.TabIndex = 1;
            // 
            // btn_search
            // 
            this.btn_search.Location = new System.Drawing.Point(526, 47);
            this.btn_search.Name = "btn_search";
            this.btn_search.Size = new System.Drawing.Size(75, 23);
            this.btn_search.TabIndex = 2;
            this.btn_search.Text = "Tìm";
            this.btn_search.UseVisualStyleBackColor = true;
            this.btn_search.Click += new System.EventHandler(this.btn_search_Click);
            // 
            // label_date
            // 
            this.label_date.AutoSize = true;
            this.label_date.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_date.Location = new System.Drawing.Point(249, 0);
            this.label_date.Name = "label_date";
            this.label_date.Size = new System.Drawing.Size(45, 22);
            this.label_date.TabIndex = 3;
            this.label_date.Text = "date";
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
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_ton)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel_search.ResumeLayout(false);
            this.panel_search.PerformLayout();
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
            this.tableLayoutPanel3.ResumeLayout(false);
            this.tableLayoutPanel3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel panel_tonkho;
        private System.Windows.Forms.DataGridView dataGridView_ton;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label TotalAmount;
        private System.Windows.Forms.Label Total_label;
        private System.Windows.Forms.TableLayoutPanel panel_search;
        private System.Windows.Forms.ColorDialog colorDialog1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox StockId;
        private System.Windows.Forms.ComboBox GroupID;
        private System.Windows.Forms.Label label_title;
        private System.Windows.Forms.Button btn_search;
        private System.Windows.Forms.Label label_date;
    }
}