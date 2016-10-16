namespace Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("tblKhoCanDoi")]
    public partial class tblKhoCanDoi
    {
        [Key]
        [Column(Order = 0)]
        [StringLength(50)]
        public string Period { get; set; }

        public DateTime? StockDate { get; set; }

        [Key]
        [Column(Order = 1)]
        [StringLength(50)]
        public string StockID { get; set; }

        public bool? isBalanced { get; set; }
    }
}
