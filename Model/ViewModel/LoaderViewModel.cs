using System.ComponentModel;
using Model.Helper;

namespace Model.ViewModel
{
    public class LoaderViewModel
    {
        [DisplayName("STT")]
        public int Serial { get; set; }
        [HiddenColumn]
        public string KeyAutoID { get; set; }
        [DisplayName("Mã bốc xếp")]
        public string LoaderID { get; set; }
        [DisplayName("Tên bốc xếp")]
        public string LoaderName { get; set; }
        [DisplayName("Ghi chú")]
        public string Note { get; set; }
    }
}
