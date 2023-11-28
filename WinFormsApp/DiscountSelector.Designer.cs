namespace WinFormsApp
{
    partial class DiscountSelector
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
            labelProductsSearch = new ReaLTaiizor.Controls.DungeonLabel();
            txtBoxDiscountsSearch = new ReaLTaiizor.Controls.DungeonTextBox();
            dataGridViewDiscounts = new ReaLTaiizor.Controls.PoisonDataGridView();
            labelTitle = new ReaLTaiizor.Controls.DungeonHeaderLabel();
            ((System.ComponentModel.ISupportInitialize)dataGridViewDiscounts).BeginInit();
            SuspendLayout();
            // 
            // labelProductsSearch
            // 
            labelProductsSearch.AutoSize = true;
            labelProductsSearch.BackColor = Color.Transparent;
            labelProductsSearch.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            labelProductsSearch.ForeColor = Color.FromArgb(76, 76, 77);
            labelProductsSearch.Location = new Point(57, 42);
            labelProductsSearch.Name = "labelProductsSearch";
            labelProductsSearch.Size = new Size(72, 25);
            labelProductsSearch.TabIndex = 38;
            labelProductsSearch.Text = "Buscar:";
            // 
            // txtBoxDiscountsSearch
            // 
            txtBoxDiscountsSearch.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            txtBoxDiscountsSearch.BackColor = Color.Transparent;
            txtBoxDiscountsSearch.BorderColor = Color.FromArgb(180, 180, 180);
            txtBoxDiscountsSearch.EdgeColor = Color.White;
            txtBoxDiscountsSearch.Font = new Font("Tahoma", 11F, FontStyle.Regular, GraphicsUnit.Point);
            txtBoxDiscountsSearch.ForeColor = Color.DimGray;
            txtBoxDiscountsSearch.Location = new Point(135, 42);
            txtBoxDiscountsSearch.MaxLength = 32767;
            txtBoxDiscountsSearch.Multiline = false;
            txtBoxDiscountsSearch.Name = "txtBoxDiscountsSearch";
            txtBoxDiscountsSearch.ReadOnly = false;
            txtBoxDiscountsSearch.Size = new Size(589, 28);
            txtBoxDiscountsSearch.TabIndex = 37;
            txtBoxDiscountsSearch.TextAlignment = HorizontalAlignment.Left;
            txtBoxDiscountsSearch.UseSystemPasswordChar = false;
            txtBoxDiscountsSearch.TextChanged += txtBoxDiscountsSearch_TextChanged;
            // 
            // dataGridViewDiscounts
            // 
            dataGridViewDiscounts.AllowUserToResizeRows = false;
            dataGridViewDiscounts.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dataGridViewDiscounts.BackgroundColor = Color.FromArgb(255, 255, 255);
            dataGridViewDiscounts.BorderStyle = BorderStyle.None;
            dataGridViewDiscounts.CellBorderStyle = DataGridViewCellBorderStyle.None;
            dataGridViewDiscounts.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = Color.FromArgb(85, 85, 85);
            dataGridViewCellStyle1.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Pixel);
            dataGridViewCellStyle1.ForeColor = Color.FromArgb(255, 255, 255);
            dataGridViewCellStyle1.SelectionBackColor = Color.FromArgb(102, 102, 102);
            dataGridViewCellStyle1.SelectionForeColor = Color.FromArgb(17, 17, 17);
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            dataGridViewDiscounts.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dataGridViewDiscounts.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = Color.FromArgb(255, 255, 255);
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Pixel);
            dataGridViewCellStyle2.ForeColor = Color.FromArgb(136, 136, 136);
            dataGridViewCellStyle2.SelectionBackColor = Color.FromArgb(102, 102, 102);
            dataGridViewCellStyle2.SelectionForeColor = Color.FromArgb(17, 17, 17);
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.False;
            dataGridViewDiscounts.DefaultCellStyle = dataGridViewCellStyle2;
            dataGridViewDiscounts.EnableHeadersVisualStyles = false;
            dataGridViewDiscounts.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Pixel);
            dataGridViewDiscounts.GridColor = Color.FromArgb(255, 255, 255);
            dataGridViewDiscounts.Location = new Point(11, 80);
            dataGridViewDiscounts.Name = "dataGridViewDiscounts";
            dataGridViewDiscounts.RowHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = Color.FromArgb(85, 85, 85);
            dataGridViewCellStyle3.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Pixel);
            dataGridViewCellStyle3.ForeColor = Color.FromArgb(255, 255, 255);
            dataGridViewCellStyle3.SelectionBackColor = Color.FromArgb(102, 102, 102);
            dataGridViewCellStyle3.SelectionForeColor = Color.FromArgb(17, 17, 17);
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.True;
            dataGridViewDiscounts.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            dataGridViewDiscounts.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            dataGridViewDiscounts.RowTemplate.Height = 25;
            dataGridViewDiscounts.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridViewDiscounts.Size = new Size(778, 314);
            dataGridViewDiscounts.Style = ReaLTaiizor.Enum.Poison.ColorStyle.Silver;
            dataGridViewDiscounts.TabIndex = 35;
            dataGridViewDiscounts.CellContentClick += dataGridViewDiscounts_CellContentClick;
            // 
            // labelTitle
            // 
            labelTitle.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            labelTitle.AutoSize = true;
            labelTitle.BackColor = Color.Transparent;
            labelTitle.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point);
            labelTitle.ForeColor = Color.FromArgb(76, 76, 77);
            labelTitle.Location = new Point(257, 11);
            labelTitle.Name = "labelTitle";
            labelTitle.Size = new Size(272, 32);
            labelTitle.TabIndex = 34;
            labelTitle.Text = "Seleccionar Descuento";
            // 
            // DiscountSelector
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 419);
            Controls.Add(labelProductsSearch);
            Controls.Add(txtBoxDiscountsSearch);
            Controls.Add(dataGridViewDiscounts);
            Controls.Add(labelTitle);
            Name = "DiscountSelector";
            Text = "CreateProductHasDiscount";
            Load += CreateProductHasDiscount_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridViewDiscounts).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ReaLTaiizor.Controls.DungeonLabel labelProductsSearch;
        private ReaLTaiizor.Controls.DungeonTextBox txtBoxDiscountsSearch;
        private ReaLTaiizor.Controls.ForeverButton buttonSelectDiscount;
        private ReaLTaiizor.Controls.PoisonDataGridView dataGridViewDiscounts;
        private ReaLTaiizor.Controls.DungeonHeaderLabel labelTitle;
    }
}