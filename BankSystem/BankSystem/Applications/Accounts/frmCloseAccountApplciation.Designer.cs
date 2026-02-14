namespace BankSystem.Applications.Accounts
{
    partial class frmCloseAccountApplciation
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
            this.lblHeaderTitle = new System.Windows.Forms.Label();
            this.btnClose = new System.Windows.Forms.Button();
            this.btnConfirmClose = new System.Windows.Forms.Button();
            this.gbClosureDetails = new System.Windows.Forms.GroupBox();
            this.txtNotes = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.lblBalance = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.ctrlAccountInfoCardWithFilter1 = new BankSystem.Accounts.Controls.ctrlAccountInfoCardWithFilter();
            this.pnlHeader.SuspendLayout();
            this.gbClosureDetails.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlHeader
            // 
            this.pnlHeader.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(62)))), ((int)(((byte)(80)))));
            this.pnlHeader.Controls.Add(this.lblHeaderTitle);
            this.pnlHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlHeader.Location = new System.Drawing.Point(0, 0);
            this.pnlHeader.Name = "pnlHeader";
            this.pnlHeader.Size = new System.Drawing.Size(830, 80);
            this.pnlHeader.TabIndex = 1;
            // 
            // lblHeaderTitle
            // 
            this.lblHeaderTitle.AutoSize = true;
            this.lblHeaderTitle.Font = new System.Drawing.Font("Segoe UI Semibold", 20F, System.Drawing.FontStyle.Bold);
            this.lblHeaderTitle.ForeColor = System.Drawing.Color.White;
            this.lblHeaderTitle.Location = new System.Drawing.Point(265, 20);
            this.lblHeaderTitle.Name = "lblHeaderTitle";
            this.lblHeaderTitle.Size = new System.Drawing.Size(301, 37);
            this.lblHeaderTitle.TabIndex = 0;
            this.lblHeaderTitle.Text = "Close Bank Account";
            // 
            // ctrlAccountInfoCardWithFilter1
            // 
            this.ctrlAccountInfoCardWithFilter1.BackColor = System.Drawing.Color.White;
            this.ctrlAccountInfoCardWithFilter1.Location = new System.Drawing.Point(39, 90);
            this.ctrlAccountInfoCardWithFilter1.Name = "ctrlAccountInfoCardWithFilter1";
            this.ctrlAccountInfoCardWithFilter1.Size = new System.Drawing.Size(739, 388);
            this.ctrlAccountInfoCardWithFilter1.TabIndex = 0;
            // 
            // gbClosureDetails
            // 
            this.gbClosureDetails.Controls.Add(this.txtNotes);
            this.gbClosureDetails.Controls.Add(this.label2);
            this.gbClosureDetails.Controls.Add(this.lblBalance);
            this.gbClosureDetails.Controls.Add(this.label1);
            this.gbClosureDetails.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold);
            this.gbClosureDetails.Location = new System.Drawing.Point(39, 484);
            this.gbClosureDetails.Name = "gbClosureDetails";
            this.gbClosureDetails.Size = new System.Drawing.Size(739, 148);
            this.gbClosureDetails.TabIndex = 2;
            this.gbClosureDetails.TabStop = false;
            this.gbClosureDetails.Text = "Closure Details";
            // 
            // txtNotes
            // 
            this.txtNotes.Location = new System.Drawing.Point(145, 75);
            this.txtNotes.Multiline = true;
            this.txtNotes.Name = "txtNotes";
            this.txtNotes.Size = new System.Drawing.Size(564, 55);
            this.txtNotes.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(26, 78);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(113, 19);
            this.label2.TabIndex = 2;
            this.label2.Text = "Closure Reason:";
            // 
            // lblBalance
            // 
            this.lblBalance.AutoSize = true;
            this.lblBalance.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.lblBalance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lblBalance.Location = new System.Drawing.Point(141, 35);
            this.lblBalance.Name = "lblBalance";
            this.lblBalance.Size = new System.Drawing.Size(55, 21);
            this.lblBalance.TabIndex = 1;
            this.lblBalance.Text = "0.00 $";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(26, 37);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(109, 19);
            this.label1.TabIndex = 0;
            this.label1.Text = "Net Balance:";
            // 
            // btnConfirmClose
            // 
            this.btnConfirmClose.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(76)))), ((int)(((byte)(60)))));
            this.btnConfirmClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnConfirmClose.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            this.btnConfirmClose.ForeColor = System.Drawing.Color.White;
            this.btnConfirmClose.Location = new System.Drawing.Point(648, 648);
            this.btnConfirmClose.Name = "btnConfirmClose";
            this.btnConfirmClose.Size = new System.Drawing.Size(130, 45);
            this.btnConfirmClose.TabIndex = 3;
            this.btnConfirmClose.Text = "Confirm Close";
            this.btnConfirmClose.UseVisualStyleBackColor = false;
            // 
            // btnClose
            // 
            this.btnClose.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(149)))), ((int)(((byte)(165)))), ((int)(((byte)(166)))));
            this.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClose.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            this.btnClose.ForeColor = System.Drawing.Color.White;
            this.btnClose.Location = new System.Drawing.Point(512, 648);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(130, 45);
            this.btnClose.TabIndex = 4;
            this.btnClose.Text = "Cancel";
            this.btnClose.UseVisualStyleBackColor = false;
            // 
            // frmCloseAccountApplication
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(830, 715);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnConfirmClose);
            this.Controls.Add(this.gbClosureDetails);
            this.Controls.Add(this.pnlHeader);
            this.Controls.Add(this.ctrlAccountInfoCardWithFilter1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.Name = "frmCloseAccountApplication";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Close Bank Account";
            this.pnlHeader.ResumeLayout(false);
            this.pnlHeader.PerformLayout();
            this.gbClosureDetails.ResumeLayout(false);
            this.gbClosureDetails.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlHeader;
        private System.Windows.Forms.Label lblHeaderTitle;
        private System.Windows.Forms.GroupBox gbClosureDetails;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblBalance;
        private System.Windows.Forms.TextBox txtNotes;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnConfirmClose;
        private System.Windows.Forms.Button btnClose;
        private BankSystem.Accounts.Controls.ctrlAccountInfoCardWithFilter ctrlAccountInfoCardWithFilter1;
    }
}