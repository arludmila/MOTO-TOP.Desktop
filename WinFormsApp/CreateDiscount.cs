using Contracts.DTOs.Entities;
using Contracts.DTOs.Relationships;
using Contracts.Utils;
using Entities.Core;
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
    public partial class CreateDiscount : Form
    {
        public CreateDiscount()
        {
            this.StartPosition = FormStartPosition.CenterScreen;
            InitializeComponent();
            Text = "Agregar Descuento";
        }

        private async void buttonCreateDiscount_Click(object sender, EventArgs e)
        {
            var percentage = Convert.ToDouble(txtBoxPercentage.Text)/100;
            var discountDto = new DiscountDto()
            {
                Description = txtBoxDescription.Text,
                Percentage = percentage
            };
            string response = await ApiHelper.PostAsync($"{ApiUrl.LocalUrl}discounts", discountDto);

            if (response.Contains("error") || response.Contains("failed"))
            {
                MessageBoxHelper.ShowErrorMessageBox("Error al crear descuento");
            }
            else
            {
                MessageBoxHelper.ShowSuccessMessageBox("Descuento registrado!");
                Close();
            }
        }
    }
}
