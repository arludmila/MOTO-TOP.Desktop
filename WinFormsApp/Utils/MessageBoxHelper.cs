using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinFormsApp.Utils
{
    public static class MessageBoxHelper
    {
        public static void ShowInfoMessageBox(string message)
        {
           MessageBox.Show(message, "Info",MessageBoxButtons.OK,MessageBoxIcon.Information);
        }
        public static void ShowSuccessMessageBox(string message)
        {
            MessageBox.Show(message, "Exito", MessageBoxButtons.OK, MessageBoxIcon.None);
        }
        public static void ShowErrorMessageBox(string message)
        {
            MessageBox.Show(message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
        public static void ShowErrorMessageBox(string message, string description)
        {
            using (var form = new MessageBoxWithDetails())
            {
                form.Title = message;
                form.Description = description;
                form.ShowDialog();
            }
        }
    }
}
