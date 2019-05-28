namespace CIS741_FinalProject_LamontMacoyMelkie
{
    partial class frmOrder
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
            this.txtOrder = new System.Windows.Forms.TextBox();
            this.btnPlaceOrder = new System.Windows.Forms.Button();
            this.btnOrderClose = new System.Windows.Forms.Button();
            this.lblOrderHeader = new System.Windows.Forms.Label();
            this.txtOrderSubtotal = new System.Windows.Forms.TextBox();
            this.lblOrderSubtotal = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txtOrder
            // 
            this.txtOrder.BackColor = System.Drawing.SystemColors.Info;
            this.txtOrder.Font = new System.Drawing.Font("Monotype Corsiva", 13.875F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtOrder.Location = new System.Drawing.Point(43, 157);
            this.txtOrder.Multiline = true;
            this.txtOrder.Name = "txtOrder";
            this.txtOrder.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtOrder.Size = new System.Drawing.Size(997, 770);
            this.txtOrder.TabIndex = 0;
            // 
            // btnPlaceOrder
            // 
            this.btnPlaceOrder.BackgroundImage = global::CIS741_FinalProject_LamontMacoyMelkie.Properties.Resources.buttonBackground1;
            this.btnPlaceOrder.Font = new System.Drawing.Font("Monotype Corsiva", 16.125F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPlaceOrder.ForeColor = System.Drawing.Color.Snow;
            this.btnPlaceOrder.Location = new System.Drawing.Point(530, 957);
            this.btnPlaceOrder.Name = "btnPlaceOrder";
            this.btnPlaceOrder.Size = new System.Drawing.Size(242, 65);
            this.btnPlaceOrder.TabIndex = 10;
            this.btnPlaceOrder.Text = "Place Order";
            this.btnPlaceOrder.UseVisualStyleBackColor = true;
            this.btnPlaceOrder.Visible = false;
            this.btnPlaceOrder.Click += new System.EventHandler(this.btnPlaceOrder_Click);
            // 
            // btnOrderClose
            // 
            this.btnOrderClose.BackgroundImage = global::CIS741_FinalProject_LamontMacoyMelkie.Properties.Resources.buttonBackground;
            this.btnOrderClose.Font = new System.Drawing.Font("Monotype Corsiva", 16.125F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnOrderClose.ForeColor = System.Drawing.Color.Snow;
            this.btnOrderClose.Location = new System.Drawing.Point(798, 957);
            this.btnOrderClose.Name = "btnOrderClose";
            this.btnOrderClose.Size = new System.Drawing.Size(242, 65);
            this.btnOrderClose.TabIndex = 11;
            this.btnOrderClose.Text = "Close";
            this.btnOrderClose.UseVisualStyleBackColor = true;
            this.btnOrderClose.Click += new System.EventHandler(this.btnOrderClose_Click);
            // 
            // lblOrderHeader
            // 
            this.lblOrderHeader.AutoSize = true;
            this.lblOrderHeader.BackColor = System.Drawing.Color.Transparent;
            this.lblOrderHeader.Font = new System.Drawing.Font("Monotype Corsiva", 48F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblOrderHeader.Location = new System.Drawing.Point(392, -2);
            this.lblOrderHeader.Name = "lblOrderHeader";
            this.lblOrderHeader.Size = new System.Drawing.Size(323, 156);
            this.lblOrderHeader.TabIndex = 12;
            this.lblOrderHeader.Text = "Order";
            // 
            // txtOrderSubtotal
            // 
            this.txtOrderSubtotal.Font = new System.Drawing.Font("Monotype Corsiva", 16.125F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtOrderSubtotal.Location = new System.Drawing.Point(279, 960);
            this.txtOrderSubtotal.Name = "txtOrderSubtotal";
            this.txtOrderSubtotal.ReadOnly = true;
            this.txtOrderSubtotal.Size = new System.Drawing.Size(216, 56);
            this.txtOrderSubtotal.TabIndex = 22;
            // 
            // lblOrderSubtotal
            // 
            this.lblOrderSubtotal.AutoSize = true;
            this.lblOrderSubtotal.BackColor = System.Drawing.Color.Transparent;
            this.lblOrderSubtotal.Font = new System.Drawing.Font("Monotype Corsiva", 16.125F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblOrderSubtotal.Location = new System.Drawing.Point(48, 963);
            this.lblOrderSubtotal.Name = "lblOrderSubtotal";
            this.lblOrderSubtotal.Size = new System.Drawing.Size(184, 52);
            this.lblOrderSubtotal.TabIndex = 21;
            this.lblOrderSubtotal.Text = "Subtotal :";
            // 
            // frmOrder
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(192F, 192F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.AutoSize = true;
            this.BackgroundImage = global::CIS741_FinalProject_LamontMacoyMelkie.Properties.Resources.menuBackground2;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1106, 1080);
            this.Controls.Add(this.txtOrderSubtotal);
            this.Controls.Add(this.lblOrderSubtotal);
            this.Controls.Add(this.lblOrderHeader);
            this.Controls.Add(this.btnOrderClose);
            this.Controls.Add(this.btnPlaceOrder);
            this.Controls.Add(this.txtOrder);
            this.Name = "frmOrder";
            this.Text = "Your Order";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnOrderClose;
        private System.Windows.Forms.Label lblOrderHeader;
        public System.Windows.Forms.TextBox txtOrder;
        public System.Windows.Forms.Button btnPlaceOrder;
        public System.Windows.Forms.TextBox txtOrderSubtotal;
        private System.Windows.Forms.Label lblOrderSubtotal;
    }
}