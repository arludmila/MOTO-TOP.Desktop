using Contracts.DTOs.Entities;
using Contracts.Utils;
using Entities.Enums;
using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WinFormsApp.Utils;

namespace WinFormsApp
{
    public partial class CreateOfficeWorker : Form
    {
        public CreateOfficeWorker()
        {
            this.StartPosition = FormStartPosition.CenterScreen;
            InitializeComponent();
            Text = "Agregar empleado central";
        }

        private async void buttonCreateOfficeWorker_Click(object sender, EventArgs e)
        {
            // TODO: terminar implementacion... falta todo el controller API de esta entidad...
            PasswordHasher<string> passwordHasher = new();

            string firstName = FormInputValidator.ValidateAndGetDungeonTextBoxText(txtBoxFirstName, "First Name")!;
            string lastName = FormInputValidator.ValidateAndGetDungeonTextBoxText(txtBoxLastName, "Last Name")!;
            string password = FormInputValidator.ValidateAndGetDungeonTextBoxText(txtBoxPassword, "Password")!;
            string email = FormInputValidator.ValidateAndGetDungeonTextBoxText(txtBoxEmail, "Email")!;
            string docNumber = FormInputValidator.ValidateAndGetDungeonTextBoxText(txtBoxDocNumber, "Document Number")!;
            if (firstName != null && lastName != null && email != null && docNumber != null)
            {
                PersonDocType selectedDocType = (PersonDocType)comboBoxDocType.SelectedItem;
                var registerDto = new UserDto()
                {
                    FirstName = firstName,
                    LastName = lastName,
                    PasswordHash = passwordHasher.HashPassword(string.Empty, password),
                    Email = email,
                    DocumentNumber = docNumber,
                    DocumentType = selectedDocType,
                };

                string response = await ApiHelper.PostAsync("https://localhost:7215/api/office-workers/register", registerDto);

                if (response.Contains("error") || response.Contains("failed"))
                {
                    MessageBoxHelper.ShowErrorMessageBox("Error al registrar empleado de central");
                }
                else
                {
                    MessageBoxHelper.ShowSuccessMessageBox("Empleado de central registrado!");
                    Close();
                }
            }
            else
            {
                MessageBoxHelper.ShowErrorMessageBox("Datos no validos. Por favor complete todos los campos requeridos.");
            }
        }

        private void CreateOfficeWorker_Load(object sender, EventArgs e)
        {
            txtBoxPassword.UseSystemPasswordChar = true;
            comboBoxDocType.DataSource = Enum.GetValues(typeof(PersonDocType));
        }
    }
}
