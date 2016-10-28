using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Model;
using Model.ViewModel;
using Service.Interfaces;
using _4.Helper;

namespace Service.Implements
{
    public class StockCategoryService:BaseService,ICategoryService<tblIndexStock>
    {
        public StockCategoryService(HongLienDb hongLienDb) : base(hongLienDb)
        {
        }

        public StringBuilder BaseQuery { get; }

        public List<ControlViewModel> GetSearchComponent => new List<ControlViewModel>()
        {
            new ControlViewModel()
            {
                Control = new TextBox()
                {
                    
                }
            }
        };
       

        public SortableBindingList<tblIndexStock> GetDataSource()
        {
            throw new System.NotImplementedException();
        }

        public SortableBindingList<tblIndexStock> Search(Control.ControlCollection controls)
        {
            throw new System.NotImplementedException();
        }

        public List<ControlViewModel> GetCRUDComponent { get; }
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
            throw new System.NotImplementedException();
        }

        public ValidationModel Update(TableLayoutControlCollection controls)
        {
            throw new System.NotImplementedException();
        }
    }
}
