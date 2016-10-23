using System.Dynamic;
using Model;
using _4.Helper;

namespace Service.Implements
{
    public abstract class BaseService
    {
        protected HongLienDb HongLienDb;

        protected BaseService(HongLienDb hongLienDb)
        {
            this.HongLienDb = hongLienDb;
        }

        public virtual void Delete<T>(int id) where T : class
        {
            var dbSet = HongLienDb.Set<T>();
            var entity = dbSet.Find(id);
            entity.TrySetProperty("IsDeleted",true);
            HongLienDb.SaveChanges();
        }
    }
}
