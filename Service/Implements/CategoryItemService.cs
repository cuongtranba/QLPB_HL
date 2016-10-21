using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Model;
using Model.ViewModel;
using Service.Interfaces;
using _4.Helper;

namespace Service.Implements
{
    public class CategoryItemService : BaseService, ICategoryService
    {
        public CategoryItemService(HongLienDb hongLienDb) : base(hongLienDb)
        {

        }

        public StringBuilder BaseQuery => new StringBuilder("select item.KeyAutoID as ItemId,item.ItemName,item.UnitID,item.BuyPrice,item.SalePrice,item.Note,itemgroup.GroupName,item.GroupID,stock.StockDesc,stock.KeyAutoID as StockId\r\nfrom tblIndexItem item \r\nleft join tblIndexItemGroup itemgroup\r\non item.GroupID = itemgroup.KeyAutoID\r\nleft join tblIndexStock stock\r\non item.StockID = stock.KeyAutoID ");

        public object GetDataSource()
        {
            var items = HongLienDb.Database.SqlQuery<ItemViewModel>(BaseQuery.ToString()).ToList().ToSortableBindingList();
            return items;
        }

        public List<ControlViewModel> GetSearchComponent()
        {
            var controlViewModel = new List<ControlViewModel>()
            {
                new ControlViewModel()
                {
                    Control = new TextBox(){Name = "ItemName",Size = new Size(199,20)},
                    Label = new Label() {Text = "Tên Hàng",TextAlign = ContentAlignment.MiddleLeft}
                },
                new ControlViewModel()
                {
                    Control = new TextBox() {Name = "Note",Size = new Size(199,20)},
                    Label = new Label() {Text = "Ghi chú",TextAlign = ContentAlignment.MiddleLeft}
                }
            };
            return controlViewModel;
        }

        public object Search(Control.ControlCollection controls)
        {
            var searchQuery = BaseQuery.Append(controls.BuildSearchQueryFromPanel());
            var items = HongLienDb.Database.SqlQuery<ItemViewModel>(searchQuery.ToString(), controls.GetSearchParameters()).ToList().ToSortableBindingList();
            return items;
        }

        public List<ControlViewModel> GetCRUDComponent()
        {
            var controlViewModel = new List<ControlViewModel>
            {
                new ControlViewModel()
                {
                    Control = new TextBox(){Name = "ItemName"},
                    Label = new Label(){Text = "Tên hàng",TextAlign = ContentAlignment.MiddleLeft}
                },
                new ControlViewModel()
                {
                    Control = new TextBox(){Name = "UnitID"},
                    Label = new Label(){Text = "Đơn vị tính",TextAlign = ContentAlignment.MiddleLeft}
                },
                new ControlViewModel()
                {
                    Control = new TextBox(){Name = "BuyPrice"},
                    Label = new Label(){Text = "Giá mua",TextAlign = ContentAlignment.MiddleLeft}
                },
                new ControlViewModel()
                {
                    Control = new TextBox(){Name = "SalePrice"},
                    Label = new Label(){Text = "Giá bán",TextAlign = ContentAlignment.MiddleLeft}
                },
                new ControlViewModel()
                {
                    Control = new TextBox(){Name = "Note"},
                    Label = new Label(){Text = "Ghi chú",TextAlign = ContentAlignment.MiddleLeft}
                },
                new ControlViewModel()
                {
                    Control = new TextBox(){Name = "GroupName"},
                    Label = new Label(){Text = "Tên nhóm",TextAlign = ContentAlignment.MiddleLeft}
                },
                new ControlViewModel()
                {
                    Control = new TextBox(){Name = "StockDesc"},
                    Label = new Label(){Text = "Kho",TextAlign = ContentAlignment.MiddleLeft}
                },
            };
            return controlViewModel;
        }
    }
}
