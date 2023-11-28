using Contracts.DTOs.Entities;
using Contracts.DTOs.Relationships;
using Contracts.Utils;
using Contracts.ViewModels;
using Entities.Core;
using Entities.Relationships;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WinFormsApp.Utils;

namespace WinFormsApp
{
    public partial class CreateInvoice : Form
    {
        private double _total;
        private List<OrderProductViewModel> _invoiceDetails;
        private int _officeWorkerId;
        private string _productName;
        private ProductViewModel _productsVMCurrent;
        private bool _allStockAvailable = true;
        public CreateInvoice(int officeWorkerId)
        {
            _officeWorkerId = officeWorkerId;
            this.StartPosition = FormStartPosition.CenterScreen;
            InitializeComponent();
            Text = "Registro de Venta";
            _invoiceDetails = new List<OrderProductViewModel>();
        }

        private void buttonAddDetail_Click(object sender, EventArgs e)
        {



            int productId, quantity;
            double price;

            if (FormInputValidator.TryConvertDungeonTextBoxToInt(txtBoxProductId, "Product ID", out productId) &&
                FormInputValidator.TryConvertDungeonTextBoxToInt(txtBoxQuantity, "Quantity", out quantity) &&
                FormInputValidator.TryConvertDungeonTextBoxToDouble(txtBoxPrice, "Price", out price))
            {

                var orderProductVM = new OrderProductViewModel()
                {

                    Quantity = quantity,
                    Price = price,
                    ProductCategoryName = _productsVMCurrent.CategoryName,
                    ProductName = _productsVMCurrent.Name,
                    ProductId = productId,
                    ProductQuantity = _productsVMCurrent.Quantity,

                };




                _invoiceDetails.Add(orderProductVM);
            }
            else
            {
                MessageBoxHelper.ShowErrorMessageBox("Datos no validos. Por favor complete todos los campos requeridos.");
            }

            FormInputClearer.ClearDungeonTextBoxes(txtBoxPrice, txtBoxQuantity, txtBoxProductId);
            LoadData();
            SumTotal();
            CheckStock();
        }
        private void StyleWinform()
        {

            // data grid
            dataGridViewDetails.RowHeadersVisible = false;
            dataGridViewDetails.AllowUserToAddRows = false;
            dataGridViewDetails.AutoGenerateColumns = false;

            // data grid columns
            dataGridViewDetails.Columns.Add("ProductId", "Producto Id");
            dataGridViewDetails.Columns["ProductId"].DataPropertyName = "ProductId";

            dataGridViewDetails.Columns.Add("ProductCategoryName", "Rubro");
            dataGridViewDetails.Columns["ProductCategoryName"].DataPropertyName = "ProductCategoryName";

            dataGridViewDetails.Columns.Add("ProductName", "Producto");
            dataGridViewDetails.Columns["ProductName"].DataPropertyName = "ProductName";

            dataGridViewDetails.Columns.Add("Quantity", "Cantidad");
            dataGridViewDetails.Columns["Quantity"].DataPropertyName = "Quantity";

            dataGridViewDetails.Columns.Add("Price", "Precio");
            dataGridViewDetails.Columns["Price"].DataPropertyName = "Price";

            dataGridViewDetails.Columns.Add("ProductQuantity", "Stock Disponible");
            dataGridViewDetails.Columns["ProductQuantity"].DataPropertyName = "ProductQuantity";
            // 
            dataGridViewDetails.Columns["ProductId"].ReadOnly = true;
            dataGridViewDetails.Columns["ProductCategoryName"].ReadOnly = true;
            dataGridViewDetails.Columns["ProductName"].ReadOnly = true;
            dataGridViewDetails.Columns["Quantity"].ReadOnly = false;
            dataGridViewDetails.Columns["Price"].ReadOnly = true;
            dataGridViewDetails.Columns["ProductQuantity"].ReadOnly = true;
            foreach (DataGridViewColumn column in dataGridViewDetails.Columns)
            {
                column.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            }
            dataGridViewDetails.ColumnHeadersDefaultCellStyle.ForeColor = Color.Black;
            dataGridViewDetails.ColumnHeadersDefaultCellStyle.BackColor = Color.LightSteelBlue;
            dataGridViewDetails.ColumnHeadersDefaultCellStyle.SelectionBackColor = Color.LightSteelBlue;
            dataGridViewDetails.DefaultCellStyle.SelectionBackColor = Color.White;
            dataGridViewDetails.DefaultCellStyle.SelectionForeColor = Color.Black;
        }
        private void LoadData()
        {

            dataGridViewDetails.DataSource = new BindingList<OrderProductViewModel>(_invoiceDetails); ;
        }
        private void CheckStock()
        {
            _allStockAvailable = true;
            foreach (DataGridViewRow row in dataGridViewDetails.Rows)
            {
                int quantity = Convert.ToInt32(row.Cells["Quantity"].Value);
                int productQuantity = Convert.ToInt32(row.Cells["ProductQuantity"].Value);
                if (quantity > productQuantity)
                {
                    row.DefaultCellStyle.BackColor = Color.LightCoral;
                    row.DefaultCellStyle.SelectionBackColor = Color.LightCoral;
                    _allStockAvailable = false;
                }
                else
                {
                    row.DefaultCellStyle.BackColor = Color.LightGreen;

                    row.DefaultCellStyle.SelectionBackColor = Color.LightGreen;
                }
                row.DefaultCellStyle.ForeColor = Color.Black;
            }
        }
        private void SumTotal()
        {
            foreach (DataGridViewRow row in dataGridViewDetails.Rows)
            {
                int quantity = Convert.ToInt32(row.Cells["Quantity"].Value);
                double price = Convert.ToDouble(row.Cells["Price"].Value);
                _total += quantity * price;
            }
            txtBoxTotalAmount.Text = $"$ {_total}";
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

            _productsVMCurrent = selectedProduct;


            txtBoxProductId.Text = selectedProduct.Id.ToString();

            txtBoxPrice.Text = selectedProduct.SellingPrice.ToString();

            _productName = $"{selectedProduct.CategoryName}: {selectedProduct.Name}";
        }

        private async void buttonCreateDetailedInvoice_Click(object sender, EventArgs e)
        {



            /// arreglar aca!!!
            /// 

            //var orderProductDto = new OrderProductDto()
            //{
            //    ProductId = productId,
            //    Quantity = quantity,
            //    Price = price,
            //    ProductName = _productName
            //}; ////

            if (dataGridViewDetails.RowCount == 0)
            {
                MessageBoxHelper.ShowErrorMessageBox("No hay detalles en esta factura!");
                return;
            }
            if (!_allStockAvailable)
            {
                MessageBoxHelper.ShowErrorMessageBox("No hay suficiente stock para facturar la venta.");
                return;
            }

            int clientId;

            if (FormInputValidator.TryConvertDungeonTextBoxToInt(txtBoxClientId, "Client ID", out clientId))
            {
                var invoiceDetailsDto = new List<OrderProductDto>();


                foreach (var item in _invoiceDetails)
                {
                    invoiceDetailsDto.Add(new OrderProductDto()
                    {
                        ProductId = item.ProductId,
                        Quantity = item.Quantity,
                        Price = item.Price,
                        ProductName = item.ProductName,
                    });
                }

                var invoiceWithDetailsDto = new InvoiceWithDetailsDto()
                {
                    Date = DateTime.Now,
                    Amount = _total,
                    //InvoiceDetails = _invoiceDetails,
                    ClientId = clientId,
                    OfficeWorkerId = _officeWorkerId
                };


                string response = await ApiHelper.PostAsync($"{ApiUrl.LocalUrl}invoices/detailed", invoiceWithDetailsDto);

                if (response.Contains("error") || response.Contains("failed"))
                {
                    MessageBoxHelper.ShowErrorMessageBox("Error al registrar venta");
                }
                else
                {
                    MessageBoxHelper.ShowSuccessMessageBox("Venta registrada!");
                    Close();
                }
            }
            else
            {
                MessageBoxHelper.ShowErrorMessageBox("Datos no validos. Por favor complete todos los campos requeridos.");
            }

        }

        private void CreateInvoice_Load(object sender, EventArgs e)
        {
            StyleWinform();
            DataGridViewButtonColumn buttonColumnOrders = new DataGridViewButtonColumn();
            buttonColumnOrders.Name = "DeleteButton";
            buttonColumnOrders.HeaderText = "Eliminar";
            buttonColumnOrders.Text = "Eliminar";
            buttonColumnOrders.UseColumnTextForButtonValue = true;
            dataGridViewDetails.Columns.Add(buttonColumnOrders);
            txtBoxProductId.Enabled = false;
            txtBoxTotalAmount.Enabled = false;
            txtBoxClientId.Enabled = false;
            txtBoxPrice.Enabled = false;
        }

        private void buttonSelectClient_Click(object sender, EventArgs e)
        {
            using (ClientSelector productSelectorForm = new ClientSelector())
            {
                productSelectorForm.ClientSelected += HandleClientSelected;
                productSelectorForm.ShowDialog();
            }
        }
        private void HandleClientSelected(Client selectedClient)
        {
            txtBoxClientId.Text = selectedClient.Id.ToString();
            txtBoxClientName.Text = $"{selectedClient.LastName}, {selectedClient.FirstName}";
        }

        private void dataGridViewDetails_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.ColumnIndex == dataGridViewDetails.Columns["DeleteButton"].Index)
            {
                if (dataGridViewDetails.Rows[e.RowIndex].DataBoundItem is OrderProductViewModel selectedDetail)
                {
                    // 1. Elimina la fila del DataGridView
                    dataGridViewDetails.Rows.RemoveAt(e.RowIndex);

                    // 2. Elimina el elemento de la lista _invoiceDetails
                    _invoiceDetails.Remove(selectedDetail);
                    CheckStock();
                }

            }
        }
    }
}
