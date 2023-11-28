namespace WinFormsApp
{
    partial class UpdateOrderStatus
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
            buttonAsign = new ReaLTaiizor.Controls.ForeverButton();
            dungeonHeaderLabel1 = new ReaLTaiizor.Controls.DungeonHeaderLabel();
            labelClient = new ReaLTaiizor.Controls.DungeonLabel();
            dungeonLabel1 = new ReaLTaiizor.Controls.DungeonLabel();
            dungeonLabel2 = new ReaLTaiizor.Controls.DungeonLabel();
            comboBoxTransportCompanies = new ReaLTaiizor.Controls.DungeonComboBox();
            dateTimeSent = new DateTimePicker();
            dateTimeReceived = new DateTimePicker();
            SuspendLayout();
            // 
            // buttonAsign
            // 
            buttonAsign.BackColor = Color.Transparent;
            buttonAsign.BaseColor = Color.DarkGreen;
            buttonAsign.Font = new Font("Segoe UI", 13F, FontStyle.Regular, GraphicsUnit.Point);
            buttonAsign.Location = new Point(262, 245);
            buttonAsign.Name = "buttonAsign";
            buttonAsign.Rounded = true;
            buttonAsign.Size = new Size(134, 40);
            buttonAsign.TabIndex = 33;
            buttonAsign.Text = "Asignar";
            buttonAsign.TextColor = Color.FromArgb(243, 243, 243);
            buttonAsign.Click += buttonAsign_Click;
            // 
            // dungeonHeaderLabel1
            // 
            dungeonHeaderLabel1.AutoSize = true;
            dungeonHeaderLabel1.BackColor = Color.Transparent;
            dungeonHeaderLabel1.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point);
            dungeonHeaderLabel1.ForeColor = Color.FromArgb(76, 76, 77);
            dungeonHeaderLabel1.Location = new Point(235, 15);
            dungeonHeaderLabel1.Name = "dungeonHeaderLabel1";
            dungeonHeaderLabel1.Size = new Size(233, 32);
            dungeonHeaderLabel1.TabIndex = 32;
            dungeonHeaderLabel1.Text = "Asignar Transporte";
            // 
            // labelClient
            // 
            labelClient.AutoSize = true;
            labelClient.BackColor = Color.Transparent;
            labelClient.Font = new Font("Segoe UI", 13F, FontStyle.Regular, GraphicsUnit.Point);
            labelClient.ForeColor = Color.FromArgb(76, 76, 77);
            labelClient.Location = new Point(98, 81);
            labelClient.Name = "labelClient";
            labelClient.Size = new Size(99, 25);
            labelClient.TabIndex = 31;
            labelClient.Text = "Transporte:";
            // 
            // dungeonLabel1
            // 
            dungeonLabel1.AutoSize = true;
            dungeonLabel1.BackColor = Color.Transparent;
            dungeonLabel1.Font = new Font("Segoe UI", 13F, FontStyle.Regular, GraphicsUnit.Point);
            dungeonLabel1.ForeColor = Color.FromArgb(76, 76, 77);
            dungeonLabel1.Location = new Point(63, 135);
            dungeonLabel1.Name = "dungeonLabel1";
            dungeonLabel1.Size = new Size(134, 25);
            dungeonLabel1.TabIndex = 34;
            dungeonLabel1.Text = "Fecha de envio:";
            // 
            // dungeonLabel2
            // 
            dungeonLabel2.AutoSize = true;
            dungeonLabel2.BackColor = Color.Transparent;
            dungeonLabel2.Font = new Font("Segoe UI", 13F, FontStyle.Regular, GraphicsUnit.Point);
            dungeonLabel2.ForeColor = Color.FromArgb(76, 76, 77);
            dungeonLabel2.Location = new Point(30, 185);
            dungeonLabel2.Name = "dungeonLabel2";
            dungeonLabel2.Size = new Size(167, 25);
            dungeonLabel2.TabIndex = 35;
            dungeonLabel2.Text = "Fecha de recepción:";
            // 
            // comboBoxTransportCompanies
            // 
            comboBoxTransportCompanies.BackColor = Color.FromArgb(246, 246, 246);
            comboBoxTransportCompanies.ColorA = Color.FromArgb(246, 132, 85);
            comboBoxTransportCompanies.ColorB = Color.FromArgb(231, 108, 57);
            comboBoxTransportCompanies.ColorC = Color.FromArgb(242, 241, 240);
            comboBoxTransportCompanies.ColorD = Color.FromArgb(253, 252, 252);
            comboBoxTransportCompanies.ColorE = Color.FromArgb(239, 237, 236);
            comboBoxTransportCompanies.ColorF = Color.FromArgb(180, 180, 180);
            comboBoxTransportCompanies.ColorG = Color.FromArgb(119, 119, 118);
            comboBoxTransportCompanies.ColorH = Color.FromArgb(224, 222, 220);
            comboBoxTransportCompanies.ColorI = Color.FromArgb(250, 249, 249);
            comboBoxTransportCompanies.DrawMode = DrawMode.OwnerDrawFixed;
            comboBoxTransportCompanies.DropDownHeight = 100;
            comboBoxTransportCompanies.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBoxTransportCompanies.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            comboBoxTransportCompanies.ForeColor = Color.FromArgb(76, 76, 97);
            comboBoxTransportCompanies.FormattingEnabled = true;
            comboBoxTransportCompanies.HoverSelectionColor = Color.Empty;
            comboBoxTransportCompanies.IntegralHeight = false;
            comboBoxTransportCompanies.ItemHeight = 20;
            comboBoxTransportCompanies.Location = new Point(203, 82);
            comboBoxTransportCompanies.Name = "comboBoxTransportCompanies";
            comboBoxTransportCompanies.Size = new Size(357, 26);
            comboBoxTransportCompanies.StartIndex = 0;
            comboBoxTransportCompanies.TabIndex = 36;
            // 
            // dateTimeSent
            // 
            dateTimeSent.Location = new Point(203, 137);
            dateTimeSent.Name = "dateTimeSent";
            dateTimeSent.Size = new Size(357, 23);
            dateTimeSent.TabIndex = 64;
            // 
            // dateTimeReceived
            // 
            dateTimeReceived.Location = new Point(203, 187);
            dateTimeReceived.Name = "dateTimeReceived";
            dateTimeReceived.Size = new Size(357, 23);
            dateTimeReceived.TabIndex = 65;
            // 
            // UpdateOrderStatus
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(660, 313);
            Controls.Add(dateTimeReceived);
            Controls.Add(dateTimeSent);
            Controls.Add(comboBoxTransportCompanies);
            Controls.Add(dungeonLabel2);
            Controls.Add(dungeonLabel1);
            Controls.Add(buttonAsign);
            Controls.Add(dungeonHeaderLabel1);
            Controls.Add(labelClient);
            Name = "UpdateOrderStatus";
            Text = "UpdateOrderStatus";
            Load += UpdateOrderStatus_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ReaLTaiizor.Controls.ForeverButton buttonAsign;
        private ReaLTaiizor.Controls.DungeonHeaderLabel dungeonHeaderLabel1;
        private ReaLTaiizor.Controls.DungeonLabel labelClient;
        private ReaLTaiizor.Controls.DungeonLabel dungeonLabel1;
        private ReaLTaiizor.Controls.DungeonLabel dungeonLabel2;
        private ReaLTaiizor.Controls.DungeonComboBox comboBoxTransportCompanies;
        private DateTimePicker dateTimeSent;
        private DateTimePicker dateTimeReceived;
    }
}