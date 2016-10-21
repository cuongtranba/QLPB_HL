using Model;
using System.Collections.Generic;
using System.Text;
using System.Windows.Forms;

namespace Service.Interfaces
{
    public interface ICategoryService
    {
        StringBuilder BaseQuery { get; }
        object GetDataSource();
        List<ControlViewModel> GetSearchComponent();
        object Search(Control.ControlCollection controls);
        List<ControlViewModel> GetCRUDComponent();
    }
}
