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
            DataGridViewCellStyle dataGridViewCellStyle4 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle5 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle6 = new DataGridViewCellStyle();
            dungeonHeaderLabel1 = new ReaLTaiizor.Controls.DungeonHeaderLabel();
            labelClient = new ReaLTaiizor.Controls.DungeonLabel();
            txtBoxClientName = new ReaLTaiizor.Controls.DungeonTextBox();
            labelSeller = new ReaLTaiizor.Controls.DungeonLabel();
            txtBoxSelllerName = new ReaLTaiizor.Controls.DungeonTextBox();
            labelTransportCompany = new ReaLTaiizor.Controls.DungeonLabel();
            txtBoxTransportCompany = new ReaLTaiizor.Controls.DungeonTextBox();
            labelOrderId = new ReaLTaiizor.Controls.DungeonLabel();
            txtBoxOrderId = new ReaLTaiizor.Controls.DungeonTextBox();
            dataGridViewOrderDetails = new ReaLTaiizor.Controls.PoisonDataGridView();
            foreverButton1 = new ReaLTaiizor.Controls.ForeverButton();
            foreverButton2 = new ReaLTaiizor.Controls.ForeverButton();
            foreverButton3 = new ReaLTaiizor.Controls.ForeverButton();
            ((System.ComponentModel.ISupportInitialize)dataGridViewOrderDetails).BeginInit();
            SuspendLayout();
            // 
            // dungeonHeaderLabel1
            // 
            dungeonHeaderLabel1.AutoSize = true;
            dungeonHeaderLabel1.BackColor = Color.Transparent;
            dungeonHeaderLabel1.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point);
            dungeonHeaderLabel1.ForeColor = Color.FromArgb(76, 76, 77);
            dungeonHeaderLabel1.Location = new Point(306, 9);
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
            // dataGridViewOrderDetails
            // 
            dataGridViewOrderDetails.AllowUserToResizeRows = false;
            dataGridViewOrderDetails.BackgroundColor = Color.FromArgb(255, 255, 255);
            dataGridViewOrderDetails.BorderStyle = BorderStyle.None;
            dataGridViewOrderDetails.CellBorderStyle = DataGridViewCellBorderStyle.None;
            dataGridViewOrderDetails.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle4.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = Color.FromArgb(85, 85, 85);
            dataGridViewCellStyle4.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Pixel);
            dataGridViewCellStyle4.ForeColor = Color.FromArgb(255, 255, 255);
            dataGridViewCellStyle4.SelectionBackColor = Color.FromArgb(102, 102, 102);
            dataGridViewCellStyle4.SelectionForeColor = Color.FromArgb(17, 17, 17);
            dataGridViewCellStyle4.WrapMode = DataGridViewTriState.True;
            dataGridViewOrderDetails.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle4;
            dataGridViewOrderDetails.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle5.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = Color.FromArgb(255, 255, 255);
            dataGridViewCellStyle5.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Pixel);
            dataGridViewCellStyle5.ForeColor = Color.FromArgb(136, 136, 136);
            dataGridViewCellStyle5.SelectionBackColor = Color.FromArgb(102, 102, 102);
            dataGridViewCellStyle5.SelectionForeColor = Color.FromArgb(17, 17, 17);
            dataGridViewCellStyle5.WrapMode = DataGridViewTriState.False;
            dataGridViewOrderDetails.DefaultCellStyle = dataGridViewCellStyle5;
            dataGridViewOrderDetails.EnableHeadersVisualStyles = false;
            dataGridViewOrderDetails.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Pixel);
            dataGridViewOrderDetails.GridColor = Color.FromArgb(255, 255, 255);
            dataGridViewOrderDetails.Location = new Point(4, 148);
            dataGridViewOrderDetails.Name = "dataGridViewOrderDetails";
            dataGridViewOrderDetails.RowHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle6.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = Color.FromArgb(85, 85, 85);
            dataGridViewCellStyle6.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Pixel);
            dataGridViewCellStyle6.ForeColor = Color.FromArgb(255, 255, 255);
            dataGridViewCellStyle6.SelectionBackColor = Color.FromArgb(102, 102, 102);
            dataGridViewCellStyle6.SelectionForeColor = Color.FromArgb(17, 17, 17);
            dataGridViewCellStyle6.WrapMode = DataGridViewTriState.True;
            dataGridViewOrderDetails.RowHeadersDefaultCellStyle = dataGridViewCellStyle6;
            dataGridViewOrderDetails.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            dataGridViewOrderDetails.RowTemplate.Height = 25;
            dataGridViewOrderDetails.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridViewOrderDetails.Size = new Size(778, 244);
            dataGridViewOrderDetails.Style = ReaLTaiizor.Enum.Poison.ColorStyle.Silver;
            dataGridViewOrderDetails.TabIndex = 26;
            dataGridViewOrderDetails.SelectionChanged += dataGridViewOrderDetails_SelectionChanged;
            // 
            // foreverButton1
            // 
            foreverButton1.BackColor = Color.Transparent;
            foreverButton1.BaseColor = Color.OliveDrab;
            foreverButton1.Font = new Font("Segoe UI", 13F, FontStyle.Regular, GraphicsUnit.Point);
            foreverButton1.Location = new Point(10, 398);
            foreverButton1.Name = "foreverButton1";
            foreverButton1.Rounded = true;
            foreverButton1.Size = new Size(134, 40);
            foreverButton1.TabIndex = 27;
            foreverButton1.Text = "Facturar Pedido";
            foreverButton1.TextColor = Color.FromArgb(243, 243, 243);
            // 
            // foreverButton2
            // 
            foreverButton2.BackColor = Color.Transparent;
            foreverButton2.BaseColor = Color.DimGray;
            foreverButton2.Font = new Font("Segoe UI", 13F, FontStyle.Regular, GraphicsUnit.Point);
            foreverButton2.Location = new Point(330, 398);
            foreverButton2.Name = "foreverButton2";
            foreverButton2.Rounded = true;
            foreverButton2.Size = new Size(150, 40);
            foreverButton2.TabIndex = 28;
            foreverButton2.Text = "Modificar Pedido";
            foreverButton2.TextColor = Color.FromArgb(243, 243, 243);
            // 
            // foreverButton3
            // 
            foreverButton3.BackColor = Color.Transparent;
            foreverButton3.BaseColor = Color.IndianRed;
            foreverButton3.Font = new Font("Segoe UI", 13F, FontStyle.Regular, GraphicsUnit.Point);
            foreverButton3.Location = new Point(648, 398);
            foreverButton3.Name = "foreverButton3";
            foreverButton3.Rounded = true;
            foreverButton3.Size = new Size(134, 40);
            foreverButton3.TabIndex = 29;
            foreverButton3.Text = "Cancelar Pedido";
            foreverButton3.TextColor = Color.FromArgb(243, 243, 243);
            // 
            // OrderReview
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(foreverButton3);
            Controls.Add(foreverButton2);
            Controls.Add(foreverButton1);
            Controls.Add(dataGridViewOrderDetails);
            Controls.Add(labelOrderId);
            Controls.Add(txtBoxOrderId);
            Controls.Add(labelTransportCompany);
            Controls.Add(txtBoxTransportCompany);
            Controls.Add(labelSeller);
            Controls.Add(txtBoxSelllerName);
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
        private ReaLTaiizor.Controls.DungeonLabel labelOrderId;
        private ReaLTaiizor.Controls.DungeonTextBox txtBoxOrderId;
        private ReaLTaiizor.Controls.PoisonDataGridView dataGridViewOrderDetails;
        private ReaLTaiizor.Controls.ForeverButton foreverButton1;
        private ReaLTaiizor.Controls.ForeverButton foreverButton2;
        private ReaLTaiizor.Controls.ForeverButton foreverButton3;
    }
}