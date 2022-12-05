namespace TaskManagement.Forms
{
    partial class FormTasks
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
            this.txtName = new System.Windows.Forms.TextBox();
            this.lblName = new System.Windows.Forms.Label();
            this.txtDescription = new System.Windows.Forms.TextBox();
            this.labelDescription = new System.Windows.Forms.Label();
            this.btnAdd = new System.Windows.Forms.Button();
            this.grdTasks = new System.Windows.Forms.DataGridView();
            this.TaskId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TaskName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TaskDescription = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Delete = new System.Windows.Forms.DataGridViewButtonColumn();
            this.Edit = new System.Windows.Forms.DataGridViewButtonColumn();
            ((System.ComponentModel.ISupportInitialize)(this.grdTasks)).BeginInit();
            this.SuspendLayout();
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(202, 48);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(378, 26);
            this.txtName.TabIndex = 15;
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblName.ForeColor = System.Drawing.Color.Gainsboro;
            this.lblName.Location = new System.Drawing.Point(33, 49);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(64, 25);
            this.lblName.TabIndex = 14;
            this.lblName.Text = "Name";
            // 
            // txtDescription
            // 
            this.txtDescription.Location = new System.Drawing.Point(202, 118);
            this.txtDescription.Name = "txtDescription";
            this.txtDescription.Size = new System.Drawing.Size(378, 26);
            this.txtDescription.TabIndex = 17;
            // 
            // labelDescription
            // 
            this.labelDescription.AutoSize = true;
            this.labelDescription.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelDescription.ForeColor = System.Drawing.Color.Gainsboro;
            this.labelDescription.Location = new System.Drawing.Point(33, 119);
            this.labelDescription.Name = "labelDescription";
            this.labelDescription.Size = new System.Drawing.Size(109, 25);
            this.labelDescription.TabIndex = 16;
            this.labelDescription.Text = "Description";
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(202, 212);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(121, 38);
            this.btnAdd.TabIndex = 18;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // grdTasks
            // 
            this.grdTasks.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grdTasks.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.TaskId,
            this.TaskName,
            this.TaskDescription,
            this.Delete,
            this.Edit});
            this.grdTasks.Location = new System.Drawing.Point(202, 290);
            this.grdTasks.Name = "grdTasks";
            this.grdTasks.RowHeadersVisible = false;
            this.grdTasks.RowHeadersWidth = 62;
            this.grdTasks.RowTemplate.Height = 28;
            this.grdTasks.Size = new System.Drawing.Size(1165, 271);
            this.grdTasks.TabIndex = 19;
            this.grdTasks.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.grdTasks_CellContentClick);
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
            // TaskName
            // 
            this.TaskName.DataPropertyName = "TaskName";
            this.TaskName.HeaderText = "Name";
            this.TaskName.MinimumWidth = 8;
            this.TaskName.Name = "TaskName";
            this.TaskName.ReadOnly = true;
            this.TaskName.Width = 150;
            // 
            // TaskDescription
            // 
            this.TaskDescription.DataPropertyName = "TaskDescription";
            this.TaskDescription.HeaderText = "Description";
            this.TaskDescription.MinimumWidth = 8;
            this.TaskDescription.Name = "TaskDescription";
            this.TaskDescription.ReadOnly = true;
            this.TaskDescription.Width = 150;
            // 
            // Delete
            // 
            this.Delete.HeaderText = "Delete";
            this.Delete.MinimumWidth = 8;
            this.Delete.Name = "Delete";
            this.Delete.Width = 150;
            // 
            // Edit
            // 
            this.Edit.HeaderText = "Edit";
            this.Edit.MinimumWidth = 8;
            this.Edit.Name = "Edit";
            this.Edit.Width = 150;
            // 
            // FormTasks
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(33)))), ((int)(((byte)(74)))));
            this.ClientSize = new System.Drawing.Size(1412, 744);
            this.Controls.Add(this.grdTasks);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.txtDescription);
            this.Controls.Add(this.labelDescription);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.lblName);
            this.Name = "FormTasks";
            this.Text = "FormTasks";
            ((System.ComponentModel.ISupportInitialize)(this.grdTasks)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.TextBox txtDescription;
        private System.Windows.Forms.Label labelDescription;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.DataGridView grdTasks;
        private System.Windows.Forms.DataGridViewTextBoxColumn TaskId;
        private System.Windows.Forms.DataGridViewTextBoxColumn TaskName;
        private System.Windows.Forms.DataGridViewTextBoxColumn TaskDescription;
        private System.Windows.Forms.DataGridViewButtonColumn Delete;
        private System.Windows.Forms.DataGridViewButtonColumn Edit;
    }
}