namespace Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("tblSysWorkingLock")]
    public partial class tblSysWorkingLock
    {
        [Key]
        [StringLength(50)]
        public string KeyAutoID { get; set; }

        [Required]
        [StringLength(6)]
        public string Period { get; set; }

        public bool? isLock1 { get; set; }

        public bool? isLock2 { get; set; }

        public bool? isLock3 { get; set; }

        public bool? isLock4 { get; set; }

        public bool? isLock5 { get; set; }

        public bool? isLock6 { get; set; }
    }
}
