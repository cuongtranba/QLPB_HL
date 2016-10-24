using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Windows.Forms;
using Model.ViewModel;

namespace Service.Helper
{
    public static class QueryBuilderHelper
    {
        public static QueryParameterViewModel BuildSearchQueryFormControl(this Control.ControlCollection controlCollection,
            List<ControlViewModel> controlViewModels)
        {
            var model = new QueryParameterViewModel();
            var controls = controlCollection.OfType<Control>();
            var queryBuilder = new List<string>();
            foreach (var control in controls)
            {
                if (!string.IsNullOrEmpty(control.Text) && !string.IsNullOrEmpty(control.Name))
                {
                    var controlViewModel = controlViewModels.FirstOrDefault(c => c.Control.Name == control.Name);
                    decimal decimalResult;
                    if (decimal.TryParse(control.Text, out decimalResult))
                    {
                        queryBuilder.Add($" {controlViewModel.Control.Name} = @{controlViewModel.SqlParameter} ");
                        model.SqlParameter.Add(new SqlParameter(controlViewModel.SqlParameter, decimalResult));
                    }
                    else
                    {
                        queryBuilder.Add($" {controlViewModel.Control.Name} like @{controlViewModel.SqlParameter} ");
                        model.SqlParameter.Add(new SqlParameter(controlViewModel.SqlParameter, $"%{control.Text}%"));
                    }
                }
            }
            if (queryBuilder.Any())
            {
                model.SqlQuery = string.Join(" And ", queryBuilder);
            }
            return model;
        }
    }
}
