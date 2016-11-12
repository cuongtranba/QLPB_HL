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

        public async Task<List<ComboboxItem>> GetStock()
        {
            return await
                HongLienDb.tblIndexStocks.AsNoTracking()
                    .Where(c => c.IsDeleted == false)
                    .Select(c => new ComboboxItem()
                    {
                        Text = c.StockDesc,
                        Value = c.KeyAutoID
                    })
                    .ToListAsync();
        }

        public async Task<List<ComboboxItem>> GetItemGroup()
        {
            return
                await
                    HongLienDb.tblIndexItemGroups.AsNoTracking()
                        .Where(c => c.IsDeleted == false)
                        .Select(c => new ComboboxItem()
                        {
                            Text = c.GroupName,
                            Value = c.KeyAutoID
                        })
                        .ToListAsync();
        }
    }
}
