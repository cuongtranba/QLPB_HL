namespace Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("tblIndexDocumentSub")]
    public partial class tblIndexDocumentSub
    {
        [Key]
        [Column(Order = 0)]
        [StringLength(50)]
        public string KeyAutoIDRef { get; set; }

        [Key]
        [Column(Order = 1)]
        [StringLength(4)]
        public string NumOrder { get; set; }

        [StringLength(50)]
        public string StockID { get; set; }

        [StringLength(50)]
        public string StockOderNo { get; set; }

        [StringLength(50)]
        public string ItemID { get; set; }

        [StringLength(150)]
        public string ItemName { get; set; }

        [StringLength(50)]
        public string UnitID { get; set; }

        [StringLength(50)]
        public string LoaderId { get; set; }

        public double? LoaderPrice { get; set; }

        public double? Qty { get; set; }

        public double? UnitPrice { get; set; }

        public double? Amount { get; set; }

        public double? TaxRate { get; set; }

        public double? VATable { get; set; }

        public double? VATAmount { get; set; }

        public double? TotalMoney { get; set; }

        [StringLength(150)]
        public string InWords { get; set; }

        public DateTime? ExpirateDate { get; set; }

        [StringLength(50)]
        public string LotNo { get; set; }

        public bool? IsInclude { get; set; }
    }
}
