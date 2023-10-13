using Contracts.DTOs.Entities;
using Contracts.DTOs.Relationships;
using Contracts.Utils;
using Contracts.ViewModels;
using Entities.Core;
using ReaLTaiizor.Controls;
using System.ComponentModel;
using System.Windows.Forms;

namespace WinFormsApp
{
    public partial class Main : Form
    {
        List<Category> categories;
        List<ProductViewModel> products;
        List<Client> clients;
        List<Supplier> suppliers;
        List<SellerViewModel> sellers;
        List<OrderViewModel> orders;
        public Main()
        {
            this.StartPosition = FormStartPosition.CenterScreen;
            this.Text = "MOTO-TOP";

            InitializeComponent();
        }

        private async void btnProducts_Click(object sender, EventArgs e)
        {

        }


        private async void buttonCreateCategory_Click(object sender, EventArgs e)
        {
            var category = new CategoryDto()
            {
                Name = txtBoxCategoryName.Text,
            };
            await ApiHelper.PostAsync("https://localhost:7215/api/categories", category);
            await LoadData();
            txtBoxCategoryName.Text = string.Empty;
        }

        private async void Main_Load(object sender, EventArgs e)
        {

            await LoadData();
            StyleDataGrids();
            txtBoxSupplierProductSupplierId.Enabled = false;
            txtBoxSupplierProductProductId.Enabled = false;
        }
        private void StyleDataGrids()
        {
            // CATEGORIES
            dataGridViewCategories.Columns["Id"].DisplayIndex = 0;
            dataGridViewCategories.Columns["Name"].DisplayIndex = 1;
            dataGridViewCategories.Columns["Name"].HeaderText = "Nombre";
            dataGridViewCategories.Columns["Name"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dataGridViewCategories.RowHeadersVisible = false;
            dataGridViewCategories.AllowUserToAddRows = false;
            // PRODUCTS
            dataGridViewProducts.Columns["CategoryName"].HeaderText = "Rubro";
            dataGridViewProducts.Columns["Name"].HeaderText = "Nombre";
            dataGridViewProducts.Columns["Price"].HeaderText = "Precio";
            dataGridViewProducts.Columns["Description"].HeaderText = "Descripción";
            dataGridViewProducts.Columns["Quantity"].HeaderText = "Stock";
            dataGridViewProducts.RowHeadersVisible = false;
            dataGridViewProducts.AllowUserToAddRows = false;
            foreach (DataGridViewColumn column in dataGridViewProducts.Columns)
            {
                column.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            }
            // CLIENTS
            dataGridViewClients.Columns["Id"].DisplayIndex = 0;
            dataGridViewClients.Columns["FirstName"].HeaderText = "Nombre";
            dataGridViewClients.Columns["LastName"].HeaderText = "Apellido";
            dataGridViewClients.Columns["Location"].HeaderText = "Ubicación";
            dataGridViewClients.Columns["PhoneNumber"].HeaderText = "Número de Telefono";
            dataGridViewClients.RowHeadersVisible = false;
            dataGridViewClients.AllowUserToAddRows = false;
            foreach (DataGridViewColumn column in dataGridViewClients.Columns)
            {
                column.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            }
            // SUPPLIERS
            dataGridViewSuppliers.Columns["Id"].DisplayIndex = 0;
            dataGridViewSuppliers.Columns["Name"].HeaderText = "Nombre";
            dataGridViewSuppliers.Columns["PhoneNumber"].HeaderText = "Número de Telefono";
            dataGridViewSuppliers.RowHeadersVisible = false;
            dataGridViewSuppliers.AllowUserToAddRows = false;
            foreach (DataGridViewColumn column in dataGridViewSuppliers.Columns)
            {
                column.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            }
            // SELLERS
            dataGridViewSellers.Columns["FirstName"].HeaderText = "Nombre";
            dataGridViewSellers.Columns["LastName"].HeaderText = "Apellido";
            dataGridViewSellers.Columns["Zone"].HeaderText = "Zona Asignada";
            dataGridViewSellers.RowHeadersVisible = false;
            dataGridViewSellers.AllowUserToAddRows = false;

            foreach (DataGridViewColumn column in dataGridViewSellers.Columns)
            {
                column.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            }
            // ORDERS

            DataGridViewButtonColumn buttonColumn = new DataGridViewButtonColumn();
            buttonColumn.Name = "ReviewButton";
            buttonColumn.HeaderText = "Revisar";
            buttonColumn.Text = "Revisar";
            buttonColumn.UseColumnTextForButtonValue = true;
            dataGridViewOrders.Columns.Add(buttonColumn);

            dataGridViewOrders.Columns["ShipmentStatus"].HeaderText = "Estado";
            dataGridViewOrders.Columns["ClientName"].HeaderText = "Cliente";
            dataGridViewOrders.Columns["SellerName"].HeaderText = "Vendedor";
            dataGridViewOrders.Columns["TransportCompanyName"].HeaderText = "Transporte";
            dataGridViewOrders.Columns["DateSent"].HeaderText = "Fecha de Envio";
            dataGridViewOrders.Columns["DateReceived"].HeaderText = "Fecha de Recepción";
            dataGridViewOrders.Columns["HasInvoice"].HeaderText = "Facturado";
            dataGridViewOrders.RowHeadersVisible = false;
            dataGridViewOrders.AllowUserToAddRows = false;

            foreach (DataGridViewColumn column in dataGridViewOrders.Columns)
            {
                column.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            }

        }
        private async Task LoadData()
        {
            categories = await ApiHelper.GetListAsync<Category>("https://localhost:7215/api/categories");
            if (categories != null)
            {
                dataGridViewCategories.DataSource = new BindingList<Category>(categories);
            }
            products = await ApiHelper.GetListAsync<ProductViewModel>("https://localhost:7215/api/products/view-models");
            if (products != null)
            {
                dataGridViewProducts.DataSource = new BindingList<ProductViewModel>(products);
            }
            clients = await ApiHelper.GetListAsync<Client>("https://localhost:7215/api/clients");
            if (clients != null)
            {
                dataGridViewClients.DataSource = new BindingList<Client>(clients);
            }
            suppliers = await ApiHelper.GetListAsync<Supplier>("https://localhost:7215/api/suppliers");
            if (suppliers != null)
            {
                dataGridViewSuppliers.DataSource = new BindingList<Supplier>(suppliers);
            }
            sellers = await ApiHelper.GetListAsync<SellerViewModel>("https://localhost:7215/api/sellers/view-models");
            if (sellers != null)
            {
                dataGridViewSellers.DataSource = new BindingList<SellerViewModel>(sellers);
            }
            orders = await ApiHelper.GetListAsync<OrderViewModel>("https://localhost:7215/api/orders/view-models");
            if (sellers != null)
            {
                dataGridViewOrders.DataSource = new BindingList<OrderViewModel>(orders);
            }
        }

        private async void buttonCreateProduct_Click(object sender, EventArgs e)
        {
            var form = new CreateProduct();
            form.ShowDialog();
            await LoadData();
        }

        private async void buttonCreateClient_Click(object sender, EventArgs e)
        {
            var form = new CreateClient();
            form.ShowDialog();
            await LoadData();
        }

        private async void buttonCreateSupplier_Click(object sender, EventArgs e)
        {
            var form = new CreateSupplier();
            form.ShowDialog();
            await LoadData();
        }

        private async void buttonCreateSeller_Click(object sender, EventArgs e)
        {
            var form = new CreateSeller();
            form.ShowDialog();
            await LoadData();
        }

        private void dataGridViewOrders_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == dataGridViewOrders.Columns["ReviewButton"].Index && e.RowIndex >= 0)
            {
                int orderId = (int)dataGridViewOrders.Rows[e.RowIndex].Cells["Id"].Value;
                var form = new OrderReview(orderId);
                form.ShowDialog();
            }
        }

        private void tabPageOrders_Click(object sender, EventArgs e)
        {

        }

        private void buttonCreateSupplier_Click_1(object sender, EventArgs e)
        {

        }

        private async void buttonCreateSupplierProduct_Click(object sender, EventArgs e)
        {
            var supplierProduct = new SupplierProductDto()
            {
                ProductId = Convert.ToInt32(txtBoxSupplierProductProductId.Text),
                SupplierId = Convert.ToInt32(txtBoxSupplierProductSupplierId.Text),
                Quantity = Convert.ToInt32(txtBoxSupplierProductPrice.Text),
                Price = Convert.ToDouble(txtBoxSupplierProductPrice.Text),
            };
            await ApiHelper.PostAsync("https://localhost:7215/api/supplier-products",supplierProduct);
            txtBoxSupplierProductProductId.Text = string.Empty;
            txtBoxSupplierProductSupplierId.Text = string.Empty;
            txtBoxSupplierProductPrice.Text = string.Empty;
            txtBoxSupplierProductPrice.Text = string.Empty;
            // TODO: arreglar en api -> suppProd tendria que aumentar los stock de los prod seleccionados
            // ademas, deberia cambiar el precio del producto al ultimo que se manda...
        }

        private void txtBoxSupplierProductProductId_DoubleClick(object sender, EventArgs e)
        {
        }

        private void txtBoxSupplierProductSupplierId_DoubleClick(object sender, EventArgs e)
        {
        }

        private void buttonSelectProduct_Click(object sender, EventArgs e)
        {

            using (ProductSelector productSelectorForm = new ProductSelector())
            {
                productSelectorForm.ProductSelected += HandleProductSelected;
                productSelectorForm.ShowDialog();
            }
        }
        private void HandleProductSelected(int selectedProductId)
        {
            txtBoxSupplierProductProductId.Text = selectedProductId.ToString();
        }

        private void buttonSelectSupplier_Click(object sender, EventArgs e)
        {
            using (SupplierSelector productSelectorForm = new SupplierSelector())
            {
                productSelectorForm.SupplierSelected += HandleSupplierSelected;
                productSelectorForm.ShowDialog();
            }
        }
        private void HandleSupplierSelected(int selectedSupplierId)
        {
            txtBoxSupplierProductSupplierId.Text = selectedSupplierId.ToString();
        }
    }
}