﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Service.Interfaces;
using Model.ViewModel;
using _4.Helper;
namespace QLPB_HL
{
    public partial class frmDocument : Form
    {
        private string sDocumentType = "PN";
        public string sDocumentCode = "001";
        private string sPeriod = "";
        private IDocumentService documentService;
        public frmDocument(IDocumentService DocumentService)
        {
            InitializeComponent();
            sPeriod = Global.clsVar.sCurrentPeriod;
            this.documentService = DocumentService;
            if (sDocumentCode == "002")
                sDocumentType = "PX";
            else
            {
                tabControl1.TabPages.Remove(tabPage3);
            }
        }

        private void frmDocument_Load(object sender, EventArgs e)
        {
            this.dtpFrom.Value = DateTimeExtentions.FirstDayOfPeriod(sPeriod);
            this.dtpTo.Value = DateTimeExtentions.LastDayOfPeriod(sPeriod);
            LoadData();
            if (this.tabControl1.SelectedTab != this.tabPage2)
                this.tabControl1.SelectedTab = this.tabPage2;
        }

        private void btnLoadData_Click(object sender, EventArgs e)
        {
            LoadData();
        }

        private void LoadData()
        {
            var bindingSource = new BindingSource
            {
                DataSource = documentService.getDocuments(dtpFrom.Value, dtpTo.Value, sDocumentCode)
            };
            dgvBangKe.DataSource = bindingSource;
            dgvBangKe = dgvBangKe.HiddentColumns<DocumentViewModel>();
            dgvBangKe = dgvBangKe.FormatDateTime<DocumentViewModel>();
            dgvBangKe = dgvBangKe.FormatNumber<DocumentViewModel>();
            dgvBangKe = dgvBangKe.ColumnContentAlign<DocumentViewModel>();
            dgvBangKe.AutoResizeColumns(DataGridViewAutoSizeColumnsMode.AllCells);
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {

        }
    }
}
