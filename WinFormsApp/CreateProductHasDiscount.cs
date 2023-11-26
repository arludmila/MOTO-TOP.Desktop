using Contracts.DTOs.Relationships;
using Contracts.Utils;
using Contracts.ViewModels;
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
    public partial class CreateProductHasDiscount : Form
    {
        public CreateProductHasDiscount()
        {
            this.StartPosition = FormStartPosition.CenterScreen;
            InitializeComponent();
            Text = "Agregar Descuento a Producto";
        }

        private async void buttonCreateProductHasDiscount_Click(object sender, EventArgs e)
        {
            DateTime dateFrom = dateTimeFrom.Value;

            DateTime dateTo = dateTimeTo.Value;
            var productHasDiscountDto = new ProductDiscountDto()
            {
                DateStart = dateFrom,
                DateEnd = dateTo,
                ProductId = Convert.ToInt32(txtBoxProductId.Text),
                DiscountId = Convert.ToInt32(txtBoxDiscountId.Text)
            };

            string response = await ApiHelper.PostAsync($"{ApiUrl.LocalUrl}product-discounts", productHasDiscountDto);

            if (response.Contains("error") || response.Contains("failed"))
            {
                MessageBoxHelper.ShowErrorMessageBox("Error al agregar descuento");
            }
            else
            {
                MessageBoxHelper.ShowSuccessMessageBox("Descuento registrado!");
                Close();
            }
        }

        private void CreateProductHasDiscount_Load(object sender, EventArgs e)
        {
            txtBoxDiscountDescription.Enabled = false;
            txtBoxDiscountId.Enabled = false;   
            txtBoxProductId.Enabled = false;
            txtBoxProductName.Enabled = false;
        }

        private void buttonSelectProduct_Click(object sender, EventArgs e)
        {
            using (ProductSelector productSelectorForm = new ProductSelector())
            {
                productSelectorForm.ProductSelected += HandleProductSelected;
                productSelectorForm.ShowDialog();
            }
        }
        private void HandleProductSelected(ProductViewModel selectedProduct)
        {
            txtBoxProductId.Text = selectedProduct.Id.ToString();

            txtBoxProductName.Text = $"{selectedProduct.CategoryName}: {selectedProduct.Name}";
        }
        private void buttonSelectDiscount_Click(object sender, EventArgs e)
        {
            using (DiscountSelector discountSelectorForm = new DiscountSelector())
            {
                discountSelectorForm.DiscountSelected += HandleDiscountSelected;
                discountSelectorForm.ShowDialog();
            }
        }
        private void HandleDiscountSelected(Discount selectedDiscount)
        {
            txtBoxDiscountId.Text = selectedDiscount.Id.ToString();

            txtBoxDiscountDescription.Text = selectedDiscount.Description;
        }
    }
}
