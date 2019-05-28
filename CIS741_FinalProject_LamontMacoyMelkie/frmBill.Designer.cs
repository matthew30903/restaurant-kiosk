namespace CIS741_FinalProject_LamontMacoyMelkie
{
    partial class frmBill
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
            this.lblBillHeader = new System.Windows.Forms.Label();
            this.txtBill = new System.Windows.Forms.TextBox();
            this.btnBillClose = new System.Windows.Forms.Button();
            this.btnBillPay = new System.Windows.Forms.Button();
            this.radPayCash = new System.Windows.Forms.RadioButton();
            this.gbxBillRadioButton = new System.Windows.Forms.GroupBox();
            this.radPayDebit = new System.Windows.Forms.RadioButton();
            this.radPayCredit = new System.Windows.Forms.RadioButton();
            this.lblBillSubtotal = new System.Windows.Forms.Label();
            this.txtBillSubtotal = new System.Windows.Forms.TextBox();
            this.lblBillTip = new System.Windows.Forms.Label();
            this.numBoxBillTip = new System.Windows.Forms.NumericUpDown();
            this.txtBilltax = new System.Windows.Forms.TextBox();
            this.lblBillTax = new System.Windows.Forms.Label();
            this.txtBillTotal = new System.Windows.Forms.TextBox();
            this.lblBillTotal = new System.Windows.Forms.Label();
            this.txtBillGrandtotal = new System.Windows.Forms.TextBox();
            this.lblBillGrandTotal = new System.Windows.Forms.Label();
            this.txtBillCardPin = new System.Windows.Forms.TextBox();
            this.lblBillCardPin = new System.Windows.Forms.Label();
            this.lblCardNumber = new System.Windows.Forms.Label();
            this.dateCardExpirationDate = new System.Windows.Forms.DateTimePicker();
            this.lblCardExpirationDate = new System.Windows.Forms.Label();
            this.maskTxtCardNumber = new System.Windows.Forms.MaskedTextBox();
            this.gbxBillRadioButton.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numBoxBillTip)).BeginInit();
            this.SuspendLayout();
            // 
            // lblBillHeader
            // 
            this.lblBillHeader.AutoSize = true;
            this.lblBillHeader.BackColor = System.Drawing.Color.Transparent;
            this.lblBillHeader.Font = new System.Drawing.Font("Monotype Corsiva", 48F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBillHeader.Location = new System.Drawing.Point(608, 8);
            this.lblBillHeader.Name = "lblBillHeader";
            this.lblBillHeader.Size = new System.Drawing.Size(239, 156);
            this.lblBillHeader.TabIndex = 13;
            this.lblBillHeader.Text = "Bill";
            // 
            // txtBill
            // 
            this.txtBill.BackColor = System.Drawing.SystemColors.Info;
            this.txtBill.Font = new System.Drawing.Font("Monotype Corsiva", 13.875F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBill.Location = new System.Drawing.Point(30, 171);
            this.txtBill.Multiline = true;
            this.txtBill.Name = "txtBill";
            this.txtBill.ReadOnly = true;
            this.txtBill.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtBill.Size = new System.Drawing.Size(717, 736);
            this.txtBill.TabIndex = 14;
            // 
            // btnBillClose
            // 
            this.btnBillClose.BackgroundImage = global::CIS741_FinalProject_LamontMacoyMelkie.Properties.Resources.buttonBackground;
            this.btnBillClose.Font = new System.Drawing.Font("Monotype Corsiva", 16.125F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBillClose.ForeColor = System.Drawing.Color.Snow;
            this.btnBillClose.Location = new System.Drawing.Point(1006, 1091);
            this.btnBillClose.Name = "btnBillClose";
            this.btnBillClose.Size = new System.Drawing.Size(242, 65);
            this.btnBillClose.TabIndex = 16;
            this.btnBillClose.Text = "Close";
            this.btnBillClose.UseVisualStyleBackColor = true;
            this.btnBillClose.Click += new System.EventHandler(this.btnBillClose_Click);
            // 
            // btnBillPay
            // 
            this.btnBillPay.BackgroundImage = global::CIS741_FinalProject_LamontMacoyMelkie.Properties.Resources.buttonBackground;
            this.btnBillPay.Font = new System.Drawing.Font("Monotype Corsiva", 16.125F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBillPay.ForeColor = System.Drawing.Color.Snow;
            this.btnBillPay.Location = new System.Drawing.Point(733, 1091);
            this.btnBillPay.Name = "btnBillPay";
            this.btnBillPay.Size = new System.Drawing.Size(242, 65);
            this.btnBillPay.TabIndex = 15;
            this.btnBillPay.Text = "Pay";
            this.btnBillPay.UseVisualStyleBackColor = true;
            this.btnBillPay.Click += new System.EventHandler(this.btnBillPay_Click);
            // 
            // radPayCash
            // 
            this.radPayCash.AutoSize = true;
            this.radPayCash.Checked = true;
            this.radPayCash.Font = new System.Drawing.Font("Monotype Corsiva", 16.125F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radPayCash.Location = new System.Drawing.Point(54, 54);
            this.radPayCash.Name = "radPayCash";
            this.radPayCash.Size = new System.Drawing.Size(288, 56);
            this.radPayCash.TabIndex = 17;
            this.radPayCash.TabStop = true;
            this.radPayCash.Text = "Pay with Cash";
            this.radPayCash.UseVisualStyleBackColor = true;
            this.radPayCash.CheckedChanged += new System.EventHandler(this.radPayCash_CheckedChanged);
            // 
            // gbxBillRadioButton
            // 
            this.gbxBillRadioButton.BackColor = System.Drawing.Color.Transparent;
            this.gbxBillRadioButton.Controls.Add(this.radPayDebit);
            this.gbxBillRadioButton.Controls.Add(this.radPayCredit);
            this.gbxBillRadioButton.Controls.Add(this.radPayCash);
            this.gbxBillRadioButton.Font = new System.Drawing.Font("Monotype Corsiva", 13.875F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbxBillRadioButton.Location = new System.Drawing.Point(771, 511);
            this.gbxBillRadioButton.Name = "gbxBillRadioButton";
            this.gbxBillRadioButton.Size = new System.Drawing.Size(472, 255);
            this.gbxBillRadioButton.TabIndex = 18;
            this.gbxBillRadioButton.TabStop = false;
            this.gbxBillRadioButton.Text = "Pay Options:(Sorry, no checks)";
            // 
            // radPayDebit
            // 
            this.radPayDebit.AutoSize = true;
            this.radPayDebit.Font = new System.Drawing.Font("Monotype Corsiva", 16.125F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radPayDebit.Location = new System.Drawing.Point(54, 178);
            this.radPayDebit.Name = "radPayDebit";
            this.radPayDebit.Size = new System.Drawing.Size(389, 56);
            this.radPayDebit.TabIndex = 19;
            this.radPayDebit.TabStop = true;
            this.radPayDebit.Text = "Pay with Debit Card";
            this.radPayDebit.UseVisualStyleBackColor = true;
            this.radPayDebit.CheckedChanged += new System.EventHandler(this.radPayDebit_CheckedChanged);
            // 
            // radPayCredit
            // 
            this.radPayCredit.AutoSize = true;
            this.radPayCredit.Font = new System.Drawing.Font("Monotype Corsiva", 16.125F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radPayCredit.Location = new System.Drawing.Point(54, 116);
            this.radPayCredit.Name = "radPayCredit";
            this.radPayCredit.Size = new System.Drawing.Size(396, 56);
            this.radPayCredit.TabIndex = 18;
            this.radPayCredit.TabStop = true;
            this.radPayCredit.Text = "Pay with Credit Card";
            this.radPayCredit.UseVisualStyleBackColor = true;
            this.radPayCredit.CheckedChanged += new System.EventHandler(this.radPayCredit_CheckedChanged);
            // 
            // lblBillSubtotal
            // 
            this.lblBillSubtotal.AutoSize = true;
            this.lblBillSubtotal.BackColor = System.Drawing.Color.Transparent;
            this.lblBillSubtotal.Font = new System.Drawing.Font("Monotype Corsiva", 16.125F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBillSubtotal.Location = new System.Drawing.Point(791, 171);
            this.lblBillSubtotal.Name = "lblBillSubtotal";
            this.lblBillSubtotal.Size = new System.Drawing.Size(184, 52);
            this.lblBillSubtotal.TabIndex = 19;
            this.lblBillSubtotal.Text = "Subtotal :";
            // 
            // txtBillSubtotal
            // 
            this.txtBillSubtotal.Font = new System.Drawing.Font("Monotype Corsiva", 16.125F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBillSubtotal.Location = new System.Drawing.Point(1022, 168);
            this.txtBillSubtotal.Name = "txtBillSubtotal";
            this.txtBillSubtotal.ReadOnly = true;
            this.txtBillSubtotal.Size = new System.Drawing.Size(216, 56);
            this.txtBillSubtotal.TabIndex = 20;
            // 
            // lblBillTip
            // 
            this.lblBillTip.AutoSize = true;
            this.lblBillTip.BackColor = System.Drawing.Color.Transparent;
            this.lblBillTip.Font = new System.Drawing.Font("Monotype Corsiva", 16.125F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBillTip.Location = new System.Drawing.Point(876, 386);
            this.lblBillTip.Name = "lblBillTip";
            this.lblBillTip.Size = new System.Drawing.Size(99, 52);
            this.lblBillTip.TabIndex = 21;
            this.lblBillTip.Text = "Tip :";
            // 
            // numBoxBillTip
            // 
            this.numBoxBillTip.DecimalPlaces = 2;
            this.numBoxBillTip.Font = new System.Drawing.Font("Monotype Corsiva", 16.125F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numBoxBillTip.Increment = new decimal(new int[] {
            25,
            0,
            0,
            131072});
            this.numBoxBillTip.Location = new System.Drawing.Point(1022, 378);
            this.numBoxBillTip.Name = "numBoxBillTip";
            this.numBoxBillTip.Size = new System.Drawing.Size(216, 56);
            this.numBoxBillTip.TabIndex = 22;
            this.numBoxBillTip.ValueChanged += new System.EventHandler(this.numBoxBillTip_ValueChanged);
            // 
            // txtBilltax
            // 
            this.txtBilltax.Font = new System.Drawing.Font("Monotype Corsiva", 16.125F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBilltax.Location = new System.Drawing.Point(1024, 238);
            this.txtBilltax.Name = "txtBilltax";
            this.txtBilltax.ReadOnly = true;
            this.txtBilltax.Size = new System.Drawing.Size(216, 56);
            this.txtBilltax.TabIndex = 24;
            // 
            // lblBillTax
            // 
            this.lblBillTax.AutoSize = true;
            this.lblBillTax.BackColor = System.Drawing.Color.Transparent;
            this.lblBillTax.Font = new System.Drawing.Font("Monotype Corsiva", 16.125F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBillTax.Location = new System.Drawing.Point(869, 242);
            this.lblBillTax.Name = "lblBillTax";
            this.lblBillTax.Size = new System.Drawing.Size(106, 52);
            this.lblBillTax.TabIndex = 23;
            this.lblBillTax.Text = "Tax :";
            // 
            // txtBillTotal
            // 
            this.txtBillTotal.Font = new System.Drawing.Font("Monotype Corsiva", 16.125F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBillTotal.Location = new System.Drawing.Point(1022, 308);
            this.txtBillTotal.Name = "txtBillTotal";
            this.txtBillTotal.ReadOnly = true;
            this.txtBillTotal.Size = new System.Drawing.Size(216, 56);
            this.txtBillTotal.TabIndex = 26;
            // 
            // lblBillTotal
            // 
            this.lblBillTotal.AutoSize = true;
            this.lblBillTotal.BackColor = System.Drawing.Color.Transparent;
            this.lblBillTotal.Font = new System.Drawing.Font("Monotype Corsiva", 16.125F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBillTotal.Location = new System.Drawing.Point(844, 314);
            this.lblBillTotal.Name = "lblBillTotal";
            this.lblBillTotal.Size = new System.Drawing.Size(131, 52);
            this.lblBillTotal.TabIndex = 25;
            this.lblBillTotal.Text = "Total :";
            // 
            // txtBillGrandtotal
            // 
            this.txtBillGrandtotal.Font = new System.Drawing.Font("Monotype Corsiva", 16.125F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBillGrandtotal.Location = new System.Drawing.Point(1022, 446);
            this.txtBillGrandtotal.Name = "txtBillGrandtotal";
            this.txtBillGrandtotal.ReadOnly = true;
            this.txtBillGrandtotal.Size = new System.Drawing.Size(216, 56);
            this.txtBillGrandtotal.TabIndex = 28;
            // 
            // lblBillGrandTotal
            // 
            this.lblBillGrandTotal.AutoSize = true;
            this.lblBillGrandTotal.BackColor = System.Drawing.Color.Transparent;
            this.lblBillGrandTotal.Font = new System.Drawing.Font("Monotype Corsiva", 16.125F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBillGrandTotal.Location = new System.Drawing.Point(750, 452);
            this.lblBillGrandTotal.Name = "lblBillGrandTotal";
            this.lblBillGrandTotal.Size = new System.Drawing.Size(225, 52);
            this.lblBillGrandTotal.TabIndex = 27;
            this.lblBillGrandTotal.Text = "Grandtotal :";
            // 
            // txtBillCardPin
            // 
            this.txtBillCardPin.Font = new System.Drawing.Font("Monotype Corsiva", 16.125F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBillCardPin.Location = new System.Drawing.Point(812, 921);
            this.txtBillCardPin.MaxLength = 4;
            this.txtBillCardPin.Name = "txtBillCardPin";
            this.txtBillCardPin.Size = new System.Drawing.Size(396, 56);
            this.txtBillCardPin.TabIndex = 30;
            this.txtBillCardPin.Visible = false;
            // 
            // lblBillCardPin
            // 
            this.lblBillCardPin.AutoSize = true;
            this.lblBillCardPin.BackColor = System.Drawing.Color.Transparent;
            this.lblBillCardPin.Font = new System.Drawing.Font("Monotype Corsiva", 13.875F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBillCardPin.Location = new System.Drawing.Point(751, 873);
            this.lblBillCardPin.Name = "lblBillCardPin";
            this.lblBillCardPin.Size = new System.Drawing.Size(285, 45);
            this.lblBillCardPin.TabIndex = 29;
            this.lblBillCardPin.Text = "Card Pin Number :";
            this.lblBillCardPin.Visible = false;
            // 
            // lblCardNumber
            // 
            this.lblCardNumber.AutoSize = true;
            this.lblCardNumber.BackColor = System.Drawing.Color.Transparent;
            this.lblCardNumber.Font = new System.Drawing.Font("Monotype Corsiva", 13.875F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCardNumber.Location = new System.Drawing.Point(753, 748);
            this.lblCardNumber.Name = "lblCardNumber";
            this.lblCardNumber.Size = new System.Drawing.Size(227, 45);
            this.lblCardNumber.TabIndex = 31;
            this.lblCardNumber.Text = "Card Number :";
            this.lblCardNumber.Visible = false;
            // 
            // dateCardExpirationDate
            // 
            this.dateCardExpirationDate.CalendarFont = new System.Drawing.Font("Monotype Corsiva", 13.875F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateCardExpirationDate.CustomFormat = "MM / yy    ";
            this.dateCardExpirationDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.875F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateCardExpirationDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateCardExpirationDate.Location = new System.Drawing.Point(814, 1033);
            this.dateCardExpirationDate.MinDate = new System.DateTime(2019, 1, 1, 15, 56, 0, 0);
            this.dateCardExpirationDate.Name = "dateCardExpirationDate";
            this.dateCardExpirationDate.Size = new System.Drawing.Size(396, 49);
            this.dateCardExpirationDate.TabIndex = 35;
            this.dateCardExpirationDate.Value = new System.DateTime(2019, 5, 17, 15, 58, 9, 0);
            this.dateCardExpirationDate.Visible = false;
            this.dateCardExpirationDate.ValueChanged += new System.EventHandler(this.dateCardExpirationDate_ValueChanged);
            // 
            // lblCardExpirationDate
            // 
            this.lblCardExpirationDate.AutoSize = true;
            this.lblCardExpirationDate.BackColor = System.Drawing.Color.Transparent;
            this.lblCardExpirationDate.Font = new System.Drawing.Font("Monotype Corsiva", 13.875F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCardExpirationDate.Location = new System.Drawing.Point(755, 984);
            this.lblCardExpirationDate.Name = "lblCardExpirationDate";
            this.lblCardExpirationDate.Size = new System.Drawing.Size(349, 45);
            this.lblCardExpirationDate.TabIndex = 36;
            this.lblCardExpirationDate.Text = "Card Expiration Date :";
            this.lblCardExpirationDate.Visible = false;
            // 
            // maskTxtCardNumber
            // 
            this.maskTxtCardNumber.Font = new System.Drawing.Font("Monotype Corsiva", 16.125F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.maskTxtCardNumber.Location = new System.Drawing.Point(799, 802);
            this.maskTxtCardNumber.Mask = "0000-0000-0000-0000";
            this.maskTxtCardNumber.Name = "maskTxtCardNumber";
            this.maskTxtCardNumber.Size = new System.Drawing.Size(422, 56);
            this.maskTxtCardNumber.TabIndex = 32;
            this.maskTxtCardNumber.Visible = false;
            // 
            // frmBill
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(192F, 192F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.AutoSize = true;
            this.BackgroundImage = global::CIS741_FinalProject_LamontMacoyMelkie.Properties.Resources.menuBackground;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1260, 1160);
            this.Controls.Add(this.maskTxtCardNumber);
            this.Controls.Add(this.lblCardExpirationDate);
            this.Controls.Add(this.dateCardExpirationDate);
            this.Controls.Add(this.lblCardNumber);
            this.Controls.Add(this.txtBillCardPin);
            this.Controls.Add(this.lblBillCardPin);
            this.Controls.Add(this.txtBillGrandtotal);
            this.Controls.Add(this.lblBillGrandTotal);
            this.Controls.Add(this.txtBillTotal);
            this.Controls.Add(this.lblBillTotal);
            this.Controls.Add(this.txtBilltax);
            this.Controls.Add(this.lblBillTax);
            this.Controls.Add(this.numBoxBillTip);
            this.Controls.Add(this.lblBillTip);
            this.Controls.Add(this.txtBillSubtotal);
            this.Controls.Add(this.lblBillSubtotal);
            this.Controls.Add(this.gbxBillRadioButton);
            this.Controls.Add(this.btnBillClose);
            this.Controls.Add(this.btnBillPay);
            this.Controls.Add(this.txtBill);
            this.Controls.Add(this.lblBillHeader);
            this.Name = "frmBill";
            this.Text = "frmBill";
            this.Load += new System.EventHandler(this.frmBill_Load);
            this.gbxBillRadioButton.ResumeLayout(false);
            this.gbxBillRadioButton.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numBoxBillTip)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblBillHeader;
        private System.Windows.Forms.Button btnBillClose;
        private System.Windows.Forms.Button btnBillPay;
        private System.Windows.Forms.RadioButton radPayCash;
        private System.Windows.Forms.GroupBox gbxBillRadioButton;
        public System.Windows.Forms.RadioButton radPayDebit;
        public System.Windows.Forms.RadioButton radPayCredit;
        private System.Windows.Forms.Label lblBillSubtotal;
        private System.Windows.Forms.Label lblBillTip;
        private System.Windows.Forms.NumericUpDown numBoxBillTip;
        private System.Windows.Forms.Label lblBillTax;
        private System.Windows.Forms.Label lblBillTotal;
        public System.Windows.Forms.TextBox txtBillGrandtotal;
        private System.Windows.Forms.Label lblBillGrandTotal;
        public System.Windows.Forms.TextBox txtBillCardPin;
        private System.Windows.Forms.Label lblBillCardPin;
        private System.Windows.Forms.Label lblCardNumber;
        public System.Windows.Forms.TextBox txtBill;
        public System.Windows.Forms.TextBox txtBillSubtotal;
        public System.Windows.Forms.TextBox txtBilltax;
        public System.Windows.Forms.TextBox txtBillTotal;
        public System.Windows.Forms.DateTimePicker dateCardExpirationDate;
        private System.Windows.Forms.Label lblCardExpirationDate;
        public System.Windows.Forms.MaskedTextBox maskTxtCardNumber;
    }
}