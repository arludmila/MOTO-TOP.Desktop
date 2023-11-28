namespace WinFormsApp
{
    partial class InvoiceReview
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
            dungeonLabel1 = new ReaLTaiizor.Controls.DungeonLabel();
            txtBoxInvoiceId = new ReaLTaiizor.Controls.DungeonTextBox();
            dungeonLabel2 = new ReaLTaiizor.Controls.DungeonLabel();
            txtBoxClientDocument = new ReaLTaiizor.Controls.DungeonTextBox();
            dungeonLabel3 = new ReaLTaiizor.Controls.DungeonLabel();
            txtBoxInvoiceDate = new ReaLTaiizor.Controls.DungeonTextBox();
            dataGridViewInvoiceDetails = new ReaLTaiizor.Controls.PoisonDataGridView();
            dungeonLabel4 = new ReaLTaiizor.Controls.DungeonLabel();
            txtBoxTotalAmount = new ReaLTaiizor.Controls.DungeonTextBox();
            ((System.ComponentModel.ISupportInitialize)dataGridViewInvoiceDetails).BeginInit();
            SuspendLayout();
            // 
            // dungeonHeaderLabel1
            // 
            dungeonHeaderLabel1.AutoSize = true;
            dungeonHeaderLabel1.BackColor = Color.Transparent;
            dungeonHeaderLabel1.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point);
            dungeonHeaderLabel1.ForeColor = Color.FromArgb(76, 76, 77);
            dungeonHeaderLabel1.Location = new Point(379, 9);
            dungeonHeaderLabel1.Name = "dungeonHeaderLabel1";
            dungeonHeaderLabel1.Size = new Size(186, 32);
            dungeonHeaderLabel1.TabIndex = 18;
            dungeonHeaderLabel1.Text = "Revisar Factura";
            // 
            // labelClient
            // 
            labelClient.AutoSize = true;
            labelClient.BackColor = Color.Transparent;
            labelClient.Font = new Font("Segoe UI", 13F, FontStyle.Regular, GraphicsUnit.Point);
            labelClient.ForeColor = Color.FromArgb(76, 76, 77);
            labelClient.Location = new Point(5, 58);
            labelClient.Name = "labelClient";
            labelClient.Size = new Size(69, 25);
            labelClient.TabIndex = 17;
            labelClient.Text = "Cliente:";
            // 
            // txtBoxClientName
            // 
            txtBoxClientName.BackColor = Color.Transparent;
            txtBoxClientName.BorderColor = Color.FromArgb(180, 180, 180);
            txtBoxClientName.EdgeColor = Color.White;
            txtBoxClientName.Font = new Font("Tahoma", 11F, FontStyle.Regular, GraphicsUnit.Point);
            txtBoxClientName.ForeColor = Color.DimGray;
            txtBoxClientName.Location = new Point(80, 58);
            txtBoxClientName.MaxLength = 32767;
            txtBoxClientName.Multiline = false;
            txtBoxClientName.Name = "txtBoxClientName";
            txtBoxClientName.ReadOnly = false;
            txtBoxClientName.Size = new Size(419, 28);
            txtBoxClientName.TabIndex = 16;
            txtBoxClientName.TextAlignment = HorizontalAlignment.Left;
            txtBoxClientName.UseSystemPasswordChar = false;
            // 
            // dungeonLabel1
            // 
            dungeonLabel1.AutoSize = true;
            dungeonLabel1.BackColor = Color.Transparent;
            dungeonLabel1.Font = new Font("Segoe UI", 13F, FontStyle.Regular, GraphicsUnit.Point);
            dungeonLabel1.ForeColor = Color.FromArgb(76, 76, 77);
            dungeonLabel1.Location = new Point(608, 58);
            dungeonLabel1.Name = "dungeonLabel1";
            dungeonLabel1.Size = new Size(122, 25);
            dungeonLabel1.TabIndex = 20;
            dungeonLabel1.Text = "N° de Factura:";
            // 
            // txtBoxInvoiceId
            // 
            txtBoxInvoiceId.BackColor = Color.Transparent;
            txtBoxInvoiceId.BorderColor = Color.FromArgb(180, 180, 180);
            txtBoxInvoiceId.EdgeColor = Color.White;
            txtBoxInvoiceId.Font = new Font("Tahoma", 11F, FontStyle.Regular, GraphicsUnit.Point);
            txtBoxInvoiceId.ForeColor = Color.DimGray;
            txtBoxInvoiceId.Location = new Point(736, 58);
            txtBoxInvoiceId.MaxLength = 32767;
            txtBoxInvoiceId.Multiline = false;
            txtBoxInvoiceId.Name = "txtBoxInvoiceId";
            txtBoxInvoiceId.ReadOnly = false;
            txtBoxInvoiceId.Size = new Size(166, 28);
            txtBoxInvoiceId.TabIndex = 19;
            txtBoxInvoiceId.TextAlignment = HorizontalAlignment.Left;
            txtBoxInvoiceId.UseSystemPasswordChar = false;
            // 
            // dungeonLabel2
            // 
            dungeonLabel2.AutoSize = true;
            dungeonLabel2.BackColor = Color.Transparent;
            dungeonLabel2.Font = new Font("Segoe UI", 13F, FontStyle.Regular, GraphicsUnit.Point);
            dungeonLabel2.ForeColor = Color.FromArgb(76, 76, 77);
            dungeonLabel2.Location = new Point(5, 98);
            dungeonLabel2.Name = "dungeonLabel2";
            dungeonLabel2.Size = new Size(110, 25);
            dungeonLabel2.TabIndex = 22;
            dungeonLabel2.Text = "Documento:";
            // 
            // txtBoxClientDocument
            // 
            txtBoxClientDocument.BackColor = Color.Transparent;
            txtBoxClientDocument.BorderColor = Color.FromArgb(180, 180, 180);
            txtBoxClientDocument.EdgeColor = Color.White;
            txtBoxClientDocument.Font = new Font("Tahoma", 11F, FontStyle.Regular, GraphicsUnit.Point);
            txtBoxClientDocument.ForeColor = Color.DimGray;
            txtBoxClientDocument.Location = new Point(121, 98);
            txtBoxClientDocument.MaxLength = 32767;
            txtBoxClientDocument.Multiline = false;
            txtBoxClientDocument.Name = "txtBoxClientDocument";
            txtBoxClientDocument.ReadOnly = false;
            txtBoxClientDocument.Size = new Size(378, 28);
            txtBoxClientDocument.TabIndex = 21;
            txtBoxClientDocument.TextAlignment = HorizontalAlignment.Left;
            txtBoxClientDocument.UseSystemPasswordChar = false;
            // 
            // dungeonLabel3
            // 
            dungeonLabel3.AutoSize = true;
            dungeonLabel3.BackColor = Color.Transparent;
            dungeonLabel3.Font = new Font("Segoe UI", 13F, FontStyle.Regular, GraphicsUnit.Point);
            dungeonLabel3.ForeColor = Color.FromArgb(76, 76, 77);
            dungeonLabel3.Location = new Point(669, 98);
            dungeonLabel3.Name = "dungeonLabel3";
            dungeonLabel3.Size = new Size(61, 25);
            dungeonLabel3.TabIndex = 24;
            dungeonLabel3.Text = "Fecha:";
            // 
            // txtBoxInvoiceDate
            // 
            txtBoxInvoiceDate.BackColor = Color.Transparent;
            txtBoxInvoiceDate.BorderColor = Color.FromArgb(180, 180, 180);
            txtBoxInvoiceDate.EdgeColor = Color.White;
            txtBoxInvoiceDate.Font = new Font("Tahoma", 11F, FontStyle.Regular, GraphicsUnit.Point);
            txtBoxInvoiceDate.ForeColor = Color.DimGray;
            txtBoxInvoiceDate.Location = new Point(736, 98);
            txtBoxInvoiceDate.MaxLength = 32767;
            txtBoxInvoiceDate.Multiline = false;
            txtBoxInvoiceDate.Name = "txtBoxInvoiceDate";
            txtBoxInvoiceDate.ReadOnly = false;
            txtBoxInvoiceDate.Size = new Size(166, 28);
            txtBoxInvoiceDate.TabIndex = 23;
            txtBoxInvoiceDate.TextAlignment = HorizontalAlignment.Left;
            txtBoxInvoiceDate.UseSystemPasswordChar = false;
            // 
            // dataGridViewInvoiceDetails
            // 
            dataGridViewInvoiceDetails.AllowUserToResizeRows = false;
            dataGridViewInvoiceDetails.BackgroundColor = Color.FromArgb(255, 255, 255);
            dataGridViewInvoiceDetails.BorderStyle = BorderStyle.None;
            dataGridViewInvoiceDetails.CellBorderStyle = DataGridViewCellBorderStyle.None;
            dataGridViewInvoiceDetails.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle4.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = Color.FromArgb(85, 85, 85);
            dataGridViewCellStyle4.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Pixel);
            dataGridViewCellStyle4.ForeColor = Color.FromArgb(255, 255, 255);
            dataGridViewCellStyle4.SelectionBackColor = Color.FromArgb(102, 102, 102);
            dataGridViewCellStyle4.SelectionForeColor = Color.FromArgb(17, 17, 17);
            dataGridViewCellStyle4.WrapMode = DataGridViewTriState.True;
            dataGridViewInvoiceDetails.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle4;
            dataGridViewInvoiceDetails.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle5.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = Color.FromArgb(255, 255, 255);
            dataGridViewCellStyle5.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Pixel);
            dataGridViewCellStyle5.ForeColor = Color.FromArgb(136, 136, 136);
            dataGridViewCellStyle5.SelectionBackColor = Color.FromArgb(102, 102, 102);
            dataGridViewCellStyle5.SelectionForeColor = Color.FromArgb(17, 17, 17);
            dataGridViewCellStyle5.WrapMode = DataGridViewTriState.False;
            dataGridViewInvoiceDetails.DefaultCellStyle = dataGridViewCellStyle5;
            dataGridViewInvoiceDetails.EnableHeadersVisualStyles = false;
            dataGridViewInvoiceDetails.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Pixel);
            dataGridViewInvoiceDetails.GridColor = Color.FromArgb(255, 255, 255);
            dataGridViewInvoiceDetails.Location = new Point(12, 143);
            dataGridViewInvoiceDetails.Name = "dataGridViewInvoiceDetails";
            dataGridViewInvoiceDetails.RowHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle6.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = Color.FromArgb(85, 85, 85);
            dataGridViewCellStyle6.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Pixel);
            dataGridViewCellStyle6.ForeColor = Color.FromArgb(255, 255, 255);
            dataGridViewCellStyle6.SelectionBackColor = Color.FromArgb(102, 102, 102);
            dataGridViewCellStyle6.SelectionForeColor = Color.FromArgb(17, 17, 17);
            dataGridViewCellStyle6.WrapMode = DataGridViewTriState.True;
            dataGridViewInvoiceDetails.RowHeadersDefaultCellStyle = dataGridViewCellStyle6;
            dataGridViewInvoiceDetails.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            dataGridViewInvoiceDetails.RowTemplate.Height = 25;
            dataGridViewInvoiceDetails.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridViewInvoiceDetails.Size = new Size(890, 330);
            dataGridViewInvoiceDetails.Style = ReaLTaiizor.Enum.Poison.ColorStyle.Silver;
            dataGridViewInvoiceDetails.TabIndex = 27;
            // 
            // dungeonLabel4
            // 
            dungeonLabel4.AutoSize = true;
            dungeonLabel4.BackColor = Color.Transparent;
            dungeonLabel4.Font = new Font("Segoe UI", 13F, FontStyle.Regular, GraphicsUnit.Point);
            dungeonLabel4.ForeColor = Color.FromArgb(76, 76, 77);
            dungeonLabel4.Location = new Point(512, 482);
            dungeonLabel4.Name = "dungeonLabel4";
            dungeonLabel4.Size = new Size(53, 25);
            dungeonLabel4.TabIndex = 29;
            dungeonLabel4.Text = "Total:";
            // 
            // txtBoxTotalAmount
            // 
            txtBoxTotalAmount.BackColor = Color.Transparent;
            txtBoxTotalAmount.BorderColor = Color.FromArgb(180, 180, 180);
            txtBoxTotalAmount.EdgeColor = Color.White;
            txtBoxTotalAmount.Font = new Font("Tahoma", 11F, FontStyle.Regular, GraphicsUnit.Point);
            txtBoxTotalAmount.ForeColor = Color.DimGray;
            txtBoxTotalAmount.Location = new Point(571, 479);
            txtBoxTotalAmount.MaxLength = 32767;
            txtBoxTotalAmount.Multiline = false;
            txtBoxTotalAmount.Name = "txtBoxTotalAmount";
            txtBoxTotalAmount.ReadOnly = false;
            txtBoxTotalAmount.Size = new Size(331, 28);
            txtBoxTotalAmount.TabIndex = 28;
            txtBoxTotalAmount.TextAlignment = HorizontalAlignment.Left;
            txtBoxTotalAmount.UseSystemPasswordChar = false;
            // 
            // InvoiceReview
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(914, 519);
            Controls.Add(dungeonLabel4);
            Controls.Add(txtBoxTotalAmount);
            Controls.Add(dataGridViewInvoiceDetails);
            Controls.Add(dungeonLabel3);
            Controls.Add(txtBoxInvoiceDate);
            Controls.Add(dungeonLabel2);
            Controls.Add(txtBoxClientDocument);
            Controls.Add(dungeonLabel1);
            Controls.Add(txtBoxInvoiceId);
            Controls.Add(dungeonHeaderLabel1);
            Controls.Add(labelClient);
            Controls.Add(txtBoxClientName);
            Name = "InvoiceReview";
            Text = "InvoiceReview";
            Load += InvoiceReview_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridViewInvoiceDetails).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ReaLTaiizor.Controls.DungeonHeaderLabel dungeonHeaderLabel1;
        private ReaLTaiizor.Controls.DungeonLabel labelClient;
        private ReaLTaiizor.Controls.DungeonTextBox txtBoxClientName;
        private ReaLTaiizor.Controls.DungeonLabel dungeonLabel1;
        private ReaLTaiizor.Controls.DungeonTextBox txtBoxInvoiceId;
        private ReaLTaiizor.Controls.DungeonLabel dungeonLabel2;
        private ReaLTaiizor.Controls.DungeonTextBox txtBoxClientDocument;
        private ReaLTaiizor.Controls.DungeonLabel dungeonLabel3;
        private ReaLTaiizor.Controls.DungeonTextBox txtBoxInvoiceDate;
        private ReaLTaiizor.Controls.PoisonDataGridView dataGridViewInvoiceDetails;
        private ReaLTaiizor.Controls.DungeonLabel dungeonLabel4;
        private ReaLTaiizor.Controls.DungeonTextBox txtBoxTotalAmount;
    }
}