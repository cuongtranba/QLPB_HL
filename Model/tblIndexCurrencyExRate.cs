namespace Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("tblIndexCurrencyExRate")]
    public partial class tblIndexCurrencyExRate : BaseModel
    {
        [Key]
        [Column(Order = 0)]
        [StringLength(1)]
        public string CurrencyID { get; set; }

        [Key]
        [Column(Order = 1)]
        [StringLength(10)]
        public string dmy { get; set; }

        public DateTime? FromDate { get; set; }

        public DateTime? ToDate { get; set; }

        public double? ExRateVND { get; set; }

        public double? ExRateUSD { get; set; }

        [StringLength(100)]
        public string Note { get; set; }
    }
}
