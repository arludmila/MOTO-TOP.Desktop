using Contracts.DTOs.Entities;
using Contracts.Utils;

namespace WinFormsApp
{
    public partial class CreateSupplier : Form
    {
        public CreateSupplier()
        {
            InitializeComponent();
        }

        private async void buttonCreateSupplier_Click(object sender, EventArgs e)
        {
            var supplier = new SupplierDto()
            {
                Name = txtBoxName.Text,
                PhoneNumber = txtBoxPhoneNumber.Text,
            };
            await ApiHelper.PostAsync("https://localhost:7215/api/suppliers", supplier);
            this.Close();
        }
    }
}
