using System;
using System.ComponentModel.DataAnnotations;

namespace Model.ViewModel
{
    public class UpdateLoaderViewModel
    {
        public string KeyAutoID { get; set; }
        [Required(ErrorMessage = "Thiếu mã bốc xếp")]
        public string LoaderID { get; set; }
        [Required(ErrorMessage = "Thiếu tên bốc xếp")]
        [StringLength(100)]
        public string LoaderName { get; set; }
        [StringLength(150)]
        public string Note { get; set; }
    }
}
