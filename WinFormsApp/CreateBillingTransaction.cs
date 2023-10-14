using Contracts.DTOs.Entities;
using Contracts.Utils;
using Entities.Core;
using Entities.Enums;
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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace WinFormsApp
{
    public partial class CreateBillingTransaction : Form
    {
        private BillingTransactionDto _billingTransactionDto;
        public CreateBillingTransaction(BillingTransactionDto billingTransactionDto)
        {
            InitializeComponent();
            _billingTransactionDto = billingTransactionDto;
        }

        private void CreateBillingTransaction_Load(object sender, EventArgs e)
        {

            comboBoxPaymentMethod.DataSource = Enum.GetValues(typeof(PaymentMethods));
        }

        private async void buttonCreateBillTransaction_Click(object sender, EventArgs e)
        {
            PaymentMethods selectedPaymentMethod = (PaymentMethods)comboBoxPaymentMethod.SelectedItem;
            _billingTransactionDto.Amount = Convert.ToDouble(txtBoxPayedAmount.Text) * -1;
            _billingTransactionDto.DocumentNumber = Convert.ToInt32(txtBoxPayedAmount.Text);
            _billingTransactionDto.PaymentMethod = selectedPaymentMethod;
            _billingTransactionDto.DocumentType = txtBoxDocType.Text;
            string response = await ApiHelper.PostAsync("https://localhost:7215/api/billing-transactions", _billingTransactionDto);

            if (response.Contains("error"))
            {
                MessageBox.Show("Error al registrar pago", response, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                MessageBox.Show("Pago registrado!", string.Empty, MessageBoxButtons.OK, MessageBoxIcon.Information);
                Close();
            }
        }
    }
}
