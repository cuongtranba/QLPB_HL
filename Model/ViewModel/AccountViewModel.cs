using System;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using Model.Helper;

namespace Model.ViewModel
{
    public class AccountViewModel
    {
        [DisplayName("STT")]
        public int Serial { get; set; }
        [HiddenColumn]
        public string KeyAutoID { get; set; }
        [DisplayName("Mã tài khoản")]
        public string AccountID { get; set; }
        [DisplayName("Tên tài khoản")]
        public string AccountDesc { get; set; }
        [DisplayName("Ghi chú")]
        public string Note { get; set; }
    }

    public class AddAccountViewModel
    {
        public string KeyAutoID => Guid.NewGuid().ToString();

        [StringLength(15)]
        [Required(ErrorMessage = "Thiếu mã tài khoản")]
        public string AccountID { get; set; }

        [StringLength(150)]
        [Required(ErrorMessage = "Thiếu tên tài khoản")]
        public string AccountDesc { get; set; }
        [StringLength(150)]
        public string Note { get; set; }
    }

    public class UpdateAccountViewMode
    {
        public string KeyAutoID { get; set; }
        [StringLength(15)]
        [Required(ErrorMessage = "Thiếu mã tài khoản")]
        public string AccountID { get; set; }

        [StringLength(150)]
        [Required(ErrorMessage = "Thiếu tên tài khoản")]
        public string AccountDesc { get; set; }
        [StringLength(150)]
        public string Note { get; set; }
    }

    public class SearchAccountViewModel
    {
        public string AccountDesc { get; set; }
    }
}
