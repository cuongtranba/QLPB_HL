namespace Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("tblPhieuXuatTheoKho")]
    public partial class tblPhieuXuatTheoKho
    {
        [Key]
        [Column(Order = 0)]
        [StringLength(6)]
        public string Period { get; set; }

        [Key]
        [Column(Order = 1)]
        [StringLength(50)]
        public string StockID { get; set; }

        [Key]
        [Column(Order = 2)]
        [StringLength(50)]
        public string VoucherID { get; set; }

        [StringLength(50)]
        public string DocumentID { get; set; }
    }
}
