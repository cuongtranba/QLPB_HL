using _4.Helper;
using Model;
using Model.ViewModel;
using Service.Interfaces;
using System.Collections.Generic;
using System.Text;
using System.Windows.Forms;

namespace Service.Implements
{
    public class InOutReasonCategoryService:BaseService,ICategoryService
    {
        public InOutReasonCategoryService(HongLienDb hongLienDb) : base(hongLienDb)
        {
        }

        public StringBuilder BaseQuery { get; }
        public List<ControlViewModel> GetSearchComponent { get; }
        public object GetDataSource()
        {
            throw new System.NotImplementedException();
        }

        public object Search(Control.ControlCollection controls)
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
