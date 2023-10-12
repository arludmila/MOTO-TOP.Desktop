namespace WinFormsApp
{
    partial class OrderReview
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
            buttonCreateOrderInvoice = new ReaLTaiizor.Controls.Button();
            dungeonHeaderLabel1 = new ReaLTaiizor.Controls.DungeonHeaderLabel();
            labelClient = new ReaLTaiizor.Controls.DungeonLabel();
            txtBoxClientName = new ReaLTaiizor.Controls.DungeonTextBox();
            labelSeller = new ReaLTaiizor.Controls.DungeonLabel();
            txtBoxSelllerName = new ReaLTaiizor.Controls.DungeonTextBox();
            labelTransportCompany = new ReaLTaiizor.Controls.DungeonLabel();
            txtBoxTransportCompany = new ReaLTaiizor.Controls.DungeonTextBox();
            buttonModifyOrder = new ReaLTaiizor.Controls.Button();
            buttonCancelOrder = new ReaLTaiizor.Controls.Button();
            dataGridViewOrderDetails = new ReaLTaiizor.Controls.PoisonDataGridView();
            labelOrderId = new ReaLTaiizor.Controls.DungeonLabel();
            txtBoxOrderId = new ReaLTaiizor.Controls.DungeonTextBox();
            ((System.ComponentModel.ISupportInitialize)dataGridViewOrderDetails).BeginInit();
            SuspendLayout();
            // 
            // buttonCreateOrderInvoice
            // 
            buttonCreateOrderInvoice.BackColor = Color.Transparent;
            buttonCreateOrderInvoice.BorderColor = Color.FromArgb(32, 34, 37);
            buttonCreateOrderInvoice.EnteredBorderColor = Color.FromArgb(165, 37, 37);
            buttonCreateOrderInvoice.EnteredColor = Color.FromArgb(32, 34, 37);
            buttonCreateOrderInvoice.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point);
            buttonCreateOrderInvoice.Image = null;
            buttonCreateOrderInvoice.ImageAlign = ContentAlignment.MiddleLeft;
            buttonCreateOrderInvoice.InactiveColor = Color.FromArgb(32, 34, 37);
            buttonCreateOrderInvoice.Location = new Point(12, 398);
            buttonCreateOrderInvoice.Name = "buttonCreateOrderInvoice";
            buttonCreateOrderInvoice.PressedBorderColor = Color.FromArgb(165, 37, 37);
            buttonCreateOrderInvoice.PressedColor = Color.FromArgb(165, 37, 37);
            buttonCreateOrderInvoice.Size = new Size(120, 40);
            buttonCreateOrderInvoice.TabIndex = 16;
            buttonCreateOrderInvoice.Text = "Facturar Pedido";
            buttonCreateOrderInvoice.TextAlignment = StringAlignment.Center;
            buttonCreateOrderInvoice.Click += buttonCreateOrderInvoice_Click;
            // 
            // dungeonHeaderLabel1
            // 
            dungeonHeaderLabel1.AutoSize = true;
            dungeonHeaderLabel1.BackColor = Color.Transparent;
            dungeonHeaderLabel1.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point);
            dungeonHeaderLabel1.ForeColor = Color.FromArgb(76, 76, 77);
            dungeonHeaderLabel1.Location = new Point(327, 9);
            dungeonHeaderLabel1.Name = "dungeonHeaderLabel1";
            dungeonHeaderLabel1.Size = new Size(182, 32);
            dungeonHeaderLabel1.TabIndex = 15;
            dungeonHeaderLabel1.Text = "Revisar Pedido";
            // 
            // labelClient
            // 
            labelClient.AutoSize = true;
            labelClient.BackColor = Color.Transparent;
            labelClient.Font = new Font("Segoe UI", 13F, FontStyle.Regular, GraphicsUnit.Point);
            labelClient.ForeColor = Color.FromArgb(76, 76, 77);
            labelClient.Location = new Point(10, 72);
            labelClient.Name = "labelClient";
            labelClient.Size = new Size(69, 25);
            labelClient.TabIndex = 14;
            labelClient.Text = "Cliente:";
            // 
            // txtBoxClientName
            // 
            txtBoxClientName.BackColor = Color.Transparent;
            txtBoxClientName.BorderColor = Color.FromArgb(180, 180, 180);
            txtBoxClientName.EdgeColor = Color.White;
            txtBoxClientName.Font = new Font("Tahoma", 11F, FontStyle.Regular, GraphicsUnit.Point);
            txtBoxClientName.ForeColor = Color.DimGray;
            txtBoxClientName.Location = new Point(85, 72);
            txtBoxClientName.MaxLength = 32767;
            txtBoxClientName.Multiline = false;
            txtBoxClientName.Name = "txtBoxClientName";
            txtBoxClientName.ReadOnly = false;
            txtBoxClientName.Size = new Size(296, 28);
            txtBoxClientName.TabIndex = 13;
            txtBoxClientName.TextAlignment = HorizontalAlignment.Left;
            txtBoxClientName.UseSystemPasswordChar = false;
            // 
            // labelSeller
            // 
            labelSeller.AutoSize = true;
            labelSeller.BackColor = Color.Transparent;
            labelSeller.Font = new Font("Segoe UI", 13F, FontStyle.Regular, GraphicsUnit.Point);
            labelSeller.ForeColor = Color.FromArgb(76, 76, 77);
            labelSeller.Location = new Point(387, 72);
            labelSeller.Name = "labelSeller";
            labelSeller.Size = new Size(93, 25);
            labelSeller.TabIndex = 18;
            labelSeller.Text = "Vendedor:";
            // 
            // txtBoxSelllerName
            // 
            txtBoxSelllerName.BackColor = Color.Transparent;
            txtBoxSelllerName.BorderColor = Color.FromArgb(180, 180, 180);
            txtBoxSelllerName.EdgeColor = Color.White;
            txtBoxSelllerName.Font = new Font("Tahoma", 11F, FontStyle.Regular, GraphicsUnit.Point);
            txtBoxSelllerName.ForeColor = Color.DimGray;
            txtBoxSelllerName.Location = new Point(486, 72);
            txtBoxSelllerName.MaxLength = 32767;
            txtBoxSelllerName.Multiline = false;
            txtBoxSelllerName.Name = "txtBoxSelllerName";
            txtBoxSelllerName.ReadOnly = false;
            txtBoxSelllerName.Size = new Size(296, 28);
            txtBoxSelllerName.TabIndex = 17;
            txtBoxSelllerName.TextAlignment = HorizontalAlignment.Left;
            txtBoxSelllerName.UseSystemPasswordChar = false;
            // 
            // labelTransportCompany
            // 
            labelTransportCompany.AutoSize = true;
            labelTransportCompany.BackColor = Color.Transparent;
            labelTransportCompany.Font = new Font("Segoe UI", 13F, FontStyle.Regular, GraphicsUnit.Point);
            labelTransportCompany.ForeColor = Color.FromArgb(76, 76, 77);
            labelTransportCompany.Location = new Point(10, 114);
            labelTransportCompany.Name = "labelTransportCompany";
            labelTransportCompany.Size = new Size(99, 25);
            labelTransportCompany.TabIndex = 20;
            labelTransportCompany.Text = "Transporte:";
            // 
            // txtBoxTransportCompany
            // 
            txtBoxTransportCompany.BackColor = Color.Transparent;
            txtBoxTransportCompany.BorderColor = Color.FromArgb(180, 180, 180);
            txtBoxTransportCompany.EdgeColor = Color.White;
            txtBoxTransportCompany.Font = new Font("Tahoma", 11F, FontStyle.Regular, GraphicsUnit.Point);
            txtBoxTransportCompany.ForeColor = Color.DimGray;
            txtBoxTransportCompany.Location = new Point(115, 114);
            txtBoxTransportCompany.MaxLength = 32767;
            txtBoxTransportCompany.Multiline = false;
            txtBoxTransportCompany.Name = "txtBoxTransportCompany";
            txtBoxTransportCompany.ReadOnly = false;
            txtBoxTransportCompany.Size = new Size(373, 28);
            txtBoxTransportCompany.TabIndex = 19;
            txtBoxTransportCompany.TextAlignment = HorizontalAlignment.Left;
            txtBoxTransportCompany.UseSystemPasswordChar = false;
            // 
            // buttonModifyOrder
            // 
            buttonModifyOrder.BackColor = Color.Transparent;
            buttonModifyOrder.BorderColor = Color.FromArgb(32, 34, 37);
            buttonModifyOrder.EnteredBorderColor = Color.FromArgb(165, 37, 37);
            buttonModifyOrder.EnteredColor = Color.FromArgb(32, 34, 37);
            buttonModifyOrder.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point);
            buttonModifyOrder.Image = null;
            buttonModifyOrder.ImageAlign = ContentAlignment.MiddleLeft;
            buttonModifyOrder.InactiveColor = Color.FromArgb(32, 34, 37);
            buttonModifyOrder.Location = new Point(351, 398);
            buttonModifyOrder.Name = "buttonModifyOrder";
            buttonModifyOrder.PressedBorderColor = Color.FromArgb(165, 37, 37);
            buttonModifyOrder.PressedColor = Color.FromArgb(165, 37, 37);
            buttonModifyOrder.Size = new Size(120, 40);
            buttonModifyOrder.TabIndex = 21;
            buttonModifyOrder.Text = "Modificar Pedido";
            buttonModifyOrder.TextAlignment = StringAlignment.Center;
            // 
            // buttonCancelOrder
            // 
            buttonCancelOrder.BackColor = Color.Transparent;
            buttonCancelOrder.BorderColor = Color.FromArgb(32, 34, 37);
            buttonCancelOrder.EnteredBorderColor = Color.FromArgb(165, 37, 37);
            buttonCancelOrder.EnteredColor = Color.FromArgb(32, 34, 37);
            buttonCancelOrder.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point);
            buttonCancelOrder.Image = null;
            buttonCancelOrder.ImageAlign = ContentAlignment.MiddleLeft;
            buttonCancelOrder.InactiveColor = Color.FromArgb(32, 34, 37);
            buttonCancelOrder.Location = new Point(668, 398);
            buttonCancelOrder.Name = "buttonCancelOrder";
            buttonCancelOrder.PressedBorderColor = Color.FromArgb(165, 37, 37);
            buttonCancelOrder.PressedColor = Color.FromArgb(165, 37, 37);
            buttonCancelOrder.Size = new Size(120, 40);
            buttonCancelOrder.TabIndex = 22;
            buttonCancelOrder.Text = "Cancelar Pedido";
            buttonCancelOrder.TextAlignment = StringAlignment.Center;
            // 
            // dataGridViewOrderDetails
            // 
            dataGridViewOrderDetails.AllowUserToResizeRows = false;
            dataGridViewOrderDetails.BackgroundColor = Color.FromArgb(255, 255, 255);
            dataGridViewOrderDetails.BorderStyle = BorderStyle.None;
            dataGridViewOrderDetails.CellBorderStyle = DataGridViewCellBorderStyle.None;
            dataGridViewOrderDetails.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = Color.FromArgb(255, 255, 255);
            dataGridViewCellStyle1.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Pixel);
            dataGridViewCellStyle1.ForeColor = Color.FromArgb(255, 255, 255);
            dataGridViewCellStyle1.SelectionBackColor = Color.FromArgb(255, 255, 255);
            dataGridViewCellStyle1.SelectionForeColor = Color.FromArgb(17, 17, 17);
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            dataGridViewOrderDetails.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dataGridViewOrderDetails.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = Color.FromArgb(255, 255, 255);
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Pixel);
            dataGridViewCellStyle2.ForeColor = Color.FromArgb(136, 136, 136);
            dataGridViewCellStyle2.SelectionBackColor = Color.FromArgb(255, 255, 255);
            dataGridViewCellStyle2.SelectionForeColor = Color.FromArgb(17, 17, 17);
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.False;
            dataGridViewOrderDetails.DefaultCellStyle = dataGridViewCellStyle2;
            dataGridViewOrderDetails.EnableHeadersVisualStyles = false;
            dataGridViewOrderDetails.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Pixel);
            dataGridViewOrderDetails.GridColor = Color.FromArgb(255, 255, 255);
            dataGridViewOrderDetails.Location = new Point(16, 148);
            dataGridViewOrderDetails.Name = "dataGridViewOrderDetails";
            dataGridViewOrderDetails.RowHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = Color.FromArgb(255, 255, 255);
            dataGridViewCellStyle3.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Pixel);
            dataGridViewCellStyle3.ForeColor = Color.FromArgb(255, 255, 255);
            dataGridViewCellStyle3.SelectionBackColor = Color.FromArgb(255, 255, 255);
            dataGridViewCellStyle3.SelectionForeColor = Color.FromArgb(17, 17, 17);
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.True;
            dataGridViewOrderDetails.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            dataGridViewOrderDetails.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            dataGridViewOrderDetails.RowTemplate.Height = 25;
            dataGridViewOrderDetails.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridViewOrderDetails.Size = new Size(772, 227);
            dataGridViewOrderDetails.Style = ReaLTaiizor.Enum.Poison.ColorStyle.White;
            dataGridViewOrderDetails.TabIndex = 23;
            // 
            // labelOrderId
            // 
            labelOrderId.AutoSize = true;
            labelOrderId.BackColor = Color.Transparent;
            labelOrderId.Font = new Font("Segoe UI", 13F, FontStyle.Regular, GraphicsUnit.Point);
            labelOrderId.ForeColor = Color.FromArgb(76, 76, 77);
            labelOrderId.Location = new Point(494, 114);
            labelOrderId.Name = "labelOrderId";
            labelOrderId.Size = new Size(32, 25);
            labelOrderId.TabIndex = 25;
            labelOrderId.Text = "Id:";
            // 
            // txtBoxOrderId
            // 
            txtBoxOrderId.BackColor = Color.Transparent;
            txtBoxOrderId.BorderColor = Color.FromArgb(180, 180, 180);
            txtBoxOrderId.EdgeColor = Color.White;
            txtBoxOrderId.Font = new Font("Tahoma", 11F, FontStyle.Regular, GraphicsUnit.Point);
            txtBoxOrderId.ForeColor = Color.DimGray;
            txtBoxOrderId.Location = new Point(532, 114);
            txtBoxOrderId.MaxLength = 32767;
            txtBoxOrderId.Multiline = false;
            txtBoxOrderId.Name = "txtBoxOrderId";
            txtBoxOrderId.ReadOnly = false;
            txtBoxOrderId.Size = new Size(250, 28);
            txtBoxOrderId.TabIndex = 24;
            txtBoxOrderId.TextAlignment = HorizontalAlignment.Left;
            txtBoxOrderId.UseSystemPasswordChar = false;
            // 
            // OrderReview
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(labelOrderId);
            Controls.Add(txtBoxOrderId);
            Controls.Add(dataGridViewOrderDetails);
            Controls.Add(buttonCancelOrder);
            Controls.Add(buttonModifyOrder);
            Controls.Add(labelTransportCompany);
            Controls.Add(txtBoxTransportCompany);
            Controls.Add(labelSeller);
            Controls.Add(txtBoxSelllerName);
            Controls.Add(buttonCreateOrderInvoice);
            Controls.Add(dungeonHeaderLabel1);
            Controls.Add(labelClient);
            Controls.Add(txtBoxClientName);
            Name = "OrderReview";
            Text = "OrderReview";
            Load += OrderReview_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridViewOrderDetails).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ReaLTaiizor.Controls.Button buttonCreateOrderInvoice;
        private ReaLTaiizor.Controls.DungeonHeaderLabel dungeonHeaderLabel1;
        private ReaLTaiizor.Controls.DungeonLabel labelClient;
        private ReaLTaiizor.Controls.DungeonTextBox txtBoxClientName;
        private ReaLTaiizor.Controls.DungeonLabel labelSeller;
        private ReaLTaiizor.Controls.DungeonTextBox txtBoxSelllerName;
        private ReaLTaiizor.Controls.DungeonLabel labelTransportCompany;
        private ReaLTaiizor.Controls.DungeonTextBox txtBoxTransportCompany;
        private ReaLTaiizor.Controls.Button buttonModifyOrder;
        private ReaLTaiizor.Controls.Button buttonCancelOrder;
        private ReaLTaiizor.Controls.PoisonDataGridView dataGridViewOrderDetails;
        private ReaLTaiizor.Controls.DungeonLabel labelOrderId;
        private ReaLTaiizor.Controls.DungeonTextBox txtBoxOrderId;
    }
}