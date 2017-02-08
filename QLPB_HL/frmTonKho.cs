using System;
using System.Threading.Tasks;
using System.Windows.Forms;
using Model.ViewModel;
using QLPB_HL.Global;
using Service.Interfaces;
using _4.Helper;

namespace QLPB_HL
{
    public partial class frmTonKho : Form
    {
        private ICommonService commonService;
        private IInventoryServices inventoryServices;
        public frmTonKho(ICommonService commonService, IInventoryServices inventoryServices)
        {
            this.commonService = commonService;
            this.inventoryServices = inventoryServices;
            InitializeComponent();
        }

        private async void frmTonKho_Load(object sender, EventArgs e)
        {
            this.dataGridView_ton.HiddentColumns<InventoryViewModel>();

            var itemGroup = commonService.GetItemGroup();
            var stock = commonService.GetStock();
            var items = inventoryServices.GetItems();

            await Task.WhenAll(itemGroup, stock, items);

            this.GroupID.DataSource = itemGroup.Result;
            this.StockId.DataSource = stock.Result;
            this.dataGridView_ton.DataSource = items.Result;

            label_title.Text = inventoryServices.Title;
            var date = clsVar.sCurrentPeriod.FirstDayOfPeriod();
            label_date.Text = $@"tháng {date.Month} năm {date.Year}" ;
        }

        private async void btn_search_Click(object sender, EventArgs e)
        {
            var searchViewModel=new SearchInventoryViewModel();
            this.panel_search.Controls.ToModel(searchViewModel);
            this.dataGridView_ton.DataSource = await inventoryServices.Search(searchViewModel);
        }
    }
}
