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
    }
}
