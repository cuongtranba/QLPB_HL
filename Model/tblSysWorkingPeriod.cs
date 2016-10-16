namespace Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("tblSysWorkingPeriod")]
    public partial class tblSysWorkingPeriod
    {
        [Key]
        [StringLength(50)]
        public string KeyAutoID { get; set; }

        [Required]
        [StringLength(6)]
        public string Period { get; set; }

        public DateTime? FromDate { get; set; }

        public DateTime? ToDate { get; set; }
    }
}
