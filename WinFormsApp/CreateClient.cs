using Contracts.DTOs.Entities;
using Contracts.Utils;
using Entities.Enums;
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
    public partial class CreateClient : Form
    {
        public CreateClient()
        {

            this.StartPosition = FormStartPosition.CenterScreen;
            InitializeComponent();
            Text = "Agregar Cliente";
        }

        private async void buttonCreateClient_Click(object sender, EventArgs e)
        {
            string firstName = FormInputValidator.ValidateAndGetDungeonTextBoxText(txtBoxFirstName, "First Name")!;
            string lastName = FormInputValidator.ValidateAndGetDungeonTextBoxText(txtBoxLastName, "Last Name")!;
            string location = FormInputValidator.ValidateAndGetDungeonTextBoxText(txtBoxLocation, "Location")!;
            string phoneNumber = FormInputValidator.ValidateAndGetDungeonTextBoxText(txtBoxPhoneNumber, "Phone Number")!;
            string docNumber = FormInputValidator.ValidateAndGetDungeonTextBoxText(txtBoxDocNumber, "Document Type")!;
            string email = FormInputValidator.ValidateAndGetDungeonTextBoxText(txtBoxEmail, "Email")!;
            if (firstName != null && lastName != null && location != null && phoneNumber != null && docNumber!= null && email != null)
            {
                PersonDocType selectedDocType = (PersonDocType)comboBoxDocType.SelectedItem;
                var clientDto = new ClientDto()
                {
                    FirstName = firstName,
                    LastName = lastName,
                    Location = location,
                    PhoneNumber = phoneNumber,
                    DocumentType = selectedDocType,
                    DocumentNumber = docNumber,
                    Email = email
                };


                string response = await ApiHelper.PostAsync($"{ApiUrl.LocalUrl}clients", clientDto);

                if (response.Contains("error"))
                {
                    MessageBoxHelper.ShowErrorMessageBox("Error al agregar cliente");
                }
                else
                {
                    MessageBoxHelper.ShowSuccessMessageBox("Cliente agregado!");
                    Close();
                }
                Close();
            }
           

        }

        private void CreateClient_Load(object sender, EventArgs e)
        {
            comboBoxDocType.DataSource = Enum.GetValues(typeof(PersonDocType));
        }
    }
}
