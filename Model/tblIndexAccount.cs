namespace Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("tblIndexAccount")]
    public partial class tblIndexAccount
    {
        [Key]
        [StringLength(50)]
        public string KeyAutoID { get; set; }

        [StringLength(15)]
        public string AccountID { get; set; }

        [StringLength(150)]
        public string AccountDesc { get; set; }

        public bool? isActived { get; set; }

        public bool? isCreate { get; set; }

        [StringLength(150)]
        public string Note { get; set; }
    }
}
