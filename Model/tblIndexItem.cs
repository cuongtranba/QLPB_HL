using System;
using System.ComponentModel;

namespace Model
{
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;

    [Table("tblIndexItem")]
    public partial class tblIndexItem:BaseModel
    {
        [Key]
        [StringLength(50)]
        [DisplayName("Mã")]
        public string KeyAutoID { get; set; }

        [StringLength(50)]
        public string ItemID { get; set; }

        [StringLength(150)]
        [DisplayName(@"Tên Hàng")]
        public string ItemName { get; set; }

        [StringLength(50)]
        [DisplayName(@"Đơn vị tính")]
        public string UnitID { get; set; }

        [StringLength(50)]
        public string UnitID1 { get; set; }

        [StringLength(50)]
        public string UnitID2 { get; set; }

        [StringLength(50)]
        public string StockID { get; set; }

        [StringLength(50)]
        public string GroupID { get; set; }

        public decimal? UnitRate1 { get; set; }

        public decimal? UnitRate2 { get; set; }
        [DisplayName("Giá mua")]
        public decimal? BuyPrice { get; set; }
        [DisplayName("Giá bán")]
        public decimal? SalePrice { get; set; }

        [StringLength(150)]
        [DisplayName(@"Ghi chú")]
        public string Note { get; set; }

        public bool? isSelected { get; set; }

        public tblIndexItem()
        {
            KeyAutoID = Guid.NewGuid().ToString();
        }
    }
}
