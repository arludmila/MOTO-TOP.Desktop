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
    public partial class CreateSeller : Form
    {
        public CreateSeller()
        {

            this.StartPosition = FormStartPosition.CenterScreen;
            InitializeComponent();
            Text = "Agregar Vendedor";
        }

        private async void buttonCreateSeller_Click(object sender, EventArgs e)
        {

            PasswordHasher<string> passwordHasher = new();

            string firstName = FormInputValidator.ValidateAndGetDungeonTextBoxText(txtBoxFirstName, "First Name")!;
            string lastName = FormInputValidator.ValidateAndGetDungeonTextBoxText(txtBoxLastName, "Last Name")!;
            string password = FormInputValidator.ValidateAndGetDungeonTextBoxText(txtBoxPassword, "Password")!;
            string email = FormInputValidator.ValidateAndGetDungeonTextBoxText(txtBoxEmail, "Email")!;
            string zone = FormInputValidator.ValidateAndGetDungeonTextBoxText(txtBoxZone, "Zone")!;
            string docNumber = FormInputValidator.ValidateAndGetDungeonTextBoxText(txtBoxDocNumber, "Document Number")!;
            if (firstName != null && lastName != null && email != null && zone != null && docNumber != null)
            {
                PersonDocType selectedDocType = (PersonDocType)comboBoxDocType.SelectedItem;
                var registerDto = new SellerRegisterDto()
                {
                    FirstName = firstName,
                    LastName = lastName,
                    PasswordHash = passwordHasher.HashPassword(string.Empty, password),
                    Email = email,
                    Zone = zone,
                    DocumentNumber = docNumber,
                    DocumentType = selectedDocType,
                };

                string response = await ApiHelper.PostAsync("https://localhost:7215/api/sellers/register", registerDto);

                if (response.Contains("error") || response.Contains("failed"))
                {
                    MessageBoxHelper.ShowErrorMessageBox("Error al registrar vendedor");
                }
                else
                {
                    MessageBoxHelper.ShowSuccessMessageBox("Vendedor registrado!");
                    Close();
                }
            }
            else
            {
                MessageBoxHelper.ShowErrorMessageBox("Datos no validos. Por favor complete todos los campos requeridos.");
            }
        }
        private void CreateSeller_Load(object sender, EventArgs e)
        {
            txtBoxPassword.UseSystemPasswordChar = true;
            comboBoxDocType.DataSource = Enum.GetValues(typeof(PersonDocType));
        }
    }
}
