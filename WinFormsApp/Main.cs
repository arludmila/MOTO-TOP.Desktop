using Contracts.DTOs.Entities;
using Contracts.DTOs.Relationships;
using Contracts.DTOs.Reports;
using Contracts.Utils;
using Contracts.ViewModels;
using Contracts.ViewModels.Reports;
using Entities.Core;
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
        private List<OfficeWorkerViewModel> officeWorkers;
        private Timer refreshTimer;
        private double _purchasePrice;
        private double _profitMarginPercentage;

        public Main()
        {
            this.StartPosition = FormStartPosition.CenterScreen;


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
                    MessageBoxHelper.ShowErrorMessageBox("Error al crear categor�a");
                }
                else
                {
                    MessageBoxHelper.ShowSuccessMessageBox("Categor�a registrada!");
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
                { "Description", "Descripci�n" },
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
                { "DocumentNumber", "N� de Documento" },
                { "Email", "Email" },
                { "Location", "Ubicaci�n" },
                { "PhoneNumber", "N�mero de Telefono" }
            };

            SetupDataGridView(dataGridViewClients, clientsColumns);

            // SUPPLIERS
            Dictionary<string, string> suppliersColumns = new Dictionary<string, string>
            {
                { "Id", "Id" },
                { "Name", "Nombre" },
                { "Email", "Email" },
                { "PhoneNumber", "N�mero de Telefono" }
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
                { "DocumentNumber", "N� de Documento" },
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
                { "DateReceived", "Fecha de Recepci�n" },
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
                { "ClientId", "N� Cliente" },
                { "DocumentType", "Tipo de Documento" },
                { "DocumentNumber", "N� Documento" },
                { "Amount", "Total" },
            };
            SetupDataGridView(dataGridViewBillingTransactions, billingTransactionsColumns);
            // PENDING INVOICES
            Dictionary<string, string> invoicesColumns = new Dictionary<string, string>
            {
                { "Id", "Id" },
                { "OrderId", "N� de Pedido" },
                { "ClientId", "N� de Cliente" },
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
            // TRANSPORT COMPANIES
            Dictionary<string, string> transportCompaniesColumns = new Dictionary<string, string>
            {
                { "Id", "Id" },
                { "Name", "Nombre" },
                { "Email", "Email" },
                { "PhoneNumber", "N� de Telefono" },
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
                { "DocumentNumber", "N� de Documento" },
            };

            SetupDataGridView(dataGridViewOfficeWorkers, offWorkersColumns);
            // SELLERS SALES
            Dictionary<string, string> sellersSalesColumns = new Dictionary<string, string>
            {
                { "SellerId", "N� Vendedor" },
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
                { "Id", "Id" },
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
                { "DocumentNumber", "N� de Documento" },
                { "Email", "Email" },
                { "Location", "Ubicaci�n" },
                { "PhoneNumber", "N�mero de Telefono" },
                { "TotalBalance", "Saldo Total" }
            };

            SetupDataGridView(dataGridViewClientsBalances, clientsBalancesColumns);
            // PENDING INVOICES REPORT
            Dictionary<string, string> pendingInvoicesReportColumns = new Dictionary<string, string>
            {
                { "Id", "Id" },
                { "OrderId", "N� de Pedido" },
                { "ClientId", "N� de Cliente" },
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
                { "OrderId", "N� de Pedido" },
                { "ClientId", "N� de Cliente" },
                { "Date", "Fecha" },
                { "Amount", "Total" },

            };
            SetupDataGridView(dataGridViewTotalSalesReport, totalSalesRepColumns);
            // CLIENTS PURCHASES REPORT
            Dictionary<string, string> clientsPurchasesReportColumns = new Dictionary<string, string>
            {
                { "ClientId", "N� de Cliente" },
                { "FirstName", "Nombre" },
                { "LastName", "Apellido" },
                { "DocumentType", "Tipo de Documento" },
                { "DocumentNumber", "N� de Documento" },
                { "Email", "Email" },
                { "PhoneNumber", "N�mero de Telefono" },
                { "TotalPurchases", "Cantidad de Compras" },
                { "TotalAmount", "Importe Total ($)" },

            };
            SetupDataGridView(dataGridViewClientsPruchasesReport, clientsPurchasesReportColumns);
            // PRODUCTS SALES REPORT
            Dictionary<string, string> productsSalesReportColumns = new Dictionary<string, string>
            {
                { "Id", "N� de Producto" },
                { "CategoryName", "Rubro" },
                { "Name", "Producto" },
                { "Description", "Descripci�n" },
                { "TotalSales", "Cantidad de Ventas" },
                { "TotalAmount", "Importe Total ($)" },
            };
            SetupDataGridView(dataGridViewProductsSalesReport, productsSalesReportColumns);

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
            // tama�o de c/columna --> fill (todas iguales)
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
            if (categories != null)
            {
                dataGridViewCategories.DataSource = new BindingList<Category>(categories);
            }
            products = await ApiHelper.GetListAsync<ProductViewModel>($"{ApiUrl.LocalUrl}products/view-models");
            if (products != null)
            {
                dataGridViewProducts.DataSource = new BindingList<ProductViewModel>(products);
            }
            clients = await ApiHelper.GetListAsync<Client>($"{ApiUrl.LocalUrl}clients");
            if (clients != null)
            {
                dataGridViewClients.DataSource = new BindingList<Client>(clients);
            }
            suppliers = await ApiHelper.GetListAsync<Supplier>($"{ApiUrl.LocalUrl}suppliers");
            if (suppliers != null)
            {
                dataGridViewSuppliers.DataSource = new BindingList<Supplier>(suppliers);
            }
            sellers = await ApiHelper.GetListAsync<SellerViewModel>($"{ApiUrl.LocalUrl}sellers/view-models");
            if (sellers != null)
            {
                dataGridViewSellers.DataSource = new BindingList<SellerViewModel>(sellers);
            }
            orders = await ApiHelper.GetListAsync<OrderViewModel>($"{ApiUrl.LocalUrl}orders/view-models");
            if (orders != null)
            {
                dataGridViewOrders.DataSource = new BindingList<OrderViewModel>(orders);
            }
            invoices = await ApiHelper.GetListAsync<InvoiceViewModel>($"{ApiUrl.LocalUrl}invoices/view-models");

            if (invoices != null)
            {
                dataGridViewInvoices.DataSource = new BindingList<InvoiceViewModel>(invoices);
                // pending invoices...
                pendingInvoices = GetPendingInvoices();
                if (pendingInvoices != null)
                {
                    dataGridViewPendingInvoices.DataSource = new BindingList<InvoiceViewModel>(pendingInvoices);
                }
            }
            billingTransactions = await ApiHelper.GetListAsync<BillingTransaction>($"{ApiUrl.LocalUrl}billing-transactions");

            if (billingTransactions != null)
            {
                dataGridViewBillingTransactions.DataSource = new BindingList<BillingTransaction>(billingTransactions);
            }


            transportCompanies = await ApiHelper.GetListAsync<TransportCompany>($"{ApiUrl.LocalUrl}transport-companies");

            if (transportCompanies != null)
            {
                dataGridViewTransportCompanies.DataSource = new BindingList<TransportCompany>(transportCompanies);
            }

            officeWorkers = await ApiHelper.GetListAsync<OfficeWorkerViewModel>($"{ApiUrl.LocalUrl}office-workers/view-models");

            if (officeWorkers != null)
            {
                dataGridViewOfficeWorkers.DataSource = new BindingList<OfficeWorkerViewModel>(officeWorkers);
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
                    Guid orderId = (Guid)dataGridViewOrders.Rows[e.RowIndex].Cells["Id"].Value;
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
                    FormInputClearer.ClearDungeonTextBoxes(txtBoxSupplierProductProductId, txtBoxSupplierProductSupplierId, txtBoxSupplierProductSellingPrice, txtBoxSupplierProductQuantity, txtBoxSupplierProductProfitMargin, txtBoxSupplierProductPurchasePrice);
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
            if (dataGridViewSellersSales.RowCount == 0)
            {
                MessageBoxHelper.ShowInfoMessageBox("No existen datos para exportar!");
                return;
            }
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
                worksheet.Cells["A5"].Value = "N� Vendedor";
                worksheet.Cells["B5"].Value = "Nombre";
                worksheet.Cells["C5"].Value = "Apellido";
                worksheet.Cells["D5"].Value = "Zona";
                worksheet.Cells["E5"].Value = "Cantidad de Ventas";
                worksheet.Cells["F5"].Value = "Importe Total($)";
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
                    MessageBox.Show("El archivo se ha exportado exitosamente.", "�xito", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
            if (dataGridViewOrdersPendingShipment.RowCount == 0)
            {
                MessageBoxHelper.ShowInfoMessageBox("No existen datos para exportar!");
                return;
            }
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
                    MessageBox.Show("El archivo se ha exportado exitosamente.", "�xito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }
        private void buttonExportClientsBalances_Click(object sender, EventArgs e)
        {
            if (dataGridViewClientsBalances.RowCount == 0)
            {
                MessageBoxHelper.ShowInfoMessageBox("No existen datos para exportar!");
                return;
            }
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
                worksheet.Cells["A3"].Value = "N� Cliente";
                worksheet.Cells["B3"].Value = "Nombre";
                worksheet.Cells["C3"].Value = "Apellido";

                worksheet.Cells["D3"].Value = "Direcci�n";

                worksheet.Cells["E3"].Value = "N� Telefono";
                worksheet.Cells["F3"].Value = "Tipo de Documento";
                worksheet.Cells["G3"].Value = "N� de Documento";
                worksheet.Cells["H3"].Value = "Email";
                worksheet.Cells["I3"].Value = "Saldo Total";
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
                    MessageBox.Show("El archivo se ha exportado exitosamente.", "�xito", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
            if (dataGridViewPendingInvoicesReport.RowCount == 0)
            {
                MessageBoxHelper.ShowInfoMessageBox("No existen datos para exportar!");
                return;
            }

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
                worksheet.Cells["A3"].Value = "N� Factura";
                worksheet.Cells["B3"].Value = "N� de Pedido";
                worksheet.Cells["C3"].Value = "N� de Cliente";

                worksheet.Cells["D3"].Value = "Cliente";

                worksheet.Cells["E3"].Value = "Documento del Cliente";
                worksheet.Cells["F3"].Value = "Fecha";
                worksheet.Cells["G3"].Value = "Total";
                worksheet.Cells["H3"].Value = "Deuda Pendiente";
                var dateColumn = worksheet.Column(6);
                dateColumn.Style.Numberformat.Format = "yyyy-MM-dd";
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
                    MessageBox.Show("El archivo se ha exportado exitosamente.", "�xito", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
                var invoices = JsonConvert.DeserializeObject<List<Invoice>>(response);
                dataGridViewTotalSalesReport.DataSource = new BindingList<Invoice>(invoices);
                foreach (var invoice in invoices)
                {
                    totalQuantity++;
                    totalAmount += invoice.Amount;
                }
                txtBoxTotalSalesReportTotalAmount.Text = "$" + totalAmount.ToString();
                txtBoxTotalSalesReportTotalQuantity.Text = totalQuantity.ToString();
            }
        }

        private void buttonExportTotalSalesReport_Click(object sender, EventArgs e)
        {
            if (dataGridViewTotalSalesReport.RowCount == 0)
            {
                MessageBoxHelper.ShowInfoMessageBox("No existen datos para exportar!");
                return;
            }
            var invoices = ((BindingList<Invoice>)dataGridViewTotalSalesReport.DataSource).ToList();
            ExportTotalSalesReportToExcel(invoices, dateTimeTotalSalesFrom.Value, dateTimeTotalSalesTo.Value);
        }
        public void ExportTotalSalesReportToExcel(List<Invoice> invoices, DateTime dateFrom, DateTime dateTo)
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
                worksheet.Cells["A6"].Value = "Fecha";
                worksheet.Cells["B6"].Value = "Total Facturado ($)";
                worksheet.Cells["C6"].Value = "N� de Cliente";
                worksheet.Cells["D6"].Value = "Pedido";
                worksheet.Cells["E6"].Value = "N� de Factura";
                var dateColumn = worksheet.Column(1);
                dateColumn.Style.Numberformat.Format = "yyyy-MM-dd";
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
                    MessageBox.Show("El archivo se ha exportado exitosamente.", "�xito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }

        private void buttonExportClientPurchasesReport_Click(object sender, EventArgs e)
        {
            if (dataGridViewClientsPruchasesReport.RowCount == 0)
            {
                MessageBoxHelper.ShowInfoMessageBox("No existen datos para exportar!");
                return;
            }

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
                worksheet.Cells["A5"].Value = "N� de Cliente";
                worksheet.Cells["B5"].Value = "Nombre";
                worksheet.Cells["C5"].Value = "Apellido";
                worksheet.Cells["D5"].Value = "Tipo de Documento";
                worksheet.Cells["E5"].Value = "N� de Documento";
                worksheet.Cells["F5"].Value = "Email";
                worksheet.Cells["G5"].Value = "N� de Telefono";
                worksheet.Cells["H5"].Value = "Cantidad de Compras";
                worksheet.Cells["I5"].Value = "Importe Total ($)";

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
                    MessageBox.Show("El archivo se ha exportado exitosamente.", "�xito", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
            if (dataGridViewProductsSalesReport.RowCount == 0)
            {
                MessageBoxHelper.ShowInfoMessageBox("No existen datos para exportar!");
                return;
            }
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
                worksheet.Cells["A5"].Value = "N� de Producto";
                worksheet.Cells["B5"].Value = "Rubro";
                worksheet.Cells["C5"].Value = "Producto";
                worksheet.Cells["D5"].Value = "Descripci�n";
                worksheet.Cells["E5"].Value = "Cantidad de Ventas";
                worksheet.Cells["F5"].Value = "Importe Total ($)";

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
                    MessageBox.Show("El archivo se ha exportado exitosamente.", "�xito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }
    }
}