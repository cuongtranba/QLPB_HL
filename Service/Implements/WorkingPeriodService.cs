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
        
        public async Task<List<ComboboxItem>> GetList()
        {
            var model = await HongLienDb.tblSysWorkingPeriods.AsNoTracking()
               
                .Select(w => new ComboboxItem()
                 {
                    Text = w.KeyAutoID,
                    Value = w.Period
                 }).ToListAsync();

            model.Insert(0, ComboboxItem.Empty);
            return  model;
        }
        public async Task<DateTime> GetServerDatetime()
        {
            var dateQuery = HongLienDb.Database.SqlQuery<DateTime>("SELECT getdate()");
            return dateQuery.AsEnumerable().FirstOrDefault();
        }

        public async Task<bool> InitWorkingPeriod()
        {
            DateTime dServerNow = await GetServerDatetime();
            var dPeriod = HongLienDb.tblSysWorkingPeriods.FirstOrDefault()
                .KeyAutoID
                .Equals(dServerNow.ToString("yyyyMM"));
            if (dPeriod != true)
            {
                tblSysWorkingPeriod newPeriod = new tblSysWorkingPeriod();
                newPeriod.KeyAutoID = dServerNow.ToString("yyyyMM");
                DateTime dtimeTemp = dServerNow.AddMonths(1);

                newPeriod.Period = dServerNow.ToString("yyyyMM");
                newPeriod.FromDate = dServerNow.AddDays(1 - dServerNow.Day);
                newPeriod.ToDate = dtimeTemp.AddDays(-1 - dtimeTemp.Day);
                newPeriod.IsDeleted = false;
                base.Update<tblSysWorkingPeriod>(newPeriod);
            }
            return true;
        }

        public WorkingPeriodService(HongLienDb hongLienDb) : base(hongLienDb)
        {
        }
    }
}
