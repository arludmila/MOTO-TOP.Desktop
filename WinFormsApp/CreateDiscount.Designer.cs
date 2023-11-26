namespace WinFormsApp
{
    partial class CreateDiscount
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
            labelLastName = new ReaLTaiizor.Controls.DungeonLabel();
            txtBoxPercentage = new ReaLTaiizor.Controls.DungeonTextBox();
            buttonCreateDiscount = new ReaLTaiizor.Controls.Button();
            labelCreateClient = new ReaLTaiizor.Controls.DungeonHeaderLabel();
            labelFirstName = new ReaLTaiizor.Controls.DungeonLabel();
            txtBoxDescription = new ReaLTaiizor.Controls.DungeonTextBox();
            SuspendLayout();
            // 
            // labelLastName
            // 
            labelLastName.AutoSize = true;
            labelLastName.BackColor = Color.Transparent;
            labelLastName.Font = new Font("Segoe UI", 13F, FontStyle.Regular, GraphicsUnit.Point);
            labelLastName.ForeColor = Color.FromArgb(76, 76, 77);
            labelLastName.Location = new Point(22, 116);
            labelLastName.Name = "labelLastName";
            labelLastName.Size = new Size(98, 25);
            labelLastName.TabIndex = 23;
            labelLastName.Text = "Procentaje:";
            // 
            // txtBoxPercentage
            // 
            txtBoxPercentage.BackColor = Color.Transparent;
            txtBoxPercentage.BorderColor = Color.FromArgb(180, 180, 180);
            txtBoxPercentage.EdgeColor = Color.White;
            txtBoxPercentage.Font = new Font("Tahoma", 11F, FontStyle.Regular, GraphicsUnit.Point);
            txtBoxPercentage.ForeColor = Color.DimGray;
            txtBoxPercentage.Location = new Point(126, 116);
            txtBoxPercentage.MaxLength = 32767;
            txtBoxPercentage.Multiline = false;
            txtBoxPercentage.Name = "txtBoxPercentage";
            txtBoxPercentage.ReadOnly = false;
            txtBoxPercentage.Size = new Size(296, 28);
            txtBoxPercentage.TabIndex = 19;
            txtBoxPercentage.TextAlignment = HorizontalAlignment.Left;
            txtBoxPercentage.UseSystemPasswordChar = false;
            // 
            // buttonCreateDiscount
            // 
            buttonCreateDiscount.BackColor = Color.Transparent;
            buttonCreateDiscount.BorderColor = Color.FromArgb(32, 34, 37);
            buttonCreateDiscount.EnteredBorderColor = Color.FromArgb(165, 37, 37);
            buttonCreateDiscount.EnteredColor = Color.FromArgb(32, 34, 37);
            buttonCreateDiscount.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point);
            buttonCreateDiscount.Image = null;
            buttonCreateDiscount.ImageAlign = ContentAlignment.MiddleLeft;
            buttonCreateDiscount.InactiveColor = Color.FromArgb(32, 34, 37);
            buttonCreateDiscount.Location = new Point(164, 169);
            buttonCreateDiscount.Name = "buttonCreateDiscount";
            buttonCreateDiscount.PressedBorderColor = Color.FromArgb(165, 37, 37);
            buttonCreateDiscount.PressedColor = Color.FromArgb(165, 37, 37);
            buttonCreateDiscount.Size = new Size(120, 40);
            buttonCreateDiscount.TabIndex = 20;
            buttonCreateDiscount.Text = "Agregar";
            buttonCreateDiscount.TextAlignment = StringAlignment.Center;
            buttonCreateDiscount.Click += buttonCreateDiscount_Click;
            // 
            // labelCreateClient
            // 
            labelCreateClient.AutoSize = true;
            labelCreateClient.BackColor = Color.Transparent;
            labelCreateClient.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point);
            labelCreateClient.ForeColor = Color.FromArgb(76, 76, 77);
            labelCreateClient.Location = new Point(114, 9);
            labelCreateClient.Name = "labelCreateClient";
            labelCreateClient.Size = new Size(235, 32);
            labelCreateClient.TabIndex = 22;
            labelCreateClient.Text = "Agregar Descuento";
            // 
            // labelFirstName
            // 
            labelFirstName.AutoSize = true;
            labelFirstName.BackColor = Color.Transparent;
            labelFirstName.Font = new Font("Segoe UI", 13F, FontStyle.Regular, GraphicsUnit.Point);
            labelFirstName.ForeColor = Color.FromArgb(76, 76, 77);
            labelFirstName.Location = new Point(12, 64);
            labelFirstName.Name = "labelFirstName";
            labelFirstName.Size = new Size(108, 25);
            labelFirstName.TabIndex = 21;
            labelFirstName.Text = "Descripción:";
            // 
            // txtBoxDescription
            // 
            txtBoxDescription.BackColor = Color.Transparent;
            txtBoxDescription.BorderColor = Color.FromArgb(180, 180, 180);
            txtBoxDescription.EdgeColor = Color.White;
            txtBoxDescription.Font = new Font("Tahoma", 11F, FontStyle.Regular, GraphicsUnit.Point);
            txtBoxDescription.ForeColor = Color.DimGray;
            txtBoxDescription.Location = new Point(126, 64);
            txtBoxDescription.MaxLength = 32767;
            txtBoxDescription.Multiline = false;
            txtBoxDescription.Name = "txtBoxDescription";
            txtBoxDescription.ReadOnly = false;
            txtBoxDescription.Size = new Size(296, 28);
            txtBoxDescription.TabIndex = 18;
            txtBoxDescription.TextAlignment = HorizontalAlignment.Left;
            txtBoxDescription.UseSystemPasswordChar = false;
            // 
            // CreateDiscount
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(478, 235);
            Controls.Add(labelLastName);
            Controls.Add(txtBoxPercentage);
            Controls.Add(buttonCreateDiscount);
            Controls.Add(labelCreateClient);
            Controls.Add(labelFirstName);
            Controls.Add(txtBoxDescription);
            Name = "CreateDiscount";
            Text = "CreateDiscount";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ReaLTaiizor.Controls.DungeonLabel labelLastName;
        private ReaLTaiizor.Controls.DungeonTextBox txtBoxPercentage;
        private ReaLTaiizor.Controls.Button buttonCreateDiscount;
        private ReaLTaiizor.Controls.DungeonHeaderLabel labelCreateClient;
        private ReaLTaiizor.Controls.DungeonLabel labelFirstName;
        private ReaLTaiizor.Controls.DungeonTextBox txtBoxDescription;
    }
}