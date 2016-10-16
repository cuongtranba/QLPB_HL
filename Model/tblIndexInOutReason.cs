namespace Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("tblIndexInOutReason")]
    public partial class tblIndexInOutReason
    {
        [Key]
        [StringLength(50)]
        public string KeyAutoID { get; set; }

        [StringLength(50)]
        public string ReasonID { get; set; }

        [StringLength(150)]
        public string ReasonDesc { get; set; }

        [StringLength(50)]
        public string DocType { get; set; }

        [StringLength(50)]
        public string Acc { get; set; }

        [StringLength(50)]
        public string Acc1 { get; set; }

        [StringLength(50)]
        public string Acc2 { get; set; }

        [StringLength(150)]
        public string Note { get; set; }
    }
}
