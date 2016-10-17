using Model;

namespace Service.Implements
{
    public abstract class BaseService
    {
        protected HongLienDb HongLienDb;

        protected BaseService(HongLienDb hongLienDb)
        {
            this.HongLienDb = hongLienDb;
        }
    }
}
