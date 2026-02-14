namespace BankSystem.Applications.ManageApplications
{
    partial class frmListApplications
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.pnlHeader = new System.Windows.Forms.Panel();
            this.pnlHeaderIcon = new System.Windows.Forms.Panel();
            this.pbHeaderIcon = new System.Windows.Forms.PictureBox();
            this.lblSubtitle = new System.Windows.Forms.Label();
            this.lblTitle = new System.Windows.Forms.Label();
            this.pnlToolbar = new System.Windows.Forms.Panel();
            this.btnRefresh = new System.Windows.Forms.Button();
            this.btnExport = new System.Windows.Forms.Button();
            this.btnAddApplication = new System.Windows.Forms.Button();
            this.pnlSeparator = new System.Windows.Forms.Panel();
            this.pnlFilters = new System.Windows.Forms.Panel();
            this.pnlFilterContainer = new System.Windows.Forms.Panel();
            this.txtFilterValue = new System.Windows.Forms.TextBox();
            this.cbFilterBy = new System.Windows.Forms.ComboBox();
            this.lblFilterBy = new System.Windows.Forms.Label();
            this.dgvApplications = new System.Windows.Forms.DataGridView();
            this.cmsApplications = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.showDetailsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.editToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.duplicateToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.changeStatusToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.approveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.rejectToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.suspendToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.deleteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pnlStatusBar = new System.Windows.Forms.Panel();
            this.lblLoadingStatus = new System.Windows.Forms.Label();
            this.progressBar = new System.Windows.Forms.ProgressBar();
            this.pnlRecordInfo = new System.Windows.Forms.Panel();
            this.lblLastUpdated = new System.Windows.Forms.Label();
            this.lblRecordCount = new System.Windows.Forms.Label();
            this.lblRecordText = new System.Windows.Forms.Label();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.pnlHeader.SuspendLayout();
            this.pnlHeaderIcon.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbHeaderIcon)).BeginInit();
            this.pnlToolbar.SuspendLayout();
            this.pnlFilters.SuspendLayout();
            this.pnlFilterContainer.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvApplications)).BeginInit();
            this.cmsApplications.SuspendLayout();
            this.pnlStatusBar.SuspendLayout();
            this.pnlRecordInfo.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlHeader
            // 
            this.pnlHeader.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(53)))), ((int)(((byte)(65)))));
            this.pnlHeader.Controls.Add(this.pnlHeaderIcon);
            this.pnlHeader.Controls.Add(this.lblSubtitle);
            this.pnlHeader.Controls.Add(this.lblTitle);
            this.pnlHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlHeader.Location = new System.Drawing.Point(0, 0);
            this.pnlHeader.Name = "pnlHeader";
            this.pnlHeader.Size = new System.Drawing.Size(1200, 90);
            this.pnlHeader.TabIndex = 0;
            // 
            // pnlHeaderIcon
            // 
            this.pnlHeaderIcon.Controls.Add(this.pbHeaderIcon);
            this.pnlHeaderIcon.Location = new System.Drawing.Point(20, 15);
            this.pnlHeaderIcon.Name = "pnlHeaderIcon";
            this.pnlHeaderIcon.Size = new System.Drawing.Size(60, 60);
            this.pnlHeaderIcon.TabIndex = 2;
            // 
            // pbHeaderIcon
            // 
            this.pbHeaderIcon.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pbHeaderIcon.Location = new System.Drawing.Point(0, 0);
            this.pbHeaderIcon.Name = "pbHeaderIcon";
            this.pbHeaderIcon.Size = new System.Drawing.Size(60, 60);
            this.pbHeaderIcon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbHeaderIcon.TabIndex = 0;
            this.pbHeaderIcon.TabStop = false;
            // 
            // lblSubtitle
            // 
            this.lblSubtitle.AutoSize = true;
            this.lblSubtitle.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.lblSubtitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(189)))), ((int)(((byte)(195)))), ((int)(((byte)(199)))));
            this.lblSubtitle.Location = new System.Drawing.Point(97, 50);
            this.lblSubtitle.Name = "lblSubtitle";
            this.lblSubtitle.Size = new System.Drawing.Size(272, 20);
            this.lblSubtitle.TabIndex = 3;
            this.lblSubtitle.Text = "View, manage and track all applications";
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Segoe UI", 22F, System.Drawing.FontStyle.Bold);
            this.lblTitle.ForeColor = System.Drawing.Color.White;
            this.lblTitle.Location = new System.Drawing.Point(94, 15);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(317, 41);
            this.lblTitle.TabIndex = 4;
            this.lblTitle.Text = "Manage Applications";
            // 
            // pnlToolbar
            // 
            this.pnlToolbar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(250)))), ((int)(((byte)(250)))));
            this.pnlToolbar.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlToolbar.Controls.Add(this.btnRefresh);
            this.pnlToolbar.Controls.Add(this.btnExport);
            this.pnlToolbar.Controls.Add(this.btnAddApplication);
            this.pnlToolbar.Controls.Add(this.pnlSeparator);
            this.pnlToolbar.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlToolbar.Location = new System.Drawing.Point(0, 90);
            this.pnlToolbar.Name = "pnlToolbar";
            this.pnlToolbar.Size = new System.Drawing.Size(1200, 55);
            this.pnlToolbar.TabIndex = 3;
            // 
            // btnRefresh
            // 
            this.btnRefresh.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(108)))), ((int)(((byte)(117)))), ((int)(((byte)(125)))));
            this.btnRefresh.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRefresh.ForeColor = System.Drawing.Color.White;
            this.btnRefresh.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnRefresh.Location = new System.Drawing.Point(220, 10);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(100, 35);
            this.btnRefresh.TabIndex = 0;
            this.btnRefresh.Text = "Refresh";
            this.btnRefresh.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnRefresh.UseVisualStyleBackColor = false;
            // 
            // btnExport
            // 
            this.btnExport.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(162)))), ((int)(((byte)(184)))));
            this.btnExport.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExport.ForeColor = System.Drawing.Color.White;
            this.btnExport.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnExport.Location = new System.Drawing.Point(115, 10);
            this.btnExport.Name = "btnExport";
            this.btnExport.Size = new System.Drawing.Size(95, 35);
            this.btnExport.TabIndex = 1;
            this.btnExport.Text = "Export";
            this.btnExport.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnExport.UseVisualStyleBackColor = false;
            // 
            // btnAddApplication
            // 
            this.btnAddApplication.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(167)))), ((int)(((byte)(69)))));
            this.btnAddApplication.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddApplication.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.btnAddApplication.ForeColor = System.Drawing.Color.White;
            this.btnAddApplication.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAddApplication.Location = new System.Drawing.Point(15, 10);
            this.btnAddApplication.Name = "btnAddApplication";
            this.btnAddApplication.Size = new System.Drawing.Size(90, 35);
            this.btnAddApplication.TabIndex = 2;
            this.btnAddApplication.Text = "Add";
            this.btnAddApplication.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnAddApplication.UseVisualStyleBackColor = false;
            // 
            // pnlSeparator
            // 
            this.pnlSeparator.Location = new System.Drawing.Point(0, 0);
            this.pnlSeparator.Name = "pnlSeparator";
            this.pnlSeparator.Size = new System.Drawing.Size(200, 100);
            this.pnlSeparator.TabIndex = 3;
            // 
            // pnlFilters
            // 
            this.pnlFilters.BackColor = System.Drawing.Color.White;
            this.pnlFilters.Controls.Add(this.pnlFilterContainer);
            this.pnlFilters.Controls.Add(this.lblFilterBy);
            this.pnlFilters.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlFilters.Location = new System.Drawing.Point(0, 145);
            this.pnlFilters.Name = "pnlFilters";
            this.pnlFilters.Size = new System.Drawing.Size(1200, 60);
            this.pnlFilters.TabIndex = 2;
            this.pnlFilters.Paint += new System.Windows.Forms.PaintEventHandler(this.pnlFilters_Paint);
            // 
            // pnlFilterContainer
            // 
            this.pnlFilterContainer.Controls.Add(this.txtFilterValue);
            this.pnlFilterContainer.Controls.Add(this.cbFilterBy);
            this.pnlFilterContainer.Location = new System.Drawing.Point(90, 15);
            this.pnlFilterContainer.Name = "pnlFilterContainer";
            this.pnlFilterContainer.Size = new System.Drawing.Size(470, 30);
            this.pnlFilterContainer.TabIndex = 1;
            // 
            // txtFilterValue
            // 
            this.txtFilterValue.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtFilterValue.Location = new System.Drawing.Point(180, 2);
            this.txtFilterValue.Name = "txtFilterValue";
            this.txtFilterValue.Size = new System.Drawing.Size(280, 20);
            this.txtFilterValue.TabIndex = 0;
            // 
            // cbFilterBy
            // 
            this.cbFilterBy.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbFilterBy.Items.AddRange(new object[] {
            "None",
            "Application ID",
            "Person ID",
            "Full Name",
            "Status",
            "Application Type",
            "Created By"});
            this.cbFilterBy.Location = new System.Drawing.Point(0, 2);
            this.cbFilterBy.Name = "cbFilterBy";
            this.cbFilterBy.Size = new System.Drawing.Size(170, 21);
            this.cbFilterBy.TabIndex = 1;
            // 
            // lblFilterBy
            // 
            this.lblFilterBy.AutoSize = true;
            this.lblFilterBy.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.lblFilterBy.Location = new System.Drawing.Point(20, 20);
            this.lblFilterBy.Name = "lblFilterBy";
            this.lblFilterBy.Size = new System.Drawing.Size(68, 19);
            this.lblFilterBy.TabIndex = 2;
            this.lblFilterBy.Text = "Filter By:";
            // 
            // dgvApplications
            // 
            this.dgvApplications.AllowUserToAddRows = false;
            this.dgvApplications.AllowUserToDeleteRows = false;
            this.dgvApplications.BackgroundColor = System.Drawing.Color.White;
            this.dgvApplications.BorderStyle = System.Windows.Forms.BorderStyle.None;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(249)))), ((int)(((byte)(250)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.dgvApplications.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvApplications.ColumnHeadersHeight = 45;
            this.dgvApplications.ContextMenuStrip = this.cmsApplications;
            this.dgvApplications.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvApplications.EnableHeadersVisualStyles = false;
            this.dgvApplications.Location = new System.Drawing.Point(20, 0);
            this.dgvApplications.Name = "dgvApplications";
            this.dgvApplications.ReadOnly = true;
            this.dgvApplications.RowHeadersVisible = false;
            this.dgvApplications.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvApplications.Size = new System.Drawing.Size(1160, 395);
            this.dgvApplications.TabIndex = 0;
            // 
            // cmsApplications
            // 
            this.cmsApplications.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.showDetailsToolStripMenuItem,
            this.toolStripSeparator1,
            this.editToolStripMenuItem,
            this.duplicateToolStripMenuItem,
            this.toolStripSeparator2,
            this.changeStatusToolStripMenuItem,
            this.toolStripSeparator3,
            this.deleteToolStripMenuItem});
            this.cmsApplications.Name = "cmsApplications";
            this.cmsApplications.Size = new System.Drawing.Size(159, 132);
            // 
            // showDetailsToolStripMenuItem
            // 
            this.showDetailsToolStripMenuItem.Name = "showDetailsToolStripMenuItem";
            this.showDetailsToolStripMenuItem.Size = new System.Drawing.Size(158, 22);
            this.showDetailsToolStripMenuItem.Text = "Show Details";
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(155, 6);
            // 
            // editToolStripMenuItem
            // 
            this.editToolStripMenuItem.Name = "editToolStripMenuItem";
            this.editToolStripMenuItem.Size = new System.Drawing.Size(158, 22);
            this.editToolStripMenuItem.Text = "Edit Application";
            // 
            // duplicateToolStripMenuItem
            // 
            this.duplicateToolStripMenuItem.Name = "duplicateToolStripMenuItem";
            this.duplicateToolStripMenuItem.Size = new System.Drawing.Size(158, 22);
            this.duplicateToolStripMenuItem.Text = "Duplicate";
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(155, 6);
            // 
            // changeStatusToolStripMenuItem
            // 
            this.changeStatusToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.approveToolStripMenuItem,
            this.rejectToolStripMenuItem,
            this.suspendToolStripMenuItem});
            this.changeStatusToolStripMenuItem.Name = "changeStatusToolStripMenuItem";
            this.changeStatusToolStripMenuItem.Size = new System.Drawing.Size(158, 22);
            this.changeStatusToolStripMenuItem.Text = "Change Status";
            // 
            // approveToolStripMenuItem
            // 
            this.approveToolStripMenuItem.Name = "approveToolStripMenuItem";
            this.approveToolStripMenuItem.Size = new System.Drawing.Size(119, 22);
            this.approveToolStripMenuItem.Text = "Approve";
            // 
            // rejectToolStripMenuItem
            // 
            this.rejectToolStripMenuItem.Name = "rejectToolStripMenuItem";
            this.rejectToolStripMenuItem.Size = new System.Drawing.Size(119, 22);
            this.rejectToolStripMenuItem.Text = "Reject";
            // 
            // suspendToolStripMenuItem
            // 
            this.suspendToolStripMenuItem.Name = "suspendToolStripMenuItem";
            this.suspendToolStripMenuItem.Size = new System.Drawing.Size(119, 22);
            this.suspendToolStripMenuItem.Text = "Suspend";
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(155, 6);
            // 
            // deleteToolStripMenuItem
            // 
            this.deleteToolStripMenuItem.Name = "deleteToolStripMenuItem";
            this.deleteToolStripMenuItem.Size = new System.Drawing.Size(158, 22);
            this.deleteToolStripMenuItem.Text = "Delete";
            // 
            // pnlStatusBar
            // 
            this.pnlStatusBar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(249)))), ((int)(((byte)(250)))));
            this.pnlStatusBar.Controls.Add(this.lblLoadingStatus);
            this.pnlStatusBar.Controls.Add(this.progressBar);
            this.pnlStatusBar.Controls.Add(this.pnlRecordInfo);
            this.pnlStatusBar.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnlStatusBar.Location = new System.Drawing.Point(0, 600);
            this.pnlStatusBar.Name = "pnlStatusBar";
            this.pnlStatusBar.Size = new System.Drawing.Size(1200, 35);
            this.pnlStatusBar.TabIndex = 4;
            // 
            // lblLoadingStatus
            // 
            this.lblLoadingStatus.Location = new System.Drawing.Point(0, 0);
            this.lblLoadingStatus.Name = "lblLoadingStatus";
            this.lblLoadingStatus.Size = new System.Drawing.Size(100, 23);
            this.lblLoadingStatus.TabIndex = 0;
            // 
            // progressBar
            // 
            this.progressBar.Location = new System.Drawing.Point(0, 0);
            this.progressBar.Name = "progressBar";
            this.progressBar.Size = new System.Drawing.Size(100, 23);
            this.progressBar.TabIndex = 1;
            // 
            // pnlRecordInfo
            // 
            this.pnlRecordInfo.Controls.Add(this.lblLastUpdated);
            this.pnlRecordInfo.Controls.Add(this.lblRecordCount);
            this.pnlRecordInfo.Controls.Add(this.lblRecordText);
            this.pnlRecordInfo.Dock = System.Windows.Forms.DockStyle.Right;
            this.pnlRecordInfo.Location = new System.Drawing.Point(852, 0);
            this.pnlRecordInfo.Name = "pnlRecordInfo";
            this.pnlRecordInfo.Size = new System.Drawing.Size(348, 35);
            this.pnlRecordInfo.TabIndex = 2;
            // 
            // lblLastUpdated
            // 
            this.lblLastUpdated.AutoSize = true;
            this.lblLastUpdated.Font = new System.Drawing.Font("Segoe UI", 8F);
            this.lblLastUpdated.Location = new System.Drawing.Point(180, 8);
            this.lblLastUpdated.Name = "lblLastUpdated";
            this.lblLastUpdated.Size = new System.Drawing.Size(93, 13);
            this.lblLastUpdated.TabIndex = 0;
            this.lblLastUpdated.Text = "Last Update: --:--";
            // 
            // lblRecordCount
            // 
            this.lblRecordCount.AutoSize = true;
            this.lblRecordCount.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.lblRecordCount.Location = new System.Drawing.Point(100, 8);
            this.lblRecordCount.Name = "lblRecordCount";
            this.lblRecordCount.Size = new System.Drawing.Size(14, 15);
            this.lblRecordCount.TabIndex = 1;
            this.lblRecordCount.Text = "0";
            // 
            // lblRecordText
            // 
            this.lblRecordText.AutoSize = true;
            this.lblRecordText.Location = new System.Drawing.Point(10, 8);
            this.lblRecordText.Name = "lblRecordText";
            this.lblRecordText.Size = new System.Drawing.Size(77, 13);
            this.lblRecordText.TabIndex = 2;
            this.lblRecordText.Text = "Total Records:";
            // 
            // frmListApplications
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1200, 635);
            this.Controls.Add(this.pnlFilters);
            this.Controls.Add(this.pnlToolbar);
            this.Controls.Add(this.pnlHeader);
            this.Controls.Add(this.pnlStatusBar);
            this.Name = "frmListApplications";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Manage Applications";
            this.pnlHeader.ResumeLayout(false);
            this.pnlHeader.PerformLayout();
            this.pnlHeaderIcon.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pbHeaderIcon)).EndInit();
            this.pnlToolbar.ResumeLayout(false);
            this.pnlFilters.ResumeLayout(false);
            this.pnlFilters.PerformLayout();
            this.pnlFilterContainer.ResumeLayout(false);
            this.pnlFilterContainer.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvApplications)).EndInit();
            this.cmsApplications.ResumeLayout(false);
            this.pnlStatusBar.ResumeLayout(false);
            this.pnlRecordInfo.ResumeLayout(false);
            this.pnlRecordInfo.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlHeader; private System.Windows.Forms.Panel pnlHeaderIcon; private System.Windows.Forms.PictureBox pbHeaderIcon; private System.Windows.Forms.Label lblSubtitle; private System.Windows.Forms.Label lblTitle; private System.Windows.Forms.Panel pnlToolbar; private System.Windows.Forms.Button btnRefresh; private System.Windows.Forms.Button btnExport; private System.Windows.Forms.Button btnAddApplication; private System.Windows.Forms.Panel pnlSeparator; private System.Windows.Forms.Panel pnlFilters; private System.Windows.Forms.Panel pnlFilterContainer; private System.Windows.Forms.TextBox txtFilterValue; private System.Windows.Forms.ComboBox cbFilterBy; private System.Windows.Forms.Label lblFilterBy; private System.Windows.Forms.DataGridView dgvApplications; private System.Windows.Forms.Panel pnlStatusBar; private System.Windows.Forms.Label lblLoadingStatus; private System.Windows.Forms.ProgressBar progressBar; private System.Windows.Forms.Panel pnlRecordInfo; private System.Windows.Forms.Label lblLastUpdated; private System.Windows.Forms.Label lblRecordCount; private System.Windows.Forms.Label lblRecordText; private System.Windows.Forms.ContextMenuStrip cmsApplications; private System.Windows.Forms.ToolStripMenuItem showDetailsToolStripMenuItem; private System.Windows.Forms.ToolStripSeparator toolStripSeparator1; private System.Windows.Forms.ToolStripMenuItem editToolStripMenuItem; private System.Windows.Forms.ToolStripMenuItem duplicateToolStripMenuItem; private System.Windows.Forms.ToolStripSeparator toolStripSeparator2; private System.Windows.Forms.ToolStripMenuItem changeStatusToolStripMenuItem; private System.Windows.Forms.ToolStripMenuItem approveToolStripMenuItem; private System.Windows.Forms.ToolStripMenuItem rejectToolStripMenuItem; private System.Windows.Forms.ToolStripMenuItem suspendToolStripMenuItem; private System.Windows.Forms.ToolStripSeparator toolStripSeparator3; private System.Windows.Forms.ToolStripMenuItem deleteToolStripMenuItem; private System.Windows.Forms.ToolTip toolTip1; private System.Windows.Forms.Timer timer1;
    }
}