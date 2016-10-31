using System.Collections.Generic;
using System.Data.Entity;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Windows.Forms;
using AutoMapper;
using AutoMapper.QueryableExtensions;
using LinqKit;
using Model;
using Model.ViewModel;
using Service.Interfaces;
using _4.Helper;

namespace Service.Implements
{
    public class StockCategoryService : BaseService, ICategoryService
    {
        public StringBuilder BaseQuery { get; }

        public IQueryable<StockViewModel> BaseStockQuery()
        {
            return from p1 in HongLienDb.tblIndexStocks.AsExpandable()
                   join p2 in HongLienDb.tblIndexAccounts.AsExpandable() on p1.StockOutAcc equals p2.KeyAutoID into stockOut
                   from p2 in stockOut.DefaultIfEmpty()
                   join p3 in HongLienDb.tblIndexAccounts.AsExpandable() on p1.StockAcc equals p3.KeyAutoID into stockAcc
                   from p3 in stockAcc.DefaultIfEmpty()
                   where p1.IsDeleted == false
                   select new StockViewModel()
                   {
                       StockDesc = p1.StockDesc,
                       KeyAutoID = p1.KeyAutoID,
                       Note = p1.Note,
                       CountExportDoc = p1.CountExportDoc,
                       isFull = p1.isFull,
                       StockID = p1.StockID,
                       UnitID = p1.UnitID,
                       StockOutAcc = p1.StockOutAcc,
                       CountImportDoc = p1.CountImportDoc,
                       StockAcc = p1.StockAcc,
                       StockAvailable = p1.StockAvailable,
                       StockAccName = p3.AccountDesc,
                       StockOutAccName = p2.AccountDesc
                   };
        }

        public List<ControlViewModel> GetSearchComponent => new List<ControlViewModel>()
        {
            new ControlViewModel()
                    {
                        Control = new TextBox(){Name = "StockDesc",Size = new Size(199,20)},
                        Label = new Label(){Text = "Tên Kho",TextAlign = ContentAlignment.MiddleLeft},
                    },
            new ControlViewModel()
                    {
                        Control = new TextBox(){Name = "Note",Size = new Size(199,20)},
                        Label = new Label(){Text = "Ghi Chú",TextAlign = ContentAlignment.MiddleLeft},
                    },
            new ControlViewModel()
                    {
                        Control = new ComboBox() {Name = "StockAcc",Size = new Size(199,20),DropDownStyle = ComboBoxStyle.DropDownList,DataSource = GetAccount()},
                        Label = new Label(){Text = "Tài khoản kho",TextAlign = ContentAlignment.MiddleLeft},
                    },
                    new ControlViewModel()
                    {
                        Control = new ComboBox() {Name = "StockOutAcc",Size = new Size(199,20),DropDownStyle = ComboBoxStyle.DropDownList,DataSource = GetAccount()},
                        Label = new Label(){Text = "Tài khoản xuất kho",TextAlign = ContentAlignment.MiddleLeft},
                    }
        };

        public object GetDataSource()
        {
            return BaseStockQuery().ToList().ToSortableBindingList();
        }

        public object Search(Control.ControlCollection controls)
        {
            var searchViewModel = controls.ToModel<SearchStockViewModel>();
            var searchQueryable = BaseStockQuery();
            if (!string.IsNullOrEmpty(searchViewModel.Note))
            {
                searchQueryable = searchQueryable.Where(c => c.Note.Contains(searchViewModel.Note));
            }
            if (!string.IsNullOrEmpty(searchViewModel.StockDesc))
            {
                searchQueryable = searchQueryable.Where(c => c.StockDesc.Contains(searchViewModel.StockDesc));
            }
            if (!string.IsNullOrEmpty(searchViewModel.StockAcc))
            {
                searchQueryable = searchQueryable.Where(c => c.StockAcc.Contains(searchViewModel.StockAcc));
            }
            if (!string.IsNullOrEmpty(searchViewModel.StockOutAcc))
            {
                searchQueryable = searchQueryable.Where(c => c.StockOutAcc.Contains(searchViewModel.StockOutAcc));
            }
            return
               searchQueryable
                    .ToList()
                    .ToSortableBindingList();

        }

        public List<ControlViewModel> GetCRUDComponent
        {
            get
            {
                return new List<ControlViewModel>()
                {
                    new ControlViewModel()
                    {
                        Control = new TextBox(){Name = "StockID",Size = new Size(199,20)},
                        Label = new Label(){Text = "Mã kho",TextAlign = ContentAlignment.MiddleLeft},
                    },
                    new ControlViewModel()
                    {
                        Control = new TextBox(){Name = "StockDesc",Size = new Size(199,20)},
                        Label = new Label(){Text = "Tên Kho",TextAlign = ContentAlignment.MiddleLeft},
                    },
                    new ControlViewModel()
                    {
                        Control = new TextBox(){Name = "Note",Size = new Size(199,20)},
                        Label = new Label(){Text = "Ghi Chú",TextAlign = ContentAlignment.MiddleLeft},
                    },
                    new ControlViewModel()
                    {
                        Control = new ComboBox() {Name = "StockAcc",Size = new Size(199,20),DropDownStyle = ComboBoxStyle.DropDownList,DataSource = GetAccount()},
                        Label = new Label(){Text = "Tài khoản kho",TextAlign = ContentAlignment.MiddleLeft},
                    },
                    new ControlViewModel()
                    {
                        Control = new ComboBox() {Name = "StockOutAcc",Size = new Size(199,20),DropDownStyle = ComboBoxStyle.DropDownList,DataSource = GetAccount()},
                        Label = new Label(){Text = "Tài khoản xuất kho",TextAlign = ContentAlignment.MiddleLeft},
                    },
                    new ControlViewModel()
                    {
                        Control = new ComboBox() {Name = "UnitID",Size = new Size(199,20),DropDownStyle = ComboBoxStyle.DropDownList,DataSource = GetUnit()},
                        Label = new Label(){Text = "Đơn vị tính",TextAlign = ContentAlignment.MiddleLeft},
                    }
                };
            }
        }

        private List<ComboboxItem> GetUnit()
        {
            return HongLienDb.tblIndexUnits.Where(c => c.IsDeleted == false).Select(c => new ComboboxItem()
            {
                Text = c.UnitName,
                Value = c.UnitID
            }).ToList();
        }

        private List<ComboboxItem> GetAccount()
        {
            var model = HongLienDb.tblIndexAccounts.Where(c => c.IsDeleted == false).Select(c => new ComboboxItem()
            {
                Text = c.AccountDesc,
                Value = c.KeyAutoID
            }).ToList();
            model.Insert(0, ComboboxItem.Empty);
            return model;
        }

        public ValidationModel Create(TableLayoutControlCollection controls)
        {
            var viewModel = controls.ToModel<AddStockViewModel>();
            var modelState = viewModel.ModelState();
            if (modelState.IsValid)
            {
                var model = Mapper.Map<AddStockViewModel, tblIndexStock>(viewModel);
                HongLienDb.tblIndexStocks.Add(model);
                HongLienDb.SaveChanges();
            }
            return modelState;
        }

        public void Delete(object currentRowDataBoundItem)
        {
            var viewModel = (StockViewModel)currentRowDataBoundItem;
            this.Delete<tblIndexStock>(viewModel.KeyAutoID);
        }

        public void HiddentColumns(DataGridView danhMucGridView)
        {
            danhMucGridView.HiddentColumns<StockViewModel>();
        }

        public ValidationModel Update(TableLayoutControlCollection controls)
        {
            throw new System.NotImplementedException();
        }

        public StockCategoryService(HongLienDb hongLienDb) : base(hongLienDb)
        {
        }
    }
}
