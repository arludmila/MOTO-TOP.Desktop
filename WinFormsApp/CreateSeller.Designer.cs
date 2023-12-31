﻿namespace WinFormsApp
{
    partial class CreateSeller
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
            dungeonHeaderLabel1 = new ReaLTaiizor.Controls.DungeonHeaderLabel();
            labelFirstName = new ReaLTaiizor.Controls.DungeonLabel();
            txtBoxFirstName = new ReaLTaiizor.Controls.DungeonTextBox();
            buttonCreateSeller = new ReaLTaiizor.Controls.Button();
            labelLastName = new ReaLTaiizor.Controls.DungeonLabel();
            txtBoxLastName = new ReaLTaiizor.Controls.DungeonTextBox();
            labelEmail = new ReaLTaiizor.Controls.DungeonLabel();
            txtBoxEmail = new ReaLTaiizor.Controls.DungeonTextBox();
            labelZone = new ReaLTaiizor.Controls.DungeonLabel();
            txtBoxZone = new ReaLTaiizor.Controls.DungeonTextBox();
            dungeonLabel4 = new ReaLTaiizor.Controls.DungeonLabel();
            txtBoxPassword = new ReaLTaiizor.Controls.DungeonTextBox();
            separator1 = new ReaLTaiizor.Controls.Separator();
            dungeonLabel1 = new ReaLTaiizor.Controls.DungeonLabel();
            txtBoxDocNumber = new ReaLTaiizor.Controls.DungeonTextBox();
            comboBoxDocType = new ReaLTaiizor.Controls.DungeonComboBox();
            labelDocType = new ReaLTaiizor.Controls.DungeonLabel();
            SuspendLayout();
            // 
            // dungeonHeaderLabel1
            // 
            dungeonHeaderLabel1.AutoSize = true;
            dungeonHeaderLabel1.BackColor = Color.Transparent;
            dungeonHeaderLabel1.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point);
            dungeonHeaderLabel1.ForeColor = Color.FromArgb(76, 76, 77);
            dungeonHeaderLabel1.Location = new Point(205, 18);
            dungeonHeaderLabel1.Name = "dungeonHeaderLabel1";
            dungeonHeaderLabel1.Size = new Size(224, 32);
            dungeonHeaderLabel1.TabIndex = 6;
            dungeonHeaderLabel1.Text = "Agregar Vendedor";
            // 
            // labelFirstName
            // 
            labelFirstName.AutoSize = true;
            labelFirstName.BackColor = Color.Transparent;
            labelFirstName.Font = new Font("Segoe UI", 13F, FontStyle.Regular, GraphicsUnit.Point);
            labelFirstName.ForeColor = Color.FromArgb(76, 76, 77);
            labelFirstName.Location = new Point(99, 86);
            labelFirstName.Name = "labelFirstName";
            labelFirstName.Size = new Size(82, 25);
            labelFirstName.TabIndex = 5;
            labelFirstName.Text = "Nombre:";
            // 
            // txtBoxFirstName
            // 
            txtBoxFirstName.BackColor = Color.Transparent;
            txtBoxFirstName.BorderColor = Color.FromArgb(180, 180, 180);
            txtBoxFirstName.EdgeColor = Color.White;
            txtBoxFirstName.Font = new Font("Tahoma", 11F, FontStyle.Regular, GraphicsUnit.Point);
            txtBoxFirstName.ForeColor = Color.DimGray;
            txtBoxFirstName.Location = new Point(187, 86);
            txtBoxFirstName.MaxLength = 32767;
            txtBoxFirstName.Multiline = false;
            txtBoxFirstName.Name = "txtBoxFirstName";
            txtBoxFirstName.ReadOnly = false;
            txtBoxFirstName.Size = new Size(296, 28);
            txtBoxFirstName.TabIndex = 4;
            txtBoxFirstName.TextAlignment = HorizontalAlignment.Left;
            txtBoxFirstName.UseSystemPasswordChar = false;
            // 
            // buttonCreateSeller
            // 
            buttonCreateSeller.BackColor = Color.Transparent;
            buttonCreateSeller.BorderColor = Color.FromArgb(32, 34, 37);
            buttonCreateSeller.EnteredBorderColor = Color.FromArgb(165, 37, 37);
            buttonCreateSeller.EnteredColor = Color.FromArgb(32, 34, 37);
            buttonCreateSeller.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point);
            buttonCreateSeller.Image = null;
            buttonCreateSeller.ImageAlign = ContentAlignment.MiddleLeft;
            buttonCreateSeller.InactiveColor = Color.FromArgb(32, 34, 37);
            buttonCreateSeller.Location = new Point(258, 404);
            buttonCreateSeller.Name = "buttonCreateSeller";
            buttonCreateSeller.PressedBorderColor = Color.FromArgb(165, 37, 37);
            buttonCreateSeller.PressedColor = Color.FromArgb(165, 37, 37);
            buttonCreateSeller.Size = new Size(120, 40);
            buttonCreateSeller.TabIndex = 12;
            buttonCreateSeller.Text = "Agregar";
            buttonCreateSeller.TextAlignment = StringAlignment.Center;
            buttonCreateSeller.Click += buttonCreateSeller_Click;
            // 
            // labelLastName
            // 
            labelLastName.AutoSize = true;
            labelLastName.BackColor = Color.Transparent;
            labelLastName.Font = new Font("Segoe UI", 13F, FontStyle.Regular, GraphicsUnit.Point);
            labelLastName.ForeColor = Color.FromArgb(76, 76, 77);
            labelLastName.Location = new Point(99, 129);
            labelLastName.Name = "labelLastName";
            labelLastName.Size = new Size(82, 25);
            labelLastName.TabIndex = 14;
            labelLastName.Text = "Apellido:";
            // 
            // txtBoxLastName
            // 
            txtBoxLastName.BackColor = Color.Transparent;
            txtBoxLastName.BorderColor = Color.FromArgb(180, 180, 180);
            txtBoxLastName.EdgeColor = Color.White;
            txtBoxLastName.Font = new Font("Tahoma", 11F, FontStyle.Regular, GraphicsUnit.Point);
            txtBoxLastName.ForeColor = Color.DimGray;
            txtBoxLastName.Location = new Point(187, 129);
            txtBoxLastName.MaxLength = 32767;
            txtBoxLastName.Multiline = false;
            txtBoxLastName.Name = "txtBoxLastName";
            txtBoxLastName.ReadOnly = false;
            txtBoxLastName.Size = new Size(296, 28);
            txtBoxLastName.TabIndex = 13;
            txtBoxLastName.TextAlignment = HorizontalAlignment.Left;
            txtBoxLastName.UseSystemPasswordChar = false;
            // 
            // labelEmail
            // 
            labelEmail.AutoSize = true;
            labelEmail.BackColor = Color.Transparent;
            labelEmail.Font = new Font("Segoe UI", 13F, FontStyle.Regular, GraphicsUnit.Point);
            labelEmail.ForeColor = Color.FromArgb(76, 76, 77);
            labelEmail.Location = new Point(123, 313);
            labelEmail.Name = "labelEmail";
            labelEmail.Size = new Size(58, 25);
            labelEmail.TabIndex = 16;
            labelEmail.Text = "Email:";
            // 
            // txtBoxEmail
            // 
            txtBoxEmail.BackColor = Color.Transparent;
            txtBoxEmail.BorderColor = Color.FromArgb(180, 180, 180);
            txtBoxEmail.EdgeColor = Color.White;
            txtBoxEmail.Font = new Font("Tahoma", 11F, FontStyle.Regular, GraphicsUnit.Point);
            txtBoxEmail.ForeColor = Color.DimGray;
            txtBoxEmail.Location = new Point(187, 313);
            txtBoxEmail.MaxLength = 32767;
            txtBoxEmail.Multiline = false;
            txtBoxEmail.Name = "txtBoxEmail";
            txtBoxEmail.ReadOnly = false;
            txtBoxEmail.Size = new Size(296, 28);
            txtBoxEmail.TabIndex = 15;
            txtBoxEmail.TextAlignment = HorizontalAlignment.Left;
            txtBoxEmail.UseSystemPasswordChar = false;
            // 
            // labelZone
            // 
            labelZone.AutoSize = true;
            labelZone.BackColor = Color.Transparent;
            labelZone.Font = new Font("Segoe UI", 13F, FontStyle.Regular, GraphicsUnit.Point);
            labelZone.ForeColor = Color.FromArgb(76, 76, 77);
            labelZone.Location = new Point(49, 257);
            labelZone.Name = "labelZone";
            labelZone.Size = new Size(132, 25);
            labelZone.TabIndex = 18;
            labelZone.Text = "Zona asignada:";
            // 
            // txtBoxZone
            // 
            txtBoxZone.BackColor = Color.Transparent;
            txtBoxZone.BorderColor = Color.FromArgb(180, 180, 180);
            txtBoxZone.EdgeColor = Color.White;
            txtBoxZone.Font = new Font("Tahoma", 11F, FontStyle.Regular, GraphicsUnit.Point);
            txtBoxZone.ForeColor = Color.DimGray;
            txtBoxZone.Location = new Point(187, 257);
            txtBoxZone.MaxLength = 32767;
            txtBoxZone.Multiline = false;
            txtBoxZone.Name = "txtBoxZone";
            txtBoxZone.ReadOnly = false;
            txtBoxZone.Size = new Size(296, 28);
            txtBoxZone.TabIndex = 17;
            txtBoxZone.TextAlignment = HorizontalAlignment.Left;
            txtBoxZone.UseSystemPasswordChar = false;
            // 
            // dungeonLabel4
            // 
            dungeonLabel4.AutoSize = true;
            dungeonLabel4.BackColor = Color.Transparent;
            dungeonLabel4.Font = new Font("Segoe UI", 13F, FontStyle.Regular, GraphicsUnit.Point);
            dungeonLabel4.ForeColor = Color.FromArgb(76, 76, 77);
            dungeonLabel4.Location = new Point(76, 351);
            dungeonLabel4.Name = "dungeonLabel4";
            dungeonLabel4.Size = new Size(105, 25);
            dungeonLabel4.TabIndex = 20;
            dungeonLabel4.Text = "Contraseña:";
            // 
            // txtBoxPassword
            // 
            txtBoxPassword.BackColor = Color.Transparent;
            txtBoxPassword.BorderColor = Color.FromArgb(180, 180, 180);
            txtBoxPassword.EdgeColor = Color.White;
            txtBoxPassword.Font = new Font("Tahoma", 11F, FontStyle.Regular, GraphicsUnit.Point);
            txtBoxPassword.ForeColor = Color.DimGray;
            txtBoxPassword.Location = new Point(187, 351);
            txtBoxPassword.MaxLength = 32767;
            txtBoxPassword.Multiline = false;
            txtBoxPassword.Name = "txtBoxPassword";
            txtBoxPassword.ReadOnly = false;
            txtBoxPassword.Size = new Size(296, 28);
            txtBoxPassword.TabIndex = 19;
            txtBoxPassword.TextAlignment = HorizontalAlignment.Left;
            txtBoxPassword.UseSystemPasswordChar = false;
            // 
            // separator1
            // 
            separator1.LineColor = Color.Gray;
            separator1.Location = new Point(-31, 291);
            separator1.Name = "separator1";
            separator1.Size = new Size(730, 10);
            separator1.TabIndex = 21;
            separator1.Text = "separator1";
            // 
            // dungeonLabel1
            // 
            dungeonLabel1.AutoSize = true;
            dungeonLabel1.BackColor = Color.Transparent;
            dungeonLabel1.Font = new Font("Segoe UI", 13F, FontStyle.Regular, GraphicsUnit.Point);
            dungeonLabel1.ForeColor = Color.FromArgb(76, 76, 77);
            dungeonLabel1.Location = new Point(21, 213);
            dungeonLabel1.Name = "dungeonLabel1";
            dungeonLabel1.Size = new Size(160, 25);
            dungeonLabel1.TabIndex = 23;
            dungeonLabel1.Text = "N° de Documento:";
            // 
            // txtBoxDocNumber
            // 
            txtBoxDocNumber.BackColor = Color.Transparent;
            txtBoxDocNumber.BorderColor = Color.FromArgb(180, 180, 180);
            txtBoxDocNumber.EdgeColor = Color.White;
            txtBoxDocNumber.Font = new Font("Tahoma", 11F, FontStyle.Regular, GraphicsUnit.Point);
            txtBoxDocNumber.ForeColor = Color.DimGray;
            txtBoxDocNumber.Location = new Point(187, 213);
            txtBoxDocNumber.MaxLength = 32767;
            txtBoxDocNumber.Multiline = false;
            txtBoxDocNumber.Name = "txtBoxDocNumber";
            txtBoxDocNumber.ReadOnly = false;
            txtBoxDocNumber.Size = new Size(296, 28);
            txtBoxDocNumber.TabIndex = 22;
            txtBoxDocNumber.TextAlignment = HorizontalAlignment.Left;
            txtBoxDocNumber.UseSystemPasswordChar = false;
            // 
            // comboBoxDocType
            // 
            comboBoxDocType.BackColor = Color.FromArgb(246, 246, 246);
            comboBoxDocType.ColorA = Color.FromArgb(246, 132, 85);
            comboBoxDocType.ColorB = Color.FromArgb(231, 108, 57);
            comboBoxDocType.ColorC = Color.FromArgb(242, 241, 240);
            comboBoxDocType.ColorD = Color.FromArgb(253, 252, 252);
            comboBoxDocType.ColorE = Color.FromArgb(239, 237, 236);
            comboBoxDocType.ColorF = Color.FromArgb(180, 180, 180);
            comboBoxDocType.ColorG = Color.FromArgb(119, 119, 118);
            comboBoxDocType.ColorH = Color.FromArgb(224, 222, 220);
            comboBoxDocType.ColorI = Color.FromArgb(250, 249, 249);
            comboBoxDocType.DrawMode = DrawMode.OwnerDrawFixed;
            comboBoxDocType.DropDownHeight = 100;
            comboBoxDocType.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBoxDocType.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            comboBoxDocType.ForeColor = Color.FromArgb(76, 76, 97);
            comboBoxDocType.FormattingEnabled = true;
            comboBoxDocType.HoverSelectionColor = Color.Empty;
            comboBoxDocType.IntegralHeight = false;
            comboBoxDocType.ItemHeight = 20;
            comboBoxDocType.Location = new Point(187, 172);
            comboBoxDocType.Name = "comboBoxDocType";
            comboBoxDocType.Size = new Size(296, 26);
            comboBoxDocType.StartIndex = 0;
            comboBoxDocType.TabIndex = 29;
            // 
            // labelDocType
            // 
            labelDocType.AutoSize = true;
            labelDocType.BackColor = Color.Transparent;
            labelDocType.Font = new Font("Segoe UI", 13F, FontStyle.Regular, GraphicsUnit.Point);
            labelDocType.ForeColor = Color.FromArgb(76, 76, 77);
            labelDocType.Location = new Point(6, 171);
            labelDocType.Name = "labelDocType";
            labelDocType.Size = new Size(175, 25);
            labelDocType.TabIndex = 28;
            labelDocType.Text = "Tipo de Documento:";
            // 
            // CreateSeller
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(606, 487);
            Controls.Add(comboBoxDocType);
            Controls.Add(labelDocType);
            Controls.Add(dungeonLabel1);
            Controls.Add(txtBoxDocNumber);
            Controls.Add(separator1);
            Controls.Add(dungeonLabel4);
            Controls.Add(txtBoxPassword);
            Controls.Add(labelZone);
            Controls.Add(txtBoxZone);
            Controls.Add(labelEmail);
            Controls.Add(txtBoxEmail);
            Controls.Add(labelLastName);
            Controls.Add(txtBoxLastName);
            Controls.Add(buttonCreateSeller);
            Controls.Add(dungeonHeaderLabel1);
            Controls.Add(labelFirstName);
            Controls.Add(txtBoxFirstName);
            Name = "CreateSeller";
            Text = "CreateSeller";
            Load += CreateSeller_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ReaLTaiizor.Controls.DungeonHeaderLabel dungeonHeaderLabel1;
        private ReaLTaiizor.Controls.DungeonLabel labelFirstName;
        private ReaLTaiizor.Controls.DungeonTextBox txtBoxFirstName;
        private ReaLTaiizor.Controls.Button buttonCreateSeller;
        private ReaLTaiizor.Controls.DungeonLabel labelLastName;
        private ReaLTaiizor.Controls.DungeonTextBox txtBoxLastName;
        private ReaLTaiizor.Controls.DungeonLabel labelEmail;
        private ReaLTaiizor.Controls.DungeonTextBox txtBoxEmail;
        private ReaLTaiizor.Controls.DungeonLabel labelZone;
        private ReaLTaiizor.Controls.DungeonTextBox txtBoxZone;
        private ReaLTaiizor.Controls.DungeonLabel dungeonLabel4;
        private ReaLTaiizor.Controls.DungeonTextBox txtBoxPassword;
        private ReaLTaiizor.Controls.Separator separator1;
        private ReaLTaiizor.Controls.DungeonLabel dungeonLabel1;
        private ReaLTaiizor.Controls.DungeonTextBox txtBoxDocNumber;
        private ReaLTaiizor.Controls.DungeonComboBox comboBoxDocType;
        private ReaLTaiizor.Controls.DungeonLabel labelDocType;
    }
}