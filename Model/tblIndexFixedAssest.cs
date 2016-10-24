namespace Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("tblIndexFixedAssest")]
    public partial class tblIndexFixedAssest : BaseModel
    {
        [Key]
        [StringLength(10)]
        public string KeyAutoID { get; set; }

        [StringLength(10)]
        public string AssestID { get; set; }

        [StringLength(50)]
        public string AssestName { get; set; }

        [StringLength(50)]
        public string ModelNum { get; set; }

        [StringLength(50)]
        public string SerialNum { get; set; }

        public DateTime? BeginDate { get; set; }

        [StringLength(150)]
        public string AssestStatus { get; set; }

        public DateTime? BuyDate { get; set; }

        public double? BuyPrice { get; set; }

        [StringLength(50)]
        public string CountryOrigin { get; set; }

        public bool? isActived { get; set; }
    }
}
