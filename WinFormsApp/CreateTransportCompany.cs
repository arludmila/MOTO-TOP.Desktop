using Contracts.DTOs.Entities;
using Contracts.Utils;
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
            string name = FormInputValidator.ValidateAndGetDungeonTextBoxText(txtBoxName, "Name")!;
            string phoneNumber = FormInputValidator.ValidateAndGetDungeonTextBoxText(txtBoxPhoneNumber, "Phone Number")!;
            string email = FormInputValidator.ValidateAndGetDungeonTextBoxText(txtBoxEmail, "Email")!;
            if (name != null && phoneNumber != null && email != null)
            {
                var transportCompanyDto = new TransportCompanyDto()
                {
                    Name = name,
                    PhoneNumber = phoneNumber,
                    Email = email
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
