using Service.Interfaces;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AutoMapper.QueryableExtensions;
using Model;
using Model.ViewModel;

namespace Service.Implements
{
    public class WorkingPeriodService : BaseService, IWorkingPeriodService
    {
        
        public List<ComboboxItem> GetList()
        {
            var model = HongLienDb.tblSysWorkingPeriods.Where(c=>c.IsDeleted == false).
                 Select(w => new ComboboxItem()
                 {
                 }).ToList();
            model.Insert(0, ComboboxItem.Empty);
            return model;
        }

        public Task<bool> InitWorkingPeriod(string sPeriod)
        {
            throw new NotImplementedException();
        }

        public WorkingPeriodService(HongLienDb hongLienDb) : base(hongLienDb)
        {
        }
    }
}
