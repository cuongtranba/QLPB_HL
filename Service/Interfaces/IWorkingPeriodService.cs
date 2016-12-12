using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Model.ViewModel;

namespace Service.Interfaces
{
    public interface IWorkingPeriodService 
    {
        Task<bool> InitWorkingPeriod(string sPeriod);
        IQueryable<WorkingPeriodViewModel> GetWorkingPeriodList();
    }
}
