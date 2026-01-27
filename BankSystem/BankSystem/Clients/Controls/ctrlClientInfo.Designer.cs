namespace BankSystem.Clients.Controls
{
    partial class ctrlClientInfo
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.gbClientInfo = new System.Windows.Forms.GroupBox();
            this.lblAccountsCount = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lblCreatedBy = new System.Windows.Forms.Label();
            this.lblRegistrationDate = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.ctrlPersonCard1 = new BankSystem.Users.Controls.ctrlPersonCard();
            this.gbClientInfo.SuspendLayout();
            this.SuspendLayout();
            // 
            // gbClientInfo
            // 
            this.gbClientInfo.Controls.Add(this.lblAccountsCount);
            this.gbClientInfo.Controls.Add(this.label3);
            this.gbClientInfo.Controls.Add(this.lblCreatedBy);
            this.gbClientInfo.Controls.Add(this.lblRegistrationDate);
            this.gbClientInfo.Controls.Add(this.label2);
            this.gbClientInfo.Controls.Add(this.label1);
            this.gbClientInfo.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold);
            this.gbClientInfo.Location = new System.Drawing.Point(10, 260);
            this.gbClientInfo.Name = "gbClientInfo";
            this.gbClientInfo.Size = new System.Drawing.Size(830, 95);
            this.gbClientInfo.TabIndex = 1;
            this.gbClientInfo.TabStop = false;
            this.gbClientInfo.Text = "Client Banking Details";
            // 
            // lblAccountsCount
            // 
            this.lblAccountsCount.AutoSize = true;
            this.lblAccountsCount.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.lblAccountsCount.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(211)))), ((int)(((byte)(47)))), ((int)(((byte)(47)))));
            this.lblAccountsCount.Location = new System.Drawing.Point(496, 45);
            this.lblAccountsCount.Name = "lblAccountsCount";
            this.lblAccountsCount.Size = new System.Drawing.Size(17, 19);
            this.lblAccountsCount.TabIndex = 0;
            this.lblAccountsCount.Text = "0";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI Semibold", 10F);
            this.label3.Location = new System.Drawing.Point(336, 45);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(142, 19);
            this.label3.TabIndex = 1;
            this.label3.Text = "Number of Accounts:";
            // 
            // lblCreatedBy
            // 
            this.lblCreatedBy.AutoSize = true;
            this.lblCreatedBy.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.lblCreatedBy.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(120)))), ((int)(((byte)(215)))));
            this.lblCreatedBy.Location = new System.Drawing.Point(689, 45);
            this.lblCreatedBy.Name = "lblCreatedBy";
            this.lblCreatedBy.Size = new System.Drawing.Size(89, 19);
            this.lblCreatedBy.TabIndex = 2;
            this.lblCreatedBy.Text = "[UserName]";
            // 
            // lblRegistrationDate
            // 
            this.lblRegistrationDate.AutoSize = true;
            this.lblRegistrationDate.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.lblRegistrationDate.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(120)))), ((int)(((byte)(215)))));
            this.lblRegistrationDate.Location = new System.Drawing.Point(100, 45);
            this.lblRegistrationDate.Name = "lblRegistrationDate";
            this.lblRegistrationDate.Size = new System.Drawing.Size(79, 19);
            this.lblRegistrationDate.TabIndex = 3;
            this.lblRegistrationDate.Text = "[??/??/????]";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI Semibold", 10F);
            this.label2.Location = new System.Drawing.Point(604, 45);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(79, 19);
            this.label2.TabIndex = 4;
            this.label2.Text = "Created By:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Semibold", 10F);
            this.label1.Location = new System.Drawing.Point(20, 45);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(72, 19);
            this.label1.TabIndex = 5;
            this.label1.Text = "Reg. Date:";
            // 
            // ctrlPersonCard1
            // 
            this.ctrlPersonCard1.BackColor = System.Drawing.Color.White;
            this.ctrlPersonCard1.Location = new System.Drawing.Point(10, 10);
            this.ctrlPersonCard1.Name = "ctrlPersonCard1";
            this.ctrlPersonCard1.Person = null;
            this.ctrlPersonCard1.PersonID = 0;
            this.ctrlPersonCard1.Size = new System.Drawing.Size(830, 240);
            this.ctrlPersonCard1.TabIndex = 0;
            // 
            // ctrlClientInfo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.gbClientInfo);
            this.Controls.Add(this.ctrlPersonCard1);
            this.Font = new System.Drawing.Font("Segoe UI", 9.5F);
            this.Name = "ctrlClientInfo";
            this.Size = new System.Drawing.Size(850, 370);
            this.gbClientInfo.ResumeLayout(false);
            this.gbClientInfo.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Users.Controls.ctrlPersonCard ctrlPersonCard1;
        private System.Windows.Forms.GroupBox gbClientInfo;
        private System.Windows.Forms.Label lblAccountsCount; // حقل عدد الحسابات
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblCreatedBy;
        private System.Windows.Forms.Label lblRegistrationDate;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}
