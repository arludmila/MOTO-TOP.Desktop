﻿using Contracts.Utils;
using Contracts.ViewModels;
using System.ComponentModel;

namespace WinFormsApp
{
    public partial class ProductSelector : Form
    {
        List<ProductViewModel> products;
        public event Action<int> ProductSelected;
        public ProductSelector()
        {
            InitializeComponent();
        }

        private async void buttonCreateProduct_Click(object sender, EventArgs e)
        {
            var form = new CreateProduct();
            form.ShowDialog();
            await LoadData();
        }

        private async void ProductSelector_Load(object sender, EventArgs e)
        {
            await LoadData();
            StyleDataGrid();
            CheckStock();
        }
        private async Task LoadData()
        {
            products = await ApiHelper.GetListAsync<ProductViewModel>("https://localhost:7215/api/products/view-models");
            if (products != null)
            {
                dataGridViewProducts.DataSource = new BindingList<ProductViewModel>(products);
            }
            foreach (DataGridViewColumn column in dataGridViewProducts.Columns)
            {
                column.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            }
        }
        private void StyleDataGrid()
        {
            dataGridViewProducts.RowHeadersVisible = false;
            dataGridViewProducts.AllowUserToAddRows = false;
            dataGridViewProducts.AutoGenerateColumns = false;
            dataGridViewProducts.Columns["CategoryName"].HeaderText = "Rubro";
            dataGridViewProducts.Columns["Name"].HeaderText = "Nombre";
            dataGridViewProducts.Columns["Price"].HeaderText = "Precio";
            dataGridViewProducts.Columns["Description"].HeaderText = "Descripción";
            dataGridViewProducts.Columns["Quantity"].HeaderText = "Stock";
            DataGridViewButtonColumn buttonColumn = new DataGridViewButtonColumn
            {
                Name = "SelectButton",
                Text = "Seleccionar",
                UseColumnTextForButtonValue = true,

            };
            dataGridViewProducts.Columns.Add(buttonColumn);
            dataGridViewProducts.Columns["SelectButton"].HeaderText = string.Empty;
        }
        private void CheckStock()
        {
            foreach (DataGridViewRow row in dataGridViewProducts.Rows)
            {
                int quantity = Convert.ToInt32(row.Cells["Quantity"].Value);
                if (quantity == 0)
                {
                    row.DefaultCellStyle.BackColor = Color.LightCoral;
                }
                else
                {
                    row.DefaultCellStyle.BackColor = Color.LightGreen;
                }
                row.DefaultCellStyle.ForeColor = Color.Black;
            }
        }

        private void dataGridViewProducts_SelectionChanged(object sender, EventArgs e)
        {
            dataGridViewProducts.ClearSelection();
        }

        private void dataGridViewProducts_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.ColumnIndex == dataGridViewProducts.Columns["SelectButton"].Index)
            {
                // Get the selected product's ID from the DataGridView
                int selectedProductId = (int)dataGridViewProducts.Rows[e.RowIndex].Cells["Id"].Value;

                // Raise the event and send the selected product's ID to the main form
                ProductSelected?.Invoke(selectedProductId);

                // Close the ProductSelector form
                this.Close();
            }
        }
    }
}
