namespace Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("tblSysFunction")]
    public partial class tblSysFunction
    {
        [Key]
        [StringLength(50)]
        public string FunctionID { get; set; }

        [StringLength(150)]
        public string FunctionName { get; set; }

        [StringLength(50)]
        public string FormId { get; set; }

        [StringLength(50)]
        public string FuncGroup { get; set; }
    }
}
