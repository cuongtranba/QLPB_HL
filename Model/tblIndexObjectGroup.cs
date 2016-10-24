namespace Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("tblIndexObjectGroup")]
    public partial class tblIndexObjectGroup : BaseModel
    {
        [Key]
        [StringLength(50)]
        public string KeyAutoID { get; set; }

        [StringLength(50)]
        public string ObjGroupId { get; set; }

        [StringLength(150)]
        public string ObjGroupName { get; set; }

        [StringLength(150)]
        public string Note { get; set; }
    }
}
