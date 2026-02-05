namespace BankSystem.Login
{
    partial class frmLoginWithCode
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
            this.txtLoginCode = new Guna.UI2.WinForms.Guna2TextBox();
            this.guna2HtmlLabel1 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.btnLogin = new Guna.UI2.WinForms.Guna2Button();
            this.guna2btnExit = new Guna.UI2.WinForms.Guna2Button();
            this.SuspendLayout();
            // 
            // txtLoginCode
            // 
            this.txtLoginCode.Animated = true;
            this.txtLoginCode.BackColor = System.Drawing.Color.Transparent;
            this.txtLoginCode.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtLoginCode.BorderRadius = 10;
            this.txtLoginCode.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtLoginCode.DefaultText = "";
            this.txtLoginCode.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.txtLoginCode.FocusedState.BorderColor = System.Drawing.Color.Gold;
            this.txtLoginCode.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F);
            this.txtLoginCode.ForeColor = System.Drawing.Color.White;
            this.txtLoginCode.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtLoginCode.Location = new System.Drawing.Point(30, 120);
            this.txtLoginCode.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtLoginCode.Name = "txtLoginCode";
            this.txtLoginCode.PlaceholderForeColor = System.Drawing.Color.Gray;
            this.txtLoginCode.PlaceholderText = "••••";
            this.txtLoginCode.SelectedText = "";
            this.txtLoginCode.Size = new System.Drawing.Size(475, 50);
            this.txtLoginCode.TabIndex = 0;
            this.txtLoginCode.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // guna2HtmlLabel1
            // 
            this.guna2HtmlLabel1.BackColor = System.Drawing.Color.Transparent;
            this.guna2HtmlLabel1.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold);
            this.guna2HtmlLabel1.ForeColor = System.Drawing.Color.White;
            this.guna2HtmlLabel1.Location = new System.Drawing.Point(190, 50);
            this.guna2HtmlLabel1.Name = "guna2HtmlLabel1";
            this.guna2HtmlLabel1.Size = new System.Drawing.Size(157, 27);
            this.guna2HtmlLabel1.TabIndex = 1;
            this.guna2HtmlLabel1.Text = "SECURITY CHECK";
            // 
            // btnLogin
            // 
            this.btnLogin.BorderRadius = 15;
            this.btnLogin.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnLogin.FillColor = System.Drawing.Color.Gray;
            this.btnLogin.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            this.btnLogin.ForeColor = System.Drawing.Color.White;
            this.btnLogin.Location = new System.Drawing.Point(348, 212);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Size = new System.Drawing.Size(157, 45);
            this.btnLogin.TabIndex = 5;
            this.btnLogin.Text = "Login";
            this.btnLogin.Click += new System.EventHandler(this.btnLogin_Click);
            // 
            // guna2btnExit
            // 
            this.guna2btnExit.BorderRadius = 15;
            this.guna2btnExit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.guna2btnExit.FillColor = System.Drawing.Color.Orange;
            this.guna2btnExit.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            this.guna2btnExit.ForeColor = System.Drawing.Color.White;
            this.guna2btnExit.Location = new System.Drawing.Point(185, 212);
            this.guna2btnExit.Name = "guna2btnExit";
            this.guna2btnExit.Size = new System.Drawing.Size(157, 45);
            this.guna2btnExit.TabIndex = 6;
            this.guna2btnExit.Text = "Exit";
            this.guna2btnExit.Click += new System.EventHandler(this.guna2btnExit_Click);
            // 
            // frmLoginWithCode
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(15)))), ((int)(((byte)(15)))));
            this.ClientSize = new System.Drawing.Size(535, 269);
            this.Controls.Add(this.guna2btnExit);
            this.Controls.Add(this.btnLogin);
            this.Controls.Add(this.guna2HtmlLabel1);
            this.Controls.Add(this.txtLoginCode);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmLoginWithCode";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Secure Login";
            this.Load += new System.EventHandler(this.frmLoginWithCode_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Guna.UI2.WinForms.Guna2TextBox txtLoginCode;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel1;
        private Guna.UI2.WinForms.Guna2Button btnLogin;
        private Guna.UI2.WinForms.Guna2Button guna2btnExit;
    }
}