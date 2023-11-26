using Contracts.DTOs;
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
    public partial class Login : Form
    {
        public Login()
        {
            this.StartPosition = FormStartPosition.CenterScreen;
            InitializeComponent();
        }

        private void Login_Load(object sender, EventArgs e)
        {
            txtBoxPassword.UseSystemPasswordChar = true;
        }

        private async void buttonLogin_Click(object sender, EventArgs e)
        {
            var loginRequest = new LoginRequestDto()
            {
                Email = txtBoxEmail.Text,
                Password = txtBoxPassword.Text,
            };
            int response = Convert.ToInt32(await ApiHelper.PostAsync($"{ApiUrl.LocalUrl}login/office-worker", loginRequest));

            if (response == 0)
            {
                MessageBoxHelper.ShowErrorMessageBox("Email o contraseña incorrectos! Intente de nuevo.");
            }
            else
            {
                var form = new Main(response);
                form.ShowDialog();
            }
        }
    }
}
