namespace CIS741_FinalProject_LamontMacoyMelkie
{
    partial class frmSplash
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
            this.components = new System.ComponentModel.Container();
            this.lblSplashRow3 = new System.Windows.Forms.Label();
            this.lblSplash1 = new System.Windows.Forms.Label();
            this.lblSplash2 = new System.Windows.Forms.Label();
            this.timerSplash = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // lblSplashRow3
            // 
            this.lblSplashRow3.AutoSize = true;
            this.lblSplashRow3.BackColor = System.Drawing.Color.Transparent;
            this.lblSplashRow3.Font = new System.Drawing.Font("Monotype Corsiva", 72F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSplashRow3.Location = new System.Drawing.Point(251, 1101);
            this.lblSplashRow3.Margin = new System.Windows.Forms.Padding(7, 0, 7, 0);
            this.lblSplashRow3.Name = "lblSplashRow3";
            this.lblSplashRow3.Size = new System.Drawing.Size(2163, 232);
            this.lblSplashRow3.TabIndex = 20;
            this.lblSplashRow3.Text = "Three M\'s Italian Restaurant!";
            // 
            // lblSplash1
            // 
            this.lblSplash1.AutoSize = true;
            this.lblSplash1.BackColor = System.Drawing.Color.Transparent;
            this.lblSplash1.Font = new System.Drawing.Font("Monotype Corsiva", 100.125F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSplash1.Location = new System.Drawing.Point(872, 572);
            this.lblSplash1.Margin = new System.Windows.Forms.Padding(7, 0, 7, 0);
            this.lblSplash1.Name = "lblSplash1";
            this.lblSplash1.Size = new System.Drawing.Size(975, 292);
            this.lblSplash1.TabIndex = 21;
            this.lblSplash1.Text = "Welcome";
            // 
            // lblSplash2
            // 
            this.lblSplash2.AutoSize = true;
            this.lblSplash2.BackColor = System.Drawing.Color.Transparent;
            this.lblSplash2.Font = new System.Drawing.Font("Monotype Corsiva", 64.875F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSplash2.Location = new System.Drawing.Point(1151, 894);
            this.lblSplash2.Margin = new System.Windows.Forms.Padding(7, 0, 7, 0);
            this.lblSplash2.Name = "lblSplash2";
            this.lblSplash2.Size = new System.Drawing.Size(445, 207);
            this.lblSplash2.TabIndex = 22;
            this.lblSplash2.Text = "to the";
            // 
            // timerSplash
            // 
            this.timerSplash.Enabled = true;
            this.timerSplash.Interval = 3000;
            this.timerSplash.Tick += new System.EventHandler(this.timerSplash_Tick);
            // 
            // frmSplash
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(192F, 192F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.BackgroundImage = global::CIS741_FinalProject_LamontMacoyMelkie.Properties.Resources.menuBackground1;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1829, 1244);
            this.ControlBox = false;
            this.Controls.Add(this.lblSplash2);
            this.Controls.Add(this.lblSplash1);
            this.Controls.Add(this.lblSplashRow3);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmSplash";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Greetings!";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frmSplash_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblSplashRow3;
        private System.Windows.Forms.Label lblSplash1;
        private System.Windows.Forms.Label lblSplash2;
        private System.Windows.Forms.Timer timerSplash;
    }
}