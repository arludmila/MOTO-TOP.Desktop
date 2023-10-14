namespace WinFormsApp
{
    partial class CreateBillingTransaction
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
            buttonCreateBillTransaction = new ReaLTaiizor.Controls.ForeverButton();
            labelTitle = new ReaLTaiizor.Controls.DungeonHeaderLabel();
            labelDocType = new ReaLTaiizor.Controls.DungeonLabel();
            txtBoxDocNumber = new ReaLTaiizor.Controls.DungeonTextBox();
            labelDocNumber = new ReaLTaiizor.Controls.DungeonLabel();
            labelPaymentMethod = new ReaLTaiizor.Controls.DungeonLabel();
            dungeonLabel1 = new ReaLTaiizor.Controls.DungeonLabel();
            txtBoxPayedAmount = new ReaLTaiizor.Controls.DungeonTextBox();
            comboBoxPaymentMethod = new ReaLTaiizor.Controls.DungeonComboBox();
            txtBoxDocType = new ReaLTaiizor.Controls.DungeonTextBox();
            SuspendLayout();
            // 
            // buttonCreateBillTransaction
            // 
            buttonCreateBillTransaction.BackColor = Color.Transparent;
            buttonCreateBillTransaction.BaseColor = Color.Black;
            buttonCreateBillTransaction.Font = new Font("Segoe UI", 13F, FontStyle.Regular, GraphicsUnit.Point);
            buttonCreateBillTransaction.Location = new Point(210, 249);
            buttonCreateBillTransaction.Name = "buttonCreateBillTransaction";
            buttonCreateBillTransaction.Rounded = true;
            buttonCreateBillTransaction.Size = new Size(142, 40);
            buttonCreateBillTransaction.TabIndex = 5;
            buttonCreateBillTransaction.Text = "Registrar";
            buttonCreateBillTransaction.TextColor = Color.FromArgb(243, 243, 243);
            buttonCreateBillTransaction.Click += buttonCreateBillTransaction_Click;
            // 
            // labelTitle
            // 
            labelTitle.AutoSize = true;
            labelTitle.BackColor = Color.Transparent;
            labelTitle.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point);
            labelTitle.ForeColor = Color.FromArgb(76, 76, 77);
            labelTitle.Location = new Point(192, 9);
            labelTitle.Name = "labelTitle";
            labelTitle.Size = new Size(181, 32);
            labelTitle.TabIndex = 34;
            labelTitle.Text = "Registrar Pago";
            // 
            // labelDocType
            // 
            labelDocType.AutoSize = true;
            labelDocType.BackColor = Color.Transparent;
            labelDocType.Font = new Font("Segoe UI", 13F, FontStyle.Regular, GraphicsUnit.Point);
            labelDocType.ForeColor = Color.FromArgb(76, 76, 77);
            labelDocType.Location = new Point(42, 71);
            labelDocType.Name = "labelDocType";
            labelDocType.Size = new Size(175, 25);
            labelDocType.TabIndex = 33;
            labelDocType.Text = "Tipo de Documento:";
            // 
            // txtBoxDocNumber
            // 
            txtBoxDocNumber.BackColor = Color.Transparent;
            txtBoxDocNumber.BorderColor = Color.FromArgb(180, 180, 180);
            txtBoxDocNumber.EdgeColor = Color.White;
            txtBoxDocNumber.Font = new Font("Tahoma", 11F, FontStyle.Regular, GraphicsUnit.Point);
            txtBoxDocNumber.ForeColor = Color.DimGray;
            txtBoxDocNumber.Location = new Point(223, 113);
            txtBoxDocNumber.MaxLength = 32767;
            txtBoxDocNumber.Multiline = false;
            txtBoxDocNumber.Name = "txtBoxDocNumber";
            txtBoxDocNumber.ReadOnly = false;
            txtBoxDocNumber.Size = new Size(334, 28);
            txtBoxDocNumber.TabIndex = 2;
            txtBoxDocNumber.TextAlignment = HorizontalAlignment.Left;
            txtBoxDocNumber.UseSystemPasswordChar = false;
            // 
            // labelDocNumber
            // 
            labelDocNumber.AutoSize = true;
            labelDocNumber.BackColor = Color.Transparent;
            labelDocNumber.Font = new Font("Segoe UI", 13F, FontStyle.Regular, GraphicsUnit.Point);
            labelDocNumber.ForeColor = Color.FromArgb(76, 76, 77);
            labelDocNumber.Location = new Point(12, 113);
            labelDocNumber.Name = "labelDocNumber";
            labelDocNumber.Size = new Size(205, 25);
            labelDocNumber.TabIndex = 36;
            labelDocNumber.Text = "Número de Documento:";
            // 
            // labelPaymentMethod
            // 
            labelPaymentMethod.AutoSize = true;
            labelPaymentMethod.BackColor = Color.Transparent;
            labelPaymentMethod.Font = new Font("Segoe UI", 13F, FontStyle.Regular, GraphicsUnit.Point);
            labelPaymentMethod.ForeColor = Color.FromArgb(76, 76, 77);
            labelPaymentMethod.Location = new Point(67, 160);
            labelPaymentMethod.Name = "labelPaymentMethod";
            labelPaymentMethod.Size = new Size(150, 25);
            labelPaymentMethod.TabIndex = 37;
            labelPaymentMethod.Text = "Metodo de Pago:";
            // 
            // dungeonLabel1
            // 
            dungeonLabel1.AutoSize = true;
            dungeonLabel1.BackColor = Color.Transparent;
            dungeonLabel1.Font = new Font("Segoe UI", 13F, FontStyle.Regular, GraphicsUnit.Point);
            dungeonLabel1.ForeColor = Color.FromArgb(76, 76, 77);
            dungeonLabel1.Location = new Point(67, 204);
            dungeonLabel1.Name = "dungeonLabel1";
            dungeonLabel1.Size = new Size(150, 25);
            dungeonLabel1.TabIndex = 38;
            dungeonLabel1.Text = "Cantidad Pagada:";
            // 
            // txtBoxPayedAmount
            // 
            txtBoxPayedAmount.BackColor = Color.Transparent;
            txtBoxPayedAmount.BorderColor = Color.FromArgb(180, 180, 180);
            txtBoxPayedAmount.EdgeColor = Color.White;
            txtBoxPayedAmount.Font = new Font("Tahoma", 11F, FontStyle.Regular, GraphicsUnit.Point);
            txtBoxPayedAmount.ForeColor = Color.DimGray;
            txtBoxPayedAmount.Location = new Point(223, 204);
            txtBoxPayedAmount.MaxLength = 32767;
            txtBoxPayedAmount.Multiline = false;
            txtBoxPayedAmount.Name = "txtBoxPayedAmount";
            txtBoxPayedAmount.ReadOnly = false;
            txtBoxPayedAmount.Size = new Size(334, 28);
            txtBoxPayedAmount.TabIndex = 4;
            txtBoxPayedAmount.TextAlignment = HorizontalAlignment.Left;
            txtBoxPayedAmount.UseSystemPasswordChar = false;
            // 
            // comboBoxPaymentMethod
            // 
            comboBoxPaymentMethod.BackColor = Color.FromArgb(246, 246, 246);
            comboBoxPaymentMethod.ColorA = Color.FromArgb(246, 132, 85);
            comboBoxPaymentMethod.ColorB = Color.FromArgb(231, 108, 57);
            comboBoxPaymentMethod.ColorC = Color.FromArgb(242, 241, 240);
            comboBoxPaymentMethod.ColorD = Color.FromArgb(253, 252, 252);
            comboBoxPaymentMethod.ColorE = Color.FromArgb(239, 237, 236);
            comboBoxPaymentMethod.ColorF = Color.FromArgb(180, 180, 180);
            comboBoxPaymentMethod.ColorG = Color.FromArgb(119, 119, 118);
            comboBoxPaymentMethod.ColorH = Color.FromArgb(224, 222, 220);
            comboBoxPaymentMethod.ColorI = Color.FromArgb(250, 249, 249);
            comboBoxPaymentMethod.DrawMode = DrawMode.OwnerDrawFixed;
            comboBoxPaymentMethod.DropDownHeight = 100;
            comboBoxPaymentMethod.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBoxPaymentMethod.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            comboBoxPaymentMethod.ForeColor = Color.FromArgb(76, 76, 97);
            comboBoxPaymentMethod.FormattingEnabled = true;
            comboBoxPaymentMethod.HoverSelectionColor = Color.Empty;
            comboBoxPaymentMethod.IntegralHeight = false;
            comboBoxPaymentMethod.ItemHeight = 20;
            comboBoxPaymentMethod.Location = new Point(223, 161);
            comboBoxPaymentMethod.Name = "comboBoxPaymentMethod";
            comboBoxPaymentMethod.Size = new Size(334, 26);
            comboBoxPaymentMethod.StartIndex = 0;
            comboBoxPaymentMethod.TabIndex = 3;
            // 
            // txtBoxDocType
            // 
            txtBoxDocType.BackColor = Color.Transparent;
            txtBoxDocType.BorderColor = Color.FromArgb(180, 180, 180);
            txtBoxDocType.EdgeColor = Color.White;
            txtBoxDocType.Font = new Font("Tahoma", 11F, FontStyle.Regular, GraphicsUnit.Point);
            txtBoxDocType.ForeColor = Color.DimGray;
            txtBoxDocType.Location = new Point(223, 71);
            txtBoxDocType.MaxLength = 32767;
            txtBoxDocType.Multiline = false;
            txtBoxDocType.Name = "txtBoxDocType";
            txtBoxDocType.ReadOnly = false;
            txtBoxDocType.Size = new Size(334, 28);
            txtBoxDocType.TabIndex = 1;
            txtBoxDocType.TextAlignment = HorizontalAlignment.Left;
            txtBoxDocType.UseSystemPasswordChar = false;
            // 
            // CreateBillingTransaction
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(569, 310);
            Controls.Add(txtBoxDocType);
            Controls.Add(comboBoxPaymentMethod);
            Controls.Add(txtBoxPayedAmount);
            Controls.Add(dungeonLabel1);
            Controls.Add(labelPaymentMethod);
            Controls.Add(labelDocNumber);
            Controls.Add(buttonCreateBillTransaction);
            Controls.Add(labelTitle);
            Controls.Add(labelDocType);
            Controls.Add(txtBoxDocNumber);
            Name = "CreateBillingTransaction";
            Text = "CreateBillingTransaction";
            Load += CreateBillingTransaction_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ReaLTaiizor.Controls.ForeverButton buttonCreateBillTransaction;
        private ReaLTaiizor.Controls.DungeonHeaderLabel labelTitle;
        private ReaLTaiizor.Controls.DungeonLabel labelDocType;
        private ReaLTaiizor.Controls.DungeonTextBox txtBoxDocNumber;
        private ReaLTaiizor.Controls.DungeonLabel labelDocNumber;
        private ReaLTaiizor.Controls.DungeonLabel labelPaymentMethod;
        private ReaLTaiizor.Controls.DungeonLabel dungeonLabel1;
        private ReaLTaiizor.Controls.DungeonTextBox txtBoxPayedAmount;
        private ReaLTaiizor.Controls.DungeonComboBox comboBoxPaymentMethod;
        private ReaLTaiizor.Controls.DungeonTextBox txtBoxDocType;
    }
}