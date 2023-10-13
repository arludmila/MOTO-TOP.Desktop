using Contracts.DTOs.Entities;
using Contracts.Utils;
using Contracts.ViewModels;
using Entities.Core;
using System.ComponentModel;

namespace WinFormsApp
{
    public partial class OrderReview : Form
    {
        private double total = 0;
        private readonly int _orderId;
        private OrderViewModel _orderViewModel;
        private bool allStockAvailable = true;
        public OrderReview(int orderId)
        {
            _orderId = orderId;
            InitializeComponent();
        }

        private async void OrderReview_Load(object sender, EventArgs e)
        {
            await GetOrder(_orderId);
            LoadData();
        }
        private async Task GetOrder(int id)
        {
            _orderViewModel = await ApiHelper.GetAsync<OrderViewModel>($"https://localhost:7215/api/orders/view-models/{id}");
        }
        private void LoadData()
        {
            // txt boxes
            txtBoxClientName.Text = _orderViewModel.ClientName;
            txtBoxSelllerName.Text = _orderViewModel.SellerName;
            txtBoxTransportCompany.Text = _orderViewModel.TransportCompanyName;
            txtBoxOrderId.Text = _orderId.ToString();
            txtBoxClientName.Enabled = false;
            txtBoxSelllerName.Enabled = false;
            txtBoxTransportCompany.Enabled = false;
            txtBoxOrderId.Enabled = false;
            txtBoxTotalAmount.Enabled = false;
            // data grid
            dataGridViewOrderDetails.RowHeadersVisible = false;
            dataGridViewOrderDetails.AllowUserToAddRows = false;
            dataGridViewOrderDetails.AutoGenerateColumns = false;

            // data grid columns
            dataGridViewOrderDetails.Columns.Add("ProductId", "Producto Id");
            dataGridViewOrderDetails.Columns["ProductId"].DataPropertyName = "ProductId";

            dataGridViewOrderDetails.Columns.Add("ProductCategoryName", "Rubro");
            dataGridViewOrderDetails.Columns["ProductCategoryName"].DataPropertyName = "ProductCategoryName";

            dataGridViewOrderDetails.Columns.Add("ProductName", "Producto");
            dataGridViewOrderDetails.Columns["ProductName"].DataPropertyName = "ProductName";

            dataGridViewOrderDetails.Columns.Add("Quantity", "Cantidad");
            dataGridViewOrderDetails.Columns["Quantity"].DataPropertyName = "Quantity";

            dataGridViewOrderDetails.Columns.Add("Price", "Precio");
            dataGridViewOrderDetails.Columns["Price"].DataPropertyName = "Price";

            dataGridViewOrderDetails.Columns.Add("ProductQuantity", "Stock Disponible");
            dataGridViewOrderDetails.Columns["ProductQuantity"].DataPropertyName = "ProductQuantity";
            dataGridViewOrderDetails.DataSource = new BindingList<OrderProductViewModel>(_orderViewModel.OrderProducts);
            foreach (DataGridViewColumn column in dataGridViewOrderDetails.Columns)
            {
                column.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            }
            CheckStock();
            SumTotal();
        }
        private void CheckStock()
        {
            foreach (DataGridViewRow row in dataGridViewOrderDetails.Rows)
            {
                int quantity = Convert.ToInt32(row.Cells["Quantity"].Value);
                int productQuantity = Convert.ToInt32(row.Cells["ProductQuantity"].Value);
                if (quantity > productQuantity)
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
        private void SumTotal()
        {

            foreach (DataGridViewRow row in dataGridViewOrderDetails.Rows)
            {
                int quantity = Convert.ToInt32(row.Cells["Quantity"].Value);
                double price = Convert.ToInt32(row.Cells["Price"].Value);
                total += quantity * price;
            }
            txtBoxTotalAmount.Text = $"$ {total}";
        }
        private async void buttonCreateOrderInvoice_Click(object sender, EventArgs e)
        {
            var invoice = new InvoiceDto()
            {
                Amount = total,
                Date = DateTime.Now,
                OrderId = Convert.ToInt32(txtBoxOrderId.Text),
            };
            string response = await ApiHelper.PostAsync("https://localhost:7215/api/invoices", invoice);
            if (response.Contains("error"))
            {
                MessageBox.Show("Error al facturar", response, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                MessageBox.Show("Pedido facturado!", string.Empty, MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();
            }
        }

        private void dataGridViewOrderDetails_SelectionChanged(object sender, EventArgs e)
        {
            dataGridViewOrderDetails.ClearSelection();
        }

        private async void buttonCancelOrder_Click(object sender, EventArgs e)
        {
            var response = await ApiHelper.DeleteAsync($"https://localhost:7215/api/orders/{_orderId}");
            if (response.Contains("error"))
            {
                MessageBox.Show("Error al borrar pedido", response, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                MessageBox.Show("Pedido borrado!", string.Empty, MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();
            }
        }
    }
}
