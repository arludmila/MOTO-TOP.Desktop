namespace WinFormsApp
{
    partial class ProductSelector
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
            dataGridViewProducts = new ReaLTaiizor.Controls.PoisonDataGridView();
            labelTitle = new ReaLTaiizor.Controls.DungeonHeaderLabel();
            labelProductsSearch = new ReaLTaiizor.Controls.DungeonLabel();
            txtBoxProductsSearch = new ReaLTaiizor.Controls.DungeonTextBox();
            ((System.ComponentModel.ISupportInitialize)dataGridViewProducts).BeginInit();
            SuspendLayout();
            // 
            // dataGridViewProducts
            // 
            dataGridViewProducts.AllowUserToResizeRows = false;
            dataGridViewProducts.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dataGridViewProducts.BackgroundColor = Color.FromArgb(255, 255, 255);
            dataGridViewProducts.BorderStyle = BorderStyle.None;
            dataGridViewProducts.CellBorderStyle = DataGridViewCellBorderStyle.None;
            dataGridViewProducts.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = Color.FromArgb(85, 85, 85);
            dataGridViewCellStyle1.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Pixel);
            dataGridViewCellStyle1.ForeColor = Color.FromArgb(255, 255, 255);
            dataGridViewCellStyle1.SelectionBackColor = Color.FromArgb(102, 102, 102);
            dataGridViewCellStyle1.SelectionForeColor = Color.FromArgb(17, 17, 17);
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            dataGridViewProducts.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dataGridViewProducts.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = Color.FromArgb(255, 255, 255);
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Pixel);
            dataGridViewCellStyle2.ForeColor = Color.FromArgb(136, 136, 136);
            dataGridViewCellStyle2.SelectionBackColor = Color.FromArgb(102, 102, 102);
            dataGridViewCellStyle2.SelectionForeColor = Color.FromArgb(17, 17, 17);
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.False;
            dataGridViewProducts.DefaultCellStyle = dataGridViewCellStyle2;
            dataGridViewProducts.EnableHeadersVisualStyles = false;
            dataGridViewProducts.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Pixel);
            dataGridViewProducts.GridColor = Color.FromArgb(255, 255, 255);
            dataGridViewProducts.Location = new Point(12, 78);
            dataGridViewProducts.Name = "dataGridViewProducts";
            dataGridViewProducts.RowHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = Color.FromArgb(85, 85, 85);
            dataGridViewCellStyle3.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Pixel);
            dataGridViewCellStyle3.ForeColor = Color.FromArgb(255, 255, 255);
            dataGridViewCellStyle3.SelectionBackColor = Color.FromArgb(102, 102, 102);
            dataGridViewCellStyle3.SelectionForeColor = Color.FromArgb(17, 17, 17);
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.True;
            dataGridViewProducts.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            dataGridViewProducts.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            dataGridViewProducts.RowTemplate.Height = 25;
            dataGridViewProducts.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridViewProducts.Size = new Size(778, 314);
            dataGridViewProducts.Style = ReaLTaiizor.Enum.Poison.ColorStyle.Silver;
            dataGridViewProducts.TabIndex = 30;
            dataGridViewProducts.CellContentClick += dataGridViewProducts_CellContentClick;
            dataGridViewProducts.SelectionChanged += dataGridViewProducts_SelectionChanged;
            // 
            // labelTitle
            // 
            labelTitle.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            labelTitle.AutoSize = true;
            labelTitle.BackColor = Color.Transparent;
            labelTitle.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point);
            labelTitle.ForeColor = Color.FromArgb(76, 76, 77);
            labelTitle.Location = new Point(258, 9);
            labelTitle.Name = "labelTitle";
            labelTitle.Size = new Size(257, 32);
            labelTitle.TabIndex = 29;
            labelTitle.Text = "Seleccionar Producto";
            // 
            // labelProductsSearch
            // 
            labelProductsSearch.AutoSize = true;
            labelProductsSearch.BackColor = Color.Transparent;
            labelProductsSearch.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            labelProductsSearch.ForeColor = Color.FromArgb(76, 76, 77);
            labelProductsSearch.Location = new Point(58, 40);
            labelProductsSearch.Name = "labelProductsSearch";
            labelProductsSearch.Size = new Size(72, 25);
            labelProductsSearch.TabIndex = 33;
            labelProductsSearch.Text = "Buscar:";
            // 
            // txtBoxProductsSearch
            // 
            txtBoxProductsSearch.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            txtBoxProductsSearch.BackColor = Color.Transparent;
            txtBoxProductsSearch.BorderColor = Color.FromArgb(180, 180, 180);
            txtBoxProductsSearch.EdgeColor = Color.White;
            txtBoxProductsSearch.Font = new Font("Tahoma", 11F, FontStyle.Regular, GraphicsUnit.Point);
            txtBoxProductsSearch.ForeColor = Color.DimGray;
            txtBoxProductsSearch.Location = new Point(136, 40);
            txtBoxProductsSearch.MaxLength = 32767;
            txtBoxProductsSearch.Multiline = false;
            txtBoxProductsSearch.Name = "txtBoxProductsSearch";
            txtBoxProductsSearch.ReadOnly = false;
            txtBoxProductsSearch.Size = new Size(589, 28);
            txtBoxProductsSearch.TabIndex = 32;
            txtBoxProductsSearch.TextAlignment = HorizontalAlignment.Left;
            txtBoxProductsSearch.UseSystemPasswordChar = false;
            // 
            // ProductSelector
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 411);
            Controls.Add(labelProductsSearch);
            Controls.Add(txtBoxProductsSearch);
            Controls.Add(dataGridViewProducts);
            Controls.Add(labelTitle);
            Name = "ProductSelector";
            Text = "ProductSelector";
            Load += ProductSelector_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridViewProducts).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ReaLTaiizor.Controls.ForeverButton buttonCreateProduct;
        private ReaLTaiizor.Controls.PoisonDataGridView dataGridViewProducts;
        private ReaLTaiizor.Controls.DungeonHeaderLabel labelTitle;
        private ReaLTaiizor.Controls.DungeonLabel labelProductsSearch;
        private ReaLTaiizor.Controls.DungeonTextBox txtBoxProductsSearch;
    }
}