using System;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using Model.Helper;

namespace Model.ViewModel
{
    public class ItemViewModel
    {
        [DisplayName("STT")]
        public Int64 Serial { get; set; }
        [HiddenColumn]
        public string KeyAutoID { get; set; }
        [DisplayName("Mã hàng")]
        public string ItemID { get; set; }
        [DisplayName("Tên Hàng")]
        public string ItemName { get; set; }
        [DisplayName("Đơn vị tính")]
        public string UnitID { get; set; }
        [DisplayName("Giá mua")]
        public decimal? BuyPrice { get; set; }
        [DisplayName("Giá bán")]
        public decimal? SalePrice { get; set; }
        [DisplayName("Ghi chú")]
        public string Note { get; set; }
        [DisplayName("Tên nhóm")]
        public string GroupName { get; set; }
        [HiddenColumn]
        public string GroupID { get; set; }
        [DisplayName("Kho")]
        public string StockDesc { get; set; }
        [HiddenColumn]
        public string StockID { get; set; }
    }
}
