namespace WinFormsApp
{
    partial class CreateClient
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
            buttonCreateClient = new ReaLTaiizor.Controls.Button();
            labelCreateClient = new ReaLTaiizor.Controls.DungeonHeaderLabel();
            labelFirstName = new ReaLTaiizor.Controls.DungeonLabel();
            txtBoxFirstName = new ReaLTaiizor.Controls.DungeonTextBox();
            labelLastName = new ReaLTaiizor.Controls.DungeonLabel();
            txtBoxLastName = new ReaLTaiizor.Controls.DungeonTextBox();
            labelLocation = new ReaLTaiizor.Controls.DungeonLabel();
            txtBoxLocation = new ReaLTaiizor.Controls.DungeonTextBox();
            labelPhoneNumber = new ReaLTaiizor.Controls.DungeonLabel();
            txtBoxPhoneNumber = new ReaLTaiizor.Controls.DungeonTextBox();
            SuspendLayout();
            // 
            // buttonCreateClient
            // 
            buttonCreateClient.BackColor = Color.Transparent;
            buttonCreateClient.BorderColor = Color.FromArgb(32, 34, 37);
            buttonCreateClient.EnteredBorderColor = Color.FromArgb(165, 37, 37);
            buttonCreateClient.EnteredColor = Color.FromArgb(32, 34, 37);
            buttonCreateClient.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point);
            buttonCreateClient.Image = null;
            buttonCreateClient.ImageAlign = ContentAlignment.MiddleLeft;
            buttonCreateClient.InactiveColor = Color.FromArgb(32, 34, 37);
            buttonCreateClient.Location = new Point(266, 290);
            buttonCreateClient.Name = "buttonCreateClient";
            buttonCreateClient.PressedBorderColor = Color.FromArgb(165, 37, 37);
            buttonCreateClient.PressedColor = Color.FromArgb(165, 37, 37);
            buttonCreateClient.Size = new Size(120, 40);
            buttonCreateClient.TabIndex = 5;
            buttonCreateClient.Text = "Agregar";
            buttonCreateClient.TextAlignment = StringAlignment.Center;
            buttonCreateClient.Click += buttonCreateClient_Click;
            // 
            // labelCreateClient
            // 
            labelCreateClient.AutoSize = true;
            labelCreateClient.BackColor = Color.Transparent;
            labelCreateClient.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point);
            labelCreateClient.ForeColor = Color.FromArgb(76, 76, 77);
            labelCreateClient.Location = new Point(237, 29);
            labelCreateClient.Name = "labelCreateClient";
            labelCreateClient.Size = new Size(193, 32);
            labelCreateClient.TabIndex = 14;
            labelCreateClient.Text = "Agregar Cliente";
            // 
            // labelFirstName
            // 
            labelFirstName.AutoSize = true;
            labelFirstName.BackColor = Color.Transparent;
            labelFirstName.Font = new Font("Segoe UI", 13F, FontStyle.Regular, GraphicsUnit.Point);
            labelFirstName.ForeColor = Color.FromArgb(76, 76, 77);
            labelFirstName.Location = new Point(106, 90);
            labelFirstName.Name = "labelFirstName";
            labelFirstName.Size = new Size(82, 25);
            labelFirstName.TabIndex = 13;
            labelFirstName.Text = "Nombre:";
            // 
            // txtBoxFirstName
            // 
            txtBoxFirstName.BackColor = Color.Transparent;
            txtBoxFirstName.BorderColor = Color.FromArgb(180, 180, 180);
            txtBoxFirstName.EdgeColor = Color.White;
            txtBoxFirstName.Font = new Font("Tahoma", 11F, FontStyle.Regular, GraphicsUnit.Point);
            txtBoxFirstName.ForeColor = Color.DimGray;
            txtBoxFirstName.Location = new Point(194, 90);
            txtBoxFirstName.MaxLength = 32767;
            txtBoxFirstName.Multiline = false;
            txtBoxFirstName.Name = "txtBoxFirstName";
            txtBoxFirstName.ReadOnly = false;
            txtBoxFirstName.Size = new Size(296, 28);
            txtBoxFirstName.TabIndex = 1;
            txtBoxFirstName.TextAlignment = HorizontalAlignment.Left;
            txtBoxFirstName.UseSystemPasswordChar = false;
            // 
            // labelLastName
            // 
            labelLastName.AutoSize = true;
            labelLastName.BackColor = Color.Transparent;
            labelLastName.Font = new Font("Segoe UI", 13F, FontStyle.Regular, GraphicsUnit.Point);
            labelLastName.ForeColor = Color.FromArgb(76, 76, 77);
            labelLastName.Location = new Point(106, 142);
            labelLastName.Name = "labelLastName";
            labelLastName.Size = new Size(82, 25);
            labelLastName.TabIndex = 17;
            labelLastName.Text = "Apellido:";
            // 
            // txtBoxLastName
            // 
            txtBoxLastName.BackColor = Color.Transparent;
            txtBoxLastName.BorderColor = Color.FromArgb(180, 180, 180);
            txtBoxLastName.EdgeColor = Color.White;
            txtBoxLastName.Font = new Font("Tahoma", 11F, FontStyle.Regular, GraphicsUnit.Point);
            txtBoxLastName.ForeColor = Color.DimGray;
            txtBoxLastName.Location = new Point(194, 142);
            txtBoxLastName.MaxLength = 32767;
            txtBoxLastName.Multiline = false;
            txtBoxLastName.Name = "txtBoxLastName";
            txtBoxLastName.ReadOnly = false;
            txtBoxLastName.Size = new Size(296, 28);
            txtBoxLastName.TabIndex = 2;
            txtBoxLastName.TextAlignment = HorizontalAlignment.Left;
            txtBoxLastName.UseSystemPasswordChar = false;
            // 
            // labelLocation
            // 
            labelLocation.AutoSize = true;
            labelLocation.BackColor = Color.Transparent;
            labelLocation.Font = new Font("Segoe UI", 13F, FontStyle.Regular, GraphicsUnit.Point);
            labelLocation.ForeColor = Color.FromArgb(76, 76, 77);
            labelLocation.Location = new Point(95, 190);
            labelLocation.Name = "labelLocation";
            labelLocation.Size = new Size(93, 25);
            labelLocation.TabIndex = 19;
            labelLocation.Text = "Ubicación:";
            // 
            // txtBoxLocation
            // 
            txtBoxLocation.BackColor = Color.Transparent;
            txtBoxLocation.BorderColor = Color.FromArgb(180, 180, 180);
            txtBoxLocation.EdgeColor = Color.White;
            txtBoxLocation.Font = new Font("Tahoma", 11F, FontStyle.Regular, GraphicsUnit.Point);
            txtBoxLocation.ForeColor = Color.DimGray;
            txtBoxLocation.Location = new Point(194, 190);
            txtBoxLocation.MaxLength = 32767;
            txtBoxLocation.Multiline = false;
            txtBoxLocation.Name = "txtBoxLocation";
            txtBoxLocation.ReadOnly = false;
            txtBoxLocation.Size = new Size(296, 28);
            txtBoxLocation.TabIndex = 3;
            txtBoxLocation.TextAlignment = HorizontalAlignment.Left;
            txtBoxLocation.UseSystemPasswordChar = false;
            // 
            // labelPhoneNumber
            // 
            labelPhoneNumber.AutoSize = true;
            labelPhoneNumber.BackColor = Color.Transparent;
            labelPhoneNumber.Font = new Font("Segoe UI", 13F, FontStyle.Regular, GraphicsUnit.Point);
            labelPhoneNumber.ForeColor = Color.FromArgb(76, 76, 77);
            labelPhoneNumber.Location = new Point(55, 236);
            labelPhoneNumber.Name = "labelPhoneNumber";
            labelPhoneNumber.Size = new Size(133, 25);
            labelPhoneNumber.TabIndex = 21;
            labelPhoneNumber.Text = "N° de Telefono:";
            // 
            // txtBoxPhoneNumber
            // 
            txtBoxPhoneNumber.BackColor = Color.Transparent;
            txtBoxPhoneNumber.BorderColor = Color.FromArgb(180, 180, 180);
            txtBoxPhoneNumber.EdgeColor = Color.White;
            txtBoxPhoneNumber.Font = new Font("Tahoma", 11F, FontStyle.Regular, GraphicsUnit.Point);
            txtBoxPhoneNumber.ForeColor = Color.DimGray;
            txtBoxPhoneNumber.Location = new Point(194, 236);
            txtBoxPhoneNumber.MaxLength = 32767;
            txtBoxPhoneNumber.Multiline = false;
            txtBoxPhoneNumber.Name = "txtBoxPhoneNumber";
            txtBoxPhoneNumber.ReadOnly = false;
            txtBoxPhoneNumber.Size = new Size(296, 28);
            txtBoxPhoneNumber.TabIndex = 4;
            txtBoxPhoneNumber.TextAlignment = HorizontalAlignment.Left;
            txtBoxPhoneNumber.UseSystemPasswordChar = false;
            // 
            // CreateClient
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(591, 370);
            Controls.Add(labelPhoneNumber);
            Controls.Add(txtBoxPhoneNumber);
            Controls.Add(labelLocation);
            Controls.Add(txtBoxLocation);
            Controls.Add(labelLastName);
            Controls.Add(txtBoxLastName);
            Controls.Add(buttonCreateClient);
            Controls.Add(labelCreateClient);
            Controls.Add(labelFirstName);
            Controls.Add(txtBoxFirstName);
            Name = "CreateClient";
            Text = "CreateClient";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ReaLTaiizor.Controls.Button buttonCreateClient;
        private ReaLTaiizor.Controls.DungeonHeaderLabel labelCreateClient;
        private ReaLTaiizor.Controls.DungeonLabel labelFirstName;
        private ReaLTaiizor.Controls.DungeonTextBox txtBoxFirstName;
        private ReaLTaiizor.Controls.DungeonLabel labelLastName;
        private ReaLTaiizor.Controls.DungeonTextBox txtBoxLastName;
        private ReaLTaiizor.Controls.DungeonLabel labelLocation;
        private ReaLTaiizor.Controls.DungeonTextBox txtBoxLocation;
        private ReaLTaiizor.Controls.DungeonLabel labelPhoneNumber;
        private ReaLTaiizor.Controls.DungeonTextBox txtBoxPhoneNumber;
    }
}