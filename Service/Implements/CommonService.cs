using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Threading.Tasks;
using Model;
using Model.ViewModel;
using Service.Interfaces;

namespace Service.Implements
{
    public class CommonService:BaseService,ICommonService
    {
        public CommonService(HongLienDb hongLienDb) : base(hongLienDb)
        {

        }

        public async Task<List<ComboboxItem>> GetCustomer()
        {
            var model = await HongLienDb.tblIndexObjects
                    .Where(c => c.IsDeleted == true)
                    .Select(c => new ComboboxItem()
                    {
                        Text = c.ObjectName,
                        Value = c.KeyAutoID
                    })
                    .ToListAsync();
            model.Insert(0, ComboboxItem.Empty);
            return model;
        }
        public async Task<List<ComboboxItem>> GetStock()
        {
            var model = await HongLienDb.tblIndexStocks.AsNoTracking()
                    .Where(c => c.IsDeleted == false)
                    .Select(c => new ComboboxItem()
                    {
                        Text = c.StockDesc,
                        Value = c.KeyAutoID
                    })
                    .ToListAsync();
            model.Insert(0, ComboboxItem.Empty);
            return model;
        }

        public async Task<List<ComboboxItem>> GetItemGroup()
        {
            var model = await HongLienDb.tblIndexItemGroups.AsNoTracking()
                        .Where(c => c.IsDeleted == false)
                        .Select(c => new ComboboxItem()
                        {
                            Text = c.GroupName,
                            Value = c.KeyAutoID
                        })
                        .ToListAsync();
            model.Insert(0, ComboboxItem.Empty);
            return model;
        }
    }
}
