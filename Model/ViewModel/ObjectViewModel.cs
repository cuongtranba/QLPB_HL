using System;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using Model.Helper;

namespace Model.ViewModel
{
    public class ObjectViewModel
    {
        [DisplayName("STT")]
        public int Serial { get; set; }
        [HiddenColumn]
        public string KeyAutoID { get; set; }
        [DisplayName("Mã khách hàng")]
        public string ObjectID { get; set; }
        [DisplayName("Tên khách hàng")]
        public string ObjectName { get; set; }
        [DisplayName("Tên viết tắt")]
        public string AbbName { get; set; }
        [DisplayName("Địa chỉ")]
        public string ObjectAddress { get; set; }
        [DisplayName("Số thuế")]
        public string TaxCode { get; set; }
        [DisplayName("Số ngân hàng")]
        public string BankCode { get; set; }
        [DisplayName("Điện thoại")]
        public string PhoneNum { get; set; }
        public string Email { get; set; }
        public string Website { get; set; }
        public string Fax { get; set; }
        [DisplayName("Tên người đại diện")]
        public string RepresentativeName { get; set; }
        [DisplayName("Đt người đại diện")]
        public string ReprPhone { get; set; }
        [DisplayName("Địa chỉ người đại diện")]
        public string ReprAdd { get; set; }
        [DisplayName("Email người đại diện")]
        public string ReprEmail { get; set; }
        [DisplayName("Tên giám đốc")]
        public string DirectorName { get; set; }
    }

    public class CreateObjectViewModel
    {
        public string KeyAutoID => Guid.NewGuid().ToString();
        [Required(ErrorMessage = "Thiếu mã khách hàng")]
        [StringLength(50)]
        public string ObjectID { get; set; }
        [Required(ErrorMessage = "Thiếu tên khách hàng")]
        [StringLength(150)]

        public string ObjectName { get; set; }
        [StringLength(100)]

        public string AbbName { get; set; }
        [StringLength(250)]

        public string ObjectAddress { get; set; }
        [StringLength(50)]

        public string TaxCode { get; set; }
        [StringLength(50)]

        public string BankCode { get; set; }
        [Required(ErrorMessage = "Thiếu số điện thoại")]
        [StringLength(15)]

        public string PhoneNum { get; set; }
        [StringLength(50)]

        public string Email { get; set; }
        [StringLength(50)]

        public string Website { get; set; }
        [StringLength(15)]

        public string Fax { get; set; }
        [Required(ErrorMessage = "Thiếu tên người đại diện")]
        [StringLength(15)]

        public string RepresentativeName { get; set; }
        [StringLength(15)]

        public string ReprPhone { get; set; }
        [StringLength(15)]

        public string ReprAdd { get; set; }
        [StringLength(15)]

        public string ReprEmail { get; set; }
        [Required(ErrorMessage = "thiếu tên giám đốc")]
        [StringLength(15)]

        public string DirectorName { get; set; }
    }

    public class UpdateObjectViewModel
    {
        public string KeyAutoID { get; set; }
        [Required(ErrorMessage = "Thiếu mã khách hàng")]
        [StringLength(50)]
        public string ObjectID { get; set; }
        [Required(ErrorMessage = "Thiếu tên khách hàng")]
        [StringLength(150)]

        public string ObjectName { get; set; }
        [StringLength(100)]

        public string AbbName { get; set; }
        [StringLength(250)]

        public string ObjectAddress { get; set; }
        [StringLength(50)]

        public string TaxCode { get; set; }
        [StringLength(50)]

        public string BankCode { get; set; }
        [Required(ErrorMessage = "Thiếu số điện thoại")]
        [StringLength(15)]

        public string PhoneNum { get; set; }
        [StringLength(50)]

        public string Email { get; set; }
        [StringLength(50)]

        public string Website { get; set; }
        [StringLength(15)]

        public string Fax { get; set; }
        [Required(ErrorMessage = "Thiếu tên người đại diện")]
        [StringLength(15)]

        public string RepresentativeName { get; set; }
        [StringLength(15)]

        public string ReprPhone { get; set; }
        [StringLength(15)]

        public string ReprAdd { get; set; }
        [StringLength(15)]

        public string ReprEmail { get; set; }
        [Required(ErrorMessage = "thiếu tên giám đốc")]
        [StringLength(15)]

        public string DirectorName { get; set; }
    }

    public class SearchObjectViewModel:ObjectViewModel
    {
        public new string RepresentativeName { get; set; }
        public new string ObjectName { get; set; }
    }
}
