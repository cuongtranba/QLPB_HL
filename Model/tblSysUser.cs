namespace Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("tblSysUser")]
    public partial class tblSysUser
    {
        [Key]
        [StringLength(50)]
        public string UserID { get; set; }

        [Required]
        [StringLength(50)]
        public string UserPass { get; set; }

        public bool? Loginning { get; set; }

        public DateTime? CreatedDate { get; set; }

        [StringLength(50)]
        public string CreatedBy { get; set; }

        public DateTime? EditedDate { get; set; }

        [StringLength(50)]
        public string EditedBy { get; set; }
    }
}
