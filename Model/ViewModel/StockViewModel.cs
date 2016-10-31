using System.ComponentModel;
using Model.Helper;

namespace Model.ViewModel
{
    public class StockViewModel
    {
        [HiddenColumn]
        public string KeyAutoID { get; set; }
        [DisplayName("Mã kho")]
        public string StockID { get; set; }
        [DisplayName("Tên kho")]
        public string StockDesc { get; set; }
        [HiddenColumn]
        public string StockAcc { get; set; }
        [HiddenColumn]
        public string StockOutAcc { get; set; }
        [HiddenColumn]
        public int CountImportDoc { get; set; }
        [HiddenColumn]
        public int CountExportDoc { get; set; }
        [DisplayName("Ghi chú")]
        public string Note { get; set; }
        [HiddenColumn]
        public bool isFull { get; set; }
        [HiddenColumn]
        public int StockAvailable { get; set; }
        [DisplayName("Đơn vị tính")]
        public string UnitID { get; set; }
        [DisplayName("Tài khoản kho")]
        public string StockAccName{ get; set; }
        [DisplayName("Tài khoản xuất kho")]
        public string StockOutAccName { get; set; }
    }
}
