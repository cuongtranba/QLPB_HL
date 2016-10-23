namespace QLPB_HL
{
    partial class frmDanhMuc
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
            this.panel_category = new System.Windows.Forms.TableLayoutPanel();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.panel_CRUD = new System.Windows.Forms.TableLayoutPanel();
            this.panel_CRUD_button = new System.Windows.Forms.Panel();
            this.btn_crud_refresh = new System.Windows.Forms.Button();
            this.btn_update = new System.Windows.Forms.Button();
            this.btn_delete = new System.Windows.Forms.Button();
            this.btn_create = new System.Windows.Forms.Button();
            this.panel_crud_component = new System.Windows.Forms.TableLayoutPanel();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.panel_search = new System.Windows.Forms.TableLayoutPanel();
            this.panel_search_component = new System.Windows.Forms.Panel();
            this.btn_search = new System.Windows.Forms.Button();
            this.panel_search_textbox = new System.Windows.Forms.TableLayoutPanel();
            this.DanhMucGridView = new System.Windows.Forms.DataGridView();
            this.panel_category.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.panel_CRUD.SuspendLayout();
            this.panel_CRUD_button.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.panel_search.SuspendLayout();
            this.panel_search_component.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DanhMucGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // panel_category
            // 
            this.panel_category.AutoSize = true;
            this.panel_category.ColumnCount = 2;
            this.panel_category.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.panel_category.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.panel_category.Controls.Add(this.groupBox2, 1, 1);
            this.panel_category.Controls.Add(this.groupBox1, 1, 0);
            this.panel_category.Controls.Add(this.DanhMucGridView, 0, 0);
            this.panel_category.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel_category.Location = new System.Drawing.Point(0, 0);
            this.panel_category.Name = "panel_category";
            this.panel_category.RowCount = 2;
            this.panel_category.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.panel_category.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.panel_category.Size = new System.Drawing.Size(942, 710);
            this.panel_category.TabIndex = 0;
            // 
            // groupBox2
            // 
            this.groupBox2.AutoSize = true;
            this.groupBox2.Controls.Add(this.panel_CRUD);
            this.groupBox2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox2.Location = new System.Drawing.Point(474, 66);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(465, 641);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Quản lý";
            // 
            // panel_CRUD
            // 
            this.panel_CRUD.AutoSize = true;
            this.panel_CRUD.ColumnCount = 2;
            this.panel_CRUD.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20.26144F));
            this.panel_CRUD.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 79.73856F));
            this.panel_CRUD.Controls.Add(this.panel_CRUD_button, 0, 1);
            this.panel_CRUD.Controls.Add(this.panel_crud_component, 0, 0);
            this.panel_CRUD.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel_CRUD.Location = new System.Drawing.Point(3, 16);
            this.panel_CRUD.Name = "panel_CRUD";
            this.panel_CRUD.RowCount = 2;
            this.panel_CRUD.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.panel_CRUD.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.panel_CRUD.Size = new System.Drawing.Size(459, 622);
            this.panel_CRUD.TabIndex = 0;
            // 
            // panel_CRUD_button
            // 
            this.panel_CRUD_button.AutoSize = true;
            this.panel_CRUD.SetColumnSpan(this.panel_CRUD_button, 2);
            this.panel_CRUD_button.Controls.Add(this.btn_crud_refresh);
            this.panel_CRUD_button.Controls.Add(this.btn_update);
            this.panel_CRUD_button.Controls.Add(this.btn_delete);
            this.panel_CRUD_button.Controls.Add(this.btn_create);
            this.panel_CRUD_button.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel_CRUD_button.Location = new System.Drawing.Point(3, 9);
            this.panel_CRUD_button.Name = "panel_CRUD_button";
            this.panel_CRUD_button.Size = new System.Drawing.Size(453, 610);
            this.panel_CRUD_button.TabIndex = 0;
            // 
            // btn_crud_refresh
            // 
            this.btn_crud_refresh.Location = new System.Drawing.Point(246, 3);
            this.btn_crud_refresh.Name = "btn_crud_refresh";
            this.btn_crud_refresh.Size = new System.Drawing.Size(75, 23);
            this.btn_crud_refresh.TabIndex = 3;
            this.btn_crud_refresh.Text = "làm mới";
            this.btn_crud_refresh.UseVisualStyleBackColor = true;
            this.btn_crud_refresh.Click += new System.EventHandler(this.btn_crud_refresh_Click);
            // 
            // btn_update
            // 
            this.btn_update.Location = new System.Drawing.Point(165, 3);
            this.btn_update.Name = "btn_update";
            this.btn_update.Size = new System.Drawing.Size(75, 23);
            this.btn_update.TabIndex = 2;
            this.btn_update.Text = "Sửa";
            this.btn_update.UseVisualStyleBackColor = true;
            this.btn_update.Click += new System.EventHandler(this.btn_update_Click);
            // 
            // btn_delete
            // 
            this.btn_delete.Location = new System.Drawing.Point(84, 3);
            this.btn_delete.Name = "btn_delete";
            this.btn_delete.Size = new System.Drawing.Size(75, 23);
            this.btn_delete.TabIndex = 1;
            this.btn_delete.Text = "Xóa";
            this.btn_delete.UseVisualStyleBackColor = true;
            this.btn_delete.Click += new System.EventHandler(this.btn_delete_Click);
            // 
            // btn_create
            // 
            this.btn_create.Location = new System.Drawing.Point(3, 3);
            this.btn_create.Name = "btn_create";
            this.btn_create.Size = new System.Drawing.Size(75, 23);
            this.btn_create.TabIndex = 0;
            this.btn_create.Text = "Thêm";
            this.btn_create.UseVisualStyleBackColor = true;
            this.btn_create.Click += new System.EventHandler(this.btn_create_Click);
            // 
            // panel_crud_component
            // 
            this.panel_crud_component.AutoSize = true;
            this.panel_crud_component.ColumnCount = 2;
            this.panel_CRUD.SetColumnSpan(this.panel_crud_component, 2);
            this.panel_crud_component.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.panel_crud_component.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.panel_crud_component.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel_crud_component.Location = new System.Drawing.Point(3, 3);
            this.panel_crud_component.Name = "panel_crud_component";
            this.panel_crud_component.RowCount = 2;
            this.panel_crud_component.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.panel_crud_component.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.panel_crud_component.Size = new System.Drawing.Size(453, 1);
            this.panel_crud_component.TabIndex = 1;
            // 
            // groupBox1
            // 
            this.groupBox1.AutoSize = true;
            this.groupBox1.Controls.Add(this.panel_search);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox1.Location = new System.Drawing.Point(474, 3);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(465, 57);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Tìm kiếm";
            // 
            // panel_search
            // 
            this.panel_search.AutoSize = true;
            this.panel_search.ColumnCount = 2;
            this.panel_search.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.panel_search.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.panel_search.Controls.Add(this.panel_search_component, 1, 1);
            this.panel_search.Controls.Add(this.panel_search_textbox, 0, 0);
            this.panel_search.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel_search.Location = new System.Drawing.Point(3, 16);
            this.panel_search.Name = "panel_search";
            this.panel_search.RowCount = 2;
            this.panel_search.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.panel_search.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.panel_search.Size = new System.Drawing.Size(459, 38);
            this.panel_search.TabIndex = 0;
            // 
            // panel_search_component
            // 
            this.panel_search_component.AutoSize = true;
            this.panel_search_component.Controls.Add(this.btn_search);
            this.panel_search_component.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel_search_component.Location = new System.Drawing.Point(3, 9);
            this.panel_search_component.Name = "panel_search_component";
            this.panel_search_component.Size = new System.Drawing.Size(453, 26);
            this.panel_search_component.TabIndex = 0;
            // 
            // btn_search
            // 
            this.btn_search.Location = new System.Drawing.Point(0, 0);
            this.btn_search.Name = "btn_search";
            this.btn_search.Size = new System.Drawing.Size(75, 23);
            this.btn_search.TabIndex = 0;
            this.btn_search.Text = "Tìm kiếm";
            this.btn_search.UseVisualStyleBackColor = true;
            this.btn_search.Click += new System.EventHandler(this.btn_search_Click);
            // 
            // panel_search_textbox
            // 
            this.panel_search_textbox.AutoSize = true;
            this.panel_search_textbox.ColumnCount = 2;
            this.panel_search.SetColumnSpan(this.panel_search_textbox, 2);
            this.panel_search_textbox.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.panel_search_textbox.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.panel_search_textbox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel_search_textbox.Location = new System.Drawing.Point(3, 3);
            this.panel_search_textbox.Name = "panel_search_textbox";
            this.panel_search_textbox.RowCount = 1;
            this.panel_search_textbox.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.panel_search_textbox.Size = new System.Drawing.Size(453, 1);
            this.panel_search_textbox.TabIndex = 1;
            // 
            // DanhMucGridView
            // 
            this.DanhMucGridView.AllowUserToAddRows = false;
            this.DanhMucGridView.AllowUserToDeleteRows = false;
            this.DanhMucGridView.AllowUserToOrderColumns = true;
            this.DanhMucGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.DanhMucGridView.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.DanhMucGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DanhMucGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.DanhMucGridView.Location = new System.Drawing.Point(3, 3);
            this.DanhMucGridView.Name = "DanhMucGridView";
            this.DanhMucGridView.ReadOnly = true;
            this.panel_category.SetRowSpan(this.DanhMucGridView, 2);
            this.DanhMucGridView.Size = new System.Drawing.Size(465, 704);
            this.DanhMucGridView.TabIndex = 2;
            // 
            // frmDanhMuc
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(942, 710);
            this.Controls.Add(this.panel_category);
            this.Name = "frmDanhMuc";
            this.Text = "frmDanhMuc";
            this.Load += new System.EventHandler(this.frmDanhMuc_Load);
            this.panel_category.ResumeLayout(false);
            this.panel_category.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.panel_CRUD.ResumeLayout(false);
            this.panel_CRUD.PerformLayout();
            this.panel_CRUD_button.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.panel_search.ResumeLayout(false);
            this.panel_search.PerformLayout();
            this.panel_search_component.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.DanhMucGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel panel_category;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TableLayoutPanel panel_search;
        private System.Windows.Forms.TableLayoutPanel panel_CRUD;
        private System.Windows.Forms.Panel panel_search_component;
        private System.Windows.Forms.Button btn_search;
        private System.Windows.Forms.TableLayoutPanel panel_search_textbox;
        private System.Windows.Forms.DataGridView DanhMucGridView;
        private System.Windows.Forms.Panel panel_CRUD_button;
        private System.Windows.Forms.Button btn_crud_refresh;
        private System.Windows.Forms.Button btn_update;
        private System.Windows.Forms.Button btn_delete;
        private System.Windows.Forms.Button btn_create;
        private System.Windows.Forms.TableLayoutPanel panel_crud_component;
    }
}