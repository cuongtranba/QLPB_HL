using System;
using System.ComponentModel.DataAnnotations;

namespace Model.ViewModel
{
    public class AddLoaderViewModel
    {
        public string KeyAutoID => Guid.NewGuid().ToString();
        [Required(ErrorMessage = "Thiếu mã bốc xếp")]
        public string LoaderID { get; set; }
        [Required(ErrorMessage = "Thiếu tên bốc xếp")]
        public string LoaderName { get; set; }
        [StringLength(150)]
        public string Note { get; set; }
    }
}
