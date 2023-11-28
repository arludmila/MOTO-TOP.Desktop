using Contracts.Utils;
using Contracts.ViewModels;
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

namespace WinFormsApp
{
    public partial class InvoiceReview : Form
    {
        private int _invoiceId;
        private InvoiceViewModel _invoiceViewModel;
        public InvoiceReview(int invoiceId)
        {
            this.StartPosition = FormStartPosition.CenterScreen;
            _invoiceId = invoiceId;
            InitializeComponent();
            this.Text = "Revisar Factura";
        }

        private async void InvoiceReview_Load(object sender, EventArgs e)
        {
            txtBoxInvoiceId.Enabled = false;
            txtBoxInvoiceDate.Enabled = false;
            txtBoxClientDocument.Enabled = false;
            txtBoxClientName.Enabled = false;
            txtBoxTotalAmount.Enabled = false;
            _invoiceViewModel = await ApiHelper.GetAsync<InvoiceViewModel>($"{ApiUrl.LocalUrl}invoices/view-models/{_invoiceId}");
            txtBoxInvoiceId.Text = _invoiceId.ToString();
            txtBoxInvoiceDate.Text = _invoiceViewModel.Date.ToString();
            txtBoxClientName.Text = _invoiceViewModel.ClientName;
            txtBoxClientDocument.Text = _invoiceViewModel.ClientDocument;
            txtBoxTotalAmount.Text = $"${_invoiceViewModel.TotalAmount}";


            Dictionary<string, string> invoiceDetailsColumns = new Dictionary<string, string>
            {
                { "ProductId", "Código de Producto" },
                { "ProductCategoryName", "Rubro" },
                { "ProductName", "Producto" },
                { "Quantity", "Cantidad" },
                { "Price", "Precio" },
                
            };

            Main.SetupDataGridView(dataGridViewInvoiceDetails, invoiceDetailsColumns);

            dataGridViewInvoiceDetails.DataSource = new BindingList<OrderProductViewModel>(_invoiceViewModel.InvoiceDetails);


        }

    }
}
