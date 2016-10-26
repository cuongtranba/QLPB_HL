using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace _4.Helper
{
    public static class ControlExtention
    {
        public static void ClearValue(this TableLayoutControlCollection controls)
        {
            foreach (var control in controls)
            {
                if (control is TextBox)
                {
                    TextBox textBox = (TextBox)control;
                    textBox.Text = string.Empty;
                }

                if (control is ComboBox)
                {
                    ComboBox comboBox = (ComboBox)control;
                    if (comboBox.Items.Count > 0)
                        comboBox.SelectedIndex = 0;
                }

                if (control is CheckBox)
                {
                    CheckBox checkBox = (CheckBox)control;
                    checkBox.Checked = false;
                }

                if (control is ListBox)
                {
                    ListBox listBox = (ListBox)control;
                    listBox.ClearSelected();
                }
                if (control is NumericUpDown)
                {
                    var numericUpDown = (NumericUpDown)control;
                    numericUpDown.Value = 0;
                }
                if (control is RichTextBox)
                {
                    var richTextBox = (RichTextBox)control;
                    richTextBox.Text = string.Empty;
                }
            }
        }

        public static string GetValueByName(this Control.ControlCollection collection, string name)
        {
            var values = collection.Find(name, false);
            if (values.Any())
            {
                return values.FirstOrDefault().Text;
            }
            return string.Empty;
        }

        public static DialogResult ShowErrorField(ValidationModel validationModel)
        {
            return MessageBox.Show(validationModel.AllErrorMessage, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }


    }
}
