using System;
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
            this.comboBox_loaihang.DataSource = await commonService.GetItemGroup();
            this.comboBox_kho.DataSource = await commonService.GetStock();
            this.dataGridView_ton.DataSource = await inventoryServices.GetItems();
            this.dataGridView_ton.HiddentColumns<InventoryViewModel>();
            label_title.Text = inventoryServices.Title;
            var date = clsVar.sCurrentPeriod.FirstDayOfPeriod();
            label_date.Text = $@"tháng {date.Month} năm {date.Year}" ;
        }
    }
}
