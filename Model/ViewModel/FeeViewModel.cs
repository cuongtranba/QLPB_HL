using System;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using Model.Helper;

namespace Model.ViewModel
{
    public class FeeViewModel
    {
        [DisplayName("STT")]
        public int Serial { get; set; }
        [HiddenColumn]
        public string KeyAutoID { get; set; }
        [DisplayName("Mã chi phí")]
        public string FeeID { get; set; }
        [HiddenColumn]
        public string FeeGroupID { get; set; }
        [DisplayName("Tên chi phí")]
        public string FeeDesc { get; set; }
        [DisplayName("Tên nhóm")]
        public string GroupName { get; set; }
        [DisplayName("Ghi chú")]
        public string Note { get; set; }
    }

    public class UpdateFeeViewModel
    {
        public string KeyAutoID { get; set; }
        [Required(ErrorMessage = "Thiếu mã chi phí")]
        [StringLength(15)]
        public string FeeID { get; set; }
        [Required(ErrorMessage = "Thiếu tên nhóm")]
        public string FeeGroupID { get; set; }
        [Required(ErrorMessage = "Thiếu tên chi phí")]
        [StringLength(150)]
        public string FeeDesc { get; set; }
        [StringLength(150)]
        public string Note { get; set; }
    }

    public class CreateFeeViewModel
    {
        public string KeyAutoID => Guid.NewGuid().ToString();
        [Required(ErrorMessage = "Thiếu mã chi phí")]
        [StringLength(15)]
        public string FeeID { get; set; }
        [Required(ErrorMessage = "Thiếu tên nhóm")]
        public string FeeGroupID { get; set; }
        [Required(ErrorMessage = "Thiếu tên chi phí")]
        [StringLength(150)]
        public string FeeDesc { get; set; }
        [StringLength(150)]
        public string Note { get; set; }
    }

    public class SearchFeeViewModel
    {
        public string FeeDesc { get; set; }
        public string FeeGroupID { get; set; }
    }
}
