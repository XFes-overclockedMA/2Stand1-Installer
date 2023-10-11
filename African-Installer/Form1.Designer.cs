namespace African_Installer
{
    partial class InstallThemeForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(InstallThemeForm));
            this.guna2BorderlessForm1 = new Guna.UI2.WinForms.Guna2BorderlessForm(this.components);
            this.TitleLabel = new System.Windows.Forms.Label();
            this.InstallBTN = new Guna.UI2.WinForms.Guna2GradientButton();
            this.CreditLabel = new System.Windows.Forms.Label();
            this.NameThemeLabel = new System.Windows.Forms.Label();
            this.CloseBTN = new Guna.UI2.WinForms.Guna2ImageButton();
            this.SimpleAsyncThread = new System.ComponentModel.BackgroundWorker();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.LatestVersionLabel = new System.Windows.Forms.Label();
            this.YourVersionLabel = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // guna2BorderlessForm1
            // 
            this.guna2BorderlessForm1.AnimateWindow = true;
            this.guna2BorderlessForm1.BorderRadius = 5;
            this.guna2BorderlessForm1.ContainerControl = this;
            this.guna2BorderlessForm1.DockIndicatorTransparencyValue = 0.6D;
            this.guna2BorderlessForm1.ResizeForm = false;
            this.guna2BorderlessForm1.TransparentWhileDrag = true;
            // 
            // TitleLabel
            // 
            this.TitleLabel.AutoSize = true;
            this.TitleLabel.BackColor = System.Drawing.Color.Transparent;
            this.TitleLabel.Location = new System.Drawing.Point(31, 9);
            this.TitleLabel.Name = "TitleLabel";
            this.TitleLabel.Size = new System.Drawing.Size(150, 17);
            this.TitleLabel.TabIndex = 0;
            this.TitleLabel.Text = "2Stand1 - Installer | v0.1";
            // 
            // InstallBTN
            // 
            this.InstallBTN.Animated = true;
            this.InstallBTN.BorderRadius = 5;
            this.InstallBTN.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.InstallBTN.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.InstallBTN.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.InstallBTN.DisabledState.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.InstallBTN.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.InstallBTN.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(53)))), ((int)(((byte)(226)))));
            this.InstallBTN.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(83)))), ((int)(((byte)(244)))));
            this.InstallBTN.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.InstallBTN.ForeColor = System.Drawing.Color.White;
            this.InstallBTN.Location = new System.Drawing.Point(78, 121);
            this.InstallBTN.Name = "InstallBTN";
            this.InstallBTN.Size = new System.Drawing.Size(172, 58);
            this.InstallBTN.TabIndex = 1;
            this.InstallBTN.Text = "Install ";
            this.InstallBTN.Click += new System.EventHandler(this.InstallBTN_Click);
            // 
            // CreditLabel
            // 
            this.CreditLabel.AutoSize = true;
            this.CreditLabel.BackColor = System.Drawing.Color.Transparent;
            this.CreditLabel.Location = new System.Drawing.Point(2, 263);
            this.CreditLabel.Name = "CreditLabel";
            this.CreditLabel.Size = new System.Drawing.Size(110, 17);
            this.CreditLabel.TabIndex = 2;
            this.CreditLabel.Text = "by разогнанный";
            // 
            // NameThemeLabel
            // 
            this.NameThemeLabel.AutoSize = true;
            this.NameThemeLabel.BackColor = System.Drawing.Color.Transparent;
            this.NameThemeLabel.Font = new System.Drawing.Font("Segoe UI Semibold", 12.75F, System.Drawing.FontStyle.Bold);
            this.NameThemeLabel.Location = new System.Drawing.Point(30, 82);
            this.NameThemeLabel.Name = "NameThemeLabel";
            this.NameThemeLabel.Size = new System.Drawing.Size(133, 23);
            this.NameThemeLabel.TabIndex = 6;
            this.NameThemeLabel.Text = "African - Theme";
            // 
            // CloseBTN
            // 
            this.CloseBTN.BackColor = System.Drawing.Color.Transparent;
            this.CloseBTN.CheckedState.ImageSize = new System.Drawing.Size(64, 64);
            this.CloseBTN.HoverState.Image = global::African_Installer.Properties.Resources.closeh;
            this.CloseBTN.HoverState.ImageSize = new System.Drawing.Size(22, 22);
            this.CloseBTN.Image = global::African_Installer.Properties.Resources.close;
            this.CloseBTN.ImageOffset = new System.Drawing.Point(0, 0);
            this.CloseBTN.ImageRotate = 0F;
            this.CloseBTN.ImageSize = new System.Drawing.Size(22, 22);
            this.CloseBTN.Location = new System.Drawing.Point(304, 6);
            this.CloseBTN.Name = "CloseBTN";
            this.CloseBTN.PressedState.Image = global::African_Installer.Properties.Resources.closec;
            this.CloseBTN.PressedState.ImageSize = new System.Drawing.Size(22, 22);
            this.CloseBTN.Size = new System.Drawing.Size(22, 22);
            this.CloseBTN.TabIndex = 7;
            this.CloseBTN.Click += new System.EventHandler(this.CloseBTN_Click);
            // 
            // SimpleAsyncThread
            // 
            this.SimpleAsyncThread.DoWork += new System.ComponentModel.DoWorkEventHandler(this.SimpleAsyncThread_DoWork);
            this.SimpleAsyncThread.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.SimpleAsyncThread_RunWorkerCompleted);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(83)))), ((int)(((byte)(244)))));
            this.label1.Location = new System.Drawing.Point(108, 182);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(106, 15);
            this.label1.TabIndex = 8;
            this.label1.Text = "Open Source App?";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Location = new System.Drawing.Point(2, 232);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(91, 17);
            this.label2.TabIndex = 9;
            this.label2.Text = "Your Version :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Location = new System.Drawing.Point(2, 246);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(51, 17);
            this.label3.TabIndex = 10;
            this.label3.Text = "Latest :";
            // 
            // LatestVersionLabel
            // 
            this.LatestVersionLabel.AutoSize = true;
            this.LatestVersionLabel.BackColor = System.Drawing.Color.Transparent;
            this.LatestVersionLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(83)))), ((int)(((byte)(244)))));
            this.LatestVersionLabel.Location = new System.Drawing.Point(51, 246);
            this.LatestVersionLabel.Name = "LatestVersionLabel";
            this.LatestVersionLabel.Size = new System.Drawing.Size(79, 17);
            this.LatestVersionLabel.TabIndex = 11;
            this.LatestVersionLabel.Text = "Offline Mod";
            // 
            // YourVersionLabel
            // 
            this.YourVersionLabel.AutoSize = true;
            this.YourVersionLabel.BackColor = System.Drawing.Color.Transparent;
            this.YourVersionLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(83)))), ((int)(((byte)(244)))));
            this.YourVersionLabel.Location = new System.Drawing.Point(93, 232);
            this.YourVersionLabel.Name = "YourVersionLabel";
            this.YourVersionLabel.Size = new System.Drawing.Size(25, 17);
            this.YourVersionLabel.TabIndex = 12;
            this.YourVersionLabel.Text = "0.0";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(83)))), ((int)(((byte)(244)))));
            this.label4.Location = new System.Drawing.Point(107, 263);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(44, 17);
            this.label4.TabIndex = 13;
            this.label4.Text = "#9036";
            // 
            // InstallThemeForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(15)))), ((int)(((byte)(15)))));
            this.BackgroundImage = global::African_Installer.Properties.Resources.backgroundinstaller;
            this.ClientSize = new System.Drawing.Size(333, 285);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.YourVersionLabel);
            this.Controls.Add(this.LatestVersionLabel);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.CloseBTN);
            this.Controls.Add(this.NameThemeLabel);
            this.Controls.Add(this.CreditLabel);
            this.Controls.Add(this.InstallBTN);
            this.Controls.Add(this.TitleLabel);
            this.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "InstallThemeForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "2Stand1 - Installer";
            this.Load += new System.EventHandler(this.InstallThemeForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Guna.UI2.WinForms.Guna2BorderlessForm guna2BorderlessForm1;
        private Guna.UI2.WinForms.Guna2GradientButton InstallBTN;
        private System.Windows.Forms.Label TitleLabel;
        private System.Windows.Forms.Label CreditLabel;
        private Guna.UI2.WinForms.Guna2ImageButton CloseBTN;
        private System.Windows.Forms.Label NameThemeLabel;
        private System.ComponentModel.BackgroundWorker SimpleAsyncThread;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        public System.Windows.Forms.Label LatestVersionLabel;
        public System.Windows.Forms.Label YourVersionLabel;
        private System.Windows.Forms.Label label4;
    }
}

