using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model.ViewModel
{
    public class WorkingPeriodViewModel
    {
        public string KeyAutoID { get; set; }
        public string Period { get; set; }
        public DateTime BeginByDate { get; set; }
        public DateTime EndByDate { get; set; }
    }
}
