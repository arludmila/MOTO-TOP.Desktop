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
        public CreateProduct()
        {
            
            this.StartPosition = FormStartPosition.CenterScreen;
            InitializeComponent();
            Text = "Agregar Producto";
        }

        private async void buttonCreateProduct_Click(object sender, EventArgs e)
        {
            //Category selectedCategory = (Category)comboBoxCategories.SelectedItem;
            //int categoryId = 0;
            //if (selectedCategory != null)
            //{
            //    // Access the Id property of the selected Category
            //    categoryId = selectedCategory.Id;

            //}
            //var product = new ProductDto()
            //{
            //    Name = txtBoxName.Text,
            //    Description = txtBoxDescription.Text,
            //    Price = Convert.ToDouble(txtBoxPrice.Text),
            //    Quantity = Convert.ToInt32(txtBoxQuantity.Text),
            //    CategoryId = categoryId,
            //};
            //await ApiHelper.PostAsync("https://localhost:7215/api/products", product);
            //this.Close();
            Category selectedCategory = (Category)comboBoxCategories.SelectedItem;
            int categoryId = 0;
            if (selectedCategory != null)
            {
                categoryId = selectedCategory.Id;
            }

            double price;
            int quantity;

            if (FormInputValidator.TryConvertDungeonTextBoxToDouble(txtBoxPrice, "Price", out price) &&
                FormInputValidator.TryConvertDungeonTextBoxToInt(txtBoxQuantity, "Quantity", out quantity))
            {
                var product = new ProductDto()
                {
                    Name = txtBoxName.Text,
                    Description = txtBoxDescription.Text,
                    Price = price,
                    Quantity = quantity,
                    CategoryId = categoryId,
                };

                string response = await ApiHelper.PostAsync("https://localhost:7215/api/products", product);


                if (response.Contains("error"))
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
            else
            {
                MessageBoxHelper.ShowErrorMessageBox("Datos no validos. Por favor complete todos los campos requeridos.");
            }
        }

        private async void CreateProduct_Load(object sender, EventArgs e)
        {
            var categories = await ApiHelper.GetListAsync<Category>("https://localhost:7215/api/categories");
            if (categories != null)
            {
                comboBoxCategories.DataSource = new BindingList<Category>(categories);
                comboBoxCategories.DisplayMember = "Name";
                comboBoxCategories.ValueMember = "Id";
            }

        }
    }
}
