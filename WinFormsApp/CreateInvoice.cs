﻿using Contracts.DTOs.Entities;
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
using WinFormsApp.Utils;

namespace WinFormsApp
{
    public partial class CreateInvoice : Form
    {
        private double _total;
        private List<OrderProductDto> _invoiceDetails;
        private int _officeWorkerId;
        private string _productName;
        public CreateInvoice(int officeWorkerId)
        {
            _officeWorkerId = officeWorkerId;
            this.StartPosition = FormStartPosition.CenterScreen;
            InitializeComponent();
            Text = "Registro de Venta";
            _invoiceDetails = new List<OrderProductDto>();
        }

        private void buttonAddDetail_Click(object sender, EventArgs e)
        {
            int productId, quantity;
            double price;

            if (FormInputValidator.TryConvertDungeonTextBoxToInt(txtBoxProductId, "Product ID", out productId) &&
                FormInputValidator.TryConvertDungeonTextBoxToInt(txtBoxQuantity, "Quantity", out quantity) &&
                FormInputValidator.TryConvertDungeonTextBoxToDouble(txtBoxPrice, "Price", out price))
            {
                var orderProductDto = new OrderProductDto()
                {
                    ProductId = productId,
                    Quantity = quantity,
                    Price = price,
                    ProductName = _productName
                };

                _invoiceDetails.Add(orderProductDto);
            }
            else
            {
                MessageBoxHelper.ShowErrorMessageBox("Datos no validos. Por favor complete todos los campos requeridos.");
            }

            FormInputClearer.ClearDungeonTextBoxes(txtBoxPrice, txtBoxQuantity, txtBoxProductId);
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
        private void HandleProductSelected(ProductViewModel selectedProduct)
        {
            txtBoxProductId.Text = selectedProduct.Id.ToString();

            txtBoxPrice.Text = selectedProduct.SellingPrice.ToString();
            
            _productName = $"{selectedProduct.CategoryName}: {selectedProduct.Name}";
        }

        private async void buttonCreateDetailedInvoice_Click(object sender, EventArgs e)
        {
            int clientId;

            if (FormInputValidator.TryConvertDungeonTextBoxToInt(txtBoxClientId, "Client ID", out clientId))
            {
                var invoiceWithDetailsDto = new InvoiceWithDetailsDto()
                {
                    Date = DateTime.Now,
                    Amount = _total,
                    InvoiceDetails = _invoiceDetails,
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
            Dictionary<string, string> detailsColumns = new Dictionary<string, string>
            {
                { "ProductId", "Id de Producto" },
                { "ProductName", "Producto" },
                { "Quantity", "Cantidad" },
                { "Price", "Precio" },
            };
            Main.SetupDataGridView(dataGridViewDetails, detailsColumns);
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
    }
}
