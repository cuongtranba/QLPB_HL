namespace Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("tblIndexFeeGroup")]
    public partial class tblIndexFeeGroup
    {
        [Key]
        [StringLength(50)]
        public string KeyAutoID { get; set; }

        [StringLength(15)]
        public string FeeGroupID { get; set; }

        [StringLength(150)]
        public string FeeGroupDesc { get; set; }
    }
}
