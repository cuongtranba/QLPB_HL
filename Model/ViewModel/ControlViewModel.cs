using System.Windows.Forms;

namespace Model.ViewModel
{
    public class ControlViewModel
    {
        public Control Control { get; set; }
        public Label Label { get; set; }
        private string sqlParameter;

        public string SqlParameter
        {
            get
            {
                return string.IsNullOrEmpty(sqlParameter) ? Control.Name : sqlParameter;
            }
            set
            {
                sqlParameter = value;
            }
        }
    }
}