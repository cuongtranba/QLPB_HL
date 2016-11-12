using System.ComponentModel;
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
        public int Quantity { get; set; }
        [DisplayName("Đơn giá")]
        public decimal UnitPrice { get; set; }
        [DisplayName("Thành tiền")]
        public decimal Amount { get; set; }
        [HiddenColumn]
        public string GroupID { get; set; }
    }
}
