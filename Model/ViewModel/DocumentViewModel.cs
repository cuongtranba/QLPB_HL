using System;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using Model.Helper;
using System.Windows.Forms;

namespace Model.ViewModel
{
     
   public  class DocumentViewModel
    {
        [HiddenColumn]
        public string KeyAutoId { get; set; }

        [HiddenColumn]
        public string BranchID { get; set; }

        [HiddenColumn]
        public string Period { get; set; }

        [DisplayName("Khóa")]
        public bool isLock { get; set; }

        [DisplayName("Số")]
        public string DocumentID { get; set; }

        [DisplayName("Ngày")]
        [DateTimeFormat("dd/MM/yyyy")]
        public DateTime DocumentDate { get; set; }

        [HiddenColumn]
        public string ReasonID { get; set; }

        [DisplayName("Lý do NX")]
        public string ReasonDesc { get; set; }

        [DisplayName("Diễn giải")]
        public string DocumentDesc { get; set; }

        [HiddenColumn]
        public string TransportID { get; set; }

        [DisplayName("Phương tiện")]
        public string TransName { get; set; }

        [HiddenColumn]
        public double? Distance { get; set; }

        [DisplayName("Số HĐ")]
        public string ContractNo { get; set; }

        [DisplayName("Ngày HĐ")]
        [DateTimeFormat("dd/MM/yyyy")]
        public DateTime? ContractDate { get; set; }

        [HiddenColumn]
        public string TaxGroup { get; set; }

        [DisplayName("HTTT")]
        public string PayMethod { get; set; }

        [HiddenColumn]
        public string PersonName { get; set; }

        [HiddenColumn]
        public string ObjectId { get; set; }

        [DisplayName("Đối tượng")]
        public string ObjectName { get; set; }

        [DisplayName("Loại tiền")]
        public string CurrencyID { get; set; }

        [DisplayName("Tỷ giá VNĐ")]
        public double? CurrencyExRateVND { get; set; }

        [DisplayName("Tỷ giá USD")]
        public double? CurrencyExRateUSD { get; set; }

        [HiddenColumn]
        public string StockID { get; set; }

        [DisplayName("Kho")]
        public string StockName { get; set; }

        [HiddenColumn]
        public string LoaderID { get; set; }

        [DisplayName("Đội BX")]
        public string LoaderName { get; set; }

        [DisplayName("Giá BX")]
        [NumberFormat("N0")]
        [AlignCell(DataGridViewContentAlignment.MiddleRight)]
        public double? LoaderPrice { get; set; }

        [HiddenColumn]
        public double? TaxRate { get; set; }

        [DisplayName("Tổng cộng")]
        [NumberFormat("N0")]
        [AlignCell(DataGridViewContentAlignment.MiddleRight)]
        public double? TotalAmount { get; set; }

        [HiddenColumn]
        public double? TotalAmountVND { get; set; }

        [HiddenColumn]
        public double? TotalAmountUSD { get; set; }

        [HiddenColumn]
        public double? VATable { get; set; }

        [HiddenColumn]
        public double? VATableVND { get; set; }

        [HiddenColumn]
        public double? VATableUSD { get; set; }

        [HiddenColumn]
        public double? VATAmount { get; set; }

        [HiddenColumn]
        public double? VATAmountVND { get; set; }

        [HiddenColumn]
        public double? VATAmountUSD { get; set; }

        [DisplayName("Tổng tiền")]
        [NumberFormat("N0")]
        [AlignCell(DataGridViewContentAlignment.MiddleRight)]
        public double? TotalMoney { get; set; }

        [HiddenColumn]
        public double? TotalMoneyVND { get; set; }

        [HiddenColumn]
        public double? TotalMoneyUSD { get; set; }

        [DisplayName("Bằng chữ")]
        public string InWords { get; set; }

        [HiddenColumn]
        public string InWordsVND { get; set; }

        [HiddenColumn]
        public string InWordsUSD { get; set; }

        [DisplayName("Ghi chú")]
        public string Note { get; set; }
    }
}
