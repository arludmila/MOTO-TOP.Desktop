using Contracts.DTOs.Entities;
using Contracts.Utils;
using Microsoft.AspNetCore.Identity;
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
    public partial class CreateSeller : Form
    {
        public CreateSeller()
        {
            InitializeComponent();
        }

        private async void buttonCreateSeller_Click(object sender, EventArgs e)
        {
            PasswordHasher<string> passwordHasher = new();
            var registerDto = new SellerRegisterDto()
            {
                FirstName = txtBoxFirstName.Text,
                LastName = txtBoxLastName.Text,
                PasswordHash = passwordHasher.HashPassword(string.Empty, txtBoxPassword.Text),
                Email = txtBoxEmail.Text,
                Zone = txtBoxZone.Text,
            };
            await ApiHelper.PostAsync("https://localhost:7215/api/sellers/register", registerDto);
            this.Close();
        }
        private void CreateSeller_Load(object sender, EventArgs e)
        {
            txtBoxPassword.UseSystemPasswordChar = true;
        }
    }
}
