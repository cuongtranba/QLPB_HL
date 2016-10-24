using System;

namespace Model.ViewModel
{
    public class AddItemViewModel
    {
        public string KeyAutoID { get; set; }
        public AddItemViewModel()
        {
            KeyAutoID = Guid.NewGuid().ToString();
        }
        public string ItemID { get; set; }
        public string ItemName { get; set; }
        public string UnitID { get; set; }
        public string StockID { get; set; }
        public string GroupID { get; set; }
        public double? BuyPrice { get; set; }
        public double? SalePrice { get; set; }
        public string Note { get; set; }
    }
}
