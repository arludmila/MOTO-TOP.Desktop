using ReaLTaiizor.Controls;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinFormsApp.Utils
{
    public static class FormInputValidator
    {
        public static bool ValidateDungeonTextBoxNotEmpty(DungeonTextBox textBox, string fieldName)
        {
            if (string.IsNullOrWhiteSpace(textBox.Text))
            {
                MessageBoxHelper.ShowErrorMessageBox($"{fieldName} no puede estar vacio.");
                textBox.Focus();
                return false;
            }
            return true;
        }
        public static bool TryConvertDungeonTextBoxToDouble(DungeonTextBox textBox, string fieldName, out double result)
        {
            if (double.TryParse(textBox.Text, out result))
            {
                return true;
            }
            else
            {
                MessageBoxHelper.ShowErrorMessageBox($"Dato no valido para el campo {fieldName}. Por favor ingrese un número valido.");
                textBox.Focus();
                return false;
            }
        }

        public static bool TryConvertDungeonTextBoxToInt(DungeonTextBox textBox, string fieldName, out int result)
        {
            if (int.TryParse(textBox.Text, out result))
            {
                return true;
            }
            else
            {
                MessageBoxHelper.ShowErrorMessageBox($"Dato no valido para el campo {fieldName}. Por favor ingrese un número valido.");
                textBox.Focus();
                return false;
            }
        }
        public static string? ValidateAndGetDungeonTextBoxText(DungeonTextBox textBox, string fieldName)
        {
            if (ValidateDungeonTextBoxNotEmpty(textBox, fieldName))
            {
                return textBox.Text;
            }
            return null; // Return null if validation fails.
        }
    }
}
