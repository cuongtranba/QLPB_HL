namespace Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("tblIndexObject")]
    public partial class tblIndexObject : BaseModel
    {
        [Key]
        [StringLength(50)]
        public string KeyAutoID { get; set; }

        [Required]
        [StringLength(50)]
        public string ObjectID { get; set; }

        [StringLength(50)]
        public string ObjectType { get; set; }

        [StringLength(50)]
        public string ObjectGroup { get; set; }

        [StringLength(150)]
        public string ObjectName { get; set; }

        [StringLength(100)]
        public string AbbName { get; set; }

        [StringLength(250)]
        public string ObjectAddress { get; set; }

        [StringLength(50)]
        public string TaxCode { get; set; }

        [StringLength(50)]
        public string BankCode { get; set; }

        [StringLength(15)]
        public string PhoneNum { get; set; }

        [StringLength(15)]
        public string Fax { get; set; }

        [StringLength(15)]
        public string PhoneNum1 { get; set; }

        [StringLength(15)]
        public string Fax1 { get; set; }

        [StringLength(50)]
        public string Email { get; set; }

        [StringLength(50)]
        public string Website { get; set; }

        [StringLength(50)]
        public string RepresentativeName { get; set; }

        [StringLength(15)]
        public string ReprPhone { get; set; }

        [StringLength(15)]
        public string ReprAdd { get; set; }

        [StringLength(15)]
        public string ReprEmail { get; set; }

        [StringLength(15)]
        public string DirectorName { get; set; }

        public bool? isActived { get; set; }

        public DateTime? CreateDate { get; set; }

        public DateTime? EditDate { get; set; }

        [StringLength(50)]
        public string CreateBy { get; set; }

        [StringLength(50)]
        public string EditBy { get; set; }
    }
}
