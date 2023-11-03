using Contracts.DTOs.Entities;
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
    public partial class CreateProduct : Form
    {
        private double _profitMarginPercentage;
        private double _purchasePrice;
        public CreateProduct()
        {

            this.StartPosition = FormStartPosition.CenterScreen;
            InitializeComponent();
            Text = "Agregar Producto";
        }

        private async void buttonCreateProduct_Click(object sender, EventArgs e)
        {
            Category selectedCategory = (Category)comboBoxCategories.SelectedItem;
            int categoryId = 0;
            if (selectedCategory != null)
            {
                categoryId = selectedCategory.Id;
            }

            double sellingPrice;
            int quantity;
            string name = FormInputValidator.ValidateAndGetDungeonTextBoxText(txtBoxName, "Name")!;
            string description = FormInputValidator.ValidateAndGetDungeonRichTextBoxText(txtBoxDescription, "Description")!;
            if (FormInputValidator.TryConvertDungeonTextBoxToDouble(txtBoxSellingPrice, "SellingPrice", out sellingPrice) &&
                FormInputValidator.TryConvertDungeonTextBoxToInt(txtBoxQuantity, "Quantity", out quantity))
            {
                var product = new ProductDto()
                {
                    Name = name,
                    Description = description,
                    SellingPrice = sellingPrice,
                    Quantity = quantity,
                    CategoryId = categoryId,
                    PurchasePrice = _purchasePrice,
                };

                string response = await ApiHelper.PostAsync($"{ApiUrl.LocalUrl}products", product);


                if (response.Contains("error") || response.Contains("failed"))
                {
                    MessageBoxHelper.ShowErrorMessageBox("Error al agregar producto");
                }
                else
                {
                    MessageBoxHelper.ShowSuccessMessageBox("Producto agregado!");
                    Close();
                }
                Close();
            }

        }

        private async void CreateProduct_Load(object sender, EventArgs e)
        {
            var categories = await ApiHelper.GetListAsync<Category>($"{ApiUrl.LocalUrl}categories");
            if (categories != null)
            {
                comboBoxCategories.DataSource = new BindingList<Category>(categories);
                comboBoxCategories.DisplayMember = "Name";
                comboBoxCategories.ValueMember = "Id";
            }

        }

        private void txtBoxProfitMargin_TextChanged(object sender, EventArgs e)
        {
            if (FormInputValidator.TryConvertDungeonTextBoxToDouble(txtBoxProfitMargin, "ProfitMargin", out _profitMarginPercentage))
            {
                UpdateSellingPrice();
            }
        }

        private void txtBoxPurchasePrice_TextChanged(object sender, EventArgs e)
        {
            if (FormInputValidator.TryConvertDungeonTextBoxToDouble(txtBoxPurchasePrice, "PurchasePrice", out _purchasePrice))
            {
                UpdateSellingPrice();
            }
        }
        private void UpdateSellingPrice()
        {
            double sellingPrice = _purchasePrice + (_purchasePrice * (_profitMarginPercentage / 100));
            txtBoxSellingPrice.Text = sellingPrice.ToString();
        }
    }
}
