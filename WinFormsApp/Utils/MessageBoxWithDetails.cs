using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinFormsApp.Utils
{
    public class MessageBoxWithDetails : Form
    {
        private Label titleLabel;
        private Label descriptionLabel;
        public string Title
        {
            get { return titleLabel.Text; }
            set { titleLabel.Text = value; }
        }

        public string Description
        {
            get { return descriptionLabel.Text; }
            set { descriptionLabel.Text = value; }
        }

        public MessageBoxWithDetails()
        {
            InitializeComponent();
        }
        private void InitializeComponent()
        {

            titleLabel = new Label();
            descriptionLabel = new Label();


            this.Controls.Add(titleLabel);
            this.Controls.Add(descriptionLabel);
        }

        private void okButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
