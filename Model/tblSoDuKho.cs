namespace Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("tblSoDuKho")]
    public partial class tblSoDuKho : BaseModel
    {
        [Key]
        [Column(Order = 0)]
        [StringLength(6)]
        public string Period { get; set; }

        [Key]
        [Column(Order = 1)]
        [StringLength(2)]
        public string BranchID { get; set; }

        [Key]
        [Column(Order = 2)]
        [StringLength(50)]
        public string StockID { get; set; }

        [Key]
        [Column(Order = 3)]
        [StringLength(50)]
        public string ItemID { get; set; }

        [StringLength(50)]
        public string UnitID { get; set; }

        public double? OpenQty { get; set; }

        public double? OpenUnitPrice { get; set; }

        public double? InPeriodQty { get; set; }

        public double? InputUnitPrice { get; set; }

        public double? OutPeriodQty { get; set; }

        public double? OutputUnitPrice { get; set; }

        public double? CloseQty { get; set; }

        public double? CloseUnitPrice { get; set; }

        public double? OpenAmount { get; set; }

        public double? InputAmount { get; set; }

        public double? OutputAmount { get; set; }

        public double? CloseAmount { get; set; }
    }
}
