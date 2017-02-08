using System;
using System.Windows.Forms;
using Model.ViewModel;

namespace _4.Helper
{
    public static class ControlsBinding
    {
        public static T ToModel<T>(this Control.ControlCollection collection)
        {
            var model = Activator.CreateInstance(typeof(T));
            foreach (Control control in collection)
            {
                if (control is TextBox)
                {
                    model.TrySetProperty(control.Name, control.Text);
                }
                else if (control is ComboBox)
                {
                    var combobox = (ComboBox)control;
                    var item = (ComboboxItem)combobox.SelectedItem;
                    model.TrySetProperty(combobox.Name, item.Value);
                }
                else if (control is NumericUpDown)
                {
                    var numberic = (NumericUpDown)control;
                    model.TrySetProperty(numberic.Name, numberic.Value);
                }
                else
                {
                    model.TrySetProperty(control.Name, control.Text);
                }

            }
            return (T)model;
        }

        public static void ToModel<T>(this Control.ControlCollection collection, T model)
        {
            foreach (Control control in collection)
            {
                if (control is Panel)
                {
                    ToModel(control.Controls, model);
                }
                else
                {
                    if (control is TextBox)
                    {
                        model.TrySetProperty(control.Name, control.Text);
                    }
                    else if (control is ComboBox)
                    {
                        var combobox = (ComboBox)control;
                        var item = (ComboboxItem)combobox.SelectedItem;
                        model.TrySetProperty(combobox.Name, item.Value);
                    }
                    else if (control is NumericUpDown)
                    {
                        var numberic = (NumericUpDown)control;
                        model.TrySetProperty(numberic.Name, numberic.Value);
                    }
                    else
                    {
                        model.TrySetProperty(control.Name, control.Text);
                    }
                }

            }
        }
    }
}
