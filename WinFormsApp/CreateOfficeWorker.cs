using Entities.Enums;
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
    public partial class CreateOfficeWorker : Form
    {
        public CreateOfficeWorker()
        {
            this.StartPosition = FormStartPosition.CenterScreen;
            InitializeComponent();
            Text = "Agregar empleado central";
        }

        private void buttonCreateOfficeWorker_Click(object sender, EventArgs e)
        {
            // TODO: terminar implementacion... falta todo el controller API de esta entidad...
        }

        private void CreateOfficeWorker_Load(object sender, EventArgs e)
        {
            txtBoxPassword.UseSystemPasswordChar = true;
            comboBoxDocType.DataSource = Enum.GetValues(typeof(PersonDocType));
        }
    }
}
