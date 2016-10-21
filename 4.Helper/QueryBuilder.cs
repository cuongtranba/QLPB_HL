using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace _4.Helper
{
    public static class QueryBuilder
    {
        public static string BuildSearchQueryFromPanel(this Control.ControlCollection controlCollection)
        {
            var controls = controlCollection.OfType<Control>();
            var queryBuilder=new List<string>();
            foreach (var control in controls)
            {
                if (!string.IsNullOrEmpty(control.Text))
                {
                    queryBuilder.Add($" {control.Name} like @{control.Name} ");
                }
            }
            if (queryBuilder.Any())
            {
                return " Where " + string.Join(" And ", queryBuilder);
            }
            return string.Empty;
        }

        public static SqlParameter[] GetSearchParameters(this Control.ControlCollection controlCollection)
        {
            var parameters=new List<SqlParameter>();
            var controls = controlCollection.OfType<Control>();
            foreach (var control in controls)
            {
                if (!string.IsNullOrEmpty(control.Text))
                {
                    var parameter=new SqlParameter($"@{control.Name}",$"%{control.Text}%"); 
                    parameters.Add(parameter);   
                }
            }
            return parameters.ToArray();
        }
    }
}
