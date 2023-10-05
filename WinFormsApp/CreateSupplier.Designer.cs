namespace WinFormsApp
{
    partial class CreateSupplier
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
            txtBoxPhoneNumber = new ReaLTaiizor.Controls.DungeonTextBox();
            labelPhoneNumber = new ReaLTaiizor.Controls.DungeonLabel();
            dungeonHeaderLabel1 = new ReaLTaiizor.Controls.DungeonHeaderLabel();
            labelName = new ReaLTaiizor.Controls.DungeonLabel();
            txtBoxName = new ReaLTaiizor.Controls.DungeonTextBox();
            buttonCreateSupplier = new ReaLTaiizor.Controls.Button();
            SuspendLayout();
            // 
            // txtBoxPhoneNumber
            // 
            txtBoxPhoneNumber.BackColor = Color.Transparent;
            txtBoxPhoneNumber.BorderColor = Color.FromArgb(180, 180, 180);
            txtBoxPhoneNumber.EdgeColor = Color.White;
            txtBoxPhoneNumber.Font = new Font("Tahoma", 11F, FontStyle.Regular, GraphicsUnit.Point);
            txtBoxPhoneNumber.ForeColor = Color.DimGray;
            txtBoxPhoneNumber.Location = new Point(202, 159);
            txtBoxPhoneNumber.MaxLength = 32767;
            txtBoxPhoneNumber.Multiline = false;
            txtBoxPhoneNumber.Name = "txtBoxPhoneNumber";
            txtBoxPhoneNumber.ReadOnly = false;
            txtBoxPhoneNumber.Size = new Size(296, 28);
            txtBoxPhoneNumber.TabIndex = 12;
            txtBoxPhoneNumber.TextAlignment = HorizontalAlignment.Left;
            txtBoxPhoneNumber.UseSystemPasswordChar = false;
            // 
            // labelPhoneNumber
            // 
            labelPhoneNumber.AutoSize = true;
            labelPhoneNumber.BackColor = Color.Transparent;
            labelPhoneNumber.Font = new Font("Segoe UI", 13F, FontStyle.Regular, GraphicsUnit.Point);
            labelPhoneNumber.ForeColor = Color.FromArgb(76, 76, 77);
            labelPhoneNumber.Location = new Point(18, 159);
            labelPhoneNumber.Name = "labelPhoneNumber";
            labelPhoneNumber.Size = new Size(178, 25);
            labelPhoneNumber.TabIndex = 11;
            labelPhoneNumber.Text = "Número de Telefono:";
            // 
            // dungeonHeaderLabel1
            // 
            dungeonHeaderLabel1.AutoSize = true;
            dungeonHeaderLabel1.BackColor = Color.Transparent;
            dungeonHeaderLabel1.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point);
            dungeonHeaderLabel1.ForeColor = Color.FromArgb(76, 76, 77);
            dungeonHeaderLabel1.Location = new Point(227, 34);
            dungeonHeaderLabel1.Name = "dungeonHeaderLabel1";
            dungeonHeaderLabel1.Size = new Size(233, 32);
            dungeonHeaderLabel1.TabIndex = 10;
            dungeonHeaderLabel1.Text = "Agregar Proveedor";
            // 
            // labelName
            // 
            labelName.AutoSize = true;
            labelName.BackColor = Color.Transparent;
            labelName.Font = new Font("Segoe UI", 13F, FontStyle.Regular, GraphicsUnit.Point);
            labelName.ForeColor = Color.FromArgb(76, 76, 77);
            labelName.Location = new Point(114, 104);
            labelName.Name = "labelName";
            labelName.Size = new Size(82, 25);
            labelName.TabIndex = 9;
            labelName.Text = "Nombre:";
            // 
            // txtBoxName
            // 
            txtBoxName.BackColor = Color.Transparent;
            txtBoxName.BorderColor = Color.FromArgb(180, 180, 180);
            txtBoxName.EdgeColor = Color.White;
            txtBoxName.Font = new Font("Tahoma", 11F, FontStyle.Regular, GraphicsUnit.Point);
            txtBoxName.ForeColor = Color.DimGray;
            txtBoxName.Location = new Point(202, 104);
            txtBoxName.MaxLength = 32767;
            txtBoxName.Multiline = false;
            txtBoxName.Name = "txtBoxName";
            txtBoxName.ReadOnly = false;
            txtBoxName.Size = new Size(296, 28);
            txtBoxName.TabIndex = 8;
            txtBoxName.TextAlignment = HorizontalAlignment.Left;
            txtBoxName.UseSystemPasswordChar = false;
            // 
            // buttonCreateSupplier
            // 
            buttonCreateSupplier.BackColor = Color.Transparent;
            buttonCreateSupplier.BorderColor = Color.FromArgb(32, 34, 37);
            buttonCreateSupplier.EnteredBorderColor = Color.FromArgb(165, 37, 37);
            buttonCreateSupplier.EnteredColor = Color.FromArgb(32, 34, 37);
            buttonCreateSupplier.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point);
            buttonCreateSupplier.Image = null;
            buttonCreateSupplier.ImageAlign = ContentAlignment.MiddleLeft;
            buttonCreateSupplier.InactiveColor = Color.FromArgb(32, 34, 37);
            buttonCreateSupplier.Location = new Point(270, 226);
            buttonCreateSupplier.Name = "buttonCreateSupplier";
            buttonCreateSupplier.PressedBorderColor = Color.FromArgb(165, 37, 37);
            buttonCreateSupplier.PressedColor = Color.FromArgb(165, 37, 37);
            buttonCreateSupplier.Size = new Size(120, 40);
            buttonCreateSupplier.TabIndex = 13;
            buttonCreateSupplier.Text = "Agregar";
            buttonCreateSupplier.TextAlignment = StringAlignment.Center;
            buttonCreateSupplier.Click += buttonCreateSupplier_Click;
            // 
            // CreateSupplier
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(631, 358);
            Controls.Add(buttonCreateSupplier);
            Controls.Add(txtBoxPhoneNumber);
            Controls.Add(labelPhoneNumber);
            Controls.Add(dungeonHeaderLabel1);
            Controls.Add(labelName);
            Controls.Add(txtBoxName);
            Name = "CreateSupplier";
            Text = "CreateSupplier";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ReaLTaiizor.Controls.DungeonTextBox txtBoxPhoneNumber;
        private ReaLTaiizor.Controls.DungeonLabel labelPhoneNumber;
        private ReaLTaiizor.Controls.DungeonHeaderLabel dungeonHeaderLabel1;
        private ReaLTaiizor.Controls.DungeonLabel labelName;
        private ReaLTaiizor.Controls.DungeonTextBox txtBoxName;
        private ReaLTaiizor.Controls.Button buttonCreateSupplier;
    }
}