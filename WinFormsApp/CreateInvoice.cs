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
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormsApp
{
    public partial class CreateInvoice : Form
    {
        private double _total;
        private List<OrderProductDto> _invoiceDetails;
        public CreateInvoice()
        {

            InitializeComponent();
            _invoiceDetails = new List<OrderProductDto>();
        }

        private void buttonAddDetail_Click(object sender, EventArgs e)
        {
            var orderProductDto = new OrderProductDto()
            {
                ProductId = Convert.ToInt32(txtBoxProductId.Text),
                Quantity = Convert.ToInt32(txtBoxQuantity.Text),
                Price = Convert.ToDouble(txtBoxPrice.Text),
            };
            _invoiceDetails.Add(orderProductDto);
            txtBoxPrice.Text = string.Empty;
            txtBoxQuantity.Text = string.Empty;
            txtBoxProductId.Text = string.Empty;
            LoadData();
            SumTotal();
        }
        private void LoadData()
        {
            
            dataGridViewDetails.DataSource = new BindingList<OrderProductDto>(_invoiceDetails); ;
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
        private void HandleProductSelected(int selectedProductId)
        {
            txtBoxProductId.Text = selectedProductId.ToString();
        }

        private async void buttonCreateDetailedInvoice_Click(object sender, EventArgs e)
        {
            var invoiceWithDetailsDto = new InvoiceWithDetailsDto()
            {
                Date = DateTime.Now,
                Amount = _total,
                InvoiceDetails = _invoiceDetails,
            };
            string response = await ApiHelper.PostAsync("https://localhost:7215/api/invoices/detailed", invoiceWithDetailsDto);
            if (response.Contains("error"))
            {
                MessageBox.Show("Error al registrar venta", response, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                MessageBox.Show("Venta registrada!", string.Empty, MessageBoxButtons.OK, MessageBoxIcon.Information);
                Close();
            }
        }

        private void CreateInvoice_Load(object sender, EventArgs e)
        {
            Dictionary<string, string> detailsColumns = new Dictionary<string, string>
            {
                { "ProductId", "Id de Producto" },
                { "Quantity", "Cantidad" },
                { "Price", "Precio" },
            };
            Main.SetupDataGridView(dataGridViewDetails, detailsColumns);
            txtBoxProductId.Enabled = false;
            txtBoxTotalAmount.Enabled = false;
        }
    }
}
