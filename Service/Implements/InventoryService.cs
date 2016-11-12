using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Threading.Tasks;
using Autofac;
using Model;
using Model.ViewModel;
using Service.Interfaces;

namespace Service.Implements
{
    public class InventoryService : BaseService, IInventoryServices
    {
        public InventoryService(HongLienDb hongLienDb) : base(hongLienDb)
        {
        }

        public async Task<object> GetItems()
        {
            return
                await
                    HongLienDb.tblIndexItems.AsNoTracking()
                        .Where(c => c.IsDeleted == false)
                        .Select(c => new InventoryViewModel()
                        {
                            ItemName = c.ItemName,
                            ItemId = c.KeyAutoID,
                            ItemIdDisplay = c.ItemID,
                            UnitId = c.UnitID,
                            GroupID = c.GroupID
                        })
                        .ToListAsync();
        }

        public async Task SaveInventory(List<InventoryViewModel> inventoryViewModels)
        {
            throw new System.NotImplementedException();
        }
    }
}
