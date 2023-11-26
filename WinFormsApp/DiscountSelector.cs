using Contracts.Utils;
using Contracts.ViewModels;
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
    public partial class DiscountSelector : Form
    {
        List<Discount> discounts;
        public event Action<Discount> DiscountSelected;
        public DiscountSelector()
        {
            this.StartPosition = FormStartPosition.CenterScreen;
            InitializeComponent();
            Text = "Agregar Descuento a Producto";
        }


        private async void CreateProductHasDiscount_Load(object sender, EventArgs e)
        {
            Dictionary<string, string> discountsColumns = new Dictionary<string, string>
            {
                { "Id", "Id" },
                { "Description", "Descripcion" },
                { "Percentage", "Porcetaje (%)" },
            };

            Main.SetupDataGridView(dataGridViewDiscounts, discountsColumns);
            DataGridViewButtonColumn buttonColumn = new DataGridViewButtonColumn
            {
                Name = "SelectButton",
                Text = "Seleccionar",
                UseColumnTextForButtonValue = true,

            };
            dataGridViewDiscounts.Columns.Add(buttonColumn);
            dataGridViewDiscounts.Columns["SelectButton"].HeaderText = string.Empty;
            await LoadData();
        }
        private async Task LoadData()
        {
            discounts = await ApiHelper.GetListAsync<Discount>($"{ApiUrl.LocalUrl}discounts");
            if (discounts != null)
            {
                dataGridViewDiscounts.DataSource = new BindingList<Discount>(discounts);
            }
            foreach (DataGridViewColumn column in dataGridViewDiscounts.Columns)
            {
                column.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            }
        }
        private void buttonSelectDiscount_Click(object sender, EventArgs e)
        {

        }

        private void dataGridViewDiscounts_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.ColumnIndex == dataGridViewDiscounts.Columns["SelectButton"].Index)
            {
                if (dataGridViewDiscounts.Rows[e.RowIndex].DataBoundItem is Discount selectedDiscount)
                {
                    DiscountSelected?.Invoke(selectedDiscount);
                }
                Close();
            }
        }
    }
}
