using Contracts.DTOs.Entities;
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

        }
        private void StyleDataGrids()
        {
            // CATEGORIES
            dataGridViewCategories.Columns["Id"].DisplayIndex = 0;
            dataGridViewCategories.Columns["Name"].DisplayIndex = 1;
            dataGridViewCategories.Columns["Name"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dataGridViewCategories.RowHeadersVisible = false;
            // PRODUCTS
            dataGridViewProducts.RowHeadersVisible = false;
            foreach (DataGridViewColumn column in dataGridViewProducts.Columns)
            {
                column.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            }
            // CLIENTS
            foreach (DataGridViewColumn column in dataGridViewClients.Columns)
            {
                column.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            }
            // SUPPLIERSs
            foreach (DataGridViewColumn column in dataGridViewSuppliers.Columns)
            {
                column.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            }
        }
        private async Task LoadData()
        {
            categories = await ApiHelper.GetAsync<Category>("https://localhost:7215/api/categories");
            if (categories != null)
            {
                dataGridViewCategories.DataSource = new BindingList<Category>(categories);
            }
            products = await ApiHelper.GetAsync<ProductViewModel>("https://localhost:7215/api/products/view-models");
            if (products != null)
            {
                dataGridViewProducts.DataSource = new BindingList<ProductViewModel>(products);
            }
            clients = await ApiHelper.GetAsync<Client>("https://localhost:7215/api/clients");
            if (clients != null)
            {
                dataGridViewClients.DataSource = new BindingList<Client>(clients);
            }
            suppliers = await ApiHelper.GetAsync<Supplier>("https://localhost:7215/api/suppliers");
            if (suppliers != null)
            {
                dataGridViewSuppliers.DataSource = new BindingList<Supplier>(suppliers);
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
    }
}