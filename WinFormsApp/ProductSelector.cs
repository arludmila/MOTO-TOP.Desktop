using Contracts.Utils;
using Contracts.ViewModels;
using System.ComponentModel;

namespace WinFormsApp
{
    public partial class ProductSelector : Form
    {
        List<ProductViewModel> products;
        public event Action<ProductViewModel> ProductSelected;
        public ProductSelector()
        {
            this.StartPosition = FormStartPosition.CenterScreen;
            InitializeComponent();
            Text = "Selector de Producto";
        }

        private async void buttonCreateProduct_Click(object sender, EventArgs e)
        {
            var form = new CreateProduct();
            form.ShowDialog();
            await LoadData();
            CheckStock();
        }

        private async void ProductSelector_Load(object sender, EventArgs e)
        {
            await LoadData();
            StyleDataGrid();
            CheckStock();
        }
        private async Task LoadData()
        {
            products = await ApiHelper.GetListAsync<ProductViewModel>($"{ApiUrl.LocalUrl}products/view-models");
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
            dataGridViewProducts.Columns["PurchasePrice"].HeaderText = "Precio de Compra";
            dataGridViewProducts.Columns["SellingPrice"].HeaderText = "Precio de Venta";
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
                if (quantity < 1)
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
                if (dataGridViewProducts.Rows[e.RowIndex].DataBoundItem is ProductViewModel selectedProduct)
                {
                    ProductSelected?.Invoke(selectedProduct);
                }
                Close();
            }
        }
    }
}
