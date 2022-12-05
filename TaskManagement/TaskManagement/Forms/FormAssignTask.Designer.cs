namespace TaskManagement.Forms
{
    partial class FormAssignTask
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
            this.labelDescription = new System.Windows.Forms.Label();
            this.lblTask = new System.Windows.Forms.Label();
            this.lblAssignTo = new System.Windows.Forms.Label();
            this.lblStartDate = new System.Windows.Forms.Label();
            this.lblEnddate = new System.Windows.Forms.Label();
            this.lblStatus = new System.Windows.Forms.Label();
            this.txtDescription = new System.Windows.Forms.TextBox();
            this.ddlTask = new System.Windows.Forms.ComboBox();
            this.dtpEndDate = new System.Windows.Forms.DateTimePicker();
            this.dtpStartDate = new System.Windows.Forms.DateTimePicker();
            this.ddlAssignTo = new System.Windows.Forms.ComboBox();
            this.ddlStatus = new System.Windows.Forms.ComboBox();
            this.btnAssign = new System.Windows.Forms.Button();
            this.grdAssignDetails = new System.Windows.Forms.DataGridView();
            this.TaskDetailsId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TaskId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.EmployeeId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.EmployeeName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TaskName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.StartDate = new ComponentFactory.Krypton.Toolkit.KryptonDataGridViewDateTimePickerColumn();
            this.EndDate = new ComponentFactory.Krypton.Toolkit.KryptonDataGridViewDateTimePickerColumn();
            this.Status = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Delete = new System.Windows.Forms.DataGridViewButtonColumn();
            this.Edit = new System.Windows.Forms.DataGridViewButtonColumn();
            this.DueDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.grdAssignDetails)).BeginInit();
            this.SuspendLayout();
            // 
            // labelDescription
            // 
            this.labelDescription.AutoSize = true;
            this.labelDescription.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelDescription.ForeColor = System.Drawing.Color.Gainsboro;
            this.labelDescription.Location = new System.Drawing.Point(27, 106);
            this.labelDescription.Name = "labelDescription";
            this.labelDescription.Size = new System.Drawing.Size(109, 25);
            this.labelDescription.TabIndex = 18;
            this.labelDescription.Text = "Description";
            // 
            // lblTask
            // 
            this.lblTask.AutoSize = true;
            this.lblTask.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTask.ForeColor = System.Drawing.Color.Gainsboro;
            this.lblTask.Location = new System.Drawing.Point(27, 28);
            this.lblTask.Name = "lblTask";
            this.lblTask.Size = new System.Drawing.Size(56, 25);
            this.lblTask.TabIndex = 17;
            this.lblTask.Text = "Task";
            // 
            // lblAssignTo
            // 
            this.lblAssignTo.AutoSize = true;
            this.lblAssignTo.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAssignTo.ForeColor = System.Drawing.Color.Gainsboro;
            this.lblAssignTo.Location = new System.Drawing.Point(27, 184);
            this.lblAssignTo.Name = "lblAssignTo";
            this.lblAssignTo.Size = new System.Drawing.Size(101, 25);
            this.lblAssignTo.TabIndex = 19;
            this.lblAssignTo.Text = "Assign To";
            // 
            // lblStartDate
            // 
            this.lblStartDate.AutoSize = true;
            this.lblStartDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStartDate.ForeColor = System.Drawing.Color.Gainsboro;
            this.lblStartDate.Location = new System.Drawing.Point(27, 262);
            this.lblStartDate.Name = "lblStartDate";
            this.lblStartDate.Size = new System.Drawing.Size(99, 25);
            this.lblStartDate.TabIndex = 20;
            this.lblStartDate.Text = "Start Date";
            // 
            // lblEnddate
            // 
            this.lblEnddate.AutoSize = true;
            this.lblEnddate.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEnddate.ForeColor = System.Drawing.Color.Gainsboro;
            this.lblEnddate.Location = new System.Drawing.Point(27, 340);
            this.lblEnddate.Name = "lblEnddate";
            this.lblEnddate.Size = new System.Drawing.Size(93, 25);
            this.lblEnddate.TabIndex = 21;
            this.lblEnddate.Text = "End Date";
            // 
            // lblStatus
            // 
            this.lblStatus.AutoSize = true;
            this.lblStatus.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStatus.ForeColor = System.Drawing.Color.Gainsboro;
            this.lblStatus.Location = new System.Drawing.Point(27, 418);
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(68, 25);
            this.lblStatus.TabIndex = 22;
            this.lblStatus.Text = "Status";
            // 
            // txtDescription
            // 
            this.txtDescription.Location = new System.Drawing.Point(260, 105);
            this.txtDescription.Name = "txtDescription";
            this.txtDescription.ReadOnly = true;
            this.txtDescription.Size = new System.Drawing.Size(378, 26);
            this.txtDescription.TabIndex = 23;
            // 
            // ddlTask
            // 
            this.ddlTask.FormattingEnabled = true;
            this.ddlTask.Location = new System.Drawing.Point(260, 28);
            this.ddlTask.Name = "ddlTask";
            this.ddlTask.Size = new System.Drawing.Size(378, 28);
            this.ddlTask.TabIndex = 24;
            this.ddlTask.Text = "--Select Task--";
            this.ddlTask.SelectedIndexChanged += new System.EventHandler(this.ddlTask_SelectedIndexChanged);
            // 
            // dtpEndDate
            // 
            this.dtpEndDate.Location = new System.Drawing.Point(260, 340);
            this.dtpEndDate.Name = "dtpEndDate";
            this.dtpEndDate.Size = new System.Drawing.Size(378, 26);
            this.dtpEndDate.TabIndex = 25;
            // 
            // dtpStartDate
            // 
            this.dtpStartDate.Location = new System.Drawing.Point(260, 261);
            this.dtpStartDate.Name = "dtpStartDate";
            this.dtpStartDate.Size = new System.Drawing.Size(378, 26);
            this.dtpStartDate.TabIndex = 26;
            // 
            // ddlAssignTo
            // 
            this.ddlAssignTo.FormattingEnabled = true;
            this.ddlAssignTo.Location = new System.Drawing.Point(260, 185);
            this.ddlAssignTo.Name = "ddlAssignTo";
            this.ddlAssignTo.Size = new System.Drawing.Size(378, 28);
            this.ddlAssignTo.TabIndex = 27;
            this.ddlAssignTo.Text = "--Select Employee--";
            this.ddlAssignTo.SelectedIndexChanged += new System.EventHandler(this.ddlAssignTo_SelectedIndexChanged);
            // 
            // ddlStatus
            // 
            this.ddlStatus.FormattingEnabled = true;
            this.ddlStatus.Location = new System.Drawing.Point(260, 419);
            this.ddlStatus.Name = "ddlStatus";
            this.ddlStatus.Size = new System.Drawing.Size(378, 28);
            this.ddlStatus.TabIndex = 28;
            this.ddlStatus.Text = "--Select Status--";
            // 
            // btnAssign
            // 
            this.btnAssign.Location = new System.Drawing.Point(260, 520);
            this.btnAssign.Name = "btnAssign";
            this.btnAssign.Size = new System.Drawing.Size(121, 38);
            this.btnAssign.TabIndex = 29;
            this.btnAssign.Text = "Add";
            this.btnAssign.UseVisualStyleBackColor = true;
            this.btnAssign.Click += new System.EventHandler(this.btnAssign_Click);
            // 
            // grdAssignDetails
            // 
            this.grdAssignDetails.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grdAssignDetails.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.TaskDetailsId,
            this.TaskId,
            this.EmployeeId,
            this.EmployeeName,
            this.TaskName,
            this.StartDate,
            this.EndDate,
            this.Status,
            this.Delete,
            this.Edit,
            this.DueDate});
            this.grdAssignDetails.Location = new System.Drawing.Point(32, 605);
            this.grdAssignDetails.Name = "grdAssignDetails";
            this.grdAssignDetails.RowHeadersVisible = false;
            this.grdAssignDetails.RowHeadersWidth = 62;
            this.grdAssignDetails.RowTemplate.Height = 28;
            this.grdAssignDetails.Size = new System.Drawing.Size(1592, 347);
            this.grdAssignDetails.TabIndex = 30;
            this.grdAssignDetails.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.grdAssignDetails_CellContentClick);
            // 
            // TaskDetailsId
            // 
            this.TaskDetailsId.DataPropertyName = "TaskDetailsId";
            this.TaskDetailsId.HeaderText = "TaskDetailsId";
            this.TaskDetailsId.MinimumWidth = 8;
            this.TaskDetailsId.Name = "TaskDetailsId";
            this.TaskDetailsId.ReadOnly = true;
            this.TaskDetailsId.Visible = false;
            this.TaskDetailsId.Width = 150;
            // 
            // TaskId
            // 
            this.TaskId.DataPropertyName = "TaskId";
            this.TaskId.HeaderText = "TaskId";
            this.TaskId.MinimumWidth = 8;
            this.TaskId.Name = "TaskId";
            this.TaskId.ReadOnly = true;
            this.TaskId.Visible = false;
            this.TaskId.Width = 150;
            // 
            // EmployeeId
            // 
            this.EmployeeId.DataPropertyName = "EmployeeId";
            this.EmployeeId.HeaderText = "EmployeeId";
            this.EmployeeId.MinimumWidth = 8;
            this.EmployeeId.Name = "EmployeeId";
            this.EmployeeId.ReadOnly = true;
            this.EmployeeId.Visible = false;
            this.EmployeeId.Width = 150;
            // 
            // EmployeeName
            // 
            this.EmployeeName.DataPropertyName = "EmployeeName";
            this.EmployeeName.HeaderText = "Employee";
            this.EmployeeName.MinimumWidth = 8;
            this.EmployeeName.Name = "EmployeeName";
            this.EmployeeName.ReadOnly = true;
            this.EmployeeName.Width = 150;
            // 
            // TaskName
            // 
            this.TaskName.DataPropertyName = "TaskName";
            this.TaskName.HeaderText = "Task";
            this.TaskName.MinimumWidth = 8;
            this.TaskName.Name = "TaskName";
            this.TaskName.ReadOnly = true;
            this.TaskName.Width = 150;
            // 
            // StartDate
            // 
            this.StartDate.Checked = false;
            this.StartDate.DataPropertyName = "StartDate";
            this.StartDate.HeaderText = "StartDate";
            this.StartDate.MinimumWidth = 8;
            this.StartDate.Name = "StartDate";
            this.StartDate.ReadOnly = true;
            this.StartDate.Width = 150;
            // 
            // EndDate
            // 
            this.EndDate.Checked = false;
            this.EndDate.DataPropertyName = "EndDate";
            this.EndDate.HeaderText = "EndDate";
            this.EndDate.MinimumWidth = 8;
            this.EndDate.Name = "EndDate";
            this.EndDate.ReadOnly = true;
            this.EndDate.Width = 150;
            // 
            // Status
            // 
            this.Status.DataPropertyName = "Status";
            this.Status.HeaderText = "Status";
            this.Status.MinimumWidth = 8;
            this.Status.Name = "Status";
            this.Status.ReadOnly = true;
            this.Status.Width = 150;
            // 
            // Delete
            // 
            this.Delete.HeaderText = "Delete";
            this.Delete.MinimumWidth = 8;
            this.Delete.Name = "Delete";
            this.Delete.Text = "Delete";
            this.Delete.UseColumnTextForButtonValue = true;
            this.Delete.Width = 150;
            // 
            // Edit
            // 
            this.Edit.HeaderText = "Edit";
            this.Edit.MinimumWidth = 8;
            this.Edit.Name = "Edit";
            this.Edit.Text = "Edit";
            this.Edit.UseColumnTextForButtonValue = true;
            this.Edit.Width = 150;
            // 
            // DueDate
            // 
            this.DueDate.DataPropertyName = "DueDate";
            this.DueDate.HeaderText = "DueDate";
            this.DueDate.MinimumWidth = 8;
            this.DueDate.Name = "DueDate";
            this.DueDate.ReadOnly = true;
            this.DueDate.Visible = false;
            this.DueDate.Width = 150;
            // 
            // FormAssignTask
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(33)))), ((int)(((byte)(74)))));
            this.ClientSize = new System.Drawing.Size(1669, 976);
            this.Controls.Add(this.grdAssignDetails);
            this.Controls.Add(this.btnAssign);
            this.Controls.Add(this.ddlStatus);
            this.Controls.Add(this.ddlAssignTo);
            this.Controls.Add(this.dtpStartDate);
            this.Controls.Add(this.dtpEndDate);
            this.Controls.Add(this.ddlTask);
            this.Controls.Add(this.txtDescription);
            this.Controls.Add(this.lblStatus);
            this.Controls.Add(this.lblEnddate);
            this.Controls.Add(this.lblStartDate);
            this.Controls.Add(this.lblAssignTo);
            this.Controls.Add(this.labelDescription);
            this.Controls.Add(this.lblTask);
            this.Name = "FormAssignTask";
            this.Text = "FormAssignTask";
            ((System.ComponentModel.ISupportInitialize)(this.grdAssignDetails)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelDescription;
        private System.Windows.Forms.Label lblTask;
        private System.Windows.Forms.Label lblAssignTo;
        private System.Windows.Forms.Label lblStartDate;
        private System.Windows.Forms.Label lblEnddate;
        private System.Windows.Forms.Label lblStatus;
        private System.Windows.Forms.TextBox txtDescription;
        private System.Windows.Forms.ComboBox ddlTask;
        private System.Windows.Forms.DateTimePicker dtpEndDate;
        private System.Windows.Forms.DateTimePicker dtpStartDate;
        private System.Windows.Forms.ComboBox ddlAssignTo;
        private System.Windows.Forms.ComboBox ddlStatus;
        private System.Windows.Forms.Button btnAssign;
        private System.Windows.Forms.DataGridView grdAssignDetails;
        private System.Windows.Forms.DataGridViewTextBoxColumn TaskDetailsId;
        private System.Windows.Forms.DataGridViewTextBoxColumn TaskId;
        private System.Windows.Forms.DataGridViewTextBoxColumn EmployeeId;
        private System.Windows.Forms.DataGridViewTextBoxColumn EmployeeName;
        private System.Windows.Forms.DataGridViewTextBoxColumn TaskName;
        private ComponentFactory.Krypton.Toolkit.KryptonDataGridViewDateTimePickerColumn StartDate;
        private ComponentFactory.Krypton.Toolkit.KryptonDataGridViewDateTimePickerColumn EndDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn Status;
        private System.Windows.Forms.DataGridViewButtonColumn Delete;
        private System.Windows.Forms.DataGridViewButtonColumn Edit;
        private System.Windows.Forms.DataGridViewTextBoxColumn DueDate;
    }
}