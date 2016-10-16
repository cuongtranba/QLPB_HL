namespace Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("tblIndexItem")]
    public partial class tblIndexItem
    {
        [Key]
        [StringLength(50)]
        public string KeyAutoID { get; set; }

        [StringLength(50)]
        public string ItemID { get; set; }

        [StringLength(150)]
        public string ItemName { get; set; }

        [StringLength(50)]
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

        public double? BuyPrice { get; set; }

        public double? SalePrice { get; set; }

        [StringLength(150)]
        public string Note { get; set; }

        public bool? isSelected { get; set; }
    }
}
