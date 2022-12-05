namespace TaskManagement.Forms
{
    partial class FormStatus
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
            this.grdTaskAssign = new System.Windows.Forms.DataGridView();
            this.TaskDetailsId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TaskId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.EmployeeId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.EmployeeName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TaskName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.StartDate = new ComponentFactory.Krypton.Toolkit.KryptonDataGridViewDateTimePickerColumn();
            this.EndDate = new ComponentFactory.Krypton.Toolkit.KryptonDataGridViewDateTimePickerColumn();
            this.DueDate = new ComponentFactory.Krypton.Toolkit.KryptonDataGridViewDateTimePickerColumn();
            this.label1 = new System.Windows.Forms.Label();
            this.txtEmployee = new System.Windows.Forms.TextBox();
            this.btnSearch = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtTask = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.ddlStatus = new System.Windows.Forms.ComboBox();
            this.btnReset = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.grdTaskAssign)).BeginInit();
            this.SuspendLayout();
            // 
            // grdTaskAssign
            // 
            this.grdTaskAssign.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grdTaskAssign.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.TaskDetailsId,
            this.TaskId,
            this.EmployeeId,
            this.EmployeeName,
            this.TaskName,
            this.StartDate,
            this.EndDate,
            this.DueDate});
            this.grdTaskAssign.Location = new System.Drawing.Point(61, 285);
            this.grdTaskAssign.Name = "grdTaskAssign";
            this.grdTaskAssign.RowHeadersWidth = 62;
            this.grdTaskAssign.RowTemplate.Height = 28;
            this.grdTaskAssign.Size = new System.Drawing.Size(1205, 356);
            this.grdTaskAssign.TabIndex = 0;
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
            // DueDate
            // 
            this.DueDate.Checked = false;
            this.DueDate.DataPropertyName = "DueDate";
            this.DueDate.HeaderText = "DueDate";
            this.DueDate.MinimumWidth = 8;
            this.DueDate.Name = "DueDate";
            this.DueDate.ReadOnly = true;
            this.DueDate.Visible = false;
            this.DueDate.Width = 150;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.Gainsboro;
            this.label1.Location = new System.Drawing.Point(22, 76);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(78, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "SearchBy";
            // 
            // txtEmployee
            // 
            this.txtEmployee.Location = new System.Drawing.Point(153, 73);
            this.txtEmployee.Name = "txtEmployee";
            this.txtEmployee.Size = new System.Drawing.Size(214, 26);
            this.txtEmployee.TabIndex = 2;
            // 
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point(153, 157);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(76, 42);
            this.btnSearch.TabIndex = 3;
            this.btnSearch.Text = "Search";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.Gainsboro;
            this.label2.Location = new System.Drawing.Point(149, 41);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(79, 20);
            this.label2.TabIndex = 4;
            this.label2.Text = "Employee";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.Color.Gainsboro;
            this.label3.Location = new System.Drawing.Point(386, 41);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(43, 20);
            this.label3.TabIndex = 6;
            this.label3.Text = "Task";
            // 
            // txtTask
            // 
            this.txtTask.Location = new System.Drawing.Point(390, 73);
            this.txtTask.Name = "txtTask";
            this.txtTask.Size = new System.Drawing.Size(214, 26);
            this.txtTask.TabIndex = 5;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.Color.Gainsboro;
            this.label4.Location = new System.Drawing.Point(633, 41);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(56, 20);
            this.label4.TabIndex = 7;
            this.label4.Text = "Status";
            // 
            // ddlStatus
            // 
            this.ddlStatus.FormattingEnabled = true;
            this.ddlStatus.Location = new System.Drawing.Point(637, 71);
            this.ddlStatus.Name = "ddlStatus";
            this.ddlStatus.Size = new System.Drawing.Size(146, 28);
            this.ddlStatus.TabIndex = 8;
            this.ddlStatus.Text = "--Select--";
            // 
            // btnReset
            // 
            this.btnReset.Location = new System.Drawing.Point(251, 157);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(76, 42);
            this.btnReset.TabIndex = 9;
            this.btnReset.Text = "Reset";
            this.btnReset.UseVisualStyleBackColor = true;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // FormStatus
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(33)))), ((int)(((byte)(74)))));
            this.ClientSize = new System.Drawing.Size(1742, 677);
            this.Controls.Add(this.btnReset);
            this.Controls.Add(this.ddlStatus);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtTask);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.txtEmployee);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.grdTaskAssign);
            this.Name = "FormStatus";
            this.Text = "FormStatus";
            ((System.ComponentModel.ISupportInitialize)(this.grdTaskAssign)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView grdTaskAssign;
        private System.Windows.Forms.DataGridViewTextBoxColumn TaskDetailsId;
        private System.Windows.Forms.DataGridViewTextBoxColumn TaskId;
        private System.Windows.Forms.DataGridViewTextBoxColumn EmployeeId;
        private System.Windows.Forms.DataGridViewTextBoxColumn EmployeeName;
        private System.Windows.Forms.DataGridViewTextBoxColumn TaskName;
        private ComponentFactory.Krypton.Toolkit.KryptonDataGridViewDateTimePickerColumn StartDate;
        private ComponentFactory.Krypton.Toolkit.KryptonDataGridViewDateTimePickerColumn EndDate;
        private ComponentFactory.Krypton.Toolkit.KryptonDataGridViewDateTimePickerColumn DueDate;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtEmployee;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtTask;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox ddlStatus;
        private System.Windows.Forms.Button btnReset;
    }
}