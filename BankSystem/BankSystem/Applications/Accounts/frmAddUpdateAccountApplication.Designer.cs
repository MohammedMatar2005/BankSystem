using System.Windows.Forms;

namespace BankSystem.Applications
{
    partial class frmAddUpdateAccountApplication
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
            this.tcApplication = new System.Windows.Forms.TabControl();
            this.tpPersonInfo = new System.Windows.Forms.TabPage();
            this.ctrlPersonCard1 = new BankSystem.Users.Controls.ctrlPersonCard();
            this.btnNext = new System.Windows.Forms.Button();
            this.tpAccountInfo = new System.Windows.Forms.TabPage();
            this.gbAccountDetails = new System.Windows.Forms.GroupBox();
            this.lblNotes = new System.Windows.Forms.Label();
            this.txtNotes = new System.Windows.Forms.TextBox();
            this.lblInitialBalance = new System.Windows.Forms.Label();
            this.numInitialBalance = new System.Windows.Forms.NumericUpDown();
            this.lblUser = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.lblFeesValue = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.cbAccountTypes = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.lblIDValue = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.pnlHeader.SuspendLayout();
            this.tcApplication.SuspendLayout();
            this.tpPersonInfo.SuspendLayout();
            this.tpAccountInfo.SuspendLayout();
            this.gbAccountDetails.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numInitialBalance)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlHeader
            // 
            this.pnlHeader.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(62)))), ((int)(((byte)(80)))));
            this.pnlHeader.Controls.Add(this.lblHeaderTitle);
            this.pnlHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlHeader.Location = new System.Drawing.Point(0, 0);
            this.pnlHeader.Name = "pnlHeader";
            this.pnlHeader.Size = new System.Drawing.Size(862, 80);
            this.pnlHeader.TabIndex = 4;
            // 
            // lblHeaderTitle
            // 
            this.lblHeaderTitle.AutoSize = true;
            this.lblHeaderTitle.Font = new System.Drawing.Font("Segoe UI Semibold", 20F, System.Drawing.FontStyle.Bold);
            this.lblHeaderTitle.ForeColor = System.Drawing.Color.White;
            this.lblHeaderTitle.Location = new System.Drawing.Point(240, 20);
            this.lblHeaderTitle.Name = "lblHeaderTitle";
            this.lblHeaderTitle.Size = new System.Drawing.Size(328, 37);
            this.lblHeaderTitle.TabIndex = 0;
            this.lblHeaderTitle.Text = "New Account Application";
            // 
            // tcApplication
            // 
            this.tcApplication.Controls.Add(this.tpPersonInfo);
            this.tcApplication.Controls.Add(this.tpAccountInfo);
            this.tcApplication.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.tcApplication.Location = new System.Drawing.Point(12, 95);
            this.tcApplication.Name = "tcApplication";
            this.tcApplication.SelectedIndex = 0;
            this.tcApplication.Size = new System.Drawing.Size(838, 381);
            this.tcApplication.TabIndex = 1;
            // 
            // tpPersonInfo
            // 
            this.tpPersonInfo.BackColor = System.Drawing.Color.White;
            this.tpPersonInfo.Controls.Add(this.ctrlPersonCard1);
            this.tpPersonInfo.Controls.Add(this.btnNext);
            this.tpPersonInfo.Location = new System.Drawing.Point(4, 26);
            this.tpPersonInfo.Name = "tpPersonInfo";
            this.tpPersonInfo.Size = new System.Drawing.Size(830, 351);
            this.tpPersonInfo.TabIndex = 0;
            this.tpPersonInfo.Text = "Personal Info";
            // 
            // ctrlPersonCard1
            // 
            this.ctrlPersonCard1.BackColor = System.Drawing.Color.Transparent;
            this.ctrlPersonCard1.Location = new System.Drawing.Point(3, 3);
            this.ctrlPersonCard1.Name = "ctrlPersonCard1";
            this.ctrlPersonCard1.Person = null;
            this.ctrlPersonCard1.PersonID = 0;
            this.ctrlPersonCard1.Size = new System.Drawing.Size(780, 269);
            this.ctrlPersonCard1.TabIndex = 1;
            // 
            // btnNext
            // 
            this.btnNext.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(62)))), ((int)(((byte)(80)))));
            this.btnNext.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNext.ForeColor = System.Drawing.Color.White;
            this.btnNext.Location = new System.Drawing.Point(653, 290);
            this.btnNext.Name = "btnNext";
            this.btnNext.Size = new System.Drawing.Size(130, 40);
            this.btnNext.TabIndex = 0;
            this.btnNext.Text = "Next";
            this.btnNext.UseVisualStyleBackColor = false;
            // 
            // tpAccountInfo
            // 
            this.tpAccountInfo.Controls.Add(this.gbAccountDetails);
            this.tpAccountInfo.Location = new System.Drawing.Point(4, 26);
            this.tpAccountInfo.Name = "tpAccountInfo";
            this.tpAccountInfo.Size = new System.Drawing.Size(830, 351);
            this.tpAccountInfo.TabIndex = 1;
            this.tpAccountInfo.Text = "Account Info";
            this.tpAccountInfo.UseVisualStyleBackColor = true;
            // 
            // gbAccountDetails
            // 
            this.gbAccountDetails.Controls.Add(this.label5);
            this.gbAccountDetails.Controls.Add(this.lblNotes);
            this.gbAccountDetails.Controls.Add(this.txtNotes);
            this.gbAccountDetails.Controls.Add(this.lblInitialBalance);
            this.gbAccountDetails.Controls.Add(this.numInitialBalance);
            this.gbAccountDetails.Controls.Add(this.lblUser);
            this.gbAccountDetails.Controls.Add(this.label4);
            this.gbAccountDetails.Controls.Add(this.lblFeesValue);
            this.gbAccountDetails.Controls.Add(this.label3);
            this.gbAccountDetails.Controls.Add(this.cbAccountTypes);
            this.gbAccountDetails.Controls.Add(this.label2);
            this.gbAccountDetails.Controls.Add(this.lblIDValue);
            this.gbAccountDetails.Controls.Add(this.label1);
            this.gbAccountDetails.Font = new System.Drawing.Font("Segoe UI Semibold", 11F, System.Drawing.FontStyle.Bold);
            this.gbAccountDetails.Location = new System.Drawing.Point(20, 20);
            this.gbAccountDetails.Name = "gbAccountDetails";
            this.gbAccountDetails.Size = new System.Drawing.Size(790, 328);
            this.gbAccountDetails.TabIndex = 0;
            this.gbAccountDetails.TabStop = false;
            this.gbAccountDetails.Text = "Account Details";
            // 
            // lblNotes
            // 
            this.lblNotes.AutoSize = true;
            this.lblNotes.Location = new System.Drawing.Point(34, 145);
            this.lblNotes.Name = "lblNotes";
            this.lblNotes.Size = new System.Drawing.Size(53, 20);
            this.lblNotes.TabIndex = 0;
            this.lblNotes.Text = "Notes:";
            // 
            // txtNotes
            // 
            this.txtNotes.Location = new System.Drawing.Point(210, 145);
            this.txtNotes.Multiline = true;
            this.txtNotes.Name = "txtNotes";
            this.txtNotes.Size = new System.Drawing.Size(530, 80);
            this.txtNotes.TabIndex = 1;
            // 
            // lblInitialBalance
            // 
            this.lblInitialBalance.AutoSize = true;
            this.lblInitialBalance.Location = new System.Drawing.Point(34, 103);
            this.lblInitialBalance.Name = "lblInitialBalance";
            this.lblInitialBalance.Size = new System.Drawing.Size(108, 20);
            this.lblInitialBalance.TabIndex = 2;
            this.lblInitialBalance.Text = "Initial Balance:";
            // 
            // numInitialBalance
            // 
            this.numInitialBalance.DecimalPlaces = 2;
            this.numInitialBalance.Location = new System.Drawing.Point(210, 103);
            this.numInitialBalance.Maximum = new decimal(new int[] {
            1000000,
            0,
            0,
            0});
            this.numInitialBalance.Name = "numInitialBalance";
            this.numInitialBalance.Size = new System.Drawing.Size(262, 27);
            this.numInitialBalance.TabIndex = 3;
            // 
            // lblUser
            // 
            this.lblUser.Location = new System.Drawing.Point(0, 0);
            this.lblUser.Name = "lblUser";
            this.lblUser.Size = new System.Drawing.Size(100, 23);
            this.lblUser.TabIndex = 0;
            // 
            // label4
            // 
            this.label4.Location = new System.Drawing.Point(0, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(100, 23);
            this.label4.TabIndex = 1;
            // 
            // lblFeesValue
            // 
            this.lblFeesValue.Location = new System.Drawing.Point(0, 0);
            this.lblFeesValue.Name = "lblFeesValue";
            this.lblFeesValue.Size = new System.Drawing.Size(100, 23);
            this.lblFeesValue.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.Location = new System.Drawing.Point(0, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(100, 23);
            this.label3.TabIndex = 3;
            // 
            // cbAccountTypes
            // 
            this.cbAccountTypes.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbAccountTypes.Items.AddRange(new object[] {
            "Current",
            "Saving"});
            this.cbAccountTypes.Location = new System.Drawing.Point(210, 67);
            this.cbAccountTypes.Name = "cbAccountTypes";
            this.cbAccountTypes.Size = new System.Drawing.Size(121, 28);
            this.cbAccountTypes.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(0, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(100, 23);
            this.label2.TabIndex = 5;
            this.label2.Text = "Account Type:";
            // 
            // lblIDValue
            // 
            this.lblIDValue.Location = new System.Drawing.Point(0, 0);
            this.lblIDValue.Name = "lblIDValue";
            this.lblIDValue.Size = new System.Drawing.Size(100, 23);
            this.lblIDValue.TabIndex = 6;
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(100, 23);
            this.label1.TabIndex = 7;
            // 
            // btnSave
            // 
            this.btnSave.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(204)))), ((int)(((byte)(113)))));
            this.btnSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSave.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            this.btnSave.ForeColor = System.Drawing.Color.White;
            this.btnSave.Location = new System.Drawing.Point(716, 497);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(130, 45);
            this.btnSave.TabIndex = 5;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = false;
            // 
            // btnClose
            // 
            this.btnClose.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(76)))), ((int)(((byte)(60)))));
            this.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClose.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            this.btnClose.ForeColor = System.Drawing.Color.White;
            this.btnClose.Location = new System.Drawing.Point(576, 497);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(130, 45);
            this.btnClose.TabIndex = 6;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = false;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(34, 67);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(105, 20);
            this.label5.TabIndex = 8;
            this.label5.Text = "Account Type:";
            // 
            // frmAddUpdateAccountApplication
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(862, 554);
            this.Controls.Add(this.pnlHeader);
            this.Controls.Add(this.tcApplication);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.btnClose);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.Name = "frmAddUpdateAccountApplication";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Manage Account Application";
            this.pnlHeader.ResumeLayout(false);
            this.pnlHeader.PerformLayout();
            this.tcApplication.ResumeLayout(false);
            this.tpPersonInfo.ResumeLayout(false);
            this.tpAccountInfo.ResumeLayout(false);
            this.gbAccountDetails.ResumeLayout(false);
            this.gbAccountDetails.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numInitialBalance)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlHeader;
        private System.Windows.Forms.Label lblHeaderTitle;
        private System.Windows.Forms.TabControl tcApplication;
        private System.Windows.Forms.TabPage tpPersonInfo;
        private System.Windows.Forms.TabPage tpAccountInfo;
        private System.Windows.Forms.Button btnNext;
        private System.Windows.Forms.GroupBox gbAccountDetails;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblIDValue;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cbAccountTypes;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblFeesValue;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lblUser;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnClose;
        private Users.Controls.ctrlPersonCard ctrlPersonCard1;

        private System.Windows.Forms.Label lblInitialBalance;
        private System.Windows.Forms.NumericUpDown numInitialBalance;
        private System.Windows.Forms.Label lblNotes;
        private System.Windows.Forms.TextBox txtNotes;
        private Label label5;
    }
}
