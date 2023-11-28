using Contracts.DTOs.Entities;
using Contracts.DTOs.Relationships;
using Contracts.DTOs.Reports;
using Contracts.Utils;
using Contracts.ViewModels;
using Contracts.ViewModels.Reports;
using Entities.Core;
using Entities.Relationships;
using Newtonsoft.Json;
using OfficeOpenXml;
using OfficeOpenXml.Style;
using System.ComponentModel;
using WinFormsApp.Utils;
using static System.Runtime.InteropServices.JavaScript.JSType;
using Timer = System.Windows.Forms.Timer;

namespace WinFormsApp
{
    public partial class Main : Form
    {
        private int _officeWorkerId;
        private List<Category> categories;
        private List<ProductViewModel> products;
        private List<Client> clients;
        private List<Supplier> suppliers;
        private List<SellerViewModel> sellers;
        private List<OrderViewModel> orders;
        private List<InvoiceViewModel> invoices;
        private List<InvoiceViewModel> pendingInvoices;
        private List<BillingTransactionViewModel> billingTransactions;
        private List<TransportCompany> transportCompanies;
        private List<OfficeWorkerViewModel> officeWorkers;
        private List<DiscountedProductViewModel> discountedProducts;
        private List<SellerClient> visitRequests;


        private string textToSearchCategories;
        private string textToSearchProducts;
        private string textToSearchClients;
        private string textToSearchSuppliers;
        private string textToSearchSellers;
        private string textToSearchOrders; // Ajusta según la propiedad real
        private string textToSearchInvoices; // Ajusta según la propiedad real
        private string textToSearchPendingInvoices; // Ajusta según la propiedad real
        private string textToSearchBillingTransactions; // Ajusta según la propiedad real
        private string textToSearchTransportCompanies; // Ajusta según la propiedad real
        private string textToSearchOfficeWorkers; // Ajusta según la propiedad real
        private string textToSearchDiscountedProducts; // Ajusta según la propiedad real
        private string textToSearchVisitRequests; // Ajusta según la propiedad real

        private Timer refreshTimer;
        private double _purchasePrice;
        private double _profitMarginPercentage;

        public Main(int officeWorkerId)
        {
            this.StartPosition = FormStartPosition.CenterScreen;
            _officeWorkerId = officeWorkerId;

            InitializeComponent();
            refreshTimer = new System.Windows.Forms.Timer();
            refreshTimer.Interval = 15000; // 15 seconds
            refreshTimer.Tick += new EventHandler(RefreshTimer_Tick);
            refreshTimer.Start();
            this.Text = "MOTO-TOP";

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
            string categoryName = FormInputValidator.ValidateAndGetDungeonTextBoxText(txtBoxCategoryName, "Category Name");

            if (categoryName != null)
            {
                var category = new CategoryDto()
                {
                    Name = categoryName,
                };

                string response = await ApiHelper.PostAsync($"{ApiUrl.LocalUrl}categories", category);

                if (response.Contains("error") || response.Contains("failed"))
                {
                    MessageBoxHelper.ShowErrorMessageBox("Error al crear categoría");
                }
                else
                {
                    MessageBoxHelper.ShowSuccessMessageBox("Categoría registrada!");
                    await LoadData();
                    FormInputClearer.ClearDungeonTextBoxes(txtBoxCategoryName);
                }
            }


        }

        private async void Main_Load(object sender, EventArgs e)
        {
            StyleDataGrids();
            await LoadData();

            txtBoxSupplierProductSupplierId.Enabled = false;
            txtBoxSupplierProductProductId.Enabled = false;
            txtBoxSupplierProductProductName.Enabled = false;
            txtBoxTotalSalesReportTotalAmount.Enabled = false;
            txtBoxTotalSalesReportTotalQuantity.Enabled = false;

            dateTimeClientPurchasesReportFrom.Value = DateTime.Today;
            dateTimeClientPurchasesReportTo.Value = DateTime.Today;
            dateTimeSellersSalesFrom.Value = DateTime.Today;
            dateTimeSellersSalesTo.Value = DateTime.Today;
            dateTimeTotalSalesFrom.Value = DateTime.Today;
            dateTimeTotalSalesTo.Value = DateTime.Today;
            dateTimeProductsSalesFrom.Value = DateTime.Today;
            dateTimeProductsSalesTo.Value = DateTime.Today;

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
                { "SellingPrice", "Precio de Venta" },
                { "PurchasePrice", "Precio de Compra" },
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
                { "DocumentType", "Tipo de Documento" },
                { "DocumentNumber", "N° de Documento" },
                { "Email", "Email" },
                { "Location", "Ubicación" },
                { "PhoneNumber", "Número de Telefono" }
            };

            SetupDataGridView(dataGridViewClients, clientsColumns);

            // SUPPLIERS
            Dictionary<string, string> suppliersColumns = new Dictionary<string, string>
            {
                { "Id", "Id" },
                { "Name", "Nombre" },
                { "Email", "Email" },
                { "PhoneNumber", "Número de Telefono" }
            };

            SetupDataGridView(dataGridViewSuppliers, suppliersColumns);
            // SELLERS
            Dictionary<string, string> sellersColumns = new Dictionary<string, string>
            {
                { "Id", "Id" },
                { "Zone", "Zona Asignada" },
                { "FirstName", "Nombre" },
                { "LastName", "Apellido" },
                 { "Email", "Email" },
                { "DocumentType", "Tipo de Documento" },
                { "DocumentNumber", "N° de Documento" },
            };

            SetupDataGridView(dataGridViewSellers, sellersColumns);

            // ORDERS
            Dictionary<string, string> ordersColumns = new Dictionary<string, string>
            {
                { "Id", "Id" },
                 { "Date", "Fecha" },
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
            dataGridViewOrders.Columns["HasInvoice"].ReadOnly = true;
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
                { "ClientName", "Cliente" },
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
                { "SellerName", "Vendedor" },
                { "ClientId", "N° de Cliente" },
                { "ClientName", "Cliente" },
                { "Date", "Fecha" },
                { "TotalAmount", "Total" },
                { "DebtAmount", "Deuda Pendiente" },
            };
            SetupDataGridView(dataGridViewPendingInvoices, invoicesColumns);
            DataGridViewButtonColumn buttonColumnInvoices = new DataGridViewButtonColumn();
            buttonColumnInvoices.Name = "CreateBillTransactionButton";
            buttonColumnInvoices.HeaderText = "Registrar Pago";
            buttonColumnInvoices.Text = "Registrar Pago";
            buttonColumnInvoices.UseColumnTextForButtonValue = true;
            dataGridViewPendingInvoices.Columns.Add(buttonColumnInvoices);
            AutoSizeColumnsDGV(dataGridViewPendingInvoices);
            // INVOICES
            SetupDataGridView(dataGridViewInvoices, invoicesColumns);
            DataGridViewButtonColumn inbuttonColumnOrders = new DataGridViewButtonColumn();
            inbuttonColumnOrders.Name = "ReviewButton";
            inbuttonColumnOrders.HeaderText = "Revisar";
            inbuttonColumnOrders.Text = "Revisar";
            inbuttonColumnOrders.UseColumnTextForButtonValue = true;
            dataGridViewInvoices.Columns.Add(inbuttonColumnOrders);
            // TRANSPORT COMPANIES
            Dictionary<string, string> transportCompaniesColumns = new Dictionary<string, string>
            {
                { "Id", "Id" },
                { "Name", "Nombre" },
                { "Email", "Email" },
                { "PhoneNumber", "N° de Telefono" },
            };
            SetupDataGridView(dataGridViewTransportCompanies, transportCompaniesColumns);
            // OFFICE WORKERS
            Dictionary<string, string> offWorkersColumns = new Dictionary<string, string>
            {
                { "Id", "Id" },
                { "FirstName", "Nombre" },
                { "LastName", "Apellido" },
                { "Email", "Email" },
                { "DocumentType", "Tipo de Documento" },
                { "DocumentNumber", "N° de Documento" },
            };

            SetupDataGridView(dataGridViewOfficeWorkers, offWorkersColumns);
            // SELLERS SALES
            Dictionary<string, string> sellersSalesColumns = new Dictionary<string, string>
            {
                { "SellerId", "N° Vendedor" },
                { "FirstName", "Nombre" },
                { "LastName", "Apellido" },
                { "Zone", "Zona" },
                { "TotalSales", "Cantidad de Ventas" },
                { "TotalAmount", "Importe Total ($)" },
            };

            SetupDataGridView(dataGridViewSellersSales, sellersSalesColumns);
            // ORDERS PENDING SHIPMENT
            Dictionary<string, string> ordersPendShipColumns = new Dictionary<string, string>
            {
                { "Id", "Id de Envio" },
                { "ShipmentStatus", "Estado" },
                { "ClientName", "Cliente" },
                { "SellerName", "Vendedor" },
            };
            SetupDataGridView(dataGridViewOrdersPendingShipment, ordersPendShipColumns);
            // CLIENTS BALANCES
            Dictionary<string, string> clientsBalancesColumns = new Dictionary<string, string>
            {
                { "Id", "Id" },
                { "FirstName", "Nombre" },
                { "LastName", "Apellido" },
                { "DocumentType", "Tipo de Documento" },
                { "DocumentNumber", "N° de Documento" },
                { "Email", "Email" },
                { "Location", "Ubicación" },
                { "PhoneNumber", "Número de Telefono" },
                { "TotalBalance", "Saldo Total" }
            };

            SetupDataGridView(dataGridViewClientsBalances, clientsBalancesColumns);
            // PENDING INVOICES REPORT
            Dictionary<string, string> pendingInvoicesReportColumns = new Dictionary<string, string>
            {
                { "Id", "Id" },
                { "OrderId", "N° de Pedido" },
                { "ClientId", "N° de Cliente" },
                { "ClientName", "Cliente" },
                { "ClientDocument", "Documento del Cliente" },
                { "Date", "Fecha" },
                { "TotalAmount", "Total" },
                { "DebtAmount", "Deuda Pendiente" },
            };
            SetupDataGridView(dataGridViewPendingInvoicesReport, pendingInvoicesReportColumns);
            // TOTAL SALES REPORT
            Dictionary<string, string> totalSalesRepColumns = new Dictionary<string, string>
            {
                { "Id", "Id" },
                { "OrderId", "N° de Pedido" },
                { "SellerName", "Vendedor" },
                { "ClientId", "N° de Cliente" },
                { "ClientName", "Cliente" },
                { "Date", "Fecha" },
                { "TotalAmount", "Total" },

            };
            SetupDataGridView(dataGridViewTotalSalesReport, totalSalesRepColumns);
            // CLIENTS PURCHASES REPORT
            Dictionary<string, string> clientsPurchasesReportColumns = new Dictionary<string, string>
            {
                { "ClientId", "N° de Cliente" },
                { "FirstName", "Nombre" },
                { "LastName", "Apellido" },
                { "DocumentType", "Tipo de Documento" },
                { "DocumentNumber", "N° de Documento" },
                { "Email", "Email" },
                { "PhoneNumber", "Número de Telefono" },
                { "TotalPurchases", "Cantidad de Compras" },
                { "TotalAmount", "Importe Total ($)" },

            };
            SetupDataGridView(dataGridViewClientsPruchasesReport, clientsPurchasesReportColumns);
            // PRODUCTS SALES REPORT
            Dictionary<string, string> productsSalesReportColumns = new Dictionary<string, string>
            {
                { "Id", "N° de Producto" },
                { "CategoryName", "Rubro" },
                { "Name", "Producto" },
                { "Description", "Descripción" },
                { "TotalSales", "Cantidad de Ventas" },
                { "TotalAmount", "Importe Total ($)" },
            };
            SetupDataGridView(dataGridViewProductsSalesReport, productsSalesReportColumns);
            // ACTIVE DISCOUNTS
            Dictionary<string, string> activeDiscountsColumns = new Dictionary<string, string>
            {
                { "Id", "N° de Producto" },
                { "DateStart", "Fecha de Inicio" },
                { "DateEnd", "Fecha Final" },
                { "CategoryName", "Rubro" },
                { "Name", "Nombre" },
                { "Description", "Descripcion" },
                { "Quantity", "Stock" },
                { "OriginalPrice", "Precio Original" },
                { "DiscountPercentage", "Descuento (%)" },
                { "DiscountAmount", "Descuento ($)" },
                { "DiscountedPrice", "Precio con Descuento" },

            };
            SetupDataGridView(dataGridViewActiveDiscounts, activeDiscountsColumns);
            DataGridViewButtonColumn acbuttonColumnOrders = new DataGridViewButtonColumn();
            acbuttonColumnOrders.Name = "EditButton";
            acbuttonColumnOrders.HeaderText = "Editar";
            acbuttonColumnOrders.Text = "Editar";
            acbuttonColumnOrders.UseColumnTextForButtonValue = true;
            dataGridViewActiveDiscounts.Columns.Add(acbuttonColumnOrders);
            // VISIT REQUEST
            Dictionary<string, string> visitRequestsColumns = new Dictionary<string, string>
            {
                 { "Id", "Id" },
                { "FirstName", "Nombre" },
                { "LastName", "Apellido" },
                { "Location", "Ubicación" },
                { "PhoneNumber", "N° de Telefono" },
                { "Email", "Email" },


            };
            SetupDataGridView(dataGridViewVisitRequest, visitRequestsColumns);
            DataGridViewCheckBoxColumn vrcheckBoxColumnOrders = new DataGridViewCheckBoxColumn();
            vrcheckBoxColumnOrders.HeaderText = "Atendido";
            vrcheckBoxColumnOrders.Name = "IsDone";
            vrcheckBoxColumnOrders.DataPropertyName = "IsDone";
            vrcheckBoxColumnOrders.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dataGridViewVisitRequest.Columns.Add(vrcheckBoxColumnOrders);
            dataGridViewVisitRequest.Columns["IsDone"].ReadOnly = true;
            DataGridViewButtonColumn vrbuttonColumnOrders = new DataGridViewButtonColumn();
            vrbuttonColumnOrders.Name = "ReviewButton";
            vrbuttonColumnOrders.HeaderText = "Revisar";
            vrbuttonColumnOrders.Text = "Revisar";
            vrbuttonColumnOrders.UseColumnTextForButtonValue = true;
            dataGridViewVisitRequest.Columns.Add(vrbuttonColumnOrders);
        }
        public static void SetupDataGridView(DataGridView dataGridView, Dictionary<string, string> columnDictionary)
        {
            // estilo de todos los datagrids...
            dataGridView.ColumnHeadersDefaultCellStyle.ForeColor = Color.Black;
            dataGridView.ColumnHeadersDefaultCellStyle.BackColor = Color.LightSteelBlue;
            dataGridView.ColumnHeadersDefaultCellStyle.SelectionBackColor = Color.LightSteelBlue;
            dataGridView.DefaultCellStyle.SelectionBackColor = Color.White;
            dataGridView.DefaultCellStyle.SelectionForeColor = Color.Black;

            // no auto generar columnas!
            dataGridView.AutoGenerateColumns = false;

            // columnas --> segun diccionario
            foreach (var entry in columnDictionary)
            {
                dataGridView.Columns.Add(entry.Key, entry.Value);
                dataGridView.Columns[entry.Key].DataPropertyName = entry.Key;
                dataGridView.Columns[entry.Key].ReadOnly = true;
            }

            // propiedades
            dataGridView.RowHeadersVisible = false;
            dataGridView.AllowUserToAddRows = false;
            // tamaño de c/columna --> fill (todas iguales)
            AutoSizeColumnsDGV(dataGridView);


        }
        private static void AutoSizeColumnsDGV(DataGridView dataGridView)
        {
            foreach (DataGridViewColumn column in dataGridView.Columns)
            {
                column.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            }
        }
        private async Task LoadData()
        {
            categories = await ApiHelper.GetListAsync<Category>($"{ApiUrl.LocalUrl}categories");
            SearchListGeneric(categories, dataGridViewCategories, textToSearchCategories);


            products = await ApiHelper.GetListAsync<ProductViewModel>($"{ApiUrl.LocalUrl}products/view-models");

            SearchListGeneric(products, dataGridViewProducts, textToSearchProducts);
            clients = await ApiHelper.GetListAsync<Client>($"{ApiUrl.LocalUrl}clients");
            SearchListGeneric(clients, dataGridViewClients, textToSearchClients);

            suppliers = await ApiHelper.GetListAsync<Supplier>($"{ApiUrl.LocalUrl}suppliers");
            SearchListGeneric(suppliers, dataGridViewSuppliers, textToSearchSuppliers);

            sellers = await ApiHelper.GetListAsync<SellerViewModel>($"{ApiUrl.LocalUrl}sellers/view-models");
            SearchListGeneric(sellers, dataGridViewSellers, textToSearchSellers);

            orders = await ApiHelper.GetListAsync<OrderViewModel>($"{ApiUrl.LocalUrl}orders/view-models");
            SearchListGeneric(orders, dataGridViewOrders, textToSearchOrders);

            invoices = await ApiHelper.GetListAsync<InvoiceViewModel>($"{ApiUrl.LocalUrl}invoices/view-models");
            SearchListGeneric(invoices, dataGridViewInvoices, textToSearchInvoices);

            // pending invoices...
            pendingInvoices = GetPendingInvoices();
            SearchListGeneric(pendingInvoices, dataGridViewPendingInvoices, textToSearchPendingInvoices);

            billingTransactions = await ApiHelper.GetListAsync<BillingTransactionViewModel>($"{ApiUrl.LocalUrl}billing-transactions/view-models");
            SearchListGeneric(billingTransactions, dataGridViewBillingTransactions, textToSearchBillingTransactions);

            transportCompanies = await ApiHelper.GetListAsync<TransportCompany>($"{ApiUrl.LocalUrl}transport-companies");
            SearchListGeneric(transportCompanies, dataGridViewTransportCompanies, textToSearchTransportCompanies);

            officeWorkers = await ApiHelper.GetListAsync<OfficeWorkerViewModel>($"{ApiUrl.LocalUrl}office-workers/view-models");
            SearchListGeneric(officeWorkers, dataGridViewOfficeWorkers, textToSearchOfficeWorkers);

            discountedProducts = await ApiHelper.GetListAsync<DiscountedProductViewModel>($"{ApiUrl.LocalUrl}products/discounted");
            SearchListGeneric(discountedProducts, dataGridViewActiveDiscounts, textToSearchDiscountedProducts);

            visitRequests = await ApiHelper.GetListAsync<SellerClient>($"{ApiUrl.LocalUrl}seller-clients");
            SearchListGeneric(visitRequests, dataGridViewVisitRequest, textToSearchVisitRequests);

        }
        private void SearchListGeneric<T>(List<T> lista, DataGridView dataGridView, string textToSearch)
        {
            if (string.IsNullOrWhiteSpace(textToSearch))
            {
                // Si el texto de búsqueda está vacío, mostrar todos los elementos en el DataGridView
                dataGridView.DataSource = new BindingList<T>(lista);
            }
            else
            {
                // Filtrar la lista según el criterio de búsqueda
                var resultados = lista.Where(item => ContieneValorEnJson(item, textToSearch.ToLower())).ToList();

                // Actualizar el DataGridView con los resultados encontrados
                dataGridView.DataSource = new BindingList<T>(resultados);
            }
        }
        private bool ContieneValorEnJson<T>(T item, string textToSearch)
        {
            // Convertir el objeto a formato JSON
            var json = JsonConvert.SerializeObject(item);

            // Verificar si el JSON contiene el valor de búsqueda
            return json.ToLower().Contains(textToSearch);
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
                    Guid orderId = (Guid)dataGridViewOrders.Rows[e.RowIndex].Cells["Id"].Value;
                    var form = new OrderReview(orderId);
                    form.ShowDialog();
                    await LoadData();
                }
                else
                {
                    Guid orderId = (Guid)dataGridViewOrders.Rows[e.RowIndex].Cells["Id"].Value;
                    var form = new UpdateOrderStatus(orderId);
                    form.ShowDialog();
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

            if (int.TryParse(txtBoxSupplierProductProductId.Text, out int productId) &&
            int.TryParse(txtBoxSupplierProductSupplierId.Text, out int supplierId) &&
            int.TryParse(txtBoxSupplierProductQuantity.Text, out int quantity) &&
            double.TryParse(txtBoxSupplierProductPurchasePrice.Text, out double purchasePrice) &&
            double.TryParse(txtBoxSupplierProductSellingPrice.Text, out double sellingPrice))
            {

                var supplierProduct = new SupplierProductDto()
                {
                    ProductId = productId,
                    SupplierId = supplierId,
                    Quantity = quantity,
                    PurchasePrice = purchasePrice,
                    SellingPrice = sellingPrice,
                };

                string response = await ApiHelper.PostAsync($"{ApiUrl.LocalUrl}supplier-products", supplierProduct);
                if (response.Contains("error") || response.Contains("failed"))
                {
                    MessageBox.Show("Error al registrar compra", response, MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    MessageBoxHelper.ShowSuccessMessageBox("Compra registrada!");
                    FormInputClearer.ClearDungeonTextBoxes(txtBoxSupplierProductProductId, txtBoxSupplierProductSupplierId, txtBoxSupplierProductSellingPrice, txtBoxSupplierProductQuantity, txtBoxSupplierProductProfitMargin, txtBoxSupplierProductPurchasePrice, txtBoxSupplierProductProductName);
                    await LoadData();

                }
            }
            else
            {
                MessageBoxHelper.ShowErrorMessageBox("Complete todos los campos requeridos!");
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
        private void HandleProductSelected(ProductViewModel selectedProduct)
        {
            txtBoxSupplierProductProductId.Text = selectedProduct.Id.ToString();
            txtBoxSupplierProductProductName.Text = $"{selectedProduct.CategoryName} {selectedProduct.Name}";
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
            var form = new CreateInvoice(_officeWorkerId);
            form.ShowDialog();
            await LoadData();
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }
        // actulizacion de precio de venta para registro de compra
        private void UpdateSellingPrice()
        {
            double sellingPrice = _purchasePrice + (_purchasePrice * (_profitMarginPercentage / 100));
            txtBoxSupplierProductSellingPrice.Text = sellingPrice.ToString();
        }

        private void txtBoxSupplierProductPurchasePrice_TextChanged(object sender, EventArgs e)
        {
            double.TryParse(txtBoxSupplierProductPurchasePrice.Text, out _purchasePrice);
            UpdateSellingPrice();

        }

        private void txtBoxSupplierProductProfitMargin_TextChanged(object sender, EventArgs e)
        {
            double.TryParse(txtBoxSupplierProductProfitMargin.Text, out _profitMarginPercentage);
            UpdateSellingPrice();
        }
        // -----------------------------------------------------------
        private async void buttonCreateOfficeWorker_Click(object sender, EventArgs e)
        {
            var form = new CreateOfficeWorker();
            form.ShowDialog();
            await LoadData();
        }

        private void hopeTabPage_Resize(object sender, EventArgs e)
        {

        }

        private async void buttonGenerateSellersSalesReport_Click(object sender, EventArgs e)
        {
            DateTime dateFrom = dateTimeSellersSalesFrom.Value;
            DateTime dateTo = dateTimeSellersSalesTo.Value;
            var datesDto = new DateFromToDto()
            {
                From = dateFrom,
                To = dateTo,
            };
            string response = await ApiHelper.PostAsync($"{ApiUrl.LocalUrl}reports/sellers-sales", datesDto);
            if (response.Contains("error") || response.Contains("failed"))
            {
                MessageBox.Show("Error al generar reporte", response, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                var sellerSalesVM = JsonConvert.DeserializeObject<List<SellersSalesViewModel>>(response);
                dataGridViewSellersSales.DataSource = new BindingList<SellersSalesViewModel>(sellerSalesVM);
            }

        }
        private void buttonExportSellersSalesReport_Click(object sender, EventArgs e)
        {
            var dateFrom = dateTimeSellersSalesFrom.Value;
            var dateTo = dateTimeSellersSalesTo.Value;
            var sellersSales = ((BindingList<SellersSalesViewModel>)dataGridViewSellersSales.DataSource).ToList();
            ExportSellerSalesToExcel(sellersSales, dateFrom, dateTo);
        }
        public void ExportSellerSalesToExcel(List<SellersSalesViewModel> sellersSales, DateTime dateFrom, DateTime dateTo)
        {
            ExcelPackage.LicenseContext = OfficeOpenXml.LicenseContext.NonCommercial;
            using (var package = new ExcelPackage())
            {
                var worksheet = package.Workbook.Worksheets.Add("Ventas por Vendedor");
                // TITULO
                worksheet.Cells["A1"].Value = "Cantidad de Ventas por Vendedor";
                worksheet.Cells["A1:F1"].Merge = true;
                worksheet.Cells["A1:F1"].Style.Font.Size = 16;
                worksheet.Cells["A1:F1"].Style.Font.Bold = true;
                worksheet.Cells["A1:F1"].Style.HorizontalAlignment = ExcelHorizontalAlignment.Center;

                // FECHAS
                worksheet.Cells["A3"].Value = "Periodo:";
                worksheet.Cells["B3"].Value = dateFrom.ToString("dd/MM/yyyy");
                worksheet.Cells["C3"].Value = " - ";
                worksheet.Cells["C3"].Style.HorizontalAlignment = OfficeOpenXml.Style.ExcelHorizontalAlignment.Center;
                worksheet.Cells["D3"].Value = dateTo.ToString("dd/MM/yyyy");

                // HEADERS PARA TABLA
                worksheet.Cells["A5"].LoadFromCollection(sellersSales, true, OfficeOpenXml.Table.TableStyles.Light1);
                worksheet.Cells["A5"].Value = "N° Vendedor";
                worksheet.Cells["B5"].Value = "Nombre";
                worksheet.Cells["C5"].Value = "Apellido";
                worksheet.Cells["D5"].Value = "Zona";
                worksheet.Cells["E5"].Value = "Cantidad de Ventas";
                worksheet.Cells["F5"].Value = "Importe Total($)";

                // SUMA -- FORMULA
                int rows = worksheet.Dimension.End.Row;
                int finalRow = rows + 1;
                worksheet.Cells[$"E{finalRow}"].Formula = $"SUM(E6:E{rows})";
                worksheet.Cells[$"F{finalRow}"].Formula = $"SUM(F6:F{rows})";

                // Auto-fit COLUMNAS
                worksheet.Cells[worksheet.Dimension.Address].AutoFitColumns();

                // GUARDAR ARCHIVO
                var fileName = $"VentasXVendedor_{dateFrom:yyyyMMdd}-{dateTo:yyyyMMdd}.xlsx";
                var saveFileDialog = new SaveFileDialog
                {
                    Filter = "Excel Files|*.xlsx",
                    FileName = fileName
                };

                if (saveFileDialog.ShowDialog() == DialogResult.OK)
                {
                    var fileInfo = new FileInfo(saveFileDialog.FileName);
                    package.SaveAs(fileInfo);
                    MessageBox.Show("El archivo se ha exportado exitosamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }


        private async void buttonGenerateReportOrdersPendingShipment_Click(object sender, EventArgs e)
        {
            var response = await ApiHelper.GetListAsync<OrderViewModel>($"{ApiUrl.LocalUrl}reports/orders-pending-shipment");
            if (response == null)
            {
                MessageBoxHelper.ShowInfoMessageBox("No hay pedidos pendientes de envio.");
            }
            else
            {
                dataGridViewOrdersPendingShipment.DataSource = new BindingList<OrderViewModel>(response);
            }
        }

        private void buttonExportReportOrdersPendingShipment_Click(object sender, EventArgs e)
        {
            var sellersSales = ((BindingList<OrderViewModel>)dataGridViewOrdersPendingShipment.DataSource).ToList();
            ExportOrdersPendingShipmentToExcel(sellersSales);
        }
        public void ExportOrdersPendingShipmentToExcel(List<OrderViewModel> ordersVM)
        {
            ExcelPackage.LicenseContext = OfficeOpenXml.LicenseContext.NonCommercial;
            using (var package = new ExcelPackage())
            {
                var worksheet = package.Workbook.Worksheets.Add("Pedidos Pendientes de Envio");

                // TITULO
                worksheet.Cells["A1"].Value = "Pedidos Pendientes de Envio";
                worksheet.Cells["A1:F1"].Merge = true;
                worksheet.Cells["A1:F1"].Style.Font.Size = 16;
                worksheet.Cells["A1:F1"].Style.Font.Bold = true;
                worksheet.Cells["A1:F1"].Style.HorizontalAlignment = ExcelHorizontalAlignment.Center;

                // HEADERS PARA TABLA
                worksheet.Cells["A3"].LoadFromCollection(ordersVM, true, OfficeOpenXml.Table.TableStyles.Light1);
                worksheet.Cells["A3"].Value = "Id";
                worksheet.Cells["B3"].Value = "Fecha";
                worksheet.Cells["C3"].Value = "Estado";

                worksheet.Cells["D3"].Value = "Cliente";

                worksheet.Cells["E3"].Value = "Vendedor";

                var dateColumn = worksheet.Column(2);
                dateColumn.Style.Numberformat.Format = "yyyy-MM-dd";

                // Auto-fit COLUMNAS
                worksheet.Cells[worksheet.Dimension.Address].AutoFitColumns();

                // GUARDAR ARCHIVO
                var fileName = $"PedidosPendientesDeEnvio_{DateTime.Now:yyyyMMdd}.xlsx";
                var saveFileDialog = new SaveFileDialog
                {
                    Filter = "Excel Files|*.xlsx",
                    FileName = fileName
                };

                if (saveFileDialog.ShowDialog() == DialogResult.OK)
                {
                    var fileInfo = new FileInfo(saveFileDialog.FileName);
                    package.SaveAs(fileInfo);
                    MessageBox.Show("El archivo se ha exportado exitosamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }
        private void buttonExportClientsBalances_Click(object sender, EventArgs e)
        {
            var clientBalances = ((BindingList<ClientsBalanceViewModel>)dataGridViewClientsBalances.DataSource).ToList();
            ExportClientBalancesToExcel(clientBalances);
        }
        public void ExportClientBalancesToExcel(List<ClientsBalanceViewModel> clientsBalanceVM)
        {
            ExcelPackage.LicenseContext = OfficeOpenXml.LicenseContext.NonCommercial;
            using (var package = new ExcelPackage())
            {
                var worksheet = package.Workbook.Worksheets.Add("Saldo de Clientes");

                // TITULO
                worksheet.Cells["A1"].Value = "Saldo de Clientes";
                worksheet.Cells["A1:F1"].Merge = true;
                worksheet.Cells["A1:F1"].Style.Font.Size = 16;
                worksheet.Cells["A1:F1"].Style.Font.Bold = true;
                worksheet.Cells["A1:F1"].Style.HorizontalAlignment = ExcelHorizontalAlignment.Center;

                // HEADERS PARA TABLA
                worksheet.Cells["A3"].LoadFromCollection(clientsBalanceVM, true, OfficeOpenXml.Table.TableStyles.Light1);
                worksheet.Cells["A3"].Value = "N° Cliente";
                worksheet.Cells["B3"].Value = "Nombre";
                worksheet.Cells["C3"].Value = "Apellido";

                worksheet.Cells["D3"].Value = "Dirección";

                worksheet.Cells["E3"].Value = "N° Telefono";
                worksheet.Cells["F3"].Value = "Tipo de Documento";
                worksheet.Cells["G3"].Value = "N° de Documento";
                worksheet.Cells["H3"].Value = "Email";
                worksheet.Cells["I3"].Value = "Saldo Total";
                // SUMA -- FORMULA
                int rows = worksheet.Dimension.End.Row;
                int finalRow = rows + 1;
                worksheet.Cells[$"I{finalRow}"].Formula = $"SUM(I4:I{rows})";
                // Auto-fit COLUMNAS
                worksheet.Cells[worksheet.Dimension.Address].AutoFitColumns();

                // GUARDAR ARCHIVO
                var fileName = $"SaldoDeClientes_{DateTime.Now:yyyyMMdd}.xlsx";
                var saveFileDialog = new SaveFileDialog
                {
                    Filter = "Excel Files|*.xlsx",
                    FileName = fileName
                };

                if (saveFileDialog.ShowDialog() == DialogResult.OK)
                {
                    var fileInfo = new FileInfo(saveFileDialog.FileName);
                    package.SaveAs(fileInfo);
                    MessageBox.Show("El archivo se ha exportado exitosamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }
        private async void buttonGenerateClientsBalances_Click(object sender, EventArgs e)
        {
            var response = await ApiHelper.GetListAsync<ClientsBalanceViewModel>($"{ApiUrl.LocalUrl}reports/clients-balances");
            if (response == null)
            {
                MessageBoxHelper.ShowErrorMessageBox("Error al generar reporte.");
            }
            else
            {
                dataGridViewClientsBalances.DataSource = new BindingList<ClientsBalanceViewModel>(response);
            }
        }

        private void buttonGeneratePendingInvoicesReport_Click(object sender, EventArgs e)
        {
            if (invoices != null)
            {
                // pending invoices...
                pendingInvoices = GetPendingInvoices();
                if (pendingInvoices != null)
                {
                    dataGridViewPendingInvoicesReport.DataSource = new BindingList<InvoiceViewModel>(pendingInvoices);
                }
            }
        }

        private void buttonExportPendingInvoicesReport_Click(object sender, EventArgs e)
        {
            var pendingInvoices = ((BindingList<InvoiceViewModel>)dataGridViewPendingInvoicesReport.DataSource).ToList();
            ExportPendingInvoicesReportToExcel(pendingInvoices);
        }
        public void ExportPendingInvoicesReportToExcel(List<InvoiceViewModel> pendingInvoicesVM)
        {
            ExcelPackage.LicenseContext = OfficeOpenXml.LicenseContext.NonCommercial;
            using (var package = new ExcelPackage())
            {
                var worksheet = package.Workbook.Worksheets.Add("Facturas Pendientes");

                // TITULO
                worksheet.Cells["A1"].Value = "Facturas Pendientes";
                worksheet.Cells["A1:F1"].Merge = true;
                worksheet.Cells["A1:F1"].Style.Font.Size = 16;
                worksheet.Cells["A1:F1"].Style.Font.Bold = true;
                worksheet.Cells["A1:F1"].Style.HorizontalAlignment = ExcelHorizontalAlignment.Center;

                // HEADERS PARA TABLA
                worksheet.Cells["A3"].LoadFromCollection(pendingInvoicesVM, true, OfficeOpenXml.Table.TableStyles.Light1);
                worksheet.Cells["A3"].Value = "N° de Factura";
                worksheet.Cells["B3"].Value = "N° de Pedido";
                worksheet.Cells["C3"].Value = "Vendedor";
                worksheet.Cells["D3"].Value = "N° de Cliente";
                worksheet.Cells["E3"].Value = "Documento del Cliente";
                worksheet.Cells["F3"].Value = "Cliente";
                worksheet.Cells["G3"].Value = "Fecha";

                worksheet.Cells["H3"].Value = "Total Facturado ($)";
                worksheet.Cells["I3"].Value = "Deuda Pendiente ($)";
                var dateColumn = worksheet.Column(6);
                dateColumn.Style.Numberformat.Format = "yyyy-MM-dd";
                // SUMA -- FORMULA
                int rows = worksheet.Dimension.End.Row;
                int finalRow = rows + 1;
                worksheet.Cells[$"H{finalRow}"].Formula = $"SUM(H4:H{rows})";
                worksheet.Cells[$"I{finalRow}"].Formula = $"SUM(I4:I{rows})";
                // Auto-fit COLUMNAS
                worksheet.Cells[worksheet.Dimension.Address].AutoFitColumns();

                // GUARDAR ARCHIVO
                var fileName = $"FacturasPendientes_{DateTime.Now:yyyyMMdd}.xlsx";
                var saveFileDialog = new SaveFileDialog
                {
                    Filter = "Excel Files|*.xlsx",
                    FileName = fileName
                };

                if (saveFileDialog.ShowDialog() == DialogResult.OK)
                {
                    var fileInfo = new FileInfo(saveFileDialog.FileName);
                    package.SaveAs(fileInfo);
                    MessageBox.Show("El archivo se ha exportado exitosamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }

        private async void buttonGenerateTotalSalesReport_Click(object sender, EventArgs e)
        {
            DateTime dateFrom = dateTimeTotalSalesFrom.Value;
            DateTime dateTo = dateTimeTotalSalesTo.Value;
            var datesDto = new DateFromToDto()
            {
                From = dateFrom,
                To = dateTo,
            };
            string response = await ApiHelper.PostAsync($"{ApiUrl.LocalUrl}reports/total-sales", datesDto);
            if (response.Contains("error") || response.Contains("failed"))
            {
                MessageBox.Show("Error al generar reporte", response, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                int totalQuantity = 0;
                double totalAmount = 0;
                var invoices = JsonConvert.DeserializeObject<List<InvoiceViewModel>>(response);
                dataGridViewTotalSalesReport.DataSource = new BindingList<InvoiceViewModel>(invoices);
                foreach (var invoice in invoices)
                {
                    totalQuantity++;
                    totalAmount += invoice.TotalAmount;
                }
                txtBoxTotalSalesReportTotalAmount.Text = "$" + totalAmount.ToString();
                txtBoxTotalSalesReportTotalQuantity.Text = totalQuantity.ToString();
            }
        }

        private void buttonExportTotalSalesReport_Click(object sender, EventArgs e)
        {
            var invoices = ((BindingList<InvoiceViewModel>)dataGridViewTotalSalesReport.DataSource).ToList();
            ExportTotalSalesReportToExcel(invoices, dateTimeTotalSalesFrom.Value, dateTimeTotalSalesTo.Value);
        }
        public void ExportTotalSalesReportToExcel(List<InvoiceViewModel> invoices, DateTime dateFrom, DateTime dateTo)
        {
            ExcelPackage.LicenseContext = OfficeOpenXml.LicenseContext.NonCommercial;
            using (var package = new ExcelPackage())
            {
                var worksheet = package.Workbook.Worksheets.Add("Ventas Totales");

                // TITULO
                worksheet.Cells["A1"].Value = "Ventas Totales";
                worksheet.Cells["A1:F1"].Merge = true;
                worksheet.Cells["A1:F1"].Style.Font.Size = 16;
                worksheet.Cells["A1:F1"].Style.Font.Bold = true;
                worksheet.Cells["A1:F1"].Style.HorizontalAlignment = ExcelHorizontalAlignment.Center;

                // FECHAS
                worksheet.Cells["A3"].Value = "Periodo:";
                worksheet.Cells["B3"].Value = dateFrom.ToString("dd/MM/yyyy");
                worksheet.Cells["C3"].Value = " - ";
                worksheet.Cells["C3"].Style.HorizontalAlignment = OfficeOpenXml.Style.ExcelHorizontalAlignment.Center;
                worksheet.Cells["D3"].Value = dateTo.ToString("dd/MM/yyyy");

                // TOTALES:
                worksheet.Cells["A4"].Value = "Cantidad de Ventas:";
                worksheet.Cells["B4"].Value = Convert.ToInt64(txtBoxTotalSalesReportTotalQuantity.Text);
                worksheet.Cells["D4"].Value = "Importe Total ($):";
                string cleanedString = new string(txtBoxTotalSalesReportTotalAmount.Text.Where(char.IsDigit).ToArray());
                worksheet.Cells["E4"].Value = Convert.ToDouble(cleanedString);
                // HEADERS PARA TABLA
                worksheet.Cells["A6"].LoadFromCollection(invoices, true, OfficeOpenXml.Table.TableStyles.Light1);
                worksheet.Cells["A6"].Value = "N° de Factura";
                worksheet.Cells["B6"].Value = "N° de Pedido";
                worksheet.Cells["C6"].Value = "Vendedor";
                worksheet.Cells["D6"].Value = "N° de Cliente";
                worksheet.Cells["E6"].Value = "Documento del Cliente";
                worksheet.Cells["F6"].Value = "Cliente";
                worksheet.Cells["G6"].Value = "Fecha";

                worksheet.Cells["H6"].Value = "Total Facturado ($)";
                worksheet.Cells["I6"].Value = "Deuda Pendiente ($)";

                var dateColumn = worksheet.Column(6);
                dateColumn.Style.Numberformat.Format = "yyyy-MM-dd";
                // SUMA -- FORMULA
                int rows = worksheet.Dimension.End.Row;
                int finalRow = rows + 1;
                worksheet.Cells[$"H{finalRow}"].Formula = $"SUM(H7:H{rows})";
                worksheet.Cells[$"I{finalRow}"].Formula = $"SUM(I7:I{rows})";
                // Auto-fit COLUMNAS
                worksheet.Cells[worksheet.Dimension.Address].AutoFitColumns();

                // GUARDAR ARCHIVO
                var fileName = $"VentasTotales_{dateFrom:yyyyMMdd}-{dateTo:yyyyMMdd}.xlsx";
                var saveFileDialog = new SaveFileDialog
                {
                    Filter = "Excel Files|*.xlsx",
                    FileName = fileName
                };

                if (saveFileDialog.ShowDialog() == DialogResult.OK)
                {
                    var fileInfo = new FileInfo(saveFileDialog.FileName);
                    package.SaveAs(fileInfo);
                    MessageBox.Show("El archivo se ha exportado exitosamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }

        private void buttonExportClientPurchasesReport_Click(object sender, EventArgs e)
        {

            var clientsPurchasesVM = ((BindingList<ClientPurchasesViewModel>)dataGridViewClientsPruchasesReport.DataSource).ToList();
            ExportClientsPurchasesReportToExcel(clientsPurchasesVM, dateTimeClientPurchasesReportFrom.Value, dateTimeClientPurchasesReportTo.Value);

        }
        public void ExportClientsPurchasesReportToExcel(List<ClientPurchasesViewModel> clientsPurchasesVM, DateTime dateFrom, DateTime dateTo)
        {

            ExcelPackage.LicenseContext = OfficeOpenXml.LicenseContext.NonCommercial;
            using (var package = new ExcelPackage())
            {
                var worksheet = package.Workbook.Worksheets.Add("Compras por Clientes");

                // TITULO
                worksheet.Cells["A1"].Value = "Compras por Clientes";
                worksheet.Cells["A1:F1"].Merge = true;
                worksheet.Cells["A1:F1"].Style.Font.Size = 16;
                worksheet.Cells["A1:F1"].Style.Font.Bold = true;
                worksheet.Cells["A1:F1"].Style.HorizontalAlignment = ExcelHorizontalAlignment.Center;

                // FECHAS
                worksheet.Cells["A3"].Value = "Periodo:";
                worksheet.Cells["B3"].Value = dateFrom.ToString("dd/MM/yyyy");
                worksheet.Cells["C3"].Value = " - ";
                worksheet.Cells["C3"].Style.HorizontalAlignment = OfficeOpenXml.Style.ExcelHorizontalAlignment.Center;
                worksheet.Cells["D3"].Value = dateTo.ToString("dd/MM/yyyy");

                // HEADERS PARA TABLA
                worksheet.Cells["A5"].LoadFromCollection(clientsPurchasesVM, true, OfficeOpenXml.Table.TableStyles.Light1);
                worksheet.Cells["A5"].Value = "N° de Cliente";
                worksheet.Cells["B5"].Value = "Nombre";
                worksheet.Cells["C5"].Value = "Apellido";
                worksheet.Cells["D5"].Value = "Tipo de Documento";
                worksheet.Cells["E5"].Value = "N° de Documento";
                worksheet.Cells["F5"].Value = "Email";
                worksheet.Cells["G5"].Value = "N° de Telefono";
                worksheet.Cells["H5"].Value = "Cantidad de Compras";
                worksheet.Cells["I5"].Value = "Importe Total ($)";
                // SUMA -- FORMULA
                int rows = worksheet.Dimension.End.Row;
                int finalRow = rows + 1;
                worksheet.Cells[$"H{finalRow}"].Formula = $"SUM(H6:H{rows})";
                worksheet.Cells[$"I{finalRow}"].Formula = $"SUM(I6:I{rows})";
                // Auto-fit COLUMNAS
                worksheet.Cells[worksheet.Dimension.Address].AutoFitColumns();

                // GUARDAR ARCHIVO
                var fileName = $"ComprasXClientes_{dateFrom:yyyyMMdd}-{dateTo:yyyyMMdd}.xlsx";
                var saveFileDialog = new SaveFileDialog
                {
                    Filter = "Excel Files|*.xlsx",
                    FileName = fileName
                };

                if (saveFileDialog.ShowDialog() == DialogResult.OK)
                {
                    var fileInfo = new FileInfo(saveFileDialog.FileName);
                    package.SaveAs(fileInfo);
                    MessageBox.Show("El archivo se ha exportado exitosamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }

        private async void buttonGenerateClientPurchasesReport_Click(object sender, EventArgs e)
        {
            DateTime dateFrom = dateTimeClientPurchasesReportFrom.Value;
            DateTime dateTo = dateTimeClientPurchasesReportTo.Value;
            var datesDto = new DateFromToDto()
            {
                From = dateFrom,
                To = dateTo,
            };
            string response = await ApiHelper.PostAsync($"{ApiUrl.LocalUrl}reports/clients-purchases", datesDto);
            if (response.Contains("error") || response.Contains("failed"))
            {
                MessageBox.Show("Error al generar reporte", response, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                var clientsPurchasesVM = JsonConvert.DeserializeObject<List<ClientPurchasesViewModel>>(response);
                dataGridViewClientsPruchasesReport.DataSource = new BindingList<ClientPurchasesViewModel>(clientsPurchasesVM);
            }
        }

        private async void buttonGenerateProductsSalesReport_Click(object sender, EventArgs e)
        {
            DateTime dateFrom = dateTimeProductsSalesFrom.Value;
            DateTime dateTo = dateTimeProductsSalesTo.Value;
            var datesDto = new DateFromToDto()
            {
                From = dateFrom,
                To = dateTo,
            };
            string response = await ApiHelper.PostAsync($"{ApiUrl.LocalUrl}reports/products-sales", datesDto);
            if (response.Contains("error") || response.Contains("failed"))
            {
                MessageBox.Show("Error al generar reporte", response, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                var productsSalesVM = JsonConvert.DeserializeObject<List<ProductSalesViewModel>>(response);
                dataGridViewProductsSalesReport.DataSource = new BindingList<ProductSalesViewModel>(productsSalesVM);
            }
        }

        private void buttonExportProductsSalesReport_Click(object sender, EventArgs e)
        {
            var productsSalesVM = ((BindingList<ProductSalesViewModel>)dataGridViewProductsSalesReport.DataSource).ToList();
            ExportProductsSalesReportToExcel(productsSalesVM, dateTimeProductsSalesFrom.Value, dateTimeProductsSalesTo.Value);

        }
        public void ExportProductsSalesReportToExcel(List<ProductSalesViewModel> productsSalesVM, DateTime dateFrom, DateTime dateTo)
        {

            ExcelPackage.LicenseContext = OfficeOpenXml.LicenseContext.NonCommercial;
            using (var package = new ExcelPackage())
            {
                var worksheet = package.Workbook.Worksheets.Add("Ventas por Producto");

                // TITULO
                worksheet.Cells["A1"].Value = "Ventas por Producto";
                worksheet.Cells["A1:F1"].Merge = true;
                worksheet.Cells["A1:F1"].Style.Font.Size = 16;
                worksheet.Cells["A1:F1"].Style.Font.Bold = true;
                worksheet.Cells["A1:F1"].Style.HorizontalAlignment = ExcelHorizontalAlignment.Center;

                // FECHAS
                worksheet.Cells["A3"].Value = "Periodo:";
                worksheet.Cells["B3"].Value = dateFrom.ToString("dd/MM/yyyy");
                worksheet.Cells["C3"].Value = " - ";
                worksheet.Cells["C3"].Style.HorizontalAlignment = OfficeOpenXml.Style.ExcelHorizontalAlignment.Center;
                worksheet.Cells["D3"].Value = dateTo.ToString("dd/MM/yyyy");

                // HEADERS PARA TABLA
                worksheet.Cells["A5"].LoadFromCollection(productsSalesVM, true, OfficeOpenXml.Table.TableStyles.Light1);
                worksheet.Cells["A5"].Value = "N° de Producto";
                worksheet.Cells["B5"].Value = "Rubro";
                worksheet.Cells["C5"].Value = "Producto";
                worksheet.Cells["D5"].Value = "Descripción";
                worksheet.Cells["E5"].Value = "Cantidad de Ventas";
                worksheet.Cells["F5"].Value = "Importe Total ($)";
                // SUMA -- FORMULA
                int rows = worksheet.Dimension.End.Row;
                int finalRow = rows + 1;
                worksheet.Cells[$"E{finalRow}"].Formula = $"SUM(E6:E{rows})";
                worksheet.Cells[$"F{finalRow}"].Formula = $"SUM(F6:F{rows})";
                // Auto-fit COLUMNAS
                worksheet.Cells[worksheet.Dimension.Address].AutoFitColumns();

                // GUARDAR ARCHIVO
                var fileName = $"VentasXProducto_{dateFrom:yyyyMMdd}-{dateTo:yyyyMMdd}.xlsx";
                var saveFileDialog = new SaveFileDialog
                {
                    Filter = "Excel Files|*.xlsx",
                    FileName = fileName
                };

                if (saveFileDialog.ShowDialog() == DialogResult.OK)
                {
                    var fileInfo = new FileInfo(saveFileDialog.FileName);
                    package.SaveAs(fileInfo);
                    MessageBox.Show("El archivo se ha exportado exitosamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }

        private void buttonCreateDiscount_Click(object sender, EventArgs e)
        {
            var form = new CreateDiscount();
            form.ShowDialog();
        }

        private void buttonCreateProductHasDiscount_Click(object sender, EventArgs e)
        {
            var form = new CreateProductHasDiscount();
            form.ShowDialog();

        }

        private void Main_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (e.CloseReason == CloseReason.UserClosing)
            {
                if (MessageBox.Show("¿Realmente quieres salir?", "Confirmación", MessageBoxButtons.YesNo) == DialogResult.No)
                {
                    e.Cancel = true;
                }
                else
                {
                    Application.Exit();
                }
            }
        }

        private async void dataGridViewVisitRequest_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == dataGridViewVisitRequest.Columns["ReviewButton"].Index && e.RowIndex >= 0)
            {
                int visitReqId = (int)dataGridViewVisitRequest.Rows[e.RowIndex].Cells["Id"].Value;
                var form = new ReviewVisitRequest(visitReqId);
                form.ShowDialog();
                await LoadData();
            }
        }

        private async void dataGridViewInvoices_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == dataGridViewInvoices.Columns["ReviewButton"].Index && e.RowIndex >= 0)
            {
                int invoiceId = (int)dataGridViewInvoices.Rows[e.RowIndex].Cells["Id"].Value;
                var form = new InvoiceReview(invoiceId);
                form.ShowDialog();
                await LoadData();
            }
        }

        private void txtBoxSearchCategories_TextChanged(object sender, EventArgs e)
        {
            textToSearchCategories = txtBoxSearchCategories.Text;
            SearchListGeneric(categories, dataGridViewCategories, textToSearchCategories);

        }

        private void txtBoxOrdersSearch_TextChanged(object sender, EventArgs e)
        {
            textToSearchOrders = txtBoxOrdersSearch.Text;
            SearchListGeneric(orders, dataGridViewOrders, textToSearchOrders);
        }


        private void txtBoxProductsSearch_TextChanged(object sender, EventArgs e)
        {
            textToSearchProducts = txtBoxProductsSearch.Text;
            SearchListGeneric(products, dataGridViewProducts, textToSearchProducts);
        }

        private void txtBoxSearchSuppliers_TextChanged(object sender, EventArgs e)
        {
            textToSearchSuppliers = txtBoxSearchSuppliers.Text;
            SearchListGeneric(suppliers, dataGridViewSuppliers, textToSearchSuppliers);
        }

        private void txtBoxSearchDiscounts_TextChanged(object sender, EventArgs e)
        {
            textToSearchDiscountedProducts = txtBoxSearchDiscounts.Text;
            SearchListGeneric(discountedProducts, dataGridViewActiveDiscounts, textToSearchDiscountedProducts);
        }

        private void txtBoxSearchBillingTransactions_TextChanged(object sender, EventArgs e)
        {
            textToSearchBillingTransactions = txtBoxSearchBillingTransactions.Text;
            SearchListGeneric(billingTransactions, dataGridViewBillingTransactions, textToSearchBillingTransactions);
        }

        private void txtBoxSearchPendingInvoices_TextChanged(object sender, EventArgs e)
        {
            textToSearchPendingInvoices = txtBoxSearchPendingInvoices.Text;
            SearchListGeneric(pendingInvoices, dataGridViewPendingInvoices, textToSearchPendingInvoices);
        }

        private void txtBoxSearchInvoices_TextChanged(object sender, EventArgs e)
        {
            textToSearchInvoices = txtBoxSearchInvoices.Text;
            SearchListGeneric(invoices, dataGridViewInvoices, textToSearchInvoices);
        }

        private void txtBoxSearchClients_TextChanged(object sender, EventArgs e)
        {
            textToSearchClients = txtBoxSearchClients.Text;
            SearchListGeneric(clients, dataGridViewClients, textToSearchClients);
        }

        private void dungeonTextBox1_TextChanged(object sender, EventArgs e)
        {
            // Ajusta el nombre de la variable y la llamada a la función según tus necesidades
            textToSearchVisitRequests = dungeonTextBox1.Text;
            SearchListGeneric(visitRequests, dataGridViewVisitRequest, textToSearchVisitRequests);
        }

        private void txtBoxSearchSellers_TextChanged(object sender, EventArgs e)
        {
            textToSearchSellers = txtBoxSearchSellers.Text;
            SearchListGeneric(sellers, dataGridViewSellers, textToSearchSellers);
        }

        private void txtBoxSearchOfficeWorkers_TextChanged(object sender, EventArgs e)
        {
            textToSearchOfficeWorkers = txtBoxSearchOfficeWorkers.Text;
            SearchListGeneric(officeWorkers, dataGridViewOfficeWorkers, textToSearchOfficeWorkers);
        }

        private void txtBoxSearchTransportCompanies_TextChanged(object sender, EventArgs e)
        {
            textToSearchTransportCompanies = txtBoxSearchTransportCompanies.Text;
            SearchListGeneric(transportCompanies, dataGridViewTransportCompanies, textToSearchTransportCompanies);
        }
    }
}