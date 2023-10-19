namespace WinFormsApp
{
    partial class ClientSelector
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            labelClientsSearch = new ReaLTaiizor.Controls.DungeonLabel();
            txtBoxClientsSearch = new ReaLTaiizor.Controls.DungeonTextBox();
            buttonCreateClient = new ReaLTaiizor.Controls.ForeverButton();
            dataGridViewClients = new ReaLTaiizor.Controls.PoisonDataGridView();
            labelTitle = new ReaLTaiizor.Controls.DungeonHeaderLabel();
            ((System.ComponentModel.ISupportInitialize)dataGridViewClients).BeginInit();
            SuspendLayout();
            // 
            // labelClientsSearch
            // 
            labelClientsSearch.AutoSize = true;
            labelClientsSearch.BackColor = Color.Transparent;
            labelClientsSearch.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            labelClientsSearch.ForeColor = Color.FromArgb(76, 76, 77);
            labelClientsSearch.Location = new Point(57, 40);
            labelClientsSearch.Name = "labelClientsSearch";
            labelClientsSearch.Size = new Size(72, 25);
            labelClientsSearch.TabIndex = 43;
            labelClientsSearch.Text = "Buscar:";
            // 
            // txtBoxClientsSearch
            // 
            txtBoxClientsSearch.BackColor = Color.Transparent;
            txtBoxClientsSearch.BorderColor = Color.FromArgb(180, 180, 180);
            txtBoxClientsSearch.EdgeColor = Color.White;
            txtBoxClientsSearch.Font = new Font("Tahoma", 11F, FontStyle.Regular, GraphicsUnit.Point);
            txtBoxClientsSearch.ForeColor = Color.DimGray;
            txtBoxClientsSearch.Location = new Point(135, 40);
            txtBoxClientsSearch.MaxLength = 32767;
            txtBoxClientsSearch.Multiline = false;
            txtBoxClientsSearch.Name = "txtBoxClientsSearch";
            txtBoxClientsSearch.ReadOnly = false;
            txtBoxClientsSearch.Size = new Size(589, 28);
            txtBoxClientsSearch.TabIndex = 1;
            txtBoxClientsSearch.TextAlignment = HorizontalAlignment.Left;
            txtBoxClientsSearch.UseSystemPasswordChar = false;
            // 
            // buttonCreateClient
            // 
            buttonCreateClient.BackColor = Color.Transparent;
            buttonCreateClient.BaseColor = Color.DimGray;
            buttonCreateClient.Font = new Font("Segoe UI", 13F, FontStyle.Regular, GraphicsUnit.Point);
            buttonCreateClient.Location = new Point(306, 398);
            buttonCreateClient.Name = "buttonCreateClient";
            buttonCreateClient.Rounded = true;
            buttonCreateClient.Size = new Size(160, 40);
            buttonCreateClient.TabIndex = 2;
            buttonCreateClient.Text = "Agregar Cliente";
            buttonCreateClient.TextColor = Color.FromArgb(243, 243, 243);
            buttonCreateClient.Click += buttonCreateClient_Click;
            // 
            // dataGridViewClients
            // 
            dataGridViewClients.AllowUserToResizeRows = false;
            dataGridViewClients.BackgroundColor = Color.FromArgb(255, 255, 255);
            dataGridViewClients.BorderStyle = BorderStyle.None;
            dataGridViewClients.CellBorderStyle = DataGridViewCellBorderStyle.None;
            dataGridViewClients.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = Color.FromArgb(243, 119, 53);
            dataGridViewCellStyle1.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Pixel);
            dataGridViewCellStyle1.ForeColor = Color.FromArgb(255, 255, 255);
            dataGridViewCellStyle1.SelectionBackColor = Color.FromArgb(244, 133, 72);
            dataGridViewCellStyle1.SelectionForeColor = Color.FromArgb(17, 17, 17);
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            dataGridViewClients.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dataGridViewClients.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = Color.FromArgb(255, 255, 255);
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Pixel);
            dataGridViewCellStyle2.ForeColor = Color.FromArgb(136, 136, 136);
            dataGridViewCellStyle2.SelectionBackColor = Color.FromArgb(244, 133, 72);
            dataGridViewCellStyle2.SelectionForeColor = Color.FromArgb(17, 17, 17);
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.False;
            dataGridViewClients.DefaultCellStyle = dataGridViewCellStyle2;
            dataGridViewClients.EnableHeadersVisualStyles = false;
            dataGridViewClients.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Pixel);
            dataGridViewClients.GridColor = Color.FromArgb(255, 255, 255);
            dataGridViewClients.Location = new Point(11, 78);
            dataGridViewClients.Name = "dataGridViewClients";
            dataGridViewClients.RowHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = Color.FromArgb(243, 119, 53);
            dataGridViewCellStyle3.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Pixel);
            dataGridViewCellStyle3.ForeColor = Color.FromArgb(255, 255, 255);
            dataGridViewCellStyle3.SelectionBackColor = Color.FromArgb(244, 133, 72);
            dataGridViewCellStyle3.SelectionForeColor = Color.FromArgb(17, 17, 17);
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.True;
            dataGridViewClients.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            dataGridViewClients.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            dataGridViewClients.RowTemplate.Height = 25;
            dataGridViewClients.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridViewClients.Size = new Size(778, 314);
            dataGridViewClients.Style = ReaLTaiizor.Enum.Poison.ColorStyle.Orange;
            dataGridViewClients.TabIndex = 40;
            dataGridViewClients.CellContentClick += dataGridViewClients_CellContentClick;
            // 
            // labelTitle
            // 
            labelTitle.AutoSize = true;
            labelTitle.BackColor = Color.Transparent;
            labelTitle.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point);
            labelTitle.ForeColor = Color.FromArgb(76, 76, 77);
            labelTitle.Location = new Point(257, 9);
            labelTitle.Name = "labelTitle";
            labelTitle.Size = new Size(230, 32);
            labelTitle.TabIndex = 39;
            labelTitle.Text = "Seleccionar Cliente";
            // 
            // ClientSelector
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(labelClientsSearch);
            Controls.Add(txtBoxClientsSearch);
            Controls.Add(buttonCreateClient);
            Controls.Add(dataGridViewClients);
            Controls.Add(labelTitle);
            Name = "ClientSelector";
            Text = "ClientSelector";
            Load += ClientSelector_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridViewClients).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ReaLTaiizor.Controls.DungeonLabel labelClientsSearch;
        private ReaLTaiizor.Controls.DungeonTextBox txtBoxClientsSearch;
        private ReaLTaiizor.Controls.ForeverButton buttonCreateClient;
        private ReaLTaiizor.Controls.PoisonDataGridView dataGridViewClients;
        private ReaLTaiizor.Controls.DungeonHeaderLabel labelTitle;
    }
}