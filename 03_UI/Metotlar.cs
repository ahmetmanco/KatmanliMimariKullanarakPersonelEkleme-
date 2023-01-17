using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03_UI
{
    internal static class Metotlar
    {
        internal static void Temizle(GroupBox grup)
        {
            foreach (var item in grup.Controls)
            {
                if (item is TextBox)
                {
                    ((TextBox)item).Text = "";
                }
                else if (item is ComboBox)
                {
                    ((ComboBox)item).SelectedItem = -1;
                }
                else if (item is RadioButton)
                {
                    ((RadioButton)item).Checked = false;
                }
                else if (item is DateTimePicker)
                {
                    ((DateTimePicker)item).Value = DateTime.Now;
                }
                else if (item is ListBox)
                {
                    ((ListBox)item).DataSource = null;
                }
                else if (item is MaskedTextBox)
                {
                    ((MaskedTextBox)item).Text = "";
                }
            }
        }

        internal static bool BosVarmi(GroupBox grup)
        {
            bool flag = false;
            foreach (var item in grup.Controls)
            {
                if (item is TextBox)
                    flag = ((TextBox)item).Text.Trim() == "";
                //else if (item is ComboBox)
                //    flag = ((ComboBox)item).SelectedIndex == -1;
                else if (item is DateTimePicker)
                    flag = ((DateTimePicker)item).Value == DateTime.Now;
                else if (item is RadioButton)
                    flag = ((RadioButton)item).Checked == true;

                if (flag) return true;
            }
            return flag;
        }
    }
}
