using Contracts.DTOs.Entities;
using Contracts.Utils;
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
using WinFormsApp.Utils;

namespace WinFormsApp
{
    public partial class UpdateOrderStatus : Form
    {
        private Guid _orderId;
        private Order _order;
        public UpdateOrderStatus(Guid orderId)
        {
            this.StartPosition = FormStartPosition.CenterScreen;
            InitializeComponent();
            _orderId = orderId;
            Text = "Asignar Transporte";
        }

        private async void buttonAsign_Click(object sender, EventArgs e)
        {
            TransportCompany selectedTC = (TransportCompany)comboBoxTransportCompanies.SelectedItem;
            int tcId = 0;
            if (selectedTC != null)
            {
                tcId = selectedTC.Id;
            }
            var orderDto = new OrderDto()
            {
                ClientId = _order.ClientId,
                Date = _order.Date,
                SellerId = _order.SellerId,
                TransportCompanyId = tcId,
                DateSent = dateTimeSent.Value,
                DateReceived = dateTimeReceived.Value,
                ShipmentStatus = Entities.Enums.ShipmentStatuses.Shipped
            };
            string response = await ApiHelper.UpdateAsync($"{ApiUrl.LocalUrl}orders/{_orderId}", orderDto);

            if (response.Contains("error") || response.Contains("failed"))
            {
                MessageBoxHelper.ShowErrorMessageBox("Error al asignar transporte.");
            }
            else
            {
                MessageBoxHelper.ShowSuccessMessageBox("Transporte asignado.");
                Close();
            }
        }

        private async void UpdateOrderStatus_Load(object sender, EventArgs e)
        {
            var transportCompanies = await ApiHelper.GetListAsync<TransportCompany>($"{ApiUrl.LocalUrl}transport-companies");
            if (transportCompanies != null)
            {
                comboBoxTransportCompanies.DataSource = new BindingList<TransportCompany>(transportCompanies);
                comboBoxTransportCompanies.DisplayMember = "Name";
                comboBoxTransportCompanies.ValueMember = "Id";
            }
            _order = await ApiHelper.GetAsync<Order>($"{ApiUrl.LocalUrl}orders/{_orderId}");
        }
    }
}
