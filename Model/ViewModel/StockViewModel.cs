namespace Model.ViewModel
{
    public class StockViewModel
    {
        public string KeyAutoID { get; set; }
        public string StockID { get; set; }
        public string StockDesc { get; set; }
        public string StockAcc { get; set; }
        public string StockOutAcc { get; set; }
        public int CountImportDoc { get; set; }
        public int CountExportDoc { get; set; }
        public string Note { get; set; }
        public bool isFull { get; set; }
        public double StockAvilable { get; set; }
        public string UnitID { get; set; }
    }
}
