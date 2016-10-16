namespace Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("tblIndexBranch")]
    public partial class tblIndexBranch
    {
        [Key]
        [StringLength(2)]
        public string BranchID { get; set; }

        [StringLength(150)]
        public string BranchName { get; set; }

        [StringLength(250)]
        public string BranchAdd { get; set; }

        [StringLength(15)]
        public string Tel { get; set; }

        [StringLength(15)]
        public string Fax { get; set; }
    }
}
