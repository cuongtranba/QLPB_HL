using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Threading.Tasks;
using Autofac;
using LinqKit;
using Model;
using Model.ViewModel;
using Service.Interfaces;
using _4.Helper;

namespace Service.Implements
{
    public class InventoryService : BaseService, IInventoryServices
    {
        public InventoryService(HongLienDb hongLienDb) : base(hongLienDb)
        {
        }

        public async Task<object> GetItems()
        {

            var query = from p1 in HongLienDb.tblIndexItems.AsNoTracking().AsExpandable()
                        join p2 in HongLienDb.tblIndexStocks.AsNoTracking() on p1.StockID equals p2.KeyAutoID into itemsStock
                        from p2 in itemsStock.DefaultIfEmpty()
                        join p3 in HongLienDb.tblIndexItemGroups.AsNoTracking().AsExpandable() on p1.GroupID equals p3.KeyAutoID
                        into itemGroup
                        from p3 in itemGroup.DefaultIfEmpty()
                        where p1.IsDeleted == false
                        select new InventoryViewModel()
                        {
                            ItemName = p1.ItemName,
                            GroupName = p3.GroupName,
                            GroupID = p1.GroupID,
                            ItemId = p1.ItemID,
                            ItemIdDisplay = p1.ItemID,
                            StockName = p2.StockDesc,
                            UnitId = p1.UnitID
                        };
            var model = await query.ToListAsync();
            return model.ToSortableBindingList();
        }

        public async Task SaveInventory(List<InventoryViewModel> inventoryViewModels)
        {
            throw new System.NotImplementedException();
        }
    }
}
