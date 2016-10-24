﻿using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Model;
using Model.ViewModel;
using Service.Helper;
using Service.Interfaces;
using _4.Helper;

namespace Service.Implements
{
    public class CategoryItemService : BaseService, ICategoryService
    {
        public CategoryItemService(HongLienDb hongLienDb) : base(hongLienDb)
        {

        }

        public StringBuilder BaseQuery => new StringBuilder("select Row_number() over(order by item.ItemID) as Serial, item.KeyAutoID ,item.ItemID as ItemId,item.ItemName,item.UnitID,item.BuyPrice,item.SalePrice,item.Note,itemgroup.GroupName,item.GroupID,stock.StockDesc,stock.KeyAutoID as StockId from tblIndexItem item left join tblIndexItemGroup itemgroup on item.GroupID = itemgroup.KeyAutoID left join tblIndexStock stock on item.StockID = stock.KeyAutoID WHERE item.IsDeleted='false' ");

        public object GetDataSource()
        {
            var items = HongLienDb.Database.SqlQuery<ItemViewModel>(BaseQuery.ToString()).ToList().ToSortableBindingList();
            return items;
        }

        public List<ControlViewModel> GetSearchComponent
        {
            get
            {
                var controlViewModel = new List<ControlViewModel>
                {
                    new ControlViewModel()
                    {
                        Control = new TextBox(){Name = "ItemName",Size = new Size(199,20)},
                        Label = new Label() {Text = "Tên Hàng",TextAlign = ContentAlignment.MiddleLeft}
                    },
                    new ControlViewModel()
                    {
                        Control = new TextBox() {Name = "item.Note",Size = new Size(199,20)},
                        Label = new Label() {Text = "Ghi chú",TextAlign = ContentAlignment.MiddleLeft},
                        SqlParameter = "Note"
                    }
                };
                return controlViewModel;
            }
        }

        public object Search(Control.ControlCollection controls)
        {
            var queryBuilder = controls.BuildSearchQueryFormControl(GetSearchComponent);
            var searchQuery = BaseQuery.Append(queryBuilder.SqlQuery);
            var items = HongLienDb.Database.SqlQuery<ItemViewModel>(searchQuery.ToString(), queryBuilder.SqlParameter.ToArray()).ToList().ToSortableBindingList();
            return items;
        }

        public List<ControlViewModel> GetCRUDComponent
        {
            get
            {
                var controlViewModel = new List<ControlViewModel>
                {
                    new ControlViewModel()
                    {
                        Control = new TextBox(){Name = "KeyAutoID",Size = new Size(199,20)},
                        Label = new Label(){Text = "Mã hàng",TextAlign = ContentAlignment.MiddleLeft},
                        SqlParameter = "ItemId"
                    },
                    new ControlViewModel()
                    {
                        Control = new TextBox(){Name = "ItemName",Size = new Size(199,20)},
                        Label = new Label(){Text = "Tên hàng",TextAlign = ContentAlignment.MiddleLeft}
                    },
                    new ControlViewModel()
                    {
                        Control = new TextBox(){Name = "UnitID",Size = new Size(199,20)},
                        Label = new Label(){Text = "Đơn vị tính",TextAlign = ContentAlignment.MiddleLeft}
                    },
                    new ControlViewModel()
                    {
                        Control = new NumericUpDown(){Name = "BuyPrice",Size = new Size(199,20)},
                        Label = new Label(){Text = "Giá mua",TextAlign = ContentAlignment.MiddleLeft}
                    },
                    new ControlViewModel()
                    {
                        Control = new NumericUpDown(){Name = "SalePrice",Size = new Size(199,20)},
                        Label = new Label(){Text = "Giá bán",TextAlign = ContentAlignment.MiddleLeft}
                    },
                    new ControlViewModel()
                    {
                        Control = new RichTextBox(){Name = "Note",Size = new Size(199,100)},
                        Label = new Label(){Text = "Ghi chú",TextAlign = ContentAlignment.MiddleLeft}
                    },
                    new ControlViewModel()
                    {
                        Control = new ComboBox(){Name = "GroupName",Sorted = true,DropDownStyle = ComboBoxStyle.DropDownList,Size = new Size(199,20),SelectedIndex = -1,DataSource = GetGroups()},
                        Label = new Label(){Text = "Tên nhóm",TextAlign = ContentAlignment.MiddleLeft}
                    },
                    new ControlViewModel()
                    {
                        Control = new ComboBox(){Name = "StockDesc",Sorted = true,DropDownStyle = ComboBoxStyle.DropDownList,Size = new Size(199,20),SelectedIndex = -1,DataSource = this.GetStocks()},
                        Label = new Label(){Text = "Kho",TextAlign = ContentAlignment.MiddleLeft}
                    },
                };
                return controlViewModel;
            }
        }

        public List<ComboboxItem> GetStocks()
        {
            return
                HongLienDb.tblIndexStocks.AsNoTracking().Where(c => c.IsDeleted == false).Select(c => new ComboboxItem()
                {
                    Text = c.StockDesc,
                    Value = c.KeyAutoID
                }).ToList();
        }

        public List<ComboboxItem> GetGroups()
        {
            return
                HongLienDb.tblIndexItemGroups.AsNoTracking()
                    .Where(c => c.IsDeleted == false)
                    .Select(c => new ComboboxItem() { Text = c.GroupName, Value = c.KeyAutoID })
                    .ToList();
        }

    }
}
