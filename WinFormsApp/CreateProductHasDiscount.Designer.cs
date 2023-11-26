namespace WinFormsApp
{
    partial class CreateProductHasDiscount
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
            buttonCreateDetailedInvoice = new ReaLTaiizor.Controls.Button();
            buttonSelectProduct = new ReaLTaiizor.Controls.ForeverButton();
            txtBoxProductId = new ReaLTaiizor.Controls.DungeonTextBox();
            dungeonLabel1 = new ReaLTaiizor.Controls.DungeonLabel();
            dungeonHeaderLabel1 = new ReaLTaiizor.Controls.DungeonHeaderLabel();
            buttonSelectDiscount = new ReaLTaiizor.Controls.ForeverButton();
            txtBoxDiscountId = new ReaLTaiizor.Controls.DungeonTextBox();
            dungeonLabel2 = new ReaLTaiizor.Controls.DungeonLabel();
            buttonCreateProductHasDiscount = new ReaLTaiizor.Controls.Button();
            txtBoxProductName = new ReaLTaiizor.Controls.DungeonTextBox();
            txtBoxDiscountDescription = new ReaLTaiizor.Controls.DungeonTextBox();
            dateTimeFrom = new DateTimePicker();
            dungeonLabel3 = new ReaLTaiizor.Controls.DungeonLabel();
            dungeonLabel4 = new ReaLTaiizor.Controls.DungeonLabel();
            dateTimeTo = new DateTimePicker();
            SuspendLayout();
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
            buttonCreateDetailedInvoice.Location = new Point(346, 650);
            buttonCreateDetailedInvoice.Name = "buttonCreateDetailedInvoice";
            buttonCreateDetailedInvoice.PressedBorderColor = Color.FromArgb(165, 37, 37);
            buttonCreateDetailedInvoice.PressedColor = Color.FromArgb(165, 37, 37);
            buttonCreateDetailedInvoice.Size = new Size(120, 40);
            buttonCreateDetailedInvoice.TabIndex = 54;
            buttonCreateDetailedInvoice.Text = "Facturar";
            buttonCreateDetailedInvoice.TextAlignment = StringAlignment.Center;
            // 
            // buttonSelectProduct
            // 
            buttonSelectProduct.BackColor = Color.Transparent;
            buttonSelectProduct.BaseColor = Color.DimGray;
            buttonSelectProduct.Font = new Font("Segoe UI", 13F, FontStyle.Regular, GraphicsUnit.Point);
            buttonSelectProduct.Location = new Point(576, 68);
            buttonSelectProduct.Name = "buttonSelectProduct";
            buttonSelectProduct.Rounded = true;
            buttonSelectProduct.Size = new Size(212, 30);
            buttonSelectProduct.TabIndex = 53;
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
            txtBoxProductId.Location = new Point(113, 68);
            txtBoxProductId.MaxLength = 32767;
            txtBoxProductId.Multiline = false;
            txtBoxProductId.Name = "txtBoxProductId";
            txtBoxProductId.ReadOnly = false;
            txtBoxProductId.Size = new Size(47, 28);
            txtBoxProductId.TabIndex = 52;
            txtBoxProductId.TextAlignment = HorizontalAlignment.Left;
            txtBoxProductId.UseSystemPasswordChar = false;
            // 
            // dungeonLabel1
            // 
            dungeonLabel1.AutoSize = true;
            dungeonLabel1.BackColor = Color.Transparent;
            dungeonLabel1.Font = new Font("Segoe UI", 13F, FontStyle.Regular, GraphicsUnit.Point);
            dungeonLabel1.ForeColor = Color.FromArgb(76, 76, 77);
            dungeonLabel1.Location = new Point(18, 68);
            dungeonLabel1.Name = "dungeonLabel1";
            dungeonLabel1.Size = new Size(89, 25);
            dungeonLabel1.TabIndex = 51;
            dungeonLabel1.Text = "Producto:";
            // 
            // dungeonHeaderLabel1
            // 
            dungeonHeaderLabel1.AutoSize = true;
            dungeonHeaderLabel1.BackColor = Color.Transparent;
            dungeonHeaderLabel1.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point);
            dungeonHeaderLabel1.ForeColor = Color.FromArgb(76, 76, 77);
            dungeonHeaderLabel1.Location = new Point(198, 9);
            dungeonHeaderLabel1.Name = "dungeonHeaderLabel1";
            dungeonHeaderLabel1.Size = new Size(372, 32);
            dungeonHeaderLabel1.TabIndex = 50;
            dungeonHeaderLabel1.Text = "Agregar descuento al producto";
            // 
            // buttonSelectDiscount
            // 
            buttonSelectDiscount.BackColor = Color.Transparent;
            buttonSelectDiscount.BaseColor = Color.DimGray;
            buttonSelectDiscount.Font = new Font("Segoe UI", 13F, FontStyle.Regular, GraphicsUnit.Point);
            buttonSelectDiscount.Location = new Point(576, 117);
            buttonSelectDiscount.Name = "buttonSelectDiscount";
            buttonSelectDiscount.Rounded = true;
            buttonSelectDiscount.Size = new Size(212, 30);
            buttonSelectDiscount.TabIndex = 57;
            buttonSelectDiscount.Text = "Seleccionar Descuento";
            buttonSelectDiscount.TextColor = Color.FromArgb(243, 243, 243);
            buttonSelectDiscount.Click += buttonSelectDiscount_Click;
            // 
            // txtBoxDiscountId
            // 
            txtBoxDiscountId.BackColor = Color.Transparent;
            txtBoxDiscountId.BorderColor = Color.FromArgb(180, 180, 180);
            txtBoxDiscountId.EdgeColor = Color.White;
            txtBoxDiscountId.Font = new Font("Tahoma", 11F, FontStyle.Regular, GraphicsUnit.Point);
            txtBoxDiscountId.ForeColor = Color.DimGray;
            txtBoxDiscountId.Location = new Point(113, 117);
            txtBoxDiscountId.MaxLength = 32767;
            txtBoxDiscountId.Multiline = false;
            txtBoxDiscountId.Name = "txtBoxDiscountId";
            txtBoxDiscountId.ReadOnly = false;
            txtBoxDiscountId.Size = new Size(47, 28);
            txtBoxDiscountId.TabIndex = 56;
            txtBoxDiscountId.TextAlignment = HorizontalAlignment.Left;
            txtBoxDiscountId.UseSystemPasswordChar = false;
            // 
            // dungeonLabel2
            // 
            dungeonLabel2.AutoSize = true;
            dungeonLabel2.BackColor = Color.Transparent;
            dungeonLabel2.Font = new Font("Segoe UI", 13F, FontStyle.Regular, GraphicsUnit.Point);
            dungeonLabel2.ForeColor = Color.FromArgb(76, 76, 77);
            dungeonLabel2.Location = new Point(7, 117);
            dungeonLabel2.Name = "dungeonLabel2";
            dungeonLabel2.Size = new Size(100, 25);
            dungeonLabel2.TabIndex = 55;
            dungeonLabel2.Text = "Descuento:";
            // 
            // buttonCreateProductHasDiscount
            // 
            buttonCreateProductHasDiscount.BackColor = Color.Transparent;
            buttonCreateProductHasDiscount.BorderColor = Color.FromArgb(32, 34, 37);
            buttonCreateProductHasDiscount.EnteredBorderColor = Color.FromArgb(165, 37, 37);
            buttonCreateProductHasDiscount.EnteredColor = Color.FromArgb(32, 34, 37);
            buttonCreateProductHasDiscount.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point);
            buttonCreateProductHasDiscount.Image = null;
            buttonCreateProductHasDiscount.ImageAlign = ContentAlignment.MiddleLeft;
            buttonCreateProductHasDiscount.InactiveColor = Color.FromArgb(32, 34, 37);
            buttonCreateProductHasDiscount.Location = new Point(328, 259);
            buttonCreateProductHasDiscount.Name = "buttonCreateProductHasDiscount";
            buttonCreateProductHasDiscount.PressedBorderColor = Color.FromArgb(165, 37, 37);
            buttonCreateProductHasDiscount.PressedColor = Color.FromArgb(165, 37, 37);
            buttonCreateProductHasDiscount.Size = new Size(120, 40);
            buttonCreateProductHasDiscount.TabIndex = 58;
            buttonCreateProductHasDiscount.Text = "Agregar";
            buttonCreateProductHasDiscount.TextAlignment = StringAlignment.Center;
            buttonCreateProductHasDiscount.Click += buttonCreateProductHasDiscount_Click;
            // 
            // txtBoxProductName
            // 
            txtBoxProductName.BackColor = Color.Transparent;
            txtBoxProductName.BorderColor = Color.FromArgb(180, 180, 180);
            txtBoxProductName.EdgeColor = Color.White;
            txtBoxProductName.Font = new Font("Tahoma", 11F, FontStyle.Regular, GraphicsUnit.Point);
            txtBoxProductName.ForeColor = Color.DimGray;
            txtBoxProductName.Location = new Point(166, 68);
            txtBoxProductName.MaxLength = 32767;
            txtBoxProductName.Multiline = false;
            txtBoxProductName.Name = "txtBoxProductName";
            txtBoxProductName.ReadOnly = false;
            txtBoxProductName.Size = new Size(404, 28);
            txtBoxProductName.TabIndex = 59;
            txtBoxProductName.TextAlignment = HorizontalAlignment.Left;
            txtBoxProductName.UseSystemPasswordChar = false;
            // 
            // txtBoxDiscountDescription
            // 
            txtBoxDiscountDescription.BackColor = Color.Transparent;
            txtBoxDiscountDescription.BorderColor = Color.FromArgb(180, 180, 180);
            txtBoxDiscountDescription.EdgeColor = Color.White;
            txtBoxDiscountDescription.Font = new Font("Tahoma", 11F, FontStyle.Regular, GraphicsUnit.Point);
            txtBoxDiscountDescription.ForeColor = Color.DimGray;
            txtBoxDiscountDescription.Location = new Point(166, 117);
            txtBoxDiscountDescription.MaxLength = 32767;
            txtBoxDiscountDescription.Multiline = false;
            txtBoxDiscountDescription.Name = "txtBoxDiscountDescription";
            txtBoxDiscountDescription.ReadOnly = false;
            txtBoxDiscountDescription.Size = new Size(404, 28);
            txtBoxDiscountDescription.TabIndex = 60;
            txtBoxDiscountDescription.TextAlignment = HorizontalAlignment.Left;
            txtBoxDiscountDescription.UseSystemPasswordChar = false;
            // 
            // dateTimeFrom
            // 
            dateTimeFrom.Location = new Point(113, 166);
            dateTimeFrom.Name = "dateTimeFrom";
            dateTimeFrom.Size = new Size(457, 23);
            dateTimeFrom.TabIndex = 63;
            // 
            // dungeonLabel3
            // 
            dungeonLabel3.AutoSize = true;
            dungeonLabel3.BackColor = Color.Transparent;
            dungeonLabel3.Font = new Font("Segoe UI", 13F, FontStyle.Regular, GraphicsUnit.Point);
            dungeonLabel3.ForeColor = Color.FromArgb(76, 76, 77);
            dungeonLabel3.Location = new Point(36, 164);
            dungeonLabel3.Name = "dungeonLabel3";
            dungeonLabel3.Size = new Size(66, 25);
            dungeonLabel3.TabIndex = 64;
            dungeonLabel3.Text = "Desde:";
            // 
            // dungeonLabel4
            // 
            dungeonLabel4.AutoSize = true;
            dungeonLabel4.BackColor = Color.Transparent;
            dungeonLabel4.Font = new Font("Segoe UI", 13F, FontStyle.Regular, GraphicsUnit.Point);
            dungeonLabel4.ForeColor = Color.FromArgb(76, 76, 77);
            dungeonLabel4.Location = new Point(41, 214);
            dungeonLabel4.Name = "dungeonLabel4";
            dungeonLabel4.Size = new Size(61, 25);
            dungeonLabel4.TabIndex = 65;
            dungeonLabel4.Text = "Hasta:";
            // 
            // dateTimeTo
            // 
            dateTimeTo.Location = new Point(113, 214);
            dateTimeTo.Name = "dateTimeTo";
            dateTimeTo.Size = new Size(457, 23);
            dateTimeTo.TabIndex = 66;
            // 
            // CreateProductHasDiscount
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 316);
            Controls.Add(dateTimeTo);
            Controls.Add(dungeonLabel4);
            Controls.Add(dungeonLabel3);
            Controls.Add(dateTimeFrom);
            Controls.Add(txtBoxDiscountDescription);
            Controls.Add(txtBoxProductName);
            Controls.Add(buttonCreateProductHasDiscount);
            Controls.Add(buttonSelectDiscount);
            Controls.Add(txtBoxDiscountId);
            Controls.Add(dungeonLabel2);
            Controls.Add(buttonCreateDetailedInvoice);
            Controls.Add(buttonSelectProduct);
            Controls.Add(txtBoxProductId);
            Controls.Add(dungeonLabel1);
            Controls.Add(dungeonHeaderLabel1);
            Name = "CreateProductHasDiscount";
            Text = "CreateProductHasDiscount";
            Load += CreateProductHasDiscount_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ReaLTaiizor.Controls.Button buttonCreateDetailedInvoice;
        private ReaLTaiizor.Controls.ForeverButton buttonSelectProduct;
        private ReaLTaiizor.Controls.DungeonTextBox txtBoxProductId;
        private ReaLTaiizor.Controls.DungeonLabel dungeonLabel1;
        private ReaLTaiizor.Controls.DungeonHeaderLabel dungeonHeaderLabel1;
        private ReaLTaiizor.Controls.ForeverButton buttonSelectDiscount;
        private ReaLTaiizor.Controls.DungeonTextBox txtBoxDiscountId;
        private ReaLTaiizor.Controls.DungeonLabel dungeonLabel2;
        private ReaLTaiizor.Controls.Button buttonCreateProductHasDiscount;
        private ReaLTaiizor.Controls.DungeonTextBox txtBoxProductName;
        private ReaLTaiizor.Controls.DungeonTextBox txtBoxDiscountDescription;
        private DateTimePicker dateTimeFrom;
        private ReaLTaiizor.Controls.DungeonLabel dungeonLabel3;
        private ReaLTaiizor.Controls.DungeonLabel dungeonLabel4;
        private DateTimePicker dateTimeTo;
    }
}