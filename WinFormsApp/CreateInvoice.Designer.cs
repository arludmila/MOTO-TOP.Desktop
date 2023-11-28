namespace WinFormsApp
{
    partial class CreateInvoice
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
            buttonAddDetail = new ReaLTaiizor.Controls.Button();
            txtBoxQuantity = new ReaLTaiizor.Controls.DungeonTextBox();
            txtBoxPrice = new ReaLTaiizor.Controls.DungeonTextBox();
            labelPrice = new ReaLTaiizor.Controls.DungeonLabel();
            labelQuantity = new ReaLTaiizor.Controls.DungeonLabel();
            dungeonHeaderLabel1 = new ReaLTaiizor.Controls.DungeonHeaderLabel();
            buttonSelectProduct = new ReaLTaiizor.Controls.ForeverButton();
            txtBoxProductId = new ReaLTaiizor.Controls.DungeonTextBox();
            dungeonLabel1 = new ReaLTaiizor.Controls.DungeonLabel();
            separator1 = new ReaLTaiizor.Controls.Separator();
            separator2 = new ReaLTaiizor.Controls.Separator();
            dataGridViewDetails = new ReaLTaiizor.Controls.PoisonDataGridView();
            dungeonHeaderLabel2 = new ReaLTaiizor.Controls.DungeonHeaderLabel();
            buttonCreateDetailedInvoice = new ReaLTaiizor.Controls.Button();
            txtBoxTotalAmount = new ReaLTaiizor.Controls.DungeonTextBox();
            labelTotal = new ReaLTaiizor.Controls.DungeonLabel();
            buttonSelectClient = new ReaLTaiizor.Controls.ForeverButton();
            txtBoxClientId = new ReaLTaiizor.Controls.DungeonTextBox();
            labelClient = new ReaLTaiizor.Controls.DungeonLabel();
            txtBoxClientName = new ReaLTaiizor.Controls.DungeonTextBox();
            ((System.ComponentModel.ISupportInitialize)dataGridViewDetails).BeginInit();
            SuspendLayout();
            // 
            // buttonAddDetail
            // 
            buttonAddDetail.BackColor = Color.Transparent;
            buttonAddDetail.BorderColor = Color.FromArgb(32, 34, 37);
            buttonAddDetail.EnteredBorderColor = Color.FromArgb(165, 37, 37);
            buttonAddDetail.EnteredColor = Color.FromArgb(32, 34, 37);
            buttonAddDetail.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point);
            buttonAddDetail.Image = null;
            buttonAddDetail.ImageAlign = ContentAlignment.MiddleLeft;
            buttonAddDetail.InactiveColor = Color.FromArgb(32, 34, 37);
            buttonAddDetail.Location = new Point(338, 136);
            buttonAddDetail.Name = "buttonAddDetail";
            buttonAddDetail.PressedBorderColor = Color.FromArgb(165, 37, 37);
            buttonAddDetail.PressedColor = Color.FromArgb(165, 37, 37);
            buttonAddDetail.Size = new Size(120, 32);
            buttonAddDetail.TabIndex = 17;
            buttonAddDetail.Text = "Agregar Linea";
            buttonAddDetail.TextAlignment = StringAlignment.Center;
            buttonAddDetail.Click += buttonAddDetail_Click;
            // 
            // txtBoxQuantity
            // 
            txtBoxQuantity.BackColor = Color.Transparent;
            txtBoxQuantity.BorderColor = Color.FromArgb(180, 180, 180);
            txtBoxQuantity.EdgeColor = Color.White;
            txtBoxQuantity.Font = new Font("Tahoma", 11F, FontStyle.Regular, GraphicsUnit.Point);
            txtBoxQuantity.ForeColor = Color.DimGray;
            txtBoxQuantity.Location = new Point(105, 98);
            txtBoxQuantity.MaxLength = 32767;
            txtBoxQuantity.Multiline = false;
            txtBoxQuantity.Name = "txtBoxQuantity";
            txtBoxQuantity.ReadOnly = false;
            txtBoxQuantity.Size = new Size(296, 28);
            txtBoxQuantity.TabIndex = 16;
            txtBoxQuantity.TextAlignment = HorizontalAlignment.Left;
            txtBoxQuantity.UseSystemPasswordChar = false;
            // 
            // txtBoxPrice
            // 
            txtBoxPrice.BackColor = Color.Transparent;
            txtBoxPrice.BorderColor = Color.FromArgb(180, 180, 180);
            txtBoxPrice.EdgeColor = Color.White;
            txtBoxPrice.Font = new Font("Tahoma", 11F, FontStyle.Regular, GraphicsUnit.Point);
            txtBoxPrice.ForeColor = Color.DimGray;
            txtBoxPrice.Location = new Point(484, 98);
            txtBoxPrice.MaxLength = 32767;
            txtBoxPrice.Multiline = false;
            txtBoxPrice.Name = "txtBoxPrice";
            txtBoxPrice.ReadOnly = false;
            txtBoxPrice.Size = new Size(296, 28);
            txtBoxPrice.TabIndex = 15;
            txtBoxPrice.TextAlignment = HorizontalAlignment.Left;
            txtBoxPrice.UseSystemPasswordChar = false;
            // 
            // labelPrice
            // 
            labelPrice.AutoSize = true;
            labelPrice.BackColor = Color.Transparent;
            labelPrice.Font = new Font("Segoe UI", 13F, FontStyle.Regular, GraphicsUnit.Point);
            labelPrice.ForeColor = Color.FromArgb(76, 76, 77);
            labelPrice.Location = new Point(414, 98);
            labelPrice.Name = "labelPrice";
            labelPrice.Size = new Size(64, 25);
            labelPrice.TabIndex = 14;
            labelPrice.Text = "Precio:";
            // 
            // labelQuantity
            // 
            labelQuantity.AutoSize = true;
            labelQuantity.BackColor = Color.Transparent;
            labelQuantity.Font = new Font("Segoe UI", 13F, FontStyle.Regular, GraphicsUnit.Point);
            labelQuantity.ForeColor = Color.FromArgb(76, 76, 77);
            labelQuantity.Location = new Point(7, 98);
            labelQuantity.Name = "labelQuantity";
            labelQuantity.Size = new Size(87, 25);
            labelQuantity.TabIndex = 13;
            labelQuantity.Text = "Cantidad:";
            // 
            // dungeonHeaderLabel1
            // 
            dungeonHeaderLabel1.AutoSize = true;
            dungeonHeaderLabel1.BackColor = Color.Transparent;
            dungeonHeaderLabel1.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point);
            dungeonHeaderLabel1.ForeColor = Color.FromArgb(76, 76, 77);
            dungeonHeaderLabel1.Location = new Point(292, 9);
            dungeonHeaderLabel1.Name = "dungeonHeaderLabel1";
            dungeonHeaderLabel1.Size = new Size(178, 32);
            dungeonHeaderLabel1.TabIndex = 12;
            dungeonHeaderLabel1.Text = "Facturar Venta";
            // 
            // buttonSelectProduct
            // 
            buttonSelectProduct.BackColor = Color.Transparent;
            buttonSelectProduct.BaseColor = Color.DimGray;
            buttonSelectProduct.Font = new Font("Segoe UI", 13F, FontStyle.Regular, GraphicsUnit.Point);
            buttonSelectProduct.Location = new Point(568, 64);
            buttonSelectProduct.Name = "buttonSelectProduct";
            buttonSelectProduct.Rounded = true;
            buttonSelectProduct.Size = new Size(212, 30);
            buttonSelectProduct.TabIndex = 44;
            buttonSelectProduct.Text = "Seleccionar Producto";
            buttonSelectProduct.TextColor = Color.FromArgb(243, 243, 243);
            buttonSelectProduct.Click += buttonSelectProduct_Click;
            // 
            // txtBoxProductId
            // 
            txtBoxProductId.BackColor = Color.Transparent;
            txtBoxProductId.BorderColor = Color.FromArgb(180, 180, 180);
            txtBoxProductId.EdgeColor = Color.White;
            txtBoxProductId.Font = new Font("Tahoma", 11F, FontStyle.Regular, GraphicsUnit.Point);
            txtBoxProductId.ForeColor = Color.DimGray;
            txtBoxProductId.Location = new Point(105, 64);
            txtBoxProductId.MaxLength = 32767;
            txtBoxProductId.Multiline = false;
            txtBoxProductId.Name = "txtBoxProductId";
            txtBoxProductId.ReadOnly = false;
            txtBoxProductId.Size = new Size(457, 28);
            txtBoxProductId.TabIndex = 43;
            txtBoxProductId.TextAlignment = HorizontalAlignment.Left;
            txtBoxProductId.UseSystemPasswordChar = false;
            // 
            // dungeonLabel1
            // 
            dungeonLabel1.AutoSize = true;
            dungeonLabel1.BackColor = Color.Transparent;
            dungeonLabel1.Font = new Font("Segoe UI", 13F, FontStyle.Regular, GraphicsUnit.Point);
            dungeonLabel1.ForeColor = Color.FromArgb(76, 76, 77);
            dungeonLabel1.Location = new Point(5, 64);
            dungeonLabel1.Name = "dungeonLabel1";
            dungeonLabel1.Size = new Size(89, 25);
            dungeonLabel1.TabIndex = 42;
            dungeonLabel1.Text = "Producto:";
            // 
            // separator1
            // 
            separator1.LineColor = Color.Gray;
            separator1.Location = new Point(-5, 44);
            separator1.Name = "separator1";
            separator1.Size = new Size(831, 19);
            separator1.TabIndex = 45;
            separator1.Text = "separator1";
            // 
            // separator2
            // 
            separator2.LineColor = Color.Gray;
            separator2.Location = new Point(-17, 174);
            separator2.Name = "separator2";
            separator2.Size = new Size(831, 19);
            separator2.TabIndex = 46;
            separator2.Text = "separator2";
            // 
            // dataGridViewDetails
            // 
            dataGridViewDetails.AllowUserToResizeRows = false;
            dataGridViewDetails.BackgroundColor = Color.FromArgb(255, 255, 255);
            dataGridViewDetails.BorderStyle = BorderStyle.None;
            dataGridViewDetails.CellBorderStyle = DataGridViewCellBorderStyle.None;
            dataGridViewDetails.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = Color.FromArgb(243, 119, 53);
            dataGridViewCellStyle1.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Pixel);
            dataGridViewCellStyle1.ForeColor = Color.FromArgb(255, 255, 255);
            dataGridViewCellStyle1.SelectionBackColor = Color.FromArgb(244, 133, 72);
            dataGridViewCellStyle1.SelectionForeColor = Color.FromArgb(17, 17, 17);
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            dataGridViewDetails.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dataGridViewDetails.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = Color.FromArgb(255, 255, 255);
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Pixel);
            dataGridViewCellStyle2.ForeColor = Color.FromArgb(136, 136, 136);
            dataGridViewCellStyle2.SelectionBackColor = Color.FromArgb(244, 133, 72);
            dataGridViewCellStyle2.SelectionForeColor = Color.FromArgb(17, 17, 17);
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.False;
            dataGridViewDetails.DefaultCellStyle = dataGridViewCellStyle2;
            dataGridViewDetails.EnableHeadersVisualStyles = false;
            dataGridViewDetails.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Pixel);
            dataGridViewDetails.GridColor = Color.FromArgb(255, 255, 255);
            dataGridViewDetails.Location = new Point(12, 280);
            dataGridViewDetails.Name = "dataGridViewDetails";
            dataGridViewDetails.RowHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = Color.FromArgb(243, 119, 53);
            dataGridViewCellStyle3.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Pixel);
            dataGridViewCellStyle3.ForeColor = Color.FromArgb(255, 255, 255);
            dataGridViewCellStyle3.SelectionBackColor = Color.FromArgb(244, 133, 72);
            dataGridViewCellStyle3.SelectionForeColor = Color.FromArgb(17, 17, 17);
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.True;
            dataGridViewDetails.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            dataGridViewDetails.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            dataGridViewDetails.RowTemplate.Height = 25;
            dataGridViewDetails.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridViewDetails.Size = new Size(776, 261);
            dataGridViewDetails.Style = ReaLTaiizor.Enum.Poison.ColorStyle.Orange;
            dataGridViewDetails.TabIndex = 47;
            dataGridViewDetails.CellContentClick += dataGridViewDetails_CellContentClick;
            // 
            // dungeonHeaderLabel2
            // 
            dungeonHeaderLabel2.AutoSize = true;
            dungeonHeaderLabel2.BackColor = Color.Transparent;
            dungeonHeaderLabel2.Font = new Font("Segoe UI Semibold", 18F, FontStyle.Bold, GraphicsUnit.Point);
            dungeonHeaderLabel2.ForeColor = Color.FromArgb(76, 76, 77);
            dungeonHeaderLabel2.Location = new Point(280, 196);
            dungeonHeaderLabel2.Name = "dungeonHeaderLabel2";
            dungeonHeaderLabel2.Size = new Size(222, 32);
            dungeonHeaderLabel2.TabIndex = 48;
            dungeonHeaderLabel2.Text = "Detalles de Factura";
            // 
            // buttonCreateDetailedInvoice
            // 
            buttonCreateDetailedInvoice.BackColor = Color.Transparent;
            buttonCreateDetailedInvoice.BorderColor = Color.FromArgb(32, 34, 37);
            buttonCreateDetailedInvoice.EnteredBorderColor = Color.FromArgb(165, 37, 37);
            buttonCreateDetailedInvoice.EnteredColor = Color.FromArgb(32, 34, 37);
            buttonCreateDetailedInvoice.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point);
            buttonCreateDetailedInvoice.Image = null;
            buttonCreateDetailedInvoice.ImageAlign = ContentAlignment.MiddleLeft;
            buttonCreateDetailedInvoice.InactiveColor = Color.FromArgb(32, 34, 37);
            buttonCreateDetailedInvoice.Location = new Point(338, 584);
            buttonCreateDetailedInvoice.Name = "buttonCreateDetailedInvoice";
            buttonCreateDetailedInvoice.PressedBorderColor = Color.FromArgb(165, 37, 37);
            buttonCreateDetailedInvoice.PressedColor = Color.FromArgb(165, 37, 37);
            buttonCreateDetailedInvoice.Size = new Size(120, 40);
            buttonCreateDetailedInvoice.TabIndex = 49;
            buttonCreateDetailedInvoice.Text = "Facturar";
            buttonCreateDetailedInvoice.TextAlignment = StringAlignment.Center;
            buttonCreateDetailedInvoice.Click += buttonCreateDetailedInvoice_Click;
            // 
            // txtBoxTotalAmount
            // 
            txtBoxTotalAmount.BackColor = Color.Transparent;
            txtBoxTotalAmount.BorderColor = Color.FromArgb(180, 180, 180);
            txtBoxTotalAmount.EdgeColor = Color.White;
            txtBoxTotalAmount.Font = new Font("Tahoma", 11F, FontStyle.Regular, GraphicsUnit.Point);
            txtBoxTotalAmount.ForeColor = Color.DimGray;
            txtBoxTotalAmount.Location = new Point(492, 547);
            txtBoxTotalAmount.MaxLength = 32767;
            txtBoxTotalAmount.Multiline = false;
            txtBoxTotalAmount.Name = "txtBoxTotalAmount";
            txtBoxTotalAmount.ReadOnly = false;
            txtBoxTotalAmount.Size = new Size(296, 28);
            txtBoxTotalAmount.TabIndex = 51;
            txtBoxTotalAmount.TextAlignment = HorizontalAlignment.Left;
            txtBoxTotalAmount.UseSystemPasswordChar = false;
            // 
            // labelTotal
            // 
            labelTotal.AutoSize = true;
            labelTotal.BackColor = Color.Transparent;
            labelTotal.Font = new Font("Segoe UI", 13F, FontStyle.Regular, GraphicsUnit.Point);
            labelTotal.ForeColor = Color.FromArgb(76, 76, 77);
            labelTotal.Location = new Point(433, 547);
            labelTotal.Name = "labelTotal";
            labelTotal.Size = new Size(53, 25);
            labelTotal.TabIndex = 50;
            labelTotal.Text = "Total:";
            // 
            // buttonSelectClient
            // 
            buttonSelectClient.BackColor = Color.Transparent;
            buttonSelectClient.BaseColor = Color.DimGray;
            buttonSelectClient.Font = new Font("Segoe UI", 13F, FontStyle.Regular, GraphicsUnit.Point);
            buttonSelectClient.Location = new Point(577, 246);
            buttonSelectClient.Name = "buttonSelectClient";
            buttonSelectClient.Rounded = true;
            buttonSelectClient.Size = new Size(212, 30);
            buttonSelectClient.TabIndex = 54;
            buttonSelectClient.Text = "Seleccionar Cliente";
            buttonSelectClient.TextColor = Color.FromArgb(243, 243, 243);
            buttonSelectClient.Click += buttonSelectClient_Click;
            // 
            // txtBoxClientId
            // 
            txtBoxClientId.BackColor = Color.Transparent;
            txtBoxClientId.BorderColor = Color.FromArgb(180, 180, 180);
            txtBoxClientId.EdgeColor = Color.White;
            txtBoxClientId.Font = new Font("Tahoma", 11F, FontStyle.Regular, GraphicsUnit.Point);
            txtBoxClientId.ForeColor = Color.DimGray;
            txtBoxClientId.Location = new Point(87, 246);
            txtBoxClientId.MaxLength = 32767;
            txtBoxClientId.Multiline = false;
            txtBoxClientId.Name = "txtBoxClientId";
            txtBoxClientId.ReadOnly = false;
            txtBoxClientId.Size = new Size(73, 28);
            txtBoxClientId.TabIndex = 53;
            txtBoxClientId.TextAlignment = HorizontalAlignment.Left;
            txtBoxClientId.UseSystemPasswordChar = false;
            // 
            // labelClient
            // 
            labelClient.AutoSize = true;
            labelClient.BackColor = Color.Transparent;
            labelClient.Font = new Font("Segoe UI", 13F, FontStyle.Regular, GraphicsUnit.Point);
            labelClient.ForeColor = Color.FromArgb(76, 76, 77);
            labelClient.Location = new Point(12, 246);
            labelClient.Name = "labelClient";
            labelClient.Size = new Size(69, 25);
            labelClient.TabIndex = 52;
            labelClient.Text = "Cliente:";
            // 
            // txtBoxClientName
            // 
            txtBoxClientName.BackColor = Color.Transparent;
            txtBoxClientName.BorderColor = Color.FromArgb(180, 180, 180);
            txtBoxClientName.EdgeColor = Color.White;
            txtBoxClientName.Font = new Font("Tahoma", 11F, FontStyle.Regular, GraphicsUnit.Point);
            txtBoxClientName.ForeColor = Color.DimGray;
            txtBoxClientName.Location = new Point(166, 246);
            txtBoxClientName.MaxLength = 32767;
            txtBoxClientName.Multiline = false;
            txtBoxClientName.Name = "txtBoxClientName";
            txtBoxClientName.ReadOnly = false;
            txtBoxClientName.Size = new Size(405, 28);
            txtBoxClientName.TabIndex = 55;
            txtBoxClientName.TextAlignment = HorizontalAlignment.Left;
            txtBoxClientName.UseSystemPasswordChar = false;
            // 
            // CreateInvoice
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 628);
            Controls.Add(txtBoxClientName);
            Controls.Add(buttonSelectClient);
            Controls.Add(txtBoxClientId);
            Controls.Add(labelClient);
            Controls.Add(txtBoxTotalAmount);
            Controls.Add(labelTotal);
            Controls.Add(buttonCreateDetailedInvoice);
            Controls.Add(dungeonHeaderLabel2);
            Controls.Add(dataGridViewDetails);
            Controls.Add(separator2);
            Controls.Add(separator1);
            Controls.Add(buttonSelectProduct);
            Controls.Add(txtBoxProductId);
            Controls.Add(dungeonLabel1);
            Controls.Add(buttonAddDetail);
            Controls.Add(txtBoxQuantity);
            Controls.Add(txtBoxPrice);
            Controls.Add(labelPrice);
            Controls.Add(labelQuantity);
            Controls.Add(dungeonHeaderLabel1);
            Name = "CreateInvoice";
            Text = "CreateInvoice";
            Load += CreateInvoice_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridViewDetails).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ReaLTaiizor.Controls.Button buttonAddDetail;
        private ReaLTaiizor.Controls.DungeonTextBox txtBoxQuantity;
        private ReaLTaiizor.Controls.DungeonTextBox txtBoxPrice;
        private ReaLTaiizor.Controls.DungeonLabel labelPrice;
        private ReaLTaiizor.Controls.DungeonLabel labelQuantity;
        private ReaLTaiizor.Controls.DungeonHeaderLabel dungeonHeaderLabel1;
        private ReaLTaiizor.Controls.ForeverButton buttonSelectProduct;
        private ReaLTaiizor.Controls.DungeonTextBox txtBoxProductId;
        private ReaLTaiizor.Controls.DungeonLabel dungeonLabel1;
        private ReaLTaiizor.Controls.Separator separator1;
        private ReaLTaiizor.Controls.Separator separator2;
        private ReaLTaiizor.Controls.PoisonDataGridView dataGridViewDetails;
        private ReaLTaiizor.Controls.DungeonHeaderLabel dungeonHeaderLabel2;
        private ReaLTaiizor.Controls.Button buttonCreateDetailedInvoice;
        private ReaLTaiizor.Controls.DungeonTextBox txtBoxTotalAmount;
        private ReaLTaiizor.Controls.DungeonLabel labelTotal;
        private ReaLTaiizor.Controls.ForeverButton buttonSelectClient;
        private ReaLTaiizor.Controls.DungeonTextBox txtBoxClientId;
        private ReaLTaiizor.Controls.DungeonLabel labelClient;
        private ReaLTaiizor.Controls.DungeonTextBox txtBoxClientName;
    }
}