using Contracts.DTOs.Entities;
using Contracts.Utils;
using Entities.Enums;
using WinFormsApp.Utils;

namespace WinFormsApp
{
    public partial class CreateBillingTransaction : Form
    {
        private Dictionary<PaymentMethods, string> _paymentMethodNames;
        private BillingTransactionDto _billingTransactionDto;
        public CreateBillingTransaction(BillingTransactionDto billingTransactionDto)
        {

            this.StartPosition = FormStartPosition.CenterScreen;
            InitializeComponent();
            _billingTransactionDto = billingTransactionDto;
            Text = "Registro de Pago";
        }

        private void CreateBillingTransaction_Load(object sender, EventArgs e)
        {
            _paymentMethodNames = new Dictionary<PaymentMethods, string>
            {
                { PaymentMethods.Ninguno, "Ninguno" },
                { PaymentMethods.Efectivo, "Efectivo" },
                { PaymentMethods.TarjetaDeCredito, "Tarjeta de Crédito" },
                { PaymentMethods.TarjetaDeDebito, "Tarjeta de Débito" },
                { PaymentMethods.TransferenciaBancaria, "Transferencia Bancaria" },
                { PaymentMethods.Cheque, "Cheque" }
            };
            comboBoxPaymentMethod.DataSource = _paymentMethodNames.Values.ToList();

        }

    private async void buttonCreateBillTransaction_Click(object sender, EventArgs e)
        {
            double amount;
            int documentNumber;
            string documentType = FormInputValidator.ValidateAndGetDungeonTextBoxText(txtBoxDocType, "Document Type")!;

            if ( documentType != null &&
                FormInputValidator.TryConvertDungeonTextBoxToDouble(txtBoxPayedAmount, "Amount", out amount) &&
                FormInputValidator.TryConvertDungeonTextBoxToInt(txtBoxDocNumber, "Document Number", out documentNumber))
            {
                string selectedPaymentMethodName = comboBoxPaymentMethod.SelectedItem.ToString()!;

                // Now, you can find the PaymentMethod enum based on the selected payment method name.
                PaymentMethods selectedPaymentMethod = _paymentMethodNames.FirstOrDefault(x => x.Value == selectedPaymentMethodName).Key;

                _billingTransactionDto.Amount = amount * -1;
                _billingTransactionDto.DocumentNumber = documentNumber;
                _billingTransactionDto.PaymentMethod = selectedPaymentMethod;
                _billingTransactionDto.DocumentType = documentType;
                string response = await ApiHelper.PostAsync("https://localhost:7215/api/billing-transactions", _billingTransactionDto);

                if (response.Contains("error") || response.Contains("failed"))
                {
                    MessageBoxHelper.ShowErrorMessageBox("Error al registrar pago");
                }
                else
                {
                    MessageBoxHelper.ShowSuccessMessageBox("Pago registrado!");
                    Close();
                }
            }
            

            
        }
    }
}
