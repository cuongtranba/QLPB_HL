using System.Collections.Generic;
using System.Threading.Tasks;
using Model.ViewModel;

namespace Service.Interfaces
{
    public interface IInventoryServices
    {
        Task<object> GetItems();
        Task SaveInventory(List<InventoryViewModel> inventoryViewModels);
    }
}
