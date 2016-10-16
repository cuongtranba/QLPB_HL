namespace Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("tblIndexPaymentMethod")]
    public partial class tblIndexPaymentMethod
    {
        [Key]
        [StringLength(2)]
        public string PayMID { get; set; }

        [StringLength(150)]
        public string PayMDesc { get; set; }
    }
}
