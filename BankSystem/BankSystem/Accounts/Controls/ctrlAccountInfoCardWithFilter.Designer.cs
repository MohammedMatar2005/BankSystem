namespace BankSystem.Accounts.Controls
{
    partial class ctrlAccountInfoCardWithFilter
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
            this.components = new System.ComponentModel.Container();
            this.gbFilters = new System.Windows.Forms.GroupBox();
            this.txtFilterValue = new System.Windows.Forms.TextBox();
            this.cbFilterBy = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnAddNewAccount = new System.Windows.Forms.Button();
            this.btnFind = new System.Windows.Forms.Button();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.ctrlAccountCard1 = new BankSystem.Accounts.Controls.ctrlAccountCard();
            this.gbFilters.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // gbFilters
            // 
            this.gbFilters.Controls.Add(this.btnAddNewAccount);
            this.gbFilters.Controls.Add(this.btnFind);
            this.gbFilters.Controls.Add(this.txtFilterValue);
            this.gbFilters.Controls.Add(this.cbFilterBy);
            this.gbFilters.Controls.Add(this.label1);
            this.gbFilters.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold);
            this.gbFilters.Location = new System.Drawing.Point(3, 5);
            this.gbFilters.Name = "gbFilters";
            this.gbFilters.Size = new System.Drawing.Size(787, 90);
            this.gbFilters.TabIndex = 1;
            this.gbFilters.TabStop = false;
            this.gbFilters.Text = "Filter Accounts";
            // 
            // txtFilterValue
            // 
            this.txtFilterValue.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtFilterValue.Location = new System.Drawing.Point(280, 37);
            this.txtFilterValue.Name = "txtFilterValue";
            this.txtFilterValue.Size = new System.Drawing.Size(220, 25);
            this.txtFilterValue.TabIndex = 1;
            // 
            // cbFilterBy
            // 
            this.cbFilterBy.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbFilterBy.FormattingEnabled = true;
            this.cbFilterBy.Items.AddRange(new object[] {
            "Account No",
            "Person ID",
            "National No",
            "Application ID"});
            this.cbFilterBy.Location = new System.Drawing.Point(89, 37);
            this.cbFilterBy.Name = "cbFilterBy";
            this.cbFilterBy.Size = new System.Drawing.Size(180, 25);
            this.cbFilterBy.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(20, 40);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(58, 19);
            this.label1.TabIndex = 4;
            this.label1.Text = "Find By:";
            // 
            // btnAddNewAccount
            // 
            this.btnAddNewAccount.BackColor = System.Drawing.Color.White;
            this.btnAddNewAccount.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddNewAccount.Image = global::BankSystem.Properties.Resources.plus;
            this.btnAddNewAccount.Location = new System.Drawing.Point(614, 24);
            this.btnAddNewAccount.Name = "btnAddNewAccount";
            this.btnAddNewAccount.Size = new System.Drawing.Size(50, 50);
            this.btnAddNewAccount.TabIndex = 3;
            this.btnAddNewAccount.UseVisualStyleBackColor = false;
            // 
            // btnFind
            // 
            this.btnFind.BackColor = System.Drawing.Color.White;
            this.btnFind.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFind.Image = global::BankSystem.Properties.Resources.loupe;
            this.btnFind.Location = new System.Drawing.Point(554, 24);
            this.btnFind.Name = "btnFind";
            this.btnFind.Size = new System.Drawing.Size(50, 50);
            this.btnFind.TabIndex = 2;
            this.btnFind.UseVisualStyleBackColor = false;
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // ctrlAccountCard1
            // 
            this.ctrlAccountCard1.BackColor = System.Drawing.Color.White;
            this.ctrlAccountCard1.Location = new System.Drawing.Point(0, 101);
            this.ctrlAccountCard1.Name = "ctrlAccountCard1";
            this.ctrlAccountCard1.Size = new System.Drawing.Size(790, 399);
            this.ctrlAccountCard1.TabIndex = 2;
            // 
            // ctrlAccountInfoCardWithFilter
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.ctrlAccountCard1);
            this.Controls.Add(this.gbFilters);
            this.Name = "ctrlAccountInfoCardWithFilter";
            this.Size = new System.Drawing.Size(795, 507);
            this.Validating += new System.ComponentModel.CancelEventHandler(this.ctrlAccountInfoCardWithFilter_Validating);
            this.gbFilters.ResumeLayout(false);
            this.gbFilters.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.GroupBox gbFilters;
        private System.Windows.Forms.Button btnAddNewAccount;
        private System.Windows.Forms.Button btnFind;
        private System.Windows.Forms.TextBox txtFilterValue;
        private System.Windows.Forms.ComboBox cbFilterBy;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private ctrlAccountCard ctrlAccountCard1;
    }
}
