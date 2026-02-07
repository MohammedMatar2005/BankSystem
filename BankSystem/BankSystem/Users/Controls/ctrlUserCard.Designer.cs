namespace BankSystem.Users.Controls
{
    partial class ctrlUserCard
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
            this.ctrlPersonCard1 = new BankSystem.Users.Controls.ctrlPersonCard();
            this.gbLoginDetails = new System.Windows.Forms.GroupBox();
            this.lblIsActive = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lblUserName = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.gbLoginDetails.SuspendLayout();
            this.SuspendLayout();
            // 
            // ctrlPersonCard1
            // 
            this.ctrlPersonCard1.BackColor = System.Drawing.Color.Transparent;
            this.ctrlPersonCard1.Location = new System.Drawing.Point(3, 3);
            this.ctrlPersonCard1.Name = "ctrlPersonCard1";
            this.ctrlPersonCard1.Person = null;
            this.ctrlPersonCard1.PersonID = 0;
            this.ctrlPersonCard1.Size = new System.Drawing.Size(780, 240);
            this.ctrlPersonCard1.TabIndex = 6;
            // 
            // gbLoginDetails
            // 
            this.gbLoginDetails.Controls.Add(this.lblIsActive);
            this.gbLoginDetails.Controls.Add(this.label3);
            this.gbLoginDetails.Controls.Add(this.lblUserName);
            this.gbLoginDetails.Controls.Add(this.label1);
            this.gbLoginDetails.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold);
            this.gbLoginDetails.Location = new System.Drawing.Point(3, 260);
            this.gbLoginDetails.Name = "gbLoginDetails";
            this.gbLoginDetails.Size = new System.Drawing.Size(780, 100);
            this.gbLoginDetails.TabIndex = 5;
            this.gbLoginDetails.TabStop = false;
            this.gbLoginDetails.Text = "Login Credentials";
            // 
            // lblIsActive
            // 
            this.lblIsActive.AutoSize = true;
            this.lblIsActive.ForeColor = System.Drawing.Color.Green;
            this.lblIsActive.Location = new System.Drawing.Point(550, 45);
            this.lblIsActive.Name = "lblIsActive";
            this.lblIsActive.Size = new System.Drawing.Size(29, 19);
            this.lblIsActive.TabIndex = 3;
            this.lblIsActive.Text = "Yes";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.Color.Gray;
            this.label3.Location = new System.Drawing.Point(470, 45);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(65, 19);
            this.label3.TabIndex = 2;
            this.label3.Text = "Is Active:";
            // 
            // lblUserName
            // 
            this.lblUserName.AutoSize = true;
            this.lblUserName.Location = new System.Drawing.Point(180, 45);
            this.lblUserName.Name = "lblUserName";
            this.lblUserName.Size = new System.Drawing.Size(72, 19);
            this.lblUserName.TabIndex = 1;
            this.lblUserName.Text = "Admin001";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.Gray;
            this.label1.Location = new System.Drawing.Point(90, 45);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(74, 19);
            this.label1.TabIndex = 0;
            this.label1.Text = "Username:";
            // 
            // ctrlUserCard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.ctrlPersonCard1);
            this.Controls.Add(this.gbLoginDetails);
            this.Name = "ctrlUserCard";
            this.Size = new System.Drawing.Size(789, 361);
            this.gbLoginDetails.ResumeLayout(false);
            this.gbLoginDetails.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private ctrlPersonCard ctrlPersonCard1;
        private System.Windows.Forms.GroupBox gbLoginDetails;
        private System.Windows.Forms.Label lblIsActive;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblUserName;
        private System.Windows.Forms.Label label1;
    }
}
