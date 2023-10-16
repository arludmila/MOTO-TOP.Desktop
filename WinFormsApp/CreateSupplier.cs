using Contracts.DTOs.Entities;
using Contracts.Utils;
using WinFormsApp.Utils;

namespace WinFormsApp
{
    public partial class CreateSupplier : Form
    {
        public CreateSupplier()
        {

            this.StartPosition = FormStartPosition.CenterScreen;
            InitializeComponent();
            Text = "Agregar Proveedor";
        }

        private async void buttonCreateSupplier_Click(object sender, EventArgs e)
        {
            string name = FormInputValidator.ValidateAndGetDungeonTextBoxText(txtBoxName, "Name")!;
            string phoneNumber = FormInputValidator.ValidateAndGetDungeonTextBoxText(txtBoxPhoneNumber, "Phone Number")!;
            string email = FormInputValidator.ValidateAndGetDungeonTextBoxText(txtBoxEmail, "Email")!;
            if (name != null && phoneNumber != null && email != null)
            {
                var supplier = new SupplierDto()
                {
                    Name = name,
                    PhoneNumber = phoneNumber,
                    Email = email,
                };

                string response = await ApiHelper.PostAsync("https://localhost:7215/api/suppliers", supplier);

                if (response.Contains("error") || response.Contains("failed"))
                {
                    MessageBoxHelper.ShowErrorMessageBox("Error al registrar proveedor");
                }
                else
                {
                    MessageBoxHelper.ShowSuccessMessageBox("Proveedor registrado!");
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
