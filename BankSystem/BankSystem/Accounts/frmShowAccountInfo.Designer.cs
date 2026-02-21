namespace BankSystem.Accounts
{
    partial class frmShowAccountInfo
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
            this.pnlHeader = new System.Windows.Forms.Panel();
            this.btnExitTop = new System.Windows.Forms.Button();
            this.lblTitle = new System.Windows.Forms.Label();
            this.pnlFooter = new System.Windows.Forms.Panel();
            this.btnClose = new System.Windows.Forms.Button();
            this.pnlMainContent = new System.Windows.Forms.Panel();
            this.ctrlAccountCard1 = new BankSystem.Accounts.Controls.ctrlAccountCard();
            this.pnlHeader.SuspendLayout();
            this.pnlFooter.SuspendLayout();
            this.pnlMainContent.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlHeader
            // 
            this.pnlHeader.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.pnlHeader.Controls.Add(this.btnExitTop);
            this.pnlHeader.Controls.Add(this.lblTitle);
            this.pnlHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlHeader.Location = new System.Drawing.Point(0, 0);
            this.pnlHeader.Name = "pnlHeader";
            this.pnlHeader.Size = new System.Drawing.Size(820, 50);
            this.pnlHeader.TabIndex = 0;
            // 
            // btnExitTop
            // 
            this.btnExitTop.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnExitTop.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnExitTop.FlatAppearance.BorderSize = 0;
            this.btnExitTop.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Red;
            this.btnExitTop.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExitTop.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.btnExitTop.ForeColor = System.Drawing.Color.White;
            this.btnExitTop.Location = new System.Drawing.Point(770, 0);
            this.btnExitTop.Name = "btnExitTop";
            this.btnExitTop.Size = new System.Drawing.Size(50, 50);
            this.btnExitTop.TabIndex = 1;
            this.btnExitTop.Text = "X";
            this.btnExitTop.UseVisualStyleBackColor = true;
            this.btnExitTop.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // lblTitle
            // 
            this.lblTitle.Dock = System.Windows.Forms.DockStyle.Left;
            this.lblTitle.Font = new System.Drawing.Font("Segoe UI Semibold", 14F, System.Drawing.FontStyle.Bold);
            this.lblTitle.ForeColor = System.Drawing.Color.White;
            this.lblTitle.Location = new System.Drawing.Point(0, 0);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Padding = new System.Windows.Forms.Padding(15, 0, 0, 0);
            this.lblTitle.Size = new System.Drawing.Size(300, 50);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "Account Details";
            this.lblTitle.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // pnlFooter
            // 
            this.pnlFooter.BackColor = System.Drawing.Color.WhiteSmoke;
            this.pnlFooter.Controls.Add(this.btnClose);
            this.pnlFooter.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnlFooter.Location = new System.Drawing.Point(0, 520);
            this.pnlFooter.Name = "pnlFooter";
            this.pnlFooter.Size = new System.Drawing.Size(820, 60);
            this.pnlFooter.TabIndex = 1;
            // 
            // btnClose
            // 
            this.btnClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnClose.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));
            this.btnClose.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnClose.FlatAppearance.BorderSize = 0;
            this.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClose.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold);
            this.btnClose.Location = new System.Drawing.Point(688, 10);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(120, 40);
            this.btnClose.TabIndex = 0;
            this.btnClose.Text = "CLOSE";
            this.btnClose.UseVisualStyleBackColor = false;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // pnlMainContent
            // 
            this.pnlMainContent.Controls.Add(this.ctrlAccountCard1);
            this.pnlMainContent.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlMainContent.Location = new System.Drawing.Point(0, 50);
            this.pnlMainContent.Name = "pnlMainContent";
            this.pnlMainContent.Padding = new System.Windows.Forms.Padding(15);
            this.pnlMainContent.Size = new System.Drawing.Size(820, 470);
            this.pnlMainContent.TabIndex = 2;
            // 
            // ctrlAccountCard1
            // 
            this.ctrlAccountCard1.BackColor = System.Drawing.Color.White;
            this.ctrlAccountCard1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ctrlAccountCard1.Location = new System.Drawing.Point(15, 15);
            this.ctrlAccountCard1.Name = "ctrlAccountCard1";
            this.ctrlAccountCard1.Size = new System.Drawing.Size(790, 440);
            this.ctrlAccountCard1.TabIndex = 0;
            // 
            // frmShowAccountInfo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(820, 580);
            this.Controls.Add(this.pnlMainContent);
            this.Controls.Add(this.pnlFooter);
            this.Controls.Add(this.pnlHeader);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmShowAccountInfo";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.frmShowAccountInfo_Load);
            this.pnlHeader.ResumeLayout(false);
            this.pnlFooter.ResumeLayout(false);
            this.pnlMainContent.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlHeader;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Panel pnlFooter;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Panel pnlMainContent;
        private System.Windows.Forms.Button btnExitTop;
        private BankSystem.Accounts.Controls.ctrlAccountCard ctrlAccountCard1;
    }
}


