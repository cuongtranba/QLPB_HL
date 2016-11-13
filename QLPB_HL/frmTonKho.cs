using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Model.ViewModel;
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
        }
    }
}
