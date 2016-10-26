using System;
using System.ComponentModel;
using System.Linq;
using System.Windows.Forms;
using Autofac;
using Model.ViewModel;
using Service.Interfaces;
using _4.Helper;

namespace QLPB_HL
{
    public partial class frmDanhMuc : Form
    {
        private ICategoryService categoryService;
        public frmDanhMuc()
        {
            InitializeComponent();
        }

        private void frmDanhMuc_Load(object sender, System.EventArgs e)
        {
            categoryService = IOCFactory.Do(container => container.ResolveNamed<ICategoryService>(this.Text));
            DanhMucGridView.DataSource = categoryService.GetDataSource(); 
            categoryService.HiddentColumns(DanhMucGridView);
            DanhMucGridView.AutoResizeColumns(DataGridViewAutoSizeColumnsMode.AllCells);

            for (int i = 0; i < categoryService.GetSearchComponent.Count; i++)
            {
                this.panel_search_textbox.Controls.Add(categoryService.GetSearchComponent[i].Label, 0, i);
                this.panel_search_textbox.Controls.Add(categoryService.GetSearchComponent[i].Control, 1, i);
            }
            for (int i = 0; i < categoryService.GetCRUDComponent.Count; i++)
            {
                this.panel_crud_component.Controls.Add(categoryService.GetCRUDComponent[i].Label, 0, i);
                this.panel_crud_component.Controls.Add(categoryService.GetCRUDComponent[i].Control, 1, i);
            }
        }

        private void btn_search_Click(object sender, System.EventArgs e)
        {
            DanhMucGridView.DataSource = categoryService.Search(this.panel_search_textbox.Controls);
        }

        private void btn_create_Click(object sender, System.EventArgs e)
        {
            var result = categoryService.Create(this.panel_crud_component.Controls);
            if (!result.IsValid)
            {
                ControlExtention.ShowErrorField(result);
            }
            else
            {
                MessageBox.Show("Thêm thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                panel_crud_component.Controls.ClearValue();
                DanhMucGridView.DataSource = categoryService.GetDataSource();
            }
        }

        private void btn_delete_Click(object sender, System.EventArgs e)
        {
            if (DanhMucGridView.CurrentRow != null)
            {
                var result = MessageBox.Show("Bạn có chắc không?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (result == DialogResult.Yes)
                {
                    categoryService.Delete(DanhMucGridView.CurrentRow.DataBoundItem);
                    DanhMucGridView.DataSource = categoryService.GetDataSource();
                }
            }
        }

        private void btn_update_Click(object sender, System.EventArgs e)
        {
            if (DanhMucGridView.CurrentRow != null)
            {
                DanhMucGridView.CurrentRow.DataBoundItem.ToControl(panel_crud_component.Controls);
            }
        }

        private void btn_crud_refresh_Click(object sender, System.EventArgs e)
        {
            panel_crud_component.Controls.ClearValue();
        }
    }
}
