using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Service.Interfaces;

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
    }
}
