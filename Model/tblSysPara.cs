namespace Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("tblSysPara")]
    public partial class tblSysPara
    {
        [Key]
        [StringLength(50)]
        public string ParaName { get; set; }

        [StringLength(150)]
        public string ParaDesc { get; set; }

        [StringLength(150)]
        public string ParaValue { get; set; }
    }
}
