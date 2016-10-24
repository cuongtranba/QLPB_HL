namespace Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("tblIndexItemGroup")]
    public partial class tblIndexItemGroup : BaseModel
    {
        [Key]
        [StringLength(50)]
        public string KeyAutoID { get; set; }

        [StringLength(15)]
        public string GroupID { get; set; }

        [StringLength(150)]
        public string GroupName { get; set; }

        [StringLength(150)]
        public string Note { get; set; }
    }
}
