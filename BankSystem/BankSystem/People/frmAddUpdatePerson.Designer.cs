namespace BankSystem.People
{
    partial class frmAddUpdatePerson
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
            this.lblTitle = new System.Windows.Forms.Label();
            this.pnlMainContent = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.lblPersonID = new System.Windows.Forms.Label();
            this.gbDetails = new System.Windows.Forms.GroupBox();
            this.lblFName = new System.Windows.Forms.Label();
            this.txtFirstName = new System.Windows.Forms.TextBox();
            this.lblSName = new System.Windows.Forms.Label();
            this.txtSecondName = new System.Windows.Forms.TextBox();
            this.lblTName = new System.Windows.Forms.Label();
            this.txtThirdName = new System.Windows.Forms.TextBox();
            this.lblLName = new System.Windows.Forms.Label();
            this.txtLastName = new System.Windows.Forms.TextBox();
            this.lblNationalNo = new System.Windows.Forms.Label();
            this.txtNationalNo = new System.Windows.Forms.TextBox();
            this.lblDateOfBirth = new System.Windows.Forms.Label();
            this.dtpDateOfBirth = new System.Windows.Forms.DateTimePicker();
            this.lblGander = new System.Windows.Forms.Label();
            this.rbMale = new System.Windows.Forms.RadioButton();
            this.rbFemale = new System.Windows.Forms.RadioButton();
            this.lblPhone = new System.Windows.Forms.Label();
            this.txtPhone = new System.Windows.Forms.TextBox();
            this.lblEmail = new System.Windows.Forms.Label();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.lblCountry = new System.Windows.Forms.Label();
            this.cbCountry = new System.Windows.Forms.ComboBox();
            this.lblAddress = new System.Windows.Forms.Label();
            this.txtAddress = new System.Windows.Forms.TextBox();
            this.pbPersonImage = new System.Windows.Forms.PictureBox();
            this.llSetImage = new System.Windows.Forms.LinkLabel();
            this.llRemoveImage = new System.Windows.Forms.LinkLabel();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.pnlHeader.SuspendLayout();
            this.pnlMainContent.SuspendLayout();
            this.gbDetails.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbPersonImage)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlHeader
            // 
            this.pnlHeader.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(52)))), ((int)(((byte)(71)))));
            this.pnlHeader.Controls.Add(this.lblTitle);
            this.pnlHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlHeader.Location = new System.Drawing.Point(0, 0);
            this.pnlHeader.Name = "pnlHeader";
            this.pnlHeader.Size = new System.Drawing.Size(1000, 70);
            this.pnlHeader.TabIndex = 1;
            // 
            // lblTitle
            // 
            this.lblTitle.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblTitle.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Bold);
            this.lblTitle.ForeColor = System.Drawing.Color.White;
            this.lblTitle.Location = new System.Drawing.Point(0, 0);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(1000, 70);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "Add New Person";
            this.lblTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pnlMainContent
            // 
            this.pnlMainContent.BackColor = System.Drawing.Color.WhiteSmoke;
            this.pnlMainContent.Controls.Add(this.label1);
            this.pnlMainContent.Controls.Add(this.lblPersonID);
            this.pnlMainContent.Controls.Add(this.gbDetails);
            this.pnlMainContent.Controls.Add(this.btnSave);
            this.pnlMainContent.Controls.Add(this.btnClose);
            this.pnlMainContent.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlMainContent.Location = new System.Drawing.Point(0, 70);
            this.pnlMainContent.Name = "pnlMainContent";
            this.pnlMainContent.Size = new System.Drawing.Size(1000, 530);
            this.pnlMainContent.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Segoe UI Semibold", 11F);
            this.label1.Location = new System.Drawing.Point(40, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(100, 23);
            this.label1.TabIndex = 0;
            this.label1.Text = "Person ID:";
            // 
            // lblPersonID
            // 
            this.lblPersonID.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            this.lblPersonID.Location = new System.Drawing.Point(130, 20);
            this.lblPersonID.Name = "lblPersonID";
            this.lblPersonID.Size = new System.Drawing.Size(100, 23);
            this.lblPersonID.TabIndex = 1;
            this.lblPersonID.Text = "[???]";
            // 
            // gbDetails
            // 
            this.gbDetails.Controls.Add(this.lblFName);
            this.gbDetails.Controls.Add(this.txtFirstName);
            this.gbDetails.Controls.Add(this.lblSName);
            this.gbDetails.Controls.Add(this.txtSecondName);
            this.gbDetails.Controls.Add(this.lblTName);
            this.gbDetails.Controls.Add(this.txtThirdName);
            this.gbDetails.Controls.Add(this.lblLName);
            this.gbDetails.Controls.Add(this.txtLastName);
            this.gbDetails.Controls.Add(this.lblNationalNo);
            this.gbDetails.Controls.Add(this.txtNationalNo);
            this.gbDetails.Controls.Add(this.lblDateOfBirth);
            this.gbDetails.Controls.Add(this.dtpDateOfBirth);
            this.gbDetails.Controls.Add(this.lblGander);
            this.gbDetails.Controls.Add(this.rbMale);
            this.gbDetails.Controls.Add(this.rbFemale);
            this.gbDetails.Controls.Add(this.lblPhone);
            this.gbDetails.Controls.Add(this.txtPhone);
            this.gbDetails.Controls.Add(this.lblEmail);
            this.gbDetails.Controls.Add(this.txtEmail);
            this.gbDetails.Controls.Add(this.lblCountry);
            this.gbDetails.Controls.Add(this.cbCountry);
            this.gbDetails.Controls.Add(this.lblAddress);
            this.gbDetails.Controls.Add(this.txtAddress);
            this.gbDetails.Controls.Add(this.pbPersonImage);
            this.gbDetails.Controls.Add(this.llSetImage);
            this.gbDetails.Controls.Add(this.llRemoveImage);
            this.gbDetails.Font = new System.Drawing.Font("Segoe UI", 9.5F);
            this.gbDetails.Location = new System.Drawing.Point(30, 50);
            this.gbDetails.Name = "gbDetails";
            this.gbDetails.Size = new System.Drawing.Size(940, 380);
            this.gbDetails.TabIndex = 2;
            this.gbDetails.TabStop = false;
            this.gbDetails.Text = "Personal Information";
            // 
            // lblFName
            // 
            this.lblFName.Location = new System.Drawing.Point(20, 45);
            this.lblFName.Name = "lblFName";
            this.lblFName.Size = new System.Drawing.Size(100, 23);
            this.lblFName.TabIndex = 0;
            this.lblFName.Text = "First Name:";
            // 
            // txtFirstName
            // 
            this.txtFirstName.Location = new System.Drawing.Point(120, 42);
            this.txtFirstName.Name = "txtFirstName";
            this.txtFirstName.Size = new System.Drawing.Size(160, 24);
            this.txtFirstName.TabIndex = 1;
            // 
            // lblSName
            // 
            this.lblSName.Location = new System.Drawing.Point(300, 45);
            this.lblSName.Name = "lblSName";
            this.lblSName.Size = new System.Drawing.Size(64, 23);
            this.lblSName.TabIndex = 2;
            this.lblSName.Text = "Second:";
            // 
            // txtSecondName
            // 
            this.txtSecondName.Location = new System.Drawing.Point(370, 42);
            this.txtSecondName.Name = "txtSecondName";
            this.txtSecondName.Size = new System.Drawing.Size(160, 24);
            this.txtSecondName.TabIndex = 3;
            // 
            // lblTName
            // 
            this.lblTName.Location = new System.Drawing.Point(550, 45);
            this.lblTName.Name = "lblTName";
            this.lblTName.Size = new System.Drawing.Size(44, 23);
            this.lblTName.TabIndex = 4;
            this.lblTName.Text = "Third:";
            // 
            // txtThirdName
            // 
            this.txtThirdName.Location = new System.Drawing.Point(600, 42);
            this.txtThirdName.Name = "txtThirdName";
            this.txtThirdName.Size = new System.Drawing.Size(160, 24);
            this.txtThirdName.TabIndex = 5;
            // 
            // lblLName
            // 
            this.lblLName.Location = new System.Drawing.Point(775, 45);
            this.lblLName.Name = "lblLName";
            this.lblLName.Size = new System.Drawing.Size(39, 23);
            this.lblLName.TabIndex = 6;
            this.lblLName.Text = "Last:";
            // 
            // txtLastName
            // 
            this.txtLastName.Location = new System.Drawing.Point(820, 42);
            this.txtLastName.Name = "txtLastName";
            this.txtLastName.Size = new System.Drawing.Size(100, 24);
            this.txtLastName.TabIndex = 7;
            // 
            // lblNationalNo
            // 
            this.lblNationalNo.Location = new System.Drawing.Point(20, 95);
            this.lblNationalNo.Name = "lblNationalNo";
            this.lblNationalNo.Size = new System.Drawing.Size(100, 23);
            this.lblNationalNo.TabIndex = 8;
            this.lblNationalNo.Text = "National No:";
            // 
            // txtNationalNo
            // 
            this.txtNationalNo.Location = new System.Drawing.Point(120, 92);
            this.txtNationalNo.Name = "txtNationalNo";
            this.txtNationalNo.Size = new System.Drawing.Size(160, 24);
            this.txtNationalNo.TabIndex = 9;
            // 
            // lblDateOfBirth
            // 
            this.lblDateOfBirth.Location = new System.Drawing.Point(300, 95);
            this.lblDateOfBirth.Name = "lblDateOfBirth";
            this.lblDateOfBirth.Size = new System.Drawing.Size(100, 23);
            this.lblDateOfBirth.TabIndex = 10;
            this.lblDateOfBirth.Text = "Date Of Birth:";
            // 
            // dtpDateOfBirth
            // 
            this.dtpDateOfBirth.Location = new System.Drawing.Point(410, 92);
            this.dtpDateOfBirth.Name = "dtpDateOfBirth";
            this.dtpDateOfBirth.Size = new System.Drawing.Size(200, 24);
            this.dtpDateOfBirth.TabIndex = 11;
            // 
            // lblGander
            // 
            this.lblGander.Location = new System.Drawing.Point(20, 145);
            this.lblGander.Name = "lblGander";
            this.lblGander.Size = new System.Drawing.Size(100, 23);
            this.lblGander.TabIndex = 12;
            this.lblGander.Text = "Gander:";
            // 
            // rbMale
            // 
            this.rbMale.Checked = true;
            this.rbMale.Location = new System.Drawing.Point(120, 142);
            this.rbMale.Name = "rbMale";
            this.rbMale.Size = new System.Drawing.Size(104, 24);
            this.rbMale.TabIndex = 13;
            this.rbMale.TabStop = true;
            this.rbMale.Text = "Male";
            // 
            // rbFemale
            // 
            this.rbFemale.Location = new System.Drawing.Point(190, 142);
            this.rbFemale.Name = "rbFemale";
            this.rbFemale.Size = new System.Drawing.Size(104, 24);
            this.rbFemale.TabIndex = 14;
            this.rbFemale.Text = "Female";
            // 
            // lblPhone
            // 
            this.lblPhone.Location = new System.Drawing.Point(300, 145);
            this.lblPhone.Name = "lblPhone";
            this.lblPhone.Size = new System.Drawing.Size(100, 23);
            this.lblPhone.TabIndex = 15;
            this.lblPhone.Text = "Phone:";
            // 
            // txtPhone
            // 
            this.txtPhone.Location = new System.Drawing.Point(410, 142);
            this.txtPhone.Name = "txtPhone";
            this.txtPhone.Size = new System.Drawing.Size(200, 24);
            this.txtPhone.TabIndex = 16;
            // 
            // lblEmail
            // 
            this.lblEmail.Location = new System.Drawing.Point(20, 195);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(100, 23);
            this.lblEmail.TabIndex = 17;
            this.lblEmail.Text = "Email:";
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(120, 192);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(160, 24);
            this.txtEmail.TabIndex = 18;
            // 
            // lblCountry
            // 
            this.lblCountry.Location = new System.Drawing.Point(300, 195);
            this.lblCountry.Name = "lblCountry";
            this.lblCountry.Size = new System.Drawing.Size(100, 23);
            this.lblCountry.TabIndex = 19;
            this.lblCountry.Text = "Country:";
            // 
            // cbCountry
            // 
            this.cbCountry.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbCountry.Location = new System.Drawing.Point(410, 192);
            this.cbCountry.Name = "cbCountry";
            this.cbCountry.Size = new System.Drawing.Size(200, 25);
            this.cbCountry.TabIndex = 20;
            // 
            // lblAddress
            // 
            this.lblAddress.Location = new System.Drawing.Point(20, 245);
            this.lblAddress.Name = "lblAddress";
            this.lblAddress.Size = new System.Drawing.Size(100, 23);
            this.lblAddress.TabIndex = 21;
            this.lblAddress.Text = "Address:";
            // 
            // txtAddress
            // 
            this.txtAddress.Location = new System.Drawing.Point(120, 242);
            this.txtAddress.Multiline = true;
            this.txtAddress.Name = "txtAddress";
            this.txtAddress.Size = new System.Drawing.Size(490, 100);
            this.txtAddress.TabIndex = 22;
            // 
            // pbPersonImage
            // 
            this.pbPersonImage.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pbPersonImage.Location = new System.Drawing.Point(720, 100);
            this.pbPersonImage.Name = "pbPersonImage";
            this.pbPersonImage.Size = new System.Drawing.Size(180, 180);
            this.pbPersonImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbPersonImage.TabIndex = 23;
            this.pbPersonImage.TabStop = false;
            // 
            // llSetImage
            // 
            this.llSetImage.Location = new System.Drawing.Point(730, 290);
            this.llSetImage.Name = "llSetImage";
            this.llSetImage.Size = new System.Drawing.Size(100, 23);
            this.llSetImage.TabIndex = 24;
            this.llSetImage.TabStop = true;
            this.llSetImage.Text = "Set Image";
            // 
            // llRemoveImage
            // 
            this.llRemoveImage.Location = new System.Drawing.Point(825, 290);
            this.llRemoveImage.Name = "llRemoveImage";
            this.llRemoveImage.Size = new System.Drawing.Size(100, 23);
            this.llRemoveImage.TabIndex = 25;
            this.llRemoveImage.TabStop = true;
            this.llRemoveImage.Text = "Remove";
            // 
            // btnSave
            // 
            this.btnSave.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.btnSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSave.ForeColor = System.Drawing.Color.White;
            this.btnSave.Location = new System.Drawing.Point(830, 460);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(130, 45);
            this.btnSave.TabIndex = 3;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = false;
            // 
            // btnClose
            // 
            this.btnClose.BackColor = System.Drawing.Color.White;
            this.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClose.Location = new System.Drawing.Point(685, 460);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(130, 45);
            this.btnClose.TabIndex = 4;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = false;
            // 
            // frmAddUpdatePerson
            // 
            this.ClientSize = new System.Drawing.Size(1000, 600);
            this.Controls.Add(this.pnlMainContent);
            this.Controls.Add(this.pnlHeader);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.Name = "frmAddUpdatePerson";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.pnlHeader.ResumeLayout(false);
            this.pnlMainContent.ResumeLayout(false);
            this.gbDetails.ResumeLayout(false);
            this.gbDetails.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbPersonImage)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel pnlHeader;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Panel pnlMainContent;
        private System.Windows.Forms.GroupBox gbDetails;
        private System.Windows.Forms.Label lblFName, lblSName, lblTName, lblLName, lblNationalNo, lblGander, lblEmail, lblAddress, lblDateOfBirth, lblPhone, lblCountry;
        private System.Windows.Forms.TextBox txtFirstName, txtSecondName, txtThirdName, txtLastName, txtNationalNo, txtPhone, txtEmail, txtAddress;
        private System.Windows.Forms.DateTimePicker dtpDateOfBirth;
        private System.Windows.Forms.RadioButton rbMale, rbFemale;
        private System.Windows.Forms.ComboBox cbCountry;
        private System.Windows.Forms.PictureBox pbPersonImage;
        private System.Windows.Forms.LinkLabel llSetImage, llRemoveImage;
        private System.Windows.Forms.Button btnSave, btnClose;
        private System.Windows.Forms.Label lblPersonID, label1;
    }
}