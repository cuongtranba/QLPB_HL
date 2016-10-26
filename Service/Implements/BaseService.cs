using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
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

        public virtual void Delete<T>(string id) where T : class
        {
            var dbSet = HongLienDb.Set<T>();
            var entity = dbSet.Find(id);
            entity.TrySetProperty("IsDeleted",true);
            HongLienDb.SaveChanges();
        }

        public List<ValidationResult> TryValidate(object viewmodel)
        {
            var validationContext = new ValidationContext(viewmodel, null, null);
            var results = new List<ValidationResult>();
            Validator.TryValidateObject(viewmodel, validationContext, results, true);
            return results;
        }
    }
}
