using System.Collections.Generic;
using System.Data.Entity;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using AutoMapper.QueryableExtensions;
using Model;
using Model.ViewModel;
using Service.Interfaces;
using _4.Helper;

namespace Service.Implements
{
    public class StockCategoryService : BaseService, ICategoryService
    {
        public StringBuilder BaseQuery { get; }

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
        };

        public object GetDataSource()
        {
            return
                HongLienDb.tblIndexStocks.AsNoTracking()
                    .Where(c => c.IsDeleted == false)
                    .ProjectTo<StockViewModel>()
                    .ToList()
                    .ToSortableBindingList();
        }

        public object Search(Control.ControlCollection controls)
        {
            var searchViewModel = controls.ToModel<SearchStockViewModel>();

            return
                HongLienDb.tblIndexStocks.AsNoTracking()
                    .Where(
                        c =>
                            c.IsDeleted == false && c.Note.Contains(searchViewModel.Note) &&
                            c.StockDesc.Contains(searchViewModel.StockDesc))
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
                    }
                };
            }
        }

        public ValidationModel Create(TableLayoutControlCollection controls)
        {
            throw new System.NotImplementedException();
        }

        public void Delete(object currentRowDataBoundItem)
        {
            throw new System.NotImplementedException();
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
