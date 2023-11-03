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

namespace WinFormsApp
{
    public partial class ClientSelector : Form
    {
        private List<Client> _clients = new List<Client>();
        public event Action<int> ClientSelected;

        public ClientSelector()
        {
            this.StartPosition = FormStartPosition.CenterScreen;
            InitializeComponent();
            Text = "Selector de Cliente";
        }

        private async void ClientSelector_Load(object sender, EventArgs e)
        {
            await LoadData();
        }

        private async void buttonCreateClient_Click(object sender, EventArgs e)
        {
            var form = new CreateClient();
            form.ShowDialog();
            await LoadData();
        }
        private async Task LoadData()
        {

            Dictionary<string, string> clientsColumns = new Dictionary<string, string>
            {
                { "Id", "Id" },
                { "FirstName", "Nombre" },
                { "LastName", "Apellido" },
                { "Location", "Ubicación" },
                { "PhoneNumber", "Número de Telefono" }
            };

            Main.SetupDataGridView(dataGridViewClients, clientsColumns);
            _clients = await ApiHelper.GetListAsync<Client>($"{ApiUrl.LocalUrl}clients");
            if (_clients != null)
            {
                dataGridViewClients.DataSource = new BindingList<Client>(_clients);
            }
            // boton
            DataGridViewButtonColumn buttonColumn = new DataGridViewButtonColumn
            {
                Name = "SelectButton",
                Text = "Seleccionar",
                UseColumnTextForButtonValue = true,

            };
            dataGridViewClients.Columns.Add(buttonColumn);
            dataGridViewClients.Columns["SelectButton"].HeaderText = string.Empty;

        }

        private void dataGridViewClients_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.ColumnIndex == dataGridViewClients.Columns["SelectButton"].Index)
            {
                // Get the selected product's ID from the DataGridView
                int selectedProductId = (int)dataGridViewClients.Rows[e.RowIndex].Cells["Id"].Value;

                // Raise the event and send the selected product's ID to the main form
                ClientSelected?.Invoke(selectedProductId);

                // Close the ProductSelector form
                this.Close();
            }
        }
    }
}
