namespace Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("tblIndexUnit")]
    public partial class tblIndexUnit
    {
        [Key]
        [StringLength(15)]
        public string UnitID { get; set; }

        [StringLength(150)]
        public string UnitName { get; set; }

        [StringLength(150)]
        public string Note { get; set; }
    }
}
