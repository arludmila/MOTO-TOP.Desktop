using Contracts.DTOs.Entities;
using Contracts.Utils;
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
    public partial class CreateTransportCompany : Form
    {
        public CreateTransportCompany()
        {
            InitializeComponent();
        }

        private async void buttonCreateTransportCompany_Click(object sender, EventArgs e)
        {
            var transportCompanyDto = new TransportCompanyDto()
            {
                Name = txtBoxName.Text,
                PhoneNumber = txtBoxPhoneNumber.Text,
            };
            string response = await ApiHelper.PostAsync("https://localhost:7215/api/transport-companies",transportCompanyDto);

            if (response.Contains("error"))
            {
                MessageBox.Show("Error al crear empresa", response, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                MessageBox.Show("Empresa registrada!", string.Empty, MessageBoxButtons.OK, MessageBoxIcon.Information);
                Close();

            }
        }
    }
}
