using System;
using System.ComponentModel.DataAnnotations;

namespace Model.ViewModel
{
    public class AddItemViewModel
    {
        public string KeyAutoID { get; set; }
        public AddItemViewModel()
        {
            KeyAutoID = Guid.NewGuid().ToString();
        }
        [Required(ErrorMessage = "Thiếu mã hàng")]
        public string ItemID { get; set; }
        [Required(ErrorMessage = "Thiếu tên hàng")]
        public string ItemName { get; set; }
        [Required(ErrorMessage = "Thiếu đơn vị")]
        public string UnitID { get; set; }
        [Required(ErrorMessage = "Thiếu tên kho")]
        public string StockID { get; set; }
        [Required(ErrorMessage = "Thiếu tên nhóm")]
        public string GroupID { get; set; }
        [Required(ErrorMessage = "Thiếu tiền mua")]
        public decimal BuyPrice { get; set; }
        [Required(ErrorMessage = "Thiếu tiền bán")]
        public decimal SalePrice { get; set; }
        public string Note { get; set; }
    }
}
