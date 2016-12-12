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
        public IQueryable<WorkingPeriodViewModel> GetWorkingPeriodList()
        {
            var result = HongLienDb.tblSysWorkingPeriods.AsNoTracking().ProjectTo(WorkingPeriodViewModel);
            return result;
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
