using System.Windows.Forms;

namespace _4.Helper
{
    public class TextBoxCustom : TextBox
    {
        private string sqlParameter;

        public string SqlParameter
        {
            get
            {
                return sqlParameter;
            }
            set
            {
                sqlParameter = string.IsNullOrEmpty(value) ? Name : value;
            }
        }
    }

   public class RichTextBoxCustom : RichTextBox
    {
        private string sqlParameter;

        public string SqlParameter
        {
            get
            {
                return sqlParameter;
            }
            set
            {
                sqlParameter = string.IsNullOrEmpty(value) ? Name : value;
            }
        }
    }

    public class NumericUpDownCustom : NumericUpDown
    {
        private string sqlParameter;

        public string SqlParameter
        {
            get
            {
                return sqlParameter;
            }
            set
            {
                sqlParameter = string.IsNullOrEmpty(value) ? Name : value;
            }
        }
    }

    public class ComboBoxCustom : ComboBox
    {
        private string sqlParameter;

        public string SqlParameter
        {
            get
            {
                return sqlParameter;
            }
            set
            {
                sqlParameter = string.IsNullOrEmpty(value) ? Name : value;
            }
        }
    }

}
