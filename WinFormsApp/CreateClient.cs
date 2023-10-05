using Contracts.DTOs.Entities;
using Contracts.Utils;
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
    public partial class CreateClient : Form
    {
        public CreateClient()
        {
            InitializeComponent();
        }

        private async void buttonCreateClient_Click(object sender, EventArgs e)
        {
            var client = new ClientDto()
            {
                FirstName = txtBoxFirstName.Text,
                LastName = txtBoxLastName.Text,
                Location = txtBoxLocation.Text,
                PhoneNumber = txtBoxPhoneNumber.Text,
            };
            await ApiHelper.PostAsync("https://localhost:7215/api/clients",client);
            this.Close();
        }
    }
}
