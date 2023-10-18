namespace WinFormsApp
{
    partial class CreateOfficeWorker
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
            comboBoxDocType = new ReaLTaiizor.Controls.DungeonComboBox();
            labelDocType = new ReaLTaiizor.Controls.DungeonLabel();
            dungeonLabel1 = new ReaLTaiizor.Controls.DungeonLabel();
            txtBoxDocNumber = new ReaLTaiizor.Controls.DungeonTextBox();
            separator1 = new ReaLTaiizor.Controls.Separator();
            dungeonLabel4 = new ReaLTaiizor.Controls.DungeonLabel();
            txtBoxPassword = new ReaLTaiizor.Controls.DungeonTextBox();
            labelEmail = new ReaLTaiizor.Controls.DungeonLabel();
            txtBoxEmail = new ReaLTaiizor.Controls.DungeonTextBox();
            labelLastName = new ReaLTaiizor.Controls.DungeonLabel();
            txtBoxLastName = new ReaLTaiizor.Controls.DungeonTextBox();
            buttonCreateOfficeWorker = new ReaLTaiizor.Controls.Button();
            dungeonHeaderLabel1 = new ReaLTaiizor.Controls.DungeonHeaderLabel();
            labelFirstName = new ReaLTaiizor.Controls.DungeonLabel();
            txtBoxFirstName = new ReaLTaiizor.Controls.DungeonTextBox();
            SuspendLayout();
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
            comboBoxDocType.Location = new Point(189, 176);
            comboBoxDocType.Name = "comboBoxDocType";
            comboBoxDocType.Size = new Size(296, 26);
            comboBoxDocType.StartIndex = 0;
            comboBoxDocType.TabIndex = 46;
            // 
            // labelDocType
            // 
            labelDocType.AutoSize = true;
            labelDocType.BackColor = Color.Transparent;
            labelDocType.Font = new Font("Segoe UI", 13F, FontStyle.Regular, GraphicsUnit.Point);
            labelDocType.ForeColor = Color.FromArgb(76, 76, 77);
            labelDocType.Location = new Point(8, 175);
            labelDocType.Name = "labelDocType";
            labelDocType.Size = new Size(175, 25);
            labelDocType.TabIndex = 45;
            labelDocType.Text = "Tipo de Documento:";
            // 
            // dungeonLabel1
            // 
            dungeonLabel1.AutoSize = true;
            dungeonLabel1.BackColor = Color.Transparent;
            dungeonLabel1.Font = new Font("Segoe UI", 13F, FontStyle.Regular, GraphicsUnit.Point);
            dungeonLabel1.ForeColor = Color.FromArgb(76, 76, 77);
            dungeonLabel1.Location = new Point(23, 217);
            dungeonLabel1.Name = "dungeonLabel1";
            dungeonLabel1.Size = new Size(160, 25);
            dungeonLabel1.TabIndex = 44;
            dungeonLabel1.Text = "N° de Documento:";
            // 
            // txtBoxDocNumber
            // 
            txtBoxDocNumber.BackColor = Color.Transparent;
            txtBoxDocNumber.BorderColor = Color.FromArgb(180, 180, 180);
            txtBoxDocNumber.EdgeColor = Color.White;
            txtBoxDocNumber.Font = new Font("Tahoma", 11F, FontStyle.Regular, GraphicsUnit.Point);
            txtBoxDocNumber.ForeColor = Color.DimGray;
            txtBoxDocNumber.Location = new Point(189, 217);
            txtBoxDocNumber.MaxLength = 32767;
            txtBoxDocNumber.Multiline = false;
            txtBoxDocNumber.Name = "txtBoxDocNumber";
            txtBoxDocNumber.ReadOnly = false;
            txtBoxDocNumber.Size = new Size(296, 28);
            txtBoxDocNumber.TabIndex = 43;
            txtBoxDocNumber.TextAlignment = HorizontalAlignment.Left;
            txtBoxDocNumber.UseSystemPasswordChar = false;
            // 
            // separator1
            // 
            separator1.LineColor = Color.Gray;
            separator1.Location = new Point(-29, 258);
            separator1.Name = "separator1";
            separator1.Size = new Size(730, 10);
            separator1.TabIndex = 42;
            separator1.Text = "separator1";
            // 
            // dungeonLabel4
            // 
            dungeonLabel4.AutoSize = true;
            dungeonLabel4.BackColor = Color.Transparent;
            dungeonLabel4.Font = new Font("Segoe UI", 13F, FontStyle.Regular, GraphicsUnit.Point);
            dungeonLabel4.ForeColor = Color.FromArgb(76, 76, 77);
            dungeonLabel4.Location = new Point(78, 318);
            dungeonLabel4.Name = "dungeonLabel4";
            dungeonLabel4.Size = new Size(105, 25);
            dungeonLabel4.TabIndex = 41;
            dungeonLabel4.Text = "Contraseña:";
            // 
            // txtBoxPassword
            // 
            txtBoxPassword.BackColor = Color.Transparent;
            txtBoxPassword.BorderColor = Color.FromArgb(180, 180, 180);
            txtBoxPassword.EdgeColor = Color.White;
            txtBoxPassword.Font = new Font("Tahoma", 11F, FontStyle.Regular, GraphicsUnit.Point);
            txtBoxPassword.ForeColor = Color.DimGray;
            txtBoxPassword.Location = new Point(189, 318);
            txtBoxPassword.MaxLength = 32767;
            txtBoxPassword.Multiline = false;
            txtBoxPassword.Name = "txtBoxPassword";
            txtBoxPassword.ReadOnly = false;
            txtBoxPassword.Size = new Size(296, 28);
            txtBoxPassword.TabIndex = 40;
            txtBoxPassword.TextAlignment = HorizontalAlignment.Left;
            txtBoxPassword.UseSystemPasswordChar = false;
            // 
            // labelEmail
            // 
            labelEmail.AutoSize = true;
            labelEmail.BackColor = Color.Transparent;
            labelEmail.Font = new Font("Segoe UI", 13F, FontStyle.Regular, GraphicsUnit.Point);
            labelEmail.ForeColor = Color.FromArgb(76, 76, 77);
            labelEmail.Location = new Point(125, 280);
            labelEmail.Name = "labelEmail";
            labelEmail.Size = new Size(58, 25);
            labelEmail.TabIndex = 37;
            labelEmail.Text = "Email:";
            // 
            // txtBoxEmail
            // 
            txtBoxEmail.BackColor = Color.Transparent;
            txtBoxEmail.BorderColor = Color.FromArgb(180, 180, 180);
            txtBoxEmail.EdgeColor = Color.White;
            txtBoxEmail.Font = new Font("Tahoma", 11F, FontStyle.Regular, GraphicsUnit.Point);
            txtBoxEmail.ForeColor = Color.DimGray;
            txtBoxEmail.Location = new Point(189, 280);
            txtBoxEmail.MaxLength = 32767;
            txtBoxEmail.Multiline = false;
            txtBoxEmail.Name = "txtBoxEmail";
            txtBoxEmail.ReadOnly = false;
            txtBoxEmail.Size = new Size(296, 28);
            txtBoxEmail.TabIndex = 36;
            txtBoxEmail.TextAlignment = HorizontalAlignment.Left;
            txtBoxEmail.UseSystemPasswordChar = false;
            // 
            // labelLastName
            // 
            labelLastName.AutoSize = true;
            labelLastName.BackColor = Color.Transparent;
            labelLastName.Font = new Font("Segoe UI", 13F, FontStyle.Regular, GraphicsUnit.Point);
            labelLastName.ForeColor = Color.FromArgb(76, 76, 77);
            labelLastName.Location = new Point(101, 133);
            labelLastName.Name = "labelLastName";
            labelLastName.Size = new Size(82, 25);
            labelLastName.TabIndex = 35;
            labelLastName.Text = "Apellido:";
            // 
            // txtBoxLastName
            // 
            txtBoxLastName.BackColor = Color.Transparent;
            txtBoxLastName.BorderColor = Color.FromArgb(180, 180, 180);
            txtBoxLastName.EdgeColor = Color.White;
            txtBoxLastName.Font = new Font("Tahoma", 11F, FontStyle.Regular, GraphicsUnit.Point);
            txtBoxLastName.ForeColor = Color.DimGray;
            txtBoxLastName.Location = new Point(189, 133);
            txtBoxLastName.MaxLength = 32767;
            txtBoxLastName.Multiline = false;
            txtBoxLastName.Name = "txtBoxLastName";
            txtBoxLastName.ReadOnly = false;
            txtBoxLastName.Size = new Size(296, 28);
            txtBoxLastName.TabIndex = 34;
            txtBoxLastName.TextAlignment = HorizontalAlignment.Left;
            txtBoxLastName.UseSystemPasswordChar = false;
            // 
            // buttonCreateOfficeWorker
            // 
            buttonCreateOfficeWorker.BackColor = Color.Transparent;
            buttonCreateOfficeWorker.BorderColor = Color.FromArgb(32, 34, 37);
            buttonCreateOfficeWorker.EnteredBorderColor = Color.FromArgb(165, 37, 37);
            buttonCreateOfficeWorker.EnteredColor = Color.FromArgb(32, 34, 37);
            buttonCreateOfficeWorker.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point);
            buttonCreateOfficeWorker.Image = null;
            buttonCreateOfficeWorker.ImageAlign = ContentAlignment.MiddleLeft;
            buttonCreateOfficeWorker.InactiveColor = Color.FromArgb(32, 34, 37);
            buttonCreateOfficeWorker.Location = new Point(260, 371);
            buttonCreateOfficeWorker.Name = "buttonCreateOfficeWorker";
            buttonCreateOfficeWorker.PressedBorderColor = Color.FromArgb(165, 37, 37);
            buttonCreateOfficeWorker.PressedColor = Color.FromArgb(165, 37, 37);
            buttonCreateOfficeWorker.Size = new Size(120, 40);
            buttonCreateOfficeWorker.TabIndex = 33;
            buttonCreateOfficeWorker.Text = "Agregar";
            buttonCreateOfficeWorker.TextAlignment = StringAlignment.Center;
            buttonCreateOfficeWorker.Click += buttonCreateOfficeWorker_Click;
            // 
            // dungeonHeaderLabel1
            // 
            dungeonHeaderLabel1.AutoSize = true;
            dungeonHeaderLabel1.BackColor = Color.Transparent;
            dungeonHeaderLabel1.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point);
            dungeonHeaderLabel1.ForeColor = Color.FromArgb(76, 76, 77);
            dungeonHeaderLabel1.Location = new Point(154, 21);
            dungeonHeaderLabel1.Name = "dungeonHeaderLabel1";
            dungeonHeaderLabel1.Size = new Size(316, 32);
            dungeonHeaderLabel1.TabIndex = 32;
            dungeonHeaderLabel1.Text = "Agregar Empleado Central";
            // 
            // labelFirstName
            // 
            labelFirstName.AutoSize = true;
            labelFirstName.BackColor = Color.Transparent;
            labelFirstName.Font = new Font("Segoe UI", 13F, FontStyle.Regular, GraphicsUnit.Point);
            labelFirstName.ForeColor = Color.FromArgb(76, 76, 77);
            labelFirstName.Location = new Point(101, 90);
            labelFirstName.Name = "labelFirstName";
            labelFirstName.Size = new Size(82, 25);
            labelFirstName.TabIndex = 31;
            labelFirstName.Text = "Nombre:";
            // 
            // txtBoxFirstName
            // 
            txtBoxFirstName.BackColor = Color.Transparent;
            txtBoxFirstName.BorderColor = Color.FromArgb(180, 180, 180);
            txtBoxFirstName.EdgeColor = Color.White;
            txtBoxFirstName.Font = new Font("Tahoma", 11F, FontStyle.Regular, GraphicsUnit.Point);
            txtBoxFirstName.ForeColor = Color.DimGray;
            txtBoxFirstName.Location = new Point(189, 90);
            txtBoxFirstName.MaxLength = 32767;
            txtBoxFirstName.Multiline = false;
            txtBoxFirstName.Name = "txtBoxFirstName";
            txtBoxFirstName.ReadOnly = false;
            txtBoxFirstName.Size = new Size(296, 28);
            txtBoxFirstName.TabIndex = 30;
            txtBoxFirstName.TextAlignment = HorizontalAlignment.Left;
            txtBoxFirstName.UseSystemPasswordChar = false;
            // 
            // CreateOfficeWorker
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(567, 470);
            Controls.Add(comboBoxDocType);
            Controls.Add(labelDocType);
            Controls.Add(dungeonLabel1);
            Controls.Add(txtBoxDocNumber);
            Controls.Add(separator1);
            Controls.Add(dungeonLabel4);
            Controls.Add(txtBoxPassword);
            Controls.Add(labelEmail);
            Controls.Add(txtBoxEmail);
            Controls.Add(labelLastName);
            Controls.Add(txtBoxLastName);
            Controls.Add(buttonCreateOfficeWorker);
            Controls.Add(dungeonHeaderLabel1);
            Controls.Add(labelFirstName);
            Controls.Add(txtBoxFirstName);
            Name = "CreateOfficeWorker";
            Text = "CreateOfficeWorker";
            Load += CreateOfficeWorker_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ReaLTaiizor.Controls.DungeonComboBox comboBoxDocType;
        private ReaLTaiizor.Controls.DungeonLabel labelDocType;
        private ReaLTaiizor.Controls.DungeonLabel dungeonLabel1;
        private ReaLTaiizor.Controls.DungeonTextBox txtBoxDocNumber;
        private ReaLTaiizor.Controls.Separator separator1;
        private ReaLTaiizor.Controls.DungeonLabel dungeonLabel4;
        private ReaLTaiizor.Controls.DungeonTextBox txtBoxPassword;
        private ReaLTaiizor.Controls.DungeonLabel labelEmail;
        private ReaLTaiizor.Controls.DungeonTextBox txtBoxEmail;
        private ReaLTaiizor.Controls.DungeonLabel labelLastName;
        private ReaLTaiizor.Controls.DungeonTextBox txtBoxLastName;
        private ReaLTaiizor.Controls.Button buttonCreateOfficeWorker;
        private ReaLTaiizor.Controls.DungeonHeaderLabel dungeonHeaderLabel1;
        private ReaLTaiizor.Controls.DungeonLabel labelFirstName;
        private ReaLTaiizor.Controls.DungeonTextBox txtBoxFirstName;
    }
}