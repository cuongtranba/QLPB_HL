using System;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using Model.Helper;

namespace Model.ViewModel
{
    public class InOutReasonViewModel
    {
        [DisplayName("STT")]
        public int Serial { get; set; }
        [HiddenColumn]
        public string KeyAutoID { get; set; }
        [DisplayName("Mã lí do")]
        public string ReasonID { get; set; }
        [DisplayName("Tên lí do")]
        public string ReasonDesc { get; set; }
        [HiddenColumn]
        public string DocType { get; set; }
        [DisplayName("Loại phiếu")]
        public string DocTypeDisplay
        {
            get
            {
                switch (DocType)
                {
                    case "PN":
                        return "Phiếu nhập";
                    case "PX":
                        return "Phiếu xuất";
                }
                return "";
            }
        }
        [HiddenColumn]
        public string Acc { get; set; }
        [DisplayName("Tài khoản")]
        public string AccountName { get; set; }
        [HiddenColumn]
        public string Acc1 { get; set; }
        [DisplayName("Tài khoản 1")]
        public string AccountName1 { get; set; }
        [HiddenColumn]
        public string Acc2 { get; set; }
        [DisplayName("Tài khoản 2")]
        public string AccountName2 { get; set; }
        [DisplayName("Ghi chú")]
        public string Note { get; set; }
    }

    public class UpdateInOutReasonViewModel
    {
        public string KeyAutoID { get; set; }
        [Required(ErrorMessage = "Thiếu mã lí do")]
        [StringLength(50)]
        public string ReasonID { get; set; }
        [Required(ErrorMessage = "Thiếu tên lí do")]
        [StringLength(150)]
        public string ReasonDesc { get; set; }
        [Required(ErrorMessage = "Thiếu loại phiếu")]
        [StringLength(50)]
        public string DocType { get; set; }

        [StringLength(50)]
        public string Acc { get; set; }

        [StringLength(50)]
        public string Acc1 { get; set; }

        [StringLength(50)]
        public string Acc2 { get; set; }

        [StringLength(150)]
        public string Note { get; set; }
    }

    public class CreateInOutReasonViewModel
    {
        public string KeyAutoID => Guid.NewGuid().ToString();
        [Required(ErrorMessage = "Thiếu mã lí do")]
        [StringLength(50)]
        public string ReasonID { get; set; }
        [Required(ErrorMessage = "Thiếu tên lí do")]
        [StringLength(150)]
        public string ReasonDesc { get; set; }
        [Required(ErrorMessage = "Thiếu loại phiếu")]
        [StringLength(50)]
        public string DocType { get; set; }

        [StringLength(50)]
        public string Acc { get; set; }

        [StringLength(50)]
        public string Acc1 { get; set; }

        [StringLength(50)]
        public string Acc2 { get; set; }

        [StringLength(150)]
        public string Note { get; set; }
    }

    public class SearchInOutReasonViewModel
    {
        public string Acc { get; set; }
        public string DocType { get; set; }
        public string ReasonDesc { get; set; }
    }
}
