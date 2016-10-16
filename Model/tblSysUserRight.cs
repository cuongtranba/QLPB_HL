namespace Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("tblSysUserRight")]
    public partial class tblSysUserRight
    {
        [Key]
        [Column(Order = 0)]
        [StringLength(50)]
        public string UserID { get; set; }

        [Key]
        [Column(Order = 1)]
        [StringLength(50)]
        public string FunctionID { get; set; }

        public bool? AllowFull { get; set; }

        public bool? isView { get; set; }

        public bool? isAdd { get; set; }

        public bool? isEdit { get; set; }

        public bool? isDelete { get; set; }

        public bool? DenyAll { get; set; }

        [StringLength(50)]
        public string CreateBy { get; set; }

        public DateTime? CreateDate { get; set; }

        [StringLength(50)]
        public string EditBy { get; set; }

        public DateTime? EditDate { get; set; }
    }
}
