namespace WinFormsApp
{
    partial class SupplierSelector
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
            labelSuppliersSearch = new ReaLTaiizor.Controls.DungeonLabel();
            txtBoxSuppliersSearch = new ReaLTaiizor.Controls.DungeonTextBox();
            buttonCreateSupplier = new ReaLTaiizor.Controls.ForeverButton();
            dataGridViewSuppliers = new ReaLTaiizor.Controls.PoisonDataGridView();
            labelTitle = new ReaLTaiizor.Controls.DungeonHeaderLabel();
            ((System.ComponentModel.ISupportInitialize)dataGridViewSuppliers).BeginInit();
            SuspendLayout();
            // 
            // labelSuppliersSearch
            // 
            labelSuppliersSearch.AutoSize = true;
            labelSuppliersSearch.BackColor = Color.Transparent;
            labelSuppliersSearch.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            labelSuppliersSearch.ForeColor = Color.FromArgb(76, 76, 77);
            labelSuppliersSearch.Location = new Point(57, 42);
            labelSuppliersSearch.Name = "labelSuppliersSearch";
            labelSuppliersSearch.Size = new Size(72, 25);
            labelSuppliersSearch.TabIndex = 38;
            labelSuppliersSearch.Text = "Buscar:";
            // 
            // txtBoxSuppliersSearch
            // 
            txtBoxSuppliersSearch.BackColor = Color.Transparent;
            txtBoxSuppliersSearch.BorderColor = Color.FromArgb(180, 180, 180);
            txtBoxSuppliersSearch.EdgeColor = Color.White;
            txtBoxSuppliersSearch.Font = new Font("Tahoma", 11F, FontStyle.Regular, GraphicsUnit.Point);
            txtBoxSuppliersSearch.ForeColor = Color.DimGray;
            txtBoxSuppliersSearch.Location = new Point(135, 42);
            txtBoxSuppliersSearch.MaxLength = 32767;
            txtBoxSuppliersSearch.Multiline = false;
            txtBoxSuppliersSearch.Name = "txtBoxSuppliersSearch";
            txtBoxSuppliersSearch.ReadOnly = false;
            txtBoxSuppliersSearch.Size = new Size(589, 28);
            txtBoxSuppliersSearch.TabIndex = 37;
            txtBoxSuppliersSearch.TextAlignment = HorizontalAlignment.Left;
            txtBoxSuppliersSearch.UseSystemPasswordChar = false;
            // 
            // buttonCreateSupplier
            // 
            buttonCreateSupplier.BackColor = Color.Transparent;
            buttonCreateSupplier.BaseColor = Color.DimGray;
            buttonCreateSupplier.Font = new Font("Segoe UI", 13F, FontStyle.Regular, GraphicsUnit.Point);
            buttonCreateSupplier.Location = new Point(306, 400);
            buttonCreateSupplier.Name = "buttonCreateSupplier";
            buttonCreateSupplier.Rounded = true;
            buttonCreateSupplier.Size = new Size(160, 40);
            buttonCreateSupplier.TabIndex = 36;
            buttonCreateSupplier.Text = "Agregar Proveedor";
            buttonCreateSupplier.TextColor = Color.FromArgb(243, 243, 243);
            buttonCreateSupplier.Click += buttonCreateSupplier_Click;
            // 
            // dataGridViewSuppliers
            // 
            dataGridViewSuppliers.AllowUserToResizeRows = false;
            dataGridViewSuppliers.BackgroundColor = Color.FromArgb(255, 255, 255);
            dataGridViewSuppliers.BorderStyle = BorderStyle.None;
            dataGridViewSuppliers.CellBorderStyle = DataGridViewCellBorderStyle.None;
            dataGridViewSuppliers.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = Color.FromArgb(85, 85, 85);
            dataGridViewCellStyle1.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Pixel);
            dataGridViewCellStyle1.ForeColor = Color.FromArgb(255, 255, 255);
            dataGridViewCellStyle1.SelectionBackColor = Color.FromArgb(102, 102, 102);
            dataGridViewCellStyle1.SelectionForeColor = Color.FromArgb(17, 17, 17);
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            dataGridViewSuppliers.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dataGridViewSuppliers.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = Color.FromArgb(255, 255, 255);
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Pixel);
            dataGridViewCellStyle2.ForeColor = Color.FromArgb(136, 136, 136);
            dataGridViewCellStyle2.SelectionBackColor = Color.FromArgb(102, 102, 102);
            dataGridViewCellStyle2.SelectionForeColor = Color.FromArgb(17, 17, 17);
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.False;
            dataGridViewSuppliers.DefaultCellStyle = dataGridViewCellStyle2;
            dataGridViewSuppliers.EnableHeadersVisualStyles = false;
            dataGridViewSuppliers.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Pixel);
            dataGridViewSuppliers.GridColor = Color.FromArgb(255, 255, 255);
            dataGridViewSuppliers.Location = new Point(11, 80);
            dataGridViewSuppliers.Name = "dataGridViewSuppliers";
            dataGridViewSuppliers.RowHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = Color.FromArgb(85, 85, 85);
            dataGridViewCellStyle3.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Pixel);
            dataGridViewCellStyle3.ForeColor = Color.FromArgb(255, 255, 255);
            dataGridViewCellStyle3.SelectionBackColor = Color.FromArgb(102, 102, 102);
            dataGridViewCellStyle3.SelectionForeColor = Color.FromArgb(17, 17, 17);
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.True;
            dataGridViewSuppliers.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            dataGridViewSuppliers.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            dataGridViewSuppliers.RowTemplate.Height = 25;
            dataGridViewSuppliers.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridViewSuppliers.Size = new Size(778, 314);
            dataGridViewSuppliers.Style = ReaLTaiizor.Enum.Poison.ColorStyle.Silver;
            dataGridViewSuppliers.TabIndex = 35;
            dataGridViewSuppliers.CellContentClick += dataGridViewSuppliers_CellContentClick;
            // 
            // labelTitle
            // 
            labelTitle.AutoSize = true;
            labelTitle.BackColor = Color.Transparent;
            labelTitle.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point);
            labelTitle.ForeColor = Color.FromArgb(76, 76, 77);
            labelTitle.Location = new Point(257, 11);
            labelTitle.Name = "labelTitle";
            labelTitle.Size = new Size(270, 32);
            labelTitle.TabIndex = 34;
            labelTitle.Text = "Seleccionar Proveedor";
            // 
            // SupplierSelector
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(labelSuppliersSearch);
            Controls.Add(txtBoxSuppliersSearch);
            Controls.Add(buttonCreateSupplier);
            Controls.Add(dataGridViewSuppliers);
            Controls.Add(labelTitle);
            Name = "SupplierSelector";
            Text = "SupplierSelector";
            Load += SupplierSelector_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridViewSuppliers).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ReaLTaiizor.Controls.DungeonLabel labelSuppliersSearch;
        private ReaLTaiizor.Controls.DungeonTextBox txtBoxSuppliersSearch;
        private ReaLTaiizor.Controls.ForeverButton buttonCreateSupplier;
        private ReaLTaiizor.Controls.PoisonDataGridView dataGridViewSuppliers;
        private ReaLTaiizor.Controls.DungeonHeaderLabel labelTitle;
    }
}