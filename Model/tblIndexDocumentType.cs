namespace Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("tblIndexDocumentType")]
    public partial class tblIndexDocumentType
    {
        [Key]
        [StringLength(50)]
        public string KeyAutoID { get; set; }

        [StringLength(50)]
        public string TypeID { get; set; }

        [StringLength(150)]
        public string TypeDesc { get; set; }

        [StringLength(50)]
        public string TypeAcc { get; set; }

        [StringLength(50)]
        public string TypeAcc1 { get; set; }

        [StringLength(50)]
        public string TypeAcc2 { get; set; }

        [StringLength(150)]
        public string Note { get; set; }
    }
}
