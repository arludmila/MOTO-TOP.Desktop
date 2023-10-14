using Contracts.DTOs.Entities;
using Contracts.DTOs.Relationships;
using Contracts.Utils;
using Contracts.ViewModels;
using Entities.Core;
using System.ComponentModel;
using Timer = System.Windows.Forms.Timer;

namespace WinFormsApp
{
    public partial class Main : Form
    {
        private List<Category> categories;
        private List<ProductViewModel> products;
        private List<Client> clients;
        private List<Supplier> suppliers;
        private List<SellerViewModel> sellers;
        private List<OrderViewModel> orders;
        private List<InvoiceViewModel> invoices;
        private List<InvoiceViewModel> pendingInvoices;
        private List<BillingTransaction> billingTransactions;
        private List<TransportCompany> transportCompanies;
        private Timer refreshTimer;
        public Main()
        {
            this.StartPosition = FormStartPosition.CenterScreen;
            this.Text = "MOTO-TOP";

            InitializeComponent();
            refreshTimer = new System.Windows.Forms.Timer();
            refreshTimer.Interval = 5000; // 5 seconds
            refreshTimer.Tick += new EventHandler(RefreshTimer_Tick);
            refreshTimer.Start();
        }
        private async void RefreshTimer_Tick(object sender, EventArgs e)
        {
            await LoadData();
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
            StyleDataGrids();
            await LoadData();

            txtBoxSupplierProductSupplierId.Enabled = false;
            txtBoxSupplierProductProductId.Enabled = false;
        }
        private void StyleDataGrids()
        {
            // CATEGORIES

            Dictionary<string, string> categoriesColumns = new Dictionary<string, string>
            {
                { "Id", "Id" },
                { "Name", "Nombre" },
            };
            SetupDataGridView(dataGridViewCategories, categoriesColumns);
            // PRODUCTS
            Dictionary<string, string> productsColumns = new Dictionary<string, string>
            {
                { "Id", "Id" },
                { "CategoryName", "Rubro" },
                { "Name", "Nombre" },
                { "Price", "Precio" },
                { "Description", "Descripción" },
                { "Quantity", "Stock" }
            };

            SetupDataGridView(dataGridViewProducts, productsColumns);
            // CLIENTS
            Dictionary<string, string> clientsColumns = new Dictionary<string, string>
            {
                { "Id", "Id" },
                { "FirstName", "Nombre" },
                { "LastName", "Apellido" },
                { "Location", "Ubicación" },
                { "PhoneNumber", "Número de Telefono" }
            };

            SetupDataGridView(dataGridViewClients, clientsColumns);

            // SUPPLIERS
            Dictionary<string, string> suppliersColumns = new Dictionary<string, string>
            {
                { "Id", "Id" },
                { "Name", "Nombre" },
                { "PhoneNumber", "Número de Telefono" }
            };

            SetupDataGridView(dataGridViewSuppliers, suppliersColumns);
            // SELLERS
            Dictionary<string, string> sellersColumns = new Dictionary<string, string>
            {
                { "Id", "Id" },
                { "FirstName", "Nombre" },
                { "LastName", "Apellido" },
                { "Zone", "Zona Asignada" }
            };

            SetupDataGridView(dataGridViewSellers, sellersColumns);

            // ORDERS
            Dictionary<string, string> ordersColumns = new Dictionary<string, string>
            {
                { "Id", "Id" },
                { "ShipmentStatus", "Estado" },
                { "ClientName", "Cliente" },
                { "SellerName", "Vendedor" },
                { "TransportCompanyName", "Transporte" },
                { "DateSent", "Fecha de Envio" },
                { "DateReceived", "Fecha de Recepción" },
            };
            SetupDataGridView(dataGridViewOrders, ordersColumns);
            DataGridViewCheckBoxColumn checkBoxColumnOrders = new DataGridViewCheckBoxColumn();
            checkBoxColumnOrders.HeaderText = "Facturado";
            checkBoxColumnOrders.Name = "HasInvoice";
            checkBoxColumnOrders.DataPropertyName = "HasInvoice";
            checkBoxColumnOrders.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dataGridViewOrders.Columns.Add(checkBoxColumnOrders);
            DataGridViewButtonColumn buttonColumnOrders = new DataGridViewButtonColumn();
            buttonColumnOrders.Name = "ReviewButton";
            buttonColumnOrders.HeaderText = "Revisar";
            buttonColumnOrders.Text = "Revisar";
            buttonColumnOrders.UseColumnTextForButtonValue = true;
            dataGridViewOrders.Columns.Add(buttonColumnOrders);
            // BILLING TRANSACTIONS
            Dictionary<string, string> billingTransactionsColumns = new Dictionary<string, string>
            {
                { "Id", "Id" },
                { "PaymentMethod", "Metodo de Pago" },
                { "ClientId", "N° Cliente" },
                { "DocumentType", "Tipo de Documento" },
                { "DocumentNumber", "N° Documento" },
                { "Amount", "Total" },
            };
            SetupDataGridView(dataGridViewBillingTransactions, billingTransactionsColumns);
            // PENDING INVOICES
            Dictionary<string, string> invoicesColumns = new Dictionary<string, string>
            {
                { "Id", "Id" },
                { "OrderId", "N° de Pedido" },
                { "ClientId", "N° de Cliente" },
                { "Date", "Fecha" },
                { "TotalAmount", "Total" },
                { "DebtAmount", "Deuda Total" },
            };
            SetupDataGridView(dataGridViewPendingInvoices, invoicesColumns);
            // TODO: arreglar el auto size aca, xq si agrego columnas despues del SetupDataGridView quedan muy chicas!!!
            DataGridViewButtonColumn buttonColumnInvoices = new DataGridViewButtonColumn();
            buttonColumnInvoices.Name = "CreateBillTransactionButton";
            buttonColumnInvoices.HeaderText = "Registrar Pago";
            buttonColumnInvoices.Text = "Registrar Pago";
            buttonColumnInvoices.UseColumnTextForButtonValue = true;
            dataGridViewPendingInvoices.Columns.Add(buttonColumnInvoices);
            // PENDING INVOICES
            SetupDataGridView(dataGridViewInvoices, invoicesColumns);
            // TRANSPORT COMPANIES
            Dictionary<string, string> transportCompaniesColumns = new Dictionary<string, string>
            {
                { "Id", "Id" },
                { "Name", "Nombre" },
                { "PhoneNumber", "N° de Telefono" },
            };
            SetupDataGridView(dataGridViewTransportCompanies, transportCompaniesColumns);
        }
        public static void SetupDataGridView(DataGridView dataGridView, Dictionary<string, string> columnDictionary)
        {
            // Disable auto-generate columns
            dataGridView.AutoGenerateColumns = false;

            // Customize the columns based on the dictionary
            foreach (var entry in columnDictionary)
            {
                dataGridView.Columns.Add(entry.Key, entry.Value);
                dataGridView.Columns[entry.Key].DataPropertyName = entry.Key;
            }

            // Set up additional properties for all DataGridViews
            dataGridView.RowHeadersVisible = false;
            dataGridView.AllowUserToAddRows = false;

            foreach (DataGridViewColumn column in dataGridView.Columns)
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
            if (orders != null)
            {
                dataGridViewOrders.DataSource = new BindingList<OrderViewModel>(orders);
            }
            invoices = await ApiHelper.GetListAsync<InvoiceViewModel>("https://localhost:7215/api/invoices/view-models");

            if (invoices != null)
            {
                dataGridViewInvoices.DataSource = new BindingList<InvoiceViewModel>(invoices);
            }
            billingTransactions = await ApiHelper.GetListAsync<BillingTransaction>("https://localhost:7215/api/billing-transactions");

            if (billingTransactions != null)
            {
                dataGridViewBillingTransactions.DataSource = new BindingList<BillingTransaction>(billingTransactions);
            }
            // pending invoices...
            pendingInvoices = GetPendingInvoices();
            if (pendingInvoices != null)
            {
                dataGridViewPendingInvoices.DataSource = new BindingList<InvoiceViewModel>(pendingInvoices);
            }
            transportCompanies = await ApiHelper.GetListAsync<TransportCompany>("https://localhost:7215/api/transport-companies");

            if (transportCompanies != null)
            {
                dataGridViewTransportCompanies.DataSource = new BindingList<TransportCompany>(transportCompanies);
            }
        }
        private List<InvoiceViewModel> GetPendingInvoices()
        {
            var result = new List<InvoiceViewModel>();
            foreach (var invoice in invoices)
            {
                if (invoice.DebtAmount != 0)
                {
                    result.Add(invoice);
                }
            }
            return result;
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

        private async void dataGridViewOrders_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == dataGridViewOrders.Columns["ReviewButton"].Index && e.RowIndex >= 0)
            {
                bool hasInvoice = (bool)dataGridViewOrders.Rows[e.RowIndex].Cells["HasInvoice"].Value;
                if (!hasInvoice)
                {
                    int orderId = (int)dataGridViewOrders.Rows[e.RowIndex].Cells["Id"].Value;
                    var form = new OrderReview(orderId);
                    form.ShowDialog();
                    await LoadData();
                }
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
                Quantity = Convert.ToInt32(txtBoxSupplierProductQuantity.Text),
                Price = Convert.ToDouble(txtBoxSupplierProductPrice.Text),
            };
            string response = await ApiHelper.PostAsync("https://localhost:7215/api/supplier-products", supplierProduct);
            if (response.Contains("error"))
            {
                MessageBox.Show("Error al registrar compra", response, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                MessageBox.Show("Compra registrada!", string.Empty, MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtBoxSupplierProductProductId.Text = string.Empty;
                txtBoxSupplierProductSupplierId.Text = string.Empty;
                txtBoxSupplierProductPrice.Text = string.Empty;
                txtBoxSupplierProductQuantity.Text = string.Empty;
                await LoadData();

            }

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

        private async void dataGridViewPendingInvoices_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == dataGridViewPendingInvoices.Columns["CreateBillTransactionButton"].Index && e.RowIndex >= 0)
            {
                int invoiceId = (int)dataGridViewPendingInvoices.Rows[e.RowIndex].Cells["Id"].Value;
                int clientId = (int)dataGridViewPendingInvoices.Rows[e.RowIndex].Cells["ClientId"].Value;
                var billTransaction = new BillingTransactionDto()
                {
                    InvoiceId = invoiceId,
                    ClientId = clientId
                };
                var form = new CreateBillingTransaction(billTransaction);
                form.ShowDialog();
                await LoadData();
            }
        }

        private async void buttonCreateTransportCompany_Click(object sender, EventArgs e)
        {
            var form = new CreateTransportCompany();
            form.ShowDialog();
            await LoadData();
        }

        private async void buttonCreateInvoice_Click(object sender, EventArgs e)
        {
            var form = new CreateInvoice();
            form.ShowDialog();
            await LoadData();
        }
    }
}