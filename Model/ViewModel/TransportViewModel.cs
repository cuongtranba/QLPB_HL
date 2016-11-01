using System;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using Model.Helper;

namespace Model.ViewModel
{
    public class TransportViewModel
    {
        [DisplayName("STT")]
        public int Serial { get; set; }
        [HiddenColumn]
        public string KeyAutoID { get; set; }
        [DisplayName("Mã phương tiện")]
        public string TransID { get; set; }
        [DisplayName("Tên phương tiện")]
        public string TransName { get; set; }
        [DisplayName("Ghi chú")]
        public string Note { get; set; }
    }

    public class AddTransportViewModel
    {
        public string KeyAutoID => Guid.NewGuid().ToString();
        [Required(ErrorMessage = "Thiếu mã phương tiện")]
        [StringLength(50)]
        public string TransID { get; set; }
        [Required(ErrorMessage = "Thiếu tên phương tiện")]
        [StringLength(150)]
        public string TransName { get; set; }
        
        [StringLength(150)]
        public string Note { get; set; }
    }

    public class SearchTransportViewModel
    {
        public string TransID { get; set; }
        public string TransName { get; set; }
        public string Note { get; set; }
    }

    public class UpdateTransportViewModel
    {
        public string KeyAutoID { get; set; }
        [Required(ErrorMessage = "Thiếu mã phương tiện")]
        [StringLength(50)]
        public string TransID { get; set; }
        [Required(ErrorMessage = "Thiếu tên phương tiện")]
        [StringLength(150)]
        public string TransName { get; set; }

        [StringLength(150)]
        public string Note { get; set; }
    }
}
