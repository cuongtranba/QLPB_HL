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
        public string Title => "Tồn đầu kì";
        public InventoryService(HongLienDb hongLienDb) : base(hongLienDb)
        {
        }


        public IQueryable<InventoryViewModel> GetItemsQuery()
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
                            GroupID = p3.KeyAutoID,
                            ItemId = p1.ItemID,
                            ItemIdDisplay = p1.ItemID,
                            StockName = p2.StockDesc,
                            UnitId = p1.UnitID,
                            StockId = p2.KeyAutoID
                        };
            return query;
        }



        public async Task<object> GetItems()
        {

            var model = await GetItemsQuery().ToListAsync();
            return model.ToSortableBindingList();
        }

        public async Task SaveInventory(List<InventoryViewModel> inventoryViewModels)
        {
            throw new System.NotImplementedException();
        }

        public async Task<object> Search(SearchInventoryViewModel model)
        {
            List<InventoryViewModel> items;
            if (!string.IsNullOrEmpty(model.StockId))
            {
                items = await GetItemsQuery().Where(c => c.StockId == model.StockId).ToListAsync();
                return items.ToSortableBindingList();
            }
            if (!string.IsNullOrEmpty(model.GroupID))
            {
                items = await GetItemsQuery().Where(c => c.GroupID == model.GroupID).ToListAsync();
                return items.ToSortableBindingList();
            }
            return GetItemsQuery().ToList().ToSortableBindingList();
        }
    }
}
