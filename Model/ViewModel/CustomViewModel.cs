using System;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using Model.Helper;

namespace Model.ViewModel
{
    public class CustomViewModel
    {
        [HiddenColumn]
        public string KeyAutoID { get; set; }

        [DisplayName("Mã khách hàng")]
        public string ObjectID { get; set; }

        //[DisplayName("Loại khách hàng")]
        //public string ObjectType { get; set; }

        //[DisplayName("Nhóm")]
        //public string ObjectGroup { get; set; }

        [DisplayName("Tên")]
        public string ObjectName { get; set; }
        [DisplayName("Tên viết tắt")]
        public string AbbName { get; set; }

        [DisplayName("Địa chỉ")]
        public string ObjectAddress { get; set; }

        [DisplayName("Số thuế")]
        public string TaxCode { get; set; }

        [DisplayName("Số ngân hàng")]
        public string BankCode { get; set; }

        [DisplayName("Số điện thoại")]
        public string PhoneNum { get; set; }
        [DisplayName("Fax1")]
        public string Fax { get; set; }

        [DisplayName("Số điện thoại 2")]
        public string PhoneNum1 { get; set; }

        [DisplayName("Fax2")]
        public string Fax1 { get; set; }

        public string Email { get; set; }

        public string Website { get; set; }

        [DisplayName("Người đại diện")]
        public string RepresentativeName { get; set; }

        [DisplayName("Đt người đại diện")]
        public string ReprPhone { get; set; }

        [DisplayName("Địa chỉ người đại diện")]
        public string ReprAdd { get; set; }

        [DisplayName("Email người đại diện")]
        public string ReprEmail { get; set; }

        [DisplayName("Tên giám đốc")]
        public string DirectorName { get; set; }

        public bool? isActived { get; set; }
        public DateTime? CreateDate { get; set; }
        public DateTime? EditDate { get; set; }
        public string CreateBy { get; set; }
        public string EditBy { get; set; }
    }
}
