using System;
using System.ComponentModel.DataAnnotations;

namespace Model.ViewModel
{
    public class UpdateStockViewModel
    {
        public string KeyAutoID { get; set; }
        [Required(ErrorMessage = "Thiếu mã kho")]
        [StringLength(50)]
        public string StockID { get; set; }
        [StringLength(150)]
        [Required(ErrorMessage = "Thiếu tên kho")]
        public string StockDesc { get; set; }
        [Required(ErrorMessage = "Thiếu tài khoản kho")]
        public string StockAcc { get; set; }
        [Required(ErrorMessage = "Thiếu tài khoản xuất kho")]
        public string StockOutAcc { get; set; }
        [StringLength(150)]
        public string Note { get; set; }
        [Required(ErrorMessage = "Thiếu đơn vị tính")]
        public string UnitID { get; set; }
    }
}
