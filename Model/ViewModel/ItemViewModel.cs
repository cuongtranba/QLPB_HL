using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using _4.Helper;

namespace Model.ViewModel
{
    public class ItemViewModel
    {
        [DisplayName("Mã hàng")]
        public string ItemId { get; set; }
        [DisplayName("Tên Hàng")]
        public string ItemName { get; set; }
        [DisplayName("Đơn vị tính")]
        public string UnitID { get; set; }
        [DisplayName("Giá mua")]
        public double? BuyPrice { get; set; }
        [DisplayName("Giá bán")]
        public double? SalePrice { get; set; }
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
