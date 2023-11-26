namespace WinFormsApp
{
    partial class Login
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
            dungeonLabel4 = new ReaLTaiizor.Controls.DungeonLabel();
            txtBoxPassword = new ReaLTaiizor.Controls.DungeonTextBox();
            labelEmail = new ReaLTaiizor.Controls.DungeonLabel();
            txtBoxEmail = new ReaLTaiizor.Controls.DungeonTextBox();
            buttonLogin = new ReaLTaiizor.Controls.Button();
            dungeonHeaderLabel1 = new ReaLTaiizor.Controls.DungeonHeaderLabel();
            SuspendLayout();
            // 
            // dungeonLabel4
            // 
            dungeonLabel4.AutoSize = true;
            dungeonLabel4.BackColor = Color.Transparent;
            dungeonLabel4.Font = new Font("Segoe UI", 13F, FontStyle.Regular, GraphicsUnit.Point);
            dungeonLabel4.ForeColor = Color.FromArgb(76, 76, 77);
            dungeonLabel4.Location = new Point(20, 134);
            dungeonLabel4.Name = "dungeonLabel4";
            dungeonLabel4.Size = new Size(105, 25);
            dungeonLabel4.TabIndex = 26;
            dungeonLabel4.Text = "Contraseña:";
            // 
            // txtBoxPassword
            // 
            txtBoxPassword.BackColor = Color.Transparent;
            txtBoxPassword.BorderColor = Color.FromArgb(180, 180, 180);
            txtBoxPassword.EdgeColor = Color.White;
            txtBoxPassword.Font = new Font("Tahoma", 11F, FontStyle.Regular, GraphicsUnit.Point);
            txtBoxPassword.ForeColor = Color.DimGray;
            txtBoxPassword.Location = new Point(131, 134);
            txtBoxPassword.MaxLength = 32767;
            txtBoxPassword.Multiline = false;
            txtBoxPassword.Name = "txtBoxPassword";
            txtBoxPassword.ReadOnly = false;
            txtBoxPassword.Size = new Size(296, 28);
            txtBoxPassword.TabIndex = 2;
            txtBoxPassword.TextAlignment = HorizontalAlignment.Left;
            txtBoxPassword.UseSystemPasswordChar = false;
            // 
            // labelEmail
            // 
            labelEmail.AutoSize = true;
            labelEmail.BackColor = Color.Transparent;
            labelEmail.Font = new Font("Segoe UI", 13F, FontStyle.Regular, GraphicsUnit.Point);
            labelEmail.ForeColor = Color.FromArgb(76, 76, 77);
            labelEmail.Location = new Point(67, 85);
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
            txtBoxEmail.Location = new Point(131, 85);
            txtBoxEmail.MaxLength = 32767;
            txtBoxEmail.Multiline = false;
            txtBoxEmail.Name = "txtBoxEmail";
            txtBoxEmail.ReadOnly = false;
            txtBoxEmail.Size = new Size(296, 28);
            txtBoxEmail.TabIndex = 1;
            txtBoxEmail.TextAlignment = HorizontalAlignment.Left;
            txtBoxEmail.UseSystemPasswordChar = false;
            // 
            // buttonLogin
            // 
            buttonLogin.BackColor = Color.Transparent;
            buttonLogin.BorderColor = Color.FromArgb(32, 34, 37);
            buttonLogin.EnteredBorderColor = Color.FromArgb(165, 37, 37);
            buttonLogin.EnteredColor = Color.FromArgb(32, 34, 37);
            buttonLogin.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point);
            buttonLogin.Image = null;
            buttonLogin.ImageAlign = ContentAlignment.MiddleLeft;
            buttonLogin.InactiveColor = Color.FromArgb(32, 34, 37);
            buttonLogin.Location = new Point(208, 182);
            buttonLogin.Name = "buttonLogin";
            buttonLogin.PressedBorderColor = Color.FromArgb(165, 37, 37);
            buttonLogin.PressedColor = Color.FromArgb(165, 37, 37);
            buttonLogin.Size = new Size(120, 40);
            buttonLogin.TabIndex = 3;
            buttonLogin.Text = "Ingresar";
            buttonLogin.TextAlignment = StringAlignment.Center;
            buttonLogin.Click += buttonLogin_Click;
            // 
            // dungeonHeaderLabel1
            // 
            dungeonHeaderLabel1.AutoSize = true;
            dungeonHeaderLabel1.BackColor = Color.Transparent;
            dungeonHeaderLabel1.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point);
            dungeonHeaderLabel1.ForeColor = Color.FromArgb(76, 76, 77);
            dungeonHeaderLabel1.Location = new Point(131, 9);
            dungeonHeaderLabel1.Name = "dungeonHeaderLabel1";
            dungeonHeaderLabel1.Size = new Size(279, 32);
            dungeonHeaderLabel1.TabIndex = 21;
            dungeonHeaderLabel1.Text = "Ingresar a la aplicación";
            // 
            // Login
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(513, 271);
            Controls.Add(dungeonLabel4);
            Controls.Add(txtBoxPassword);
            Controls.Add(labelEmail);
            Controls.Add(txtBoxEmail);
            Controls.Add(buttonLogin);
            Controls.Add(dungeonHeaderLabel1);
            Name = "Login";
            Text = "Login";
            Load += Login_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ReaLTaiizor.Controls.DungeonLabel dungeonLabel4;
        private ReaLTaiizor.Controls.DungeonTextBox txtBoxPassword;
        private ReaLTaiizor.Controls.DungeonLabel labelEmail;
        private ReaLTaiizor.Controls.DungeonTextBox txtBoxEmail;
        private ReaLTaiizor.Controls.Button buttonLogin;
        private ReaLTaiizor.Controls.DungeonHeaderLabel dungeonHeaderLabel1;
    }
}