using ReaLTaiizor.Controls;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinFormsApp.Utils
{
    public static class FormInputClearer
    {
        public static  void ClearDungeonTextBoxes(params DungeonTextBox[] textBoxes)
        {
            foreach (var textBox in textBoxes)
            {
                textBox.Text = string.Empty;
            }
        }
    }
}
