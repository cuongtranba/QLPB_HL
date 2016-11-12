using System.Collections.Generic;
using System.Threading.Tasks;
using Model.ViewModel;

namespace Service.Interfaces
{
    public interface ICommonService
    {
        Task<List<ComboboxItem>> GetStock();
        Task<List<ComboboxItem>> GetItemGroup();
    }
}
