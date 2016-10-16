namespace Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("tblIndexCurrency")]
    public partial class tblIndexCurrency
    {
        [Key]
        [StringLength(10)]
        public string CurrencyID { get; set; }

        [StringLength(50)]
        public string CurrencyDesc { get; set; }

        public bool? isActived { get; set; }
    }
}
