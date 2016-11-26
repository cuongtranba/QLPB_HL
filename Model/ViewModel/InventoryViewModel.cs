using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using Model.Helper;

namespace Model.ViewModel
{
    public class InventoryViewModel
    {

        [HiddenColumn]
        public string ItemId { get; set; }
        [DisplayName("Mã hàng")]
        public string ItemIdDisplay { get; set; }
        [DisplayName("Tên hàng")]
        public string ItemName { get; set; }
        [DisplayName("ĐVT")]
        public string UnitId { get; set; }
        [DisplayName("Số lượng")]
        [AllowEdit]
        public int Quantity { get; set; }
        [DisplayName("Đơn giá")]
        [AllowEdit]
        public decimal UnitPrice { get; set; }
        [DisplayName("Thành tiền")]
        public decimal Amount { get; set; }
        [HiddenColumn]
        public string GroupID { get; set; }
        [DisplayName("Tên kho")]
        public string StockName { get; set; }
        [HiddenColumn]
        public string StockId { get; set; }
        [DisplayName("Tên nhóm")]
        public string GroupName { get; set; }
    }

    public class SearchInventoryViewModel
    {
        public string GroupID { get; set; }
        public string StockId { get; set; }
    }

}
