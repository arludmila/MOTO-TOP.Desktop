using Contracts.DTOs.Entities;
using Contracts.Utils;
using Contracts.ViewModels;
using Entities.Core;
using Entities.Relationships;
using System.ComponentModel;
using WinFormsApp.Utils;

namespace WinFormsApp
{
    public partial class OrderReview : Form
    {
        private double total = 0;
        private readonly Guid _orderId;
        private OrderViewModel _orderViewModel;
        private bool _allStockAvailable = true;
        public OrderReview(Guid orderId)
        {

            this.StartPosition = FormStartPosition.CenterScreen;
            _orderId = orderId;
            InitializeComponent();
            Text = "Revisión de Pedido";
        }

        private async void OrderReview_Load(object sender, EventArgs e)
        {
            await GetOrder(_orderId);
            StyleWinForm();
            LoadData();
        }
        private async Task GetOrder(Guid id)
        {
            _orderViewModel = await ApiHelper.GetAsync<OrderViewModel>($"{ApiUrl.LocalUrl}orders/view-models/{id}");
        }
        private void StyleWinForm()
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
            // 
            dataGridViewOrderDetails.Columns["ProductId"].ReadOnly = true;
            dataGridViewOrderDetails.Columns["ProductCategoryName"].ReadOnly = true;
            dataGridViewOrderDetails.Columns["ProductName"].ReadOnly = true;
            dataGridViewOrderDetails.Columns["Quantity"].ReadOnly = false;
            dataGridViewOrderDetails.Columns["Price"].ReadOnly = true;
            dataGridViewOrderDetails.Columns["ProductQuantity"].ReadOnly = true;

        }
        private void LoadData()
        {

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
            _allStockAvailable = true;
            foreach (DataGridViewRow row in dataGridViewOrderDetails.Rows)
            {
                int quantity = Convert.ToInt32(row.Cells["Quantity"].Value);
                int productQuantity = Convert.ToInt32(row.Cells["ProductQuantity"].Value);
                if (quantity > productQuantity)
                {
                    row.DefaultCellStyle.BackColor = Color.LightCoral;
                    _allStockAvailable = false;
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
            total = 0;
            foreach (DataGridViewRow row in dataGridViewOrderDetails.Rows)
            {
                int quantity = Convert.ToInt32(row.Cells["Quantity"].Value);
                double price = Convert.ToDouble(row.Cells["Price"].Value);
                total += quantity * price;
            }
            txtBoxTotalAmount.Text = $"$ {total}";
        }
        private async void buttonCreateOrderInvoice_Click(object sender, EventArgs e)
        {
            if (dataGridViewOrderDetails.RowCount == 0)
            {
                MessageBoxHelper.ShowErrorMessageBox("No hay detalles en este pedido!");
                return;
            }
            if (!_allStockAvailable)
            {
                MessageBoxHelper.ShowErrorMessageBox("No hay suficiente stock para facturar el pedido.");
                return;
            }
            else
            {
                Guid.TryParse(txtBoxOrderId.Text, out Guid orderId);
                Order order = await ApiHelper.GetAsync<Order>($"{ApiUrl.LocalUrl}orders/{orderId}");

                var invoice = new InvoiceDto()
                {
                    Amount = total,
                    Date = DateTime.Now,
                    OrderId = orderId,
                    ClientId = order.ClientId,
                };
                string response = await ApiHelper.PostAsync($"{ApiUrl.LocalUrl}invoices", invoice);
                if (response.Contains("error") || response.Contains("failed"))
                {
                    MessageBox.Show("Error al facturar", response, MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    MessageBox.Show("Pedido facturado!", string.Empty, MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Close();
                }
            }

        }

        private void dataGridViewOrderDetails_SelectionChanged(object sender, EventArgs e)
        {
            dataGridViewOrderDetails.ClearSelection();
        }

        private async void buttonCancelOrder_Click(object sender, EventArgs e)
        {
            var response = await ApiHelper.DeleteAsync($"{ApiUrl.LocalUrl}orders/{_orderId}");
            if (response.Contains("error") || response.Contains("failed"))
            {
                MessageBox.Show("Error al borrar pedido", response, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                MessageBox.Show("Pedido borrado!", string.Empty, MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();
            }
        }

        private async void dataGridViewOrderDetails_CellValueChangedAsync(object sender, DataGridViewCellEventArgs e)
        {

            if (e.RowIndex >= 0 && e.ColumnIndex == dataGridViewOrderDetails.Columns["Quantity"].Index)
            {
                
                int newQuantity = Convert.ToInt32(dataGridViewOrderDetails.Rows[e.RowIndex].Cells["Quantity"].Value);
                var row = dataGridViewOrderDetails.Rows[e.RowIndex];
                OrderProductViewModel orderProductVM = (OrderProductViewModel)row.DataBoundItem;
                if (newQuantity <= 0)
                {
                    // Remove the row with a quantity of 0 or less
                    dataGridViewOrderDetails.Rows.RemoveAt(e.RowIndex);
                }
                else
                {
                    // Update the underlying data source
                    _orderViewModel.OrderProducts[e.RowIndex].Quantity = newQuantity;
                }
                if (dataGridViewOrderDetails.RowCount != 0)
                {
                    

                    OrderProduct orderProduct = new OrderProduct
                    {

                        ProductId = orderProductVM.ProductId,
                        Id = orderProductVM.Id,
                        Quantity = orderProductVM.Quantity,
                        Price = orderProductVM.Price,
                        OrderId = orderProductVM.OrderId,
                        InvoiceId = orderProductVM.InvoiceId,

                    };

                    var response = await ApiHelper.UpdateAsync($"{ApiUrl.LocalUrl}order-products/{orderProduct.Id}", orderProduct);
                    if (response.Contains("error") || response.Contains("failed"))
                    {
                        MessageBox.Show("Error al actualizar datos del pedido", response, MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    var response = await ApiHelper.DeleteAsync($"{ApiUrl.LocalUrl}order-products/{orderProductVM.Id}");
                    if (response.Contains("error") || response.Contains("failed"))
                    {
                        MessageBox.Show("Error al actualizar datos del pedido", response, MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                // Recalculate total and check stock
                SumTotal();
                CheckStock();
            }
        }

        private void buttonModifyOrder_Click(object sender, EventArgs e)
        {

        }
    }
}
