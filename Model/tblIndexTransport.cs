namespace Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("tblIndexTransport")]
    public partial class tblIndexTransport
    {
        [Key]
        [StringLength(50)]
        public string KeyAutoID { get; set; }

        [StringLength(50)]
        public string TransID { get; set; }

        [StringLength(150)]
        public string TransName { get; set; }

        [StringLength(150)]
        public string Note { get; set; }
    }
}
