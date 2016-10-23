using Model;
using System.Collections.Generic;
using System.Text;
using System.Windows.Forms;
using Model.ViewModel;

namespace Service.Interfaces
{
    public interface ICategoryService
    {
        StringBuilder BaseQuery { get; }
        List<ControlViewModel> GetSearchComponent { get; }
        object GetDataSource();
        object Search(Control.ControlCollection controls);
        List<ControlViewModel> GetCRUDComponent { get; }
    }
}
