using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace _4.Helper
{
    public static class ControlExtention
    {
        public static IEnumerable<Control> ClearValue(this IEnumerable<Control> controls)
        {
            var clearValue = controls as Control[] ?? controls.ToArray();
            foreach (var control in clearValue)
            {
                if (!string.IsNullOrEmpty(control.Name))
                {
                    control.Text = string.Empty;
                }
            }
            return clearValue;
        }

        public static string GetValueByName(this Control.ControlCollection collection,string name)
        {
            var values = collection.Find(name,false);
            if (values.Any())
            {
                return values.FirstOrDefault().Text;
            }
            return string.Empty;
        }
    }
}
