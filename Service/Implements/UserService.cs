using System.Collections.Generic;
using System.Data.Entity;
using System.Threading.Tasks;
using Model;
using Model.ViewModel;
using Service.Interfaces;

namespace Service.Implements
{
    public class UserService : BaseService, IUserService
    {
        WorkingPeriodService wSer;
        public UserService(HongLienDb hongLienDb) : base(hongLienDb)
        {
            wSer = new WorkingPeriodService(hongLienDb);
        }
        public async Task<bool> Login(LoginViewModel model)
        {
            var result =
                HongLienDb.tblSysUsers.AsNoTracking()
                    .AnyAsync(c => c.UserID == model.UserName && c.UserPass == model.Password);
            return await result;
        }

        public async Task<List<ComboboxItem>> GetUserWorkingDay()
        {
            return wSer.GetList();
        }
    }
}
