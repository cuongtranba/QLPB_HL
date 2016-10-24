namespace Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("tblSysInfo")]
    public partial class tblSysInfo : BaseModel
    {
        [Key]
        [StringLength(50)]
        public string KeyAutoID { get; set; }

        [StringLength(150)]
        public string CompanyName { get; set; }

        [StringLength(150)]
        public string CompanyAddress { get; set; }

        [StringLength(20)]
        public string CompanyPhone { get; set; }

        [StringLength(30)]
        public string TaxCode { get; set; }

        public DateTime? BeginDate { get; set; }
    }
}
