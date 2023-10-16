namespace WinFormsApp
{
    partial class CreateTransportCompany
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
            buttonCreateTransportCompany = new ReaLTaiizor.Controls.Button();
            labelTitle = new ReaLTaiizor.Controls.DungeonHeaderLabel();
            labelName = new ReaLTaiizor.Controls.DungeonLabel();
            txtBoxName = new ReaLTaiizor.Controls.DungeonTextBox();
            dungeonLabel1 = new ReaLTaiizor.Controls.DungeonLabel();
            txtBoxPhoneNumber = new ReaLTaiizor.Controls.DungeonTextBox();
            labelEmail = new ReaLTaiizor.Controls.DungeonLabel();
            txtBoxEmail = new ReaLTaiizor.Controls.DungeonTextBox();
            SuspendLayout();
            // 
            // buttonCreateTransportCompany
            // 
            buttonCreateTransportCompany.BackColor = Color.Transparent;
            buttonCreateTransportCompany.BorderColor = Color.FromArgb(32, 34, 37);
            buttonCreateTransportCompany.EnteredBorderColor = Color.FromArgb(165, 37, 37);
            buttonCreateTransportCompany.EnteredColor = Color.FromArgb(32, 34, 37);
            buttonCreateTransportCompany.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point);
            buttonCreateTransportCompany.Image = null;
            buttonCreateTransportCompany.ImageAlign = ContentAlignment.MiddleLeft;
            buttonCreateTransportCompany.InactiveColor = Color.FromArgb(32, 34, 37);
            buttonCreateTransportCompany.Location = new Point(174, 243);
            buttonCreateTransportCompany.Name = "buttonCreateTransportCompany";
            buttonCreateTransportCompany.PressedBorderColor = Color.FromArgb(165, 37, 37);
            buttonCreateTransportCompany.PressedColor = Color.FromArgb(165, 37, 37);
            buttonCreateTransportCompany.Size = new Size(120, 40);
            buttonCreateTransportCompany.TabIndex = 15;
            buttonCreateTransportCompany.Text = "Agregar";
            buttonCreateTransportCompany.TextAlignment = StringAlignment.Center;
            buttonCreateTransportCompany.Click += buttonCreateTransportCompany_Click;
            // 
            // labelTitle
            // 
            labelTitle.AutoSize = true;
            labelTitle.BackColor = Color.Transparent;
            labelTitle.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point);
            labelTitle.ForeColor = Color.FromArgb(76, 76, 77);
            labelTitle.Location = new Point(59, 9);
            labelTitle.Name = "labelTitle";
            labelTitle.Size = new Size(377, 32);
            labelTitle.TabIndex = 14;
            labelTitle.Text = "Agregar Empresa de Transporte";
            // 
            // labelName
            // 
            labelName.AutoSize = true;
            labelName.BackColor = Color.Transparent;
            labelName.Font = new Font("Segoe UI", 13F, FontStyle.Regular, GraphicsUnit.Point);
            labelName.ForeColor = Color.FromArgb(76, 76, 77);
            labelName.Location = new Point(38, 78);
            labelName.Name = "labelName";
            labelName.Size = new Size(82, 25);
            labelName.TabIndex = 13;
            labelName.Text = "Nombre:";
            // 
            // txtBoxName
            // 
            txtBoxName.BackColor = Color.Transparent;
            txtBoxName.BorderColor = Color.FromArgb(180, 180, 180);
            txtBoxName.EdgeColor = Color.White;
            txtBoxName.Font = new Font("Tahoma", 11F, FontStyle.Regular, GraphicsUnit.Point);
            txtBoxName.ForeColor = Color.DimGray;
            txtBoxName.Location = new Point(126, 78);
            txtBoxName.MaxLength = 32767;
            txtBoxName.Multiline = false;
            txtBoxName.Name = "txtBoxName";
            txtBoxName.ReadOnly = false;
            txtBoxName.Size = new Size(350, 28);
            txtBoxName.TabIndex = 12;
            txtBoxName.TextAlignment = HorizontalAlignment.Left;
            txtBoxName.UseSystemPasswordChar = false;
            // 
            // dungeonLabel1
            // 
            dungeonLabel1.AutoSize = true;
            dungeonLabel1.BackColor = Color.Transparent;
            dungeonLabel1.Font = new Font("Segoe UI", 13F, FontStyle.Regular, GraphicsUnit.Point);
            dungeonLabel1.ForeColor = Color.FromArgb(76, 76, 77);
            dungeonLabel1.Location = new Point(12, 135);
            dungeonLabel1.Name = "dungeonLabel1";
            dungeonLabel1.Size = new Size(108, 25);
            dungeonLabel1.TabIndex = 17;
            dungeonLabel1.Text = "N° Telefono:";
            // 
            // txtBoxPhoneNumber
            // 
            txtBoxPhoneNumber.BackColor = Color.Transparent;
            txtBoxPhoneNumber.BorderColor = Color.FromArgb(180, 180, 180);
            txtBoxPhoneNumber.EdgeColor = Color.White;
            txtBoxPhoneNumber.Font = new Font("Tahoma", 11F, FontStyle.Regular, GraphicsUnit.Point);
            txtBoxPhoneNumber.ForeColor = Color.DimGray;
            txtBoxPhoneNumber.Location = new Point(126, 135);
            txtBoxPhoneNumber.MaxLength = 32767;
            txtBoxPhoneNumber.Multiline = false;
            txtBoxPhoneNumber.Name = "txtBoxPhoneNumber";
            txtBoxPhoneNumber.ReadOnly = false;
            txtBoxPhoneNumber.Size = new Size(350, 28);
            txtBoxPhoneNumber.TabIndex = 16;
            txtBoxPhoneNumber.TextAlignment = HorizontalAlignment.Left;
            txtBoxPhoneNumber.UseSystemPasswordChar = false;
            // 
            // labelEmail
            // 
            labelEmail.AutoSize = true;
            labelEmail.BackColor = Color.Transparent;
            labelEmail.Font = new Font("Segoe UI", 13F, FontStyle.Regular, GraphicsUnit.Point);
            labelEmail.ForeColor = Color.FromArgb(76, 76, 77);
            labelEmail.Location = new Point(62, 183);
            labelEmail.Name = "labelEmail";
            labelEmail.Size = new Size(58, 25);
            labelEmail.TabIndex = 19;
            labelEmail.Text = "Email:";
            // 
            // txtBoxEmail
            // 
            txtBoxEmail.BackColor = Color.Transparent;
            txtBoxEmail.BorderColor = Color.FromArgb(180, 180, 180);
            txtBoxEmail.EdgeColor = Color.White;
            txtBoxEmail.Font = new Font("Tahoma", 11F, FontStyle.Regular, GraphicsUnit.Point);
            txtBoxEmail.ForeColor = Color.DimGray;
            txtBoxEmail.Location = new Point(126, 183);
            txtBoxEmail.MaxLength = 32767;
            txtBoxEmail.Multiline = false;
            txtBoxEmail.Name = "txtBoxEmail";
            txtBoxEmail.ReadOnly = false;
            txtBoxEmail.Size = new Size(350, 28);
            txtBoxEmail.TabIndex = 18;
            txtBoxEmail.TextAlignment = HorizontalAlignment.Left;
            txtBoxEmail.UseSystemPasswordChar = false;
            // 
            // CreateTransportCompany
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(488, 309);
            Controls.Add(labelEmail);
            Controls.Add(txtBoxEmail);
            Controls.Add(dungeonLabel1);
            Controls.Add(txtBoxPhoneNumber);
            Controls.Add(buttonCreateTransportCompany);
            Controls.Add(labelTitle);
            Controls.Add(labelName);
            Controls.Add(txtBoxName);
            Name = "CreateTransportCompany";
            Text = "CreateTransportCompany";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ReaLTaiizor.Controls.Button buttonCreateTransportCompany;
        private ReaLTaiizor.Controls.DungeonHeaderLabel labelTitle;
        private ReaLTaiizor.Controls.DungeonLabel labelName;
        private ReaLTaiizor.Controls.DungeonTextBox txtBoxName;
        private ReaLTaiizor.Controls.DungeonLabel dungeonLabel1;
        private ReaLTaiizor.Controls.DungeonTextBox txtBoxPhoneNumber;
        private ReaLTaiizor.Controls.DungeonLabel labelEmail;
        private ReaLTaiizor.Controls.DungeonTextBox txtBoxEmail;
    }
}