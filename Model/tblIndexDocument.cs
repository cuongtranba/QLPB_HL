namespace Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("tblIndexDocument")]
    public partial class tblIndexDocument
    {
        [Key]
        [StringLength(50)]
        public string KeyAutoID { get; set; }

        [StringLength(50)]
        public string BranchID { get; set; }

        [StringLength(50)]
        public string Period { get; set; }

        [Required]
        [StringLength(50)]
        public string DocumentID { get; set; }

        [StringLength(50)]
        public string DocumentTypeID { get; set; }

        [StringLength(50)]
        public string ReasonID { get; set; }

        [StringLength(150)]
        public string DocumentDesc { get; set; }

        public DateTime? DocumentDate { get; set; }

        [StringLength(50)]
        public string TransportID { get; set; }

        public double? Distance { get; set; }

        [StringLength(50)]
        public string ContractNo { get; set; }

        public DateTime? ContractDate { get; set; }

        [StringLength(50)]
        public string TaxGroup { get; set; }

        [StringLength(50)]
        public string PayMethod { get; set; }

        [StringLength(50)]
        public string PersonName { get; set; }

        [StringLength(50)]
        public string ObjectId { get; set; }

        [StringLength(150)]
        public string ObjectName { get; set; }

        [StringLength(50)]
        public string CurrencyID { get; set; }

        public double? CurrencyExRateVND { get; set; }

        public double? CurrencyExRateUSD { get; set; }

        [StringLength(50)]
        public string StockID { get; set; }

        [StringLength(50)]
        public string LoaderID { get; set; }

        public double? LoaderPrice { get; set; }

        public double? TaxRate { get; set; }

        public double? TotalAmount { get; set; }

        public double? TotalAmountVND { get; set; }

        public double? TotalAmountUSD { get; set; }

        public double? VATable { get; set; }

        public double? VATableVND { get; set; }

        public double? VATableUSD { get; set; }

        public double? VATAmount { get; set; }

        public double? VATAmountVND { get; set; }

        public double? VATAmountUSD { get; set; }

        public double? TotalMoney { get; set; }

        public double? TotalMoneyVND { get; set; }

        public double? TotalMoneyUSD { get; set; }

        [StringLength(150)]
        public string InWords { get; set; }

        [StringLength(150)]
        public string InWordsVND { get; set; }

        [StringLength(150)]
        public string InWordsUSD { get; set; }

        [StringLength(150)]
        public string Note { get; set; }

        public bool? isLock { get; set; }

        [StringLength(50)]
        public string CreateBy { get; set; }

        public DateTime? CreateDate { get; set; }

        [StringLength(50)]
        public string EditBy { get; set; }

        public DateTime? EditDate { get; set; }
    }
}
