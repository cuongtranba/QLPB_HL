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

            var bindingSource = new BindingSource
            {
                DataSource = categoryService.GetDataSource()
            };
            DanhMucGridView.DataSource = bindingSource;
            DanhMucGridView = DanhMucGridView.HiddentColumns<ItemViewModel>();
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
            categoryService.Create(this.panel_crud_component.Controls);
        }

        private void btn_delete_Click(object sender, System.EventArgs e)
        {

        }

        private void btn_update_Click(object sender, System.EventArgs e)
        {

        }

        private void btn_crud_refresh_Click(object sender, System.EventArgs e)
        {

        }
    }
}
