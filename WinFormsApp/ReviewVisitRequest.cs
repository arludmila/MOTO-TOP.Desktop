using Contracts.DTOs.Entities;
using Contracts.DTOs.Relationships;
using Contracts.Utils;
using Contracts.ViewModels;
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
    public partial class ReviewVisitRequest : Form
    {
        private int visitRequestId;
        private SellerClient visitRequest;
        public ReviewVisitRequest(int visitRequestId)
        {

            InitializeComponent();
            this.visitRequestId = visitRequestId;
        }

        private async void ReviewVisitRequest_Load(object sender, EventArgs e)
        {
            await GetVisitRequest(visitRequestId);
            txtBoxEmail.Enabled = false;
            txtBoxFirstName.Enabled = false;
            txtBoxLastName.Enabled = false;
            txtBoxPhoneNumber.Enabled = false;
            txtBoxLocation.Enabled = false;
            txtBoxId.Enabled = false;
            txtBoxMessage.Enabled = false;
            txtBoxEmail.Text = visitRequest.Email;
            txtBoxLocation.Text = visitRequest.Location;
            txtBoxFirstName.Text = visitRequest.FirstName;
            txtBoxLastName.Text = visitRequest.LastName;
            txtBoxPhoneNumber.Text = visitRequest.PhoneNumber;
            txtBoxMessage.Text = visitRequest.Message;
            txtBoxId.Text = visitRequestId.ToString();
        }
        private async Task GetVisitRequest(int id)
        {
            visitRequest = await ApiHelper.GetAsync<SellerClient>($"{ApiUrl.LocalUrl}seller-clients/{id}");
        }
        // boton --> marcar como hecho la visita, ya se arreglo el tema
        private async void buttonCreateSeller_Click(object sender, EventArgs e)
        {
            if (visitRequest.IsDone)
            {
                return;
            }
            var sellerClientDto = new SellerClientDto()
            {
                Email = visitRequest.Email,
                Location = visitRequest.Location,
                FirstName = visitRequest.FirstName,
                LastName = visitRequest.LastName,
                PhoneNumber = visitRequest.PhoneNumber,
                Message = visitRequest.Message,
                IsDone = true
            };
            string response = await ApiHelper.UpdateAsync($"{ApiUrl.LocalUrl}seller-clients/{visitRequest.Id}", sellerClientDto);

            if (response.Contains("error") || response.Contains("failed"))
            {
                MessageBoxHelper.ShowErrorMessageBox("Error al marcar como atendida.");
            }
            else
            {
                MessageBoxHelper.ShowSuccessMessageBox("Marcada como atendida.");
                Close();
            }
        }
    }
}
