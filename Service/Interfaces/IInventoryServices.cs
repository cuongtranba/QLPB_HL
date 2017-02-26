using System.Collections.Generic;
using System.Threading.Tasks;
using Model.ViewModel;

namespace Service.Interfaces
{
    public interface IInventoryServices
    {
        string Title { get; }
        Task<object> GetItems();
        Task SaveInventory(List<InventoryViewModel> inventoryViewModels);
        Task<object> Search(SearchInventoryViewModel model);
        Task<double> GetSum(string date);
        Task Create(object currentRowDataBoundItem, string period);
    }
}
