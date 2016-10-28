using System.Collections.Generic;
using System.Text;
using System.Windows.Forms;
using Model.ViewModel;
using _4.Helper;

namespace Service.Interfaces
{
    public interface ICategoryService
    {
        StringBuilder BaseQuery { get; }
        List<ControlViewModel> GetSearchComponent { get; }
        SortableBindingList<ItemViewModel> GetDataSource();
        SortableBindingList<ItemViewModel> Search(Control.ControlCollection controls);
        List<ControlViewModel> GetCRUDComponent { get; }
        ValidationModel Create(TableLayoutControlCollection controls);
        void Delete(object currentRowDataBoundItem);
        void HiddentColumns(DataGridView danhMucGridView);
        ValidationModel Update(TableLayoutControlCollection controls);
    }
}
