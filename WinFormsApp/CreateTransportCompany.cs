using Contracts.DTOs.Entities;
using Contracts.Utils;
using Entities.Relationships;
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
    public partial class CreateTransportCompany : Form
    {
        public CreateTransportCompany()
        {
            
            this.StartPosition = FormStartPosition.CenterScreen;
            InitializeComponent();
            Text = "Agregar Empresa de Transporte";
        }

        private async void buttonCreateTransportCompany_Click(object sender, EventArgs e)
        {
            string name = FormInputValidator.ValidateAndGetDungeonTextBoxText(txtBoxName, "Name");
            string phoneNumber = FormInputValidator.ValidateAndGetDungeonTextBoxText(txtBoxPhoneNumber, "Phone Number");

            if (name != null && phoneNumber != null)
            {
                var transportCompanyDto = new TransportCompanyDto()
                {
                    Name = name,
                    PhoneNumber = phoneNumber,
                };

                string response = await ApiHelper.PostAsync("https://localhost:7215/api/transport-companies", transportCompanyDto);

                if (response.Contains("error"))
                {
                    MessageBoxHelper.ShowErrorMessageBox("Error al crear empresa");
                }
                else
                {
                    MessageBoxHelper.ShowSuccessMessageBox("Empresa registrada!");
                    Close();
                }
            }
            else
            {
                MessageBoxHelper.ShowErrorMessageBox("Datos no validos. Por favor complete todos los campos requeridos.");
            }

        }
    }
}
