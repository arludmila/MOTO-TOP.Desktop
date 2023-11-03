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
    public partial class SupplierSelector : Form
    {
        List<Supplier> suppliers;
        public event Action<int> SupplierSelected;
        public SupplierSelector()
        {

            this.StartPosition = FormStartPosition.CenterScreen;
            InitializeComponent();
            Text = "Selector de Proveedor";
        }

        private async void SupplierSelector_Load(object sender, EventArgs e)
        {
            await LoadData();
        }

        private async void buttonCreateSupplier_Click(object sender, EventArgs e)
        {
            var form = new CreateSupplier();
            form.ShowDialog();
            await LoadData();
        }
        private async Task LoadData()
        {
            suppliers = await ApiHelper.GetListAsync<Supplier>($"{ApiUrl.LocalUrl}suppliers");
            if (suppliers != null)
            {
                dataGridViewSuppliers.DataSource = new BindingList<Supplier>(suppliers);
            }
            dataGridViewSuppliers.Columns["Id"].DisplayIndex = 0;
            dataGridViewSuppliers.Columns["Name"].HeaderText = "Nombre";
            dataGridViewSuppliers.Columns["PhoneNumber"].HeaderText = "Número de Telefono";
            DataGridViewButtonColumn buttonColumn = new DataGridViewButtonColumn
            {
                Name = "SelectButton",
                Text = "Seleccionar",
                UseColumnTextForButtonValue = true,

            };
            dataGridViewSuppliers.Columns.Add(buttonColumn);
            dataGridViewSuppliers.Columns["SelectButton"].HeaderText = string.Empty;
            dataGridViewSuppliers.RowHeadersVisible = false;
            dataGridViewSuppliers.AllowUserToAddRows = false;
            foreach (DataGridViewColumn column in dataGridViewSuppliers.Columns)
            {
                column.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            }
        }

        private void dataGridViewSuppliers_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.ColumnIndex == dataGridViewSuppliers.Columns["SelectButton"].Index)
            {
                // Get the selected product's ID from the DataGridView
                int selectedProductId = (int)dataGridViewSuppliers.Rows[e.RowIndex].Cells["Id"].Value;

                // Raise the event and send the selected product's ID to the main form
                SupplierSelected?.Invoke(selectedProductId);

                // Close the ProductSelector form
                this.Close();
            }
        }
    }
}
