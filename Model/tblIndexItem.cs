using System.ComponentModel;

namespace Model
{
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;

    [Table("tblIndexItem")]
    public partial class tblIndexItem
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

        public double? UnitRate1 { get; set; }

        public double? UnitRate2 { get; set; }
        [DisplayName("Giá mua")]
        public double? BuyPrice { get; set; }
        [DisplayName("Giá bán")]
        public double? SalePrice { get; set; }

        [StringLength(150)]
        [DisplayName(@"Ghi chú")]
        public string Note { get; set; }

        public bool? isSelected { get; set; }
    }
}
