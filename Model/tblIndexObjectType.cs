namespace Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("tblIndexObjectType")]
    public partial class tblIndexObjectType : BaseModel
    {
        [Key]
        [StringLength(50)]
        public string KeyAutoID { get; set; }

        [StringLength(50)]
        public string ObjTypeId { get; set; }

        [StringLength(150)]
        public string ObjTypeName { get; set; }

        [StringLength(150)]
        public string Note { get; set; }
    }
}
