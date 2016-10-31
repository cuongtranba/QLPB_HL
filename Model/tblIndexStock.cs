namespace Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("tblIndexStock")]
    public partial class tblIndexStock:BaseModel
    {
        [Key]
        [StringLength(50)]
        public string KeyAutoID { get; set; }

        [StringLength(50)]
        public string StockID { get; set; }

        [StringLength(150)]
        public string StockDesc { get; set; }

        [StringLength(50)]
        public string StockAcc { get; set; }

        [StringLength(50)]
        public string StockOutAcc { get; set; }

        public int CountImportDoc { get; set; }

        public int CountExportDoc { get; set; }

        [StringLength(150)]
        public string Note { get; set; }

        public bool isFull { get; set; }

        public int StockAvailable { get; set; }

        [StringLength(50)]
        public string UnitID { get; set; }
    }
}
