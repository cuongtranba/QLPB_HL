using System;
using System.Collections.Generic;
using System.Data.SqlClient;

namespace Model.ViewModel
{
    public class QueryParameterViewModel
    {
        public string SqlQuery { get; set; }
        public List<SqlParameter> SqlParameter { get; set; }

        public QueryParameterViewModel()
        {
            SqlParameter = new List<SqlParameter>();
        }
    }
}
