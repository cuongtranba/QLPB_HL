namespace Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("tblIndexLoader")]
    public partial class tblIndexLoader : BaseModel
    {
        [Key]
        [StringLength(50)]
        public string KeyAutoID { get; set; }

        [Required]
        [StringLength(50)]
        public string LoaderID { get; set; }

        [StringLength(100)]
        public string LoaderName { get; set; }

        [StringLength(150)]
        public string Note { get; set; }
    }
}
