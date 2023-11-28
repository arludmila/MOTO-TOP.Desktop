namespace WinFormsApp
{
    partial class ReviewVisitRequest
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
            labelEmail = new ReaLTaiizor.Controls.DungeonLabel();
            txtBoxEmail = new ReaLTaiizor.Controls.DungeonTextBox();
            labelLastName = new ReaLTaiizor.Controls.DungeonLabel();
            txtBoxLastName = new ReaLTaiizor.Controls.DungeonTextBox();
            buttonCreateSeller = new ReaLTaiizor.Controls.Button();
            dungeonHeaderLabel1 = new ReaLTaiizor.Controls.DungeonHeaderLabel();
            labelFirstName = new ReaLTaiizor.Controls.DungeonLabel();
            txtBoxFirstName = new ReaLTaiizor.Controls.DungeonTextBox();
            dungeonLabel1 = new ReaLTaiizor.Controls.DungeonLabel();
            txtBoxId = new ReaLTaiizor.Controls.DungeonTextBox();
            dungeonLabel2 = new ReaLTaiizor.Controls.DungeonLabel();
            txtBoxLocation = new ReaLTaiizor.Controls.DungeonTextBox();
            dungeonLabel3 = new ReaLTaiizor.Controls.DungeonLabel();
            txtBoxPhoneNumber = new ReaLTaiizor.Controls.DungeonTextBox();
            dungeonLabel4 = new ReaLTaiizor.Controls.DungeonLabel();
            txtBoxMessage = new ReaLTaiizor.Controls.DungeonTextBox();
            SuspendLayout();
            // 
            // labelEmail
            // 
            labelEmail.AutoSize = true;
            labelEmail.BackColor = Color.Transparent;
            labelEmail.Font = new Font("Segoe UI", 13F, FontStyle.Regular, GraphicsUnit.Point);
            labelEmail.ForeColor = Color.FromArgb(76, 76, 77);
            labelEmail.Location = new Point(127, 265);
            labelEmail.Name = "labelEmail";
            labelEmail.Size = new Size(58, 25);
            labelEmail.TabIndex = 24;
            labelEmail.Text = "Email:";
            // 
            // txtBoxEmail
            // 
            txtBoxEmail.BackColor = Color.Transparent;
            txtBoxEmail.BorderColor = Color.FromArgb(180, 180, 180);
            txtBoxEmail.EdgeColor = Color.White;
            txtBoxEmail.Font = new Font("Tahoma", 11F, FontStyle.Regular, GraphicsUnit.Point);
            txtBoxEmail.ForeColor = Color.DimGray;
            txtBoxEmail.Location = new Point(191, 265);
            txtBoxEmail.MaxLength = 32767;
            txtBoxEmail.Multiline = false;
            txtBoxEmail.Name = "txtBoxEmail";
            txtBoxEmail.ReadOnly = false;
            txtBoxEmail.Size = new Size(370, 28);
            txtBoxEmail.TabIndex = 23;
            txtBoxEmail.TextAlignment = HorizontalAlignment.Left;
            txtBoxEmail.UseSystemPasswordChar = false;
            // 
            // labelLastName
            // 
            labelLastName.AutoSize = true;
            labelLastName.BackColor = Color.Transparent;
            labelLastName.Font = new Font("Segoe UI", 13F, FontStyle.Regular, GraphicsUnit.Point);
            labelLastName.ForeColor = Color.FromArgb(76, 76, 77);
            labelLastName.Location = new Point(103, 127);
            labelLastName.Name = "labelLastName";
            labelLastName.Size = new Size(82, 25);
            labelLastName.TabIndex = 22;
            labelLastName.Text = "Apellido:";
            // 
            // txtBoxLastName
            // 
            txtBoxLastName.BackColor = Color.Transparent;
            txtBoxLastName.BorderColor = Color.FromArgb(180, 180, 180);
            txtBoxLastName.EdgeColor = Color.White;
            txtBoxLastName.Font = new Font("Tahoma", 11F, FontStyle.Regular, GraphicsUnit.Point);
            txtBoxLastName.ForeColor = Color.DimGray;
            txtBoxLastName.Location = new Point(191, 127);
            txtBoxLastName.MaxLength = 32767;
            txtBoxLastName.Multiline = false;
            txtBoxLastName.Name = "txtBoxLastName";
            txtBoxLastName.ReadOnly = false;
            txtBoxLastName.Size = new Size(370, 28);
            txtBoxLastName.TabIndex = 21;
            txtBoxLastName.TextAlignment = HorizontalAlignment.Left;
            txtBoxLastName.UseSystemPasswordChar = false;
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
            buttonCreateSeller.Location = new Point(237, 447);
            buttonCreateSeller.Name = "buttonCreateSeller";
            buttonCreateSeller.PressedBorderColor = Color.FromArgb(165, 37, 37);
            buttonCreateSeller.PressedColor = Color.FromArgb(165, 37, 37);
            buttonCreateSeller.Size = new Size(173, 40);
            buttonCreateSeller.TabIndex = 20;
            buttonCreateSeller.Text = "Solicitud Atendida";
            buttonCreateSeller.TextAlignment = StringAlignment.Center;
            buttonCreateSeller.Click += buttonCreateSeller_Click;
            // 
            // dungeonHeaderLabel1
            // 
            dungeonHeaderLabel1.AutoSize = true;
            dungeonHeaderLabel1.BackColor = Color.Transparent;
            dungeonHeaderLabel1.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point);
            dungeonHeaderLabel1.ForeColor = Color.FromArgb(76, 76, 77);
            dungeonHeaderLabel1.Location = new Point(237, 9);
            dungeonHeaderLabel1.Name = "dungeonHeaderLabel1";
            dungeonHeaderLabel1.Size = new Size(219, 32);
            dungeonHeaderLabel1.TabIndex = 19;
            dungeonHeaderLabel1.Text = "Solicitud de Visita";
            // 
            // labelFirstName
            // 
            labelFirstName.AutoSize = true;
            labelFirstName.BackColor = Color.Transparent;
            labelFirstName.Font = new Font("Segoe UI", 13F, FontStyle.Regular, GraphicsUnit.Point);
            labelFirstName.ForeColor = Color.FromArgb(76, 76, 77);
            labelFirstName.Location = new Point(103, 84);
            labelFirstName.Name = "labelFirstName";
            labelFirstName.Size = new Size(82, 25);
            labelFirstName.TabIndex = 18;
            labelFirstName.Text = "Nombre:";
            // 
            // txtBoxFirstName
            // 
            txtBoxFirstName.BackColor = Color.Transparent;
            txtBoxFirstName.BorderColor = Color.FromArgb(180, 180, 180);
            txtBoxFirstName.EdgeColor = Color.White;
            txtBoxFirstName.Font = new Font("Tahoma", 11F, FontStyle.Regular, GraphicsUnit.Point);
            txtBoxFirstName.ForeColor = Color.DimGray;
            txtBoxFirstName.Location = new Point(191, 84);
            txtBoxFirstName.MaxLength = 32767;
            txtBoxFirstName.Multiline = false;
            txtBoxFirstName.Name = "txtBoxFirstName";
            txtBoxFirstName.ReadOnly = false;
            txtBoxFirstName.Size = new Size(370, 28);
            txtBoxFirstName.TabIndex = 17;
            txtBoxFirstName.TextAlignment = HorizontalAlignment.Left;
            txtBoxFirstName.UseSystemPasswordChar = false;
            // 
            // dungeonLabel1
            // 
            dungeonLabel1.AutoSize = true;
            dungeonLabel1.BackColor = Color.Transparent;
            dungeonLabel1.Font = new Font("Segoe UI", 13F, FontStyle.Regular, GraphicsUnit.Point);
            dungeonLabel1.ForeColor = Color.FromArgb(76, 76, 77);
            dungeonLabel1.Location = new Point(153, 44);
            dungeonLabel1.Name = "dungeonLabel1";
            dungeonLabel1.Size = new Size(32, 25);
            dungeonLabel1.TabIndex = 26;
            dungeonLabel1.Text = "Id:";
            // 
            // txtBoxId
            // 
            txtBoxId.BackColor = Color.Transparent;
            txtBoxId.BorderColor = Color.FromArgb(180, 180, 180);
            txtBoxId.EdgeColor = Color.White;
            txtBoxId.Font = new Font("Tahoma", 11F, FontStyle.Regular, GraphicsUnit.Point);
            txtBoxId.ForeColor = Color.DimGray;
            txtBoxId.Location = new Point(191, 44);
            txtBoxId.MaxLength = 32767;
            txtBoxId.Multiline = false;
            txtBoxId.Name = "txtBoxId";
            txtBoxId.ReadOnly = false;
            txtBoxId.Size = new Size(370, 28);
            txtBoxId.TabIndex = 25;
            txtBoxId.TextAlignment = HorizontalAlignment.Left;
            txtBoxId.UseSystemPasswordChar = false;
            // 
            // dungeonLabel2
            // 
            dungeonLabel2.AutoSize = true;
            dungeonLabel2.BackColor = Color.Transparent;
            dungeonLabel2.Font = new Font("Segoe UI", 13F, FontStyle.Regular, GraphicsUnit.Point);
            dungeonLabel2.ForeColor = Color.FromArgb(76, 76, 77);
            dungeonLabel2.Location = new Point(92, 173);
            dungeonLabel2.Name = "dungeonLabel2";
            dungeonLabel2.Size = new Size(93, 25);
            dungeonLabel2.TabIndex = 28;
            dungeonLabel2.Text = "Ubicación:";
            // 
            // txtBoxLocation
            // 
            txtBoxLocation.BackColor = Color.Transparent;
            txtBoxLocation.BorderColor = Color.FromArgb(180, 180, 180);
            txtBoxLocation.EdgeColor = Color.White;
            txtBoxLocation.Font = new Font("Tahoma", 11F, FontStyle.Regular, GraphicsUnit.Point);
            txtBoxLocation.ForeColor = Color.DimGray;
            txtBoxLocation.ImeMode = ImeMode.NoControl;
            txtBoxLocation.Location = new Point(191, 173);
            txtBoxLocation.MaxLength = 32767;
            txtBoxLocation.Multiline = false;
            txtBoxLocation.Name = "txtBoxLocation";
            txtBoxLocation.ReadOnly = false;
            txtBoxLocation.Size = new Size(370, 28);
            txtBoxLocation.TabIndex = 27;
            txtBoxLocation.TextAlignment = HorizontalAlignment.Left;
            txtBoxLocation.UseSystemPasswordChar = false;
            // 
            // dungeonLabel3
            // 
            dungeonLabel3.AutoSize = true;
            dungeonLabel3.BackColor = Color.Transparent;
            dungeonLabel3.Font = new Font("Segoe UI", 13F, FontStyle.Regular, GraphicsUnit.Point);
            dungeonLabel3.ForeColor = Color.FromArgb(76, 76, 77);
            dungeonLabel3.Location = new Point(52, 221);
            dungeonLabel3.Name = "dungeonLabel3";
            dungeonLabel3.Size = new Size(133, 25);
            dungeonLabel3.TabIndex = 30;
            dungeonLabel3.Text = "N° de Telefono:";
            // 
            // txtBoxPhoneNumber
            // 
            txtBoxPhoneNumber.BackColor = Color.Transparent;
            txtBoxPhoneNumber.BorderColor = Color.FromArgb(180, 180, 180);
            txtBoxPhoneNumber.EdgeColor = Color.White;
            txtBoxPhoneNumber.Font = new Font("Tahoma", 11F, FontStyle.Regular, GraphicsUnit.Point);
            txtBoxPhoneNumber.ForeColor = Color.DimGray;
            txtBoxPhoneNumber.ImeMode = ImeMode.NoControl;
            txtBoxPhoneNumber.Location = new Point(191, 221);
            txtBoxPhoneNumber.MaxLength = 32767;
            txtBoxPhoneNumber.Multiline = false;
            txtBoxPhoneNumber.Name = "txtBoxPhoneNumber";
            txtBoxPhoneNumber.ReadOnly = false;
            txtBoxPhoneNumber.Size = new Size(370, 28);
            txtBoxPhoneNumber.TabIndex = 29;
            txtBoxPhoneNumber.TextAlignment = HorizontalAlignment.Left;
            txtBoxPhoneNumber.UseSystemPasswordChar = false;
            // 
            // dungeonLabel4
            // 
            dungeonLabel4.AutoSize = true;
            dungeonLabel4.BackColor = Color.Transparent;
            dungeonLabel4.Font = new Font("Segoe UI", 13F, FontStyle.Regular, GraphicsUnit.Point);
            dungeonLabel4.ForeColor = Color.FromArgb(76, 76, 77);
            dungeonLabel4.Location = new Point(104, 310);
            dungeonLabel4.Name = "dungeonLabel4";
            dungeonLabel4.Size = new Size(81, 25);
            dungeonLabel4.TabIndex = 32;
            dungeonLabel4.Text = "Mensaje:";
            // 
            // txtBoxMessage
            // 
            txtBoxMessage.BackColor = Color.Transparent;
            txtBoxMessage.BorderColor = Color.FromArgb(180, 180, 180);
            txtBoxMessage.EdgeColor = Color.White;
            txtBoxMessage.Font = new Font("Tahoma", 11F, FontStyle.Regular, GraphicsUnit.Point);
            txtBoxMessage.ForeColor = Color.DimGray;
            txtBoxMessage.Location = new Point(191, 310);
            txtBoxMessage.MaxLength = 32767;
            txtBoxMessage.Multiline = true;
            txtBoxMessage.Name = "txtBoxMessage";
            txtBoxMessage.ReadOnly = false;
            txtBoxMessage.Size = new Size(370, 131);
            txtBoxMessage.TabIndex = 31;
            txtBoxMessage.TextAlignment = HorizontalAlignment.Left;
            txtBoxMessage.UseSystemPasswordChar = false;
            // 
            // ReviewVisitRequest
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(684, 499);
            Controls.Add(dungeonLabel4);
            Controls.Add(txtBoxMessage);
            Controls.Add(dungeonLabel3);
            Controls.Add(txtBoxPhoneNumber);
            Controls.Add(dungeonLabel2);
            Controls.Add(txtBoxLocation);
            Controls.Add(dungeonLabel1);
            Controls.Add(txtBoxId);
            Controls.Add(labelEmail);
            Controls.Add(txtBoxEmail);
            Controls.Add(labelLastName);
            Controls.Add(txtBoxLastName);
            Controls.Add(buttonCreateSeller);
            Controls.Add(dungeonHeaderLabel1);
            Controls.Add(labelFirstName);
            Controls.Add(txtBoxFirstName);
            Name = "ReviewVisitRequest";
            Text = "ReviewVisitRequest";
            Load += ReviewVisitRequest_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ReaLTaiizor.Controls.DungeonLabel labelEmail;
        private ReaLTaiizor.Controls.DungeonTextBox txtBoxEmail;
        private ReaLTaiizor.Controls.DungeonLabel labelLastName;
        private ReaLTaiizor.Controls.DungeonTextBox txtBoxLastName;
        private ReaLTaiizor.Controls.Button buttonCreateSeller;
        private ReaLTaiizor.Controls.DungeonHeaderLabel dungeonHeaderLabel1;
        private ReaLTaiizor.Controls.DungeonLabel labelFirstName;
        private ReaLTaiizor.Controls.DungeonTextBox txtBoxFirstName;
        private ReaLTaiizor.Controls.DungeonLabel dungeonLabel1;
        private ReaLTaiizor.Controls.DungeonTextBox txtBoxId;
        private ReaLTaiizor.Controls.DungeonLabel dungeonLabel2;
        private ReaLTaiizor.Controls.DungeonTextBox txtBoxLocation;
        private ReaLTaiizor.Controls.DungeonLabel dungeonLabel3;
        private ReaLTaiizor.Controls.DungeonTextBox txtBoxPhoneNumber;
        private ReaLTaiizor.Controls.DungeonLabel dungeonLabel4;
        private ReaLTaiizor.Controls.DungeonTextBox txtBoxMessage;
    }
}