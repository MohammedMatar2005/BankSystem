using System.Windows.Forms;

namespace BankSystem
{
    partial class frmMain
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
            this.msMainMenu = new System.Windows.Forms.MenuStrip();
            this.menuApplications = new System.Windows.Forms.ToolStripMenuItem();
            this.subMenuDeposit = new System.Windows.Forms.ToolStripMenuItem();
            this.openNewAccountToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.currentAccountToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.شرهىلسؤؤخعىفToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.closeAccountToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.accountTypeConversionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.subMenuWithdraw = new System.Windows.Forms.ToolStripMenuItem();
            this.creditCardRequestToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.renewCreditCardToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.replaceToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.loanFinancingApplicationsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.PeopleToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.menuUsers = new System.Windows.Forms.ToolStripMenuItem();
            this.menuClients = new System.Windows.Forms.ToolStripMenuItem();
            this.menuCurrency = new System.Windows.Forms.ToolStripMenuItem();
            this.menuSettings = new System.Windows.Forms.ToolStripMenuItem();
            this.currentUserInfoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.changePasswordToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.LogoutToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.guna2DragControl1 = new Guna.UI2.WinForms.Guna2DragControl(this.components);
            this.lblTitle = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.pictureBoxBackground = new System.Windows.Forms.PictureBox();
            this.msMainMenu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxBackground)).BeginInit();
            this.SuspendLayout();
            // 
            // msMainMenu
            // 
            this.msMainMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(30)))), ((int)(((byte)(54)))));
            this.msMainMenu.Dock = System.Windows.Forms.DockStyle.Left;
            this.msMainMenu.Font = new System.Drawing.Font("Segoe UI", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.msMainMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuApplications,
            this.PeopleToolStripMenuItem1,
            this.menuUsers,
            this.menuClients,
            this.menuCurrency,
            this.menuSettings,
            this.LogoutToolStripMenuItem1});
            this.msMainMenu.Location = new System.Drawing.Point(0, 0);
            this.msMainMenu.Name = "msMainMenu";
            this.msMainMenu.Size = new System.Drawing.Size(282, 749);
            this.msMainMenu.TabIndex = 1;
            // 
            // menuApplications
            // 
            this.menuApplications.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.subMenuDeposit,
            this.subMenuWithdraw,
            this.loanFinancingApplicationsToolStripMenuItem});
            this.menuApplications.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menuApplications.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(249)))));
            this.menuApplications.Image = global::BankSystem.Properties.Resources.transaction__1_;
            this.menuApplications.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.menuApplications.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.menuApplications.Name = "menuApplications";
            this.menuApplications.Size = new System.Drawing.Size(269, 68);
            this.menuApplications.Text = "Applications";
            // 
            // subMenuDeposit
            // 
            this.subMenuDeposit.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.openNewAccountToolStripMenuItem,
            this.closeAccountToolStripMenuItem,
            this.accountTypeConversionToolStripMenuItem});
            this.subMenuDeposit.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.subMenuDeposit.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.subMenuDeposit.Image = global::BankSystem.Properties.Resources.deposit;
            this.subMenuDeposit.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.subMenuDeposit.Name = "subMenuDeposit";
            this.subMenuDeposit.Size = new System.Drawing.Size(387, 38);
            this.subMenuDeposit.Text = "Account Applications";
            this.subMenuDeposit.Click += new System.EventHandler(this.menuDeposit_Click);
            // 
            // openNewAccountToolStripMenuItem
            // 
            this.openNewAccountToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.currentAccountToolStripMenuItem,
            this.شرهىلسؤؤخعىفToolStripMenuItem});
            this.openNewAccountToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.openNewAccountToolStripMenuItem.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.openNewAccountToolStripMenuItem.Name = "openNewAccountToolStripMenuItem";
            this.openNewAccountToolStripMenuItem.Size = new System.Drawing.Size(336, 34);
            this.openNewAccountToolStripMenuItem.Text = "Open New Account";
            // 
            // currentAccountToolStripMenuItem
            // 
            this.currentAccountToolStripMenuItem.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.currentAccountToolStripMenuItem.Name = "currentAccountToolStripMenuItem";
            this.currentAccountToolStripMenuItem.Size = new System.Drawing.Size(249, 34);
            this.currentAccountToolStripMenuItem.Text = "Current Account";
            // 
            // شرهىلسؤؤخعىفToolStripMenuItem
            // 
            this.شرهىلسؤؤخعىفToolStripMenuItem.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.شرهىلسؤؤخعىفToolStripMenuItem.Name = "شرهىلسؤؤخعىفToolStripMenuItem";
            this.شرهىلسؤؤخعىفToolStripMenuItem.Size = new System.Drawing.Size(249, 34);
            this.شرهىلسؤؤخعىفToolStripMenuItem.Text = "Savings Account";
            // 
            // closeAccountToolStripMenuItem
            // 
            this.closeAccountToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.closeAccountToolStripMenuItem.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.closeAccountToolStripMenuItem.Name = "closeAccountToolStripMenuItem";
            this.closeAccountToolStripMenuItem.Size = new System.Drawing.Size(336, 34);
            this.closeAccountToolStripMenuItem.Text = "Close Account";
            // 
            // accountTypeConversionToolStripMenuItem
            // 
            this.accountTypeConversionToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.accountTypeConversionToolStripMenuItem.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.accountTypeConversionToolStripMenuItem.Name = "accountTypeConversionToolStripMenuItem";
            this.accountTypeConversionToolStripMenuItem.Size = new System.Drawing.Size(336, 34);
            this.accountTypeConversionToolStripMenuItem.Text = "Account Type Conversion";
            // 
            // subMenuWithdraw
            // 
            this.subMenuWithdraw.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.creditCardRequestToolStripMenuItem,
            this.renewCreditCardToolStripMenuItem,
            this.replaceToolStripMenuItem});
            this.subMenuWithdraw.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.subMenuWithdraw.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.subMenuWithdraw.Image = global::BankSystem.Properties.Resources.withdrawal;
            this.subMenuWithdraw.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.subMenuWithdraw.Name = "subMenuWithdraw";
            this.subMenuWithdraw.Size = new System.Drawing.Size(387, 38);
            this.subMenuWithdraw.Text = "Card Applications";
            this.subMenuWithdraw.Click += new System.EventHandler(this.menuWithdraw_Click);
            // 
            // creditCardRequestToolStripMenuItem
            // 
            this.creditCardRequestToolStripMenuItem.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.creditCardRequestToolStripMenuItem.Name = "creditCardRequestToolStripMenuItem";
            this.creditCardRequestToolStripMenuItem.Size = new System.Drawing.Size(280, 34);
            this.creditCardRequestToolStripMenuItem.Text = "Credit Card Request";
            // 
            // renewCreditCardToolStripMenuItem
            // 
            this.renewCreditCardToolStripMenuItem.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.renewCreditCardToolStripMenuItem.Name = "renewCreditCardToolStripMenuItem";
            this.renewCreditCardToolStripMenuItem.Size = new System.Drawing.Size(280, 34);
            this.renewCreditCardToolStripMenuItem.Text = "Renew Credit Card";
            // 
            // replaceToolStripMenuItem
            // 
            this.replaceToolStripMenuItem.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.replaceToolStripMenuItem.Name = "replaceToolStripMenuItem";
            this.replaceToolStripMenuItem.Size = new System.Drawing.Size(280, 34);
            this.replaceToolStripMenuItem.Text = "Replace Credit Card";
            // 
            // loanFinancingApplicationsToolStripMenuItem
            // 
            this.loanFinancingApplicationsToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.loanFinancingApplicationsToolStripMenuItem.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.loanFinancingApplicationsToolStripMenuItem.Name = "loanFinancingApplicationsToolStripMenuItem";
            this.loanFinancingApplicationsToolStripMenuItem.Size = new System.Drawing.Size(387, 38);
            this.loanFinancingApplicationsToolStripMenuItem.Text = "Loan, Financing Applications";
            // 
            // PeopleToolStripMenuItem1
            // 
            this.PeopleToolStripMenuItem1.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PeopleToolStripMenuItem1.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.PeopleToolStripMenuItem1.Image = global::BankSystem.Properties.Resources.human_resources;
            this.PeopleToolStripMenuItem1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.PeopleToolStripMenuItem1.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.PeopleToolStripMenuItem1.Name = "PeopleToolStripMenuItem1";
            this.PeopleToolStripMenuItem1.Size = new System.Drawing.Size(269, 76);
            this.PeopleToolStripMenuItem1.Text = "People";
            this.PeopleToolStripMenuItem1.Click += new System.EventHandler(this.PeopleToolStripMenuItem1_Click);
            // 
            // menuUsers
            // 
            this.menuUsers.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menuUsers.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(249)))));
            this.menuUsers.Image = global::BankSystem.Properties.Resources.user;
            this.menuUsers.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.menuUsers.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.menuUsers.Name = "menuUsers";
            this.menuUsers.Size = new System.Drawing.Size(269, 68);
            this.menuUsers.Text = "Users";
            this.menuUsers.Click += new System.EventHandler(this.menuUsers_Click);
            // 
            // menuClients
            // 
            this.menuClients.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menuClients.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(249)))));
            this.menuClients.Image = global::BankSystem.Properties.Resources.clients;
            this.menuClients.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.menuClients.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.menuClients.Name = "menuClients";
            this.menuClients.Size = new System.Drawing.Size(269, 68);
            this.menuClients.Text = "Clients";
            this.menuClients.Click += new System.EventHandler(this.menuClients_Click);
            // 
            // menuCurrency
            // 
            this.menuCurrency.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menuCurrency.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(249)))));
            this.menuCurrency.Image = global::BankSystem.Properties.Resources.currency_conversion;
            this.menuCurrency.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.menuCurrency.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.menuCurrency.Name = "menuCurrency";
            this.menuCurrency.Size = new System.Drawing.Size(269, 68);
            this.menuCurrency.Text = "Currency Exchange";
            this.menuCurrency.Click += new System.EventHandler(this.menuCurrency_Click);
            // 
            // menuSettings
            // 
            this.menuSettings.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.currentUserInfoToolStripMenuItem,
            this.changePasswordToolStripMenuItem});
            this.menuSettings.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menuSettings.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(249)))));
            this.menuSettings.Image = global::BankSystem.Properties.Resources.settings;
            this.menuSettings.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.menuSettings.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.menuSettings.Name = "menuSettings";
            this.menuSettings.Size = new System.Drawing.Size(269, 68);
            this.menuSettings.Text = "Settings";
            this.menuSettings.Click += new System.EventHandler(this.menuSettings_Click);
            // 
            // currentUserInfoToolStripMenuItem
            // 
            this.currentUserInfoToolStripMenuItem.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.currentUserInfoToolStripMenuItem.Name = "currentUserInfoToolStripMenuItem";
            this.currentUserInfoToolStripMenuItem.Size = new System.Drawing.Size(258, 34);
            this.currentUserInfoToolStripMenuItem.Text = "Current User Info";
            // 
            // changePasswordToolStripMenuItem
            // 
            this.changePasswordToolStripMenuItem.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.changePasswordToolStripMenuItem.Name = "changePasswordToolStripMenuItem";
            this.changePasswordToolStripMenuItem.Size = new System.Drawing.Size(258, 34);
            this.changePasswordToolStripMenuItem.Text = "Change Password";
            // 
            // LogoutToolStripMenuItem1
            // 
            this.LogoutToolStripMenuItem1.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LogoutToolStripMenuItem1.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.LogoutToolStripMenuItem1.Image = global::BankSystem.Properties.Resources.sign_out;
            this.LogoutToolStripMenuItem1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.LogoutToolStripMenuItem1.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.LogoutToolStripMenuItem1.Name = "LogoutToolStripMenuItem1";
            this.LogoutToolStripMenuItem1.Size = new System.Drawing.Size(269, 68);
            this.LogoutToolStripMenuItem1.Text = "Logout";
            this.LogoutToolStripMenuItem1.Click += new System.EventHandler(this.LogoutToolStripMenuItem1_Click);
            // 
            // guna2DragControl1
            // 
            this.guna2DragControl1.DockIndicatorTransparencyValue = 0.6D;
            this.guna2DragControl1.UseTransparentDrag = true;
            // 
            // lblTitle
            // 
            this.lblTitle.BackColor = System.Drawing.Color.Transparent;
            this.lblTitle.Location = new System.Drawing.Point(0, 0);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(3, 2);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = null;
            // 
            // pictureBoxBackground
            // 
            this.pictureBoxBackground.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pictureBoxBackground.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(51)))), ((int)(((byte)(73)))));
            this.pictureBoxBackground.Location = new System.Drawing.Point(285, 0);
            this.pictureBoxBackground.Name = "pictureBoxBackground";
            this.pictureBoxBackground.Size = new System.Drawing.Size(1375, 788);
            this.pictureBoxBackground.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxBackground.TabIndex = 0;
            this.pictureBoxBackground.TabStop = false;
            // 
            // frmMain
            // 
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(51)))), ((int)(((byte)(73)))));
            this.ClientSize = new System.Drawing.Size(1280, 749);
            this.Controls.Add(this.pictureBoxBackground);
            this.Controls.Add(this.msMainMenu);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MainMenuStrip = this.msMainMenu;
            this.Name = "frmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Main Form";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.msMainMenu.ResumeLayout(false);
            this.msMainMenu.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxBackground)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.MenuStrip msMainMenu;
        private System.Windows.Forms.ToolStripMenuItem menuApplications;
        private System.Windows.Forms.ToolStripMenuItem subMenuDeposit;
        private System.Windows.Forms.ToolStripMenuItem subMenuWithdraw;
        private System.Windows.Forms.ToolStripMenuItem menuClients;
        private System.Windows.Forms.ToolStripMenuItem menuUsers;
        private System.Windows.Forms.ToolStripMenuItem menuCurrency;
        private System.Windows.Forms.ToolStripMenuItem menuSettings;
        private System.Windows.Forms.PictureBox pictureBoxBackground;
       private Guna.UI2.WinForms.Guna2DragControl guna2DragControl1;
       private Guna.UI2.WinForms.Guna2HtmlLabel lblTitle;
        private ToolStripMenuItem openNewAccountToolStripMenuItem;
        private ToolStripMenuItem closeAccountToolStripMenuItem;
        private ToolStripMenuItem accountTypeConversionToolStripMenuItem;
        private ToolStripMenuItem loanFinancingApplicationsToolStripMenuItem;
        private ToolStripMenuItem creditCardRequestToolStripMenuItem;
        private ToolStripMenuItem renewCreditCardToolStripMenuItem;
        private ToolStripMenuItem replaceToolStripMenuItem;
        private ToolStripMenuItem currentAccountToolStripMenuItem;
        private ToolStripMenuItem شرهىلسؤؤخعىفToolStripMenuItem;
        private ToolStripMenuItem currentUserInfoToolStripMenuItem;
        private ToolStripMenuItem changePasswordToolStripMenuItem;
        private ToolStripMenuItem PeopleToolStripMenuItem1;
        private ToolStripMenuItem LogoutToolStripMenuItem1;
    }
}
    


