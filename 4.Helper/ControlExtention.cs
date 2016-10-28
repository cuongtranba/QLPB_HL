using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using Model.ViewModel;

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

        public static void SetValue(this Control.ControlCollection collection, string name, object value)
        {
            foreach (Control control in collection)
            {
                if (control.Name == name)
                {
                    if (control is TextBox)
                    {
                        control.Text = (string)value;
                    }
                    else if (control is ComboBox)
                    {
                        var combobox = (ComboBox)control;
                        var dataSource = (List<ComboboxItem>)combobox.DataSource;
                        var selectedItem = dataSource.Find(c => c.Value != null && c.Value.ToString() == value.ToString());
                        combobox.SelectedItem = selectedItem;
                    }
                    else if (control is RichTextBox)
                    {
                        control.Text = (string)value;
                    }
                    else if (control is NumericUpDown)
                    {
                        var numerricUpdown = (NumericUpDown)control;
                        numerricUpdown.Value = (decimal)value;
                    }
                }
            }
        }

        public static void ToControls(this object source, Control.ControlCollection destination)
        {
            foreach (var propertyInfo in source.GetType().GetProperties())
            {
                var value = propertyInfo.GetValue(source);
                if (value != null)
                {
                    destination.SetValue(propertyInfo.Name, value);
                }
            }
        }
    }
}
