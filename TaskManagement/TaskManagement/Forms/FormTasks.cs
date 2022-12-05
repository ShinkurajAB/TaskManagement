using CsvHelper.Configuration;
using CsvHelper;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TaskManagement.Model;

namespace TaskManagement.Forms
{
    public partial class FormTasks : Form
    {
        TaskModel taskModel = new TaskModel();
        List<TaskModel> taskList = new List<TaskModel>();
        string taskUpdateId = String.Empty;
        public FormTasks()
        {
            InitializeComponent();
            GetTasks();
        }
        private void GetTasks()
        {
            if (File.Exists("Task.csv"))
            {
                var configuration = new CsvConfiguration(CultureInfo.InvariantCulture)
                {
                    HasHeaderRecord = true,
                };
                using (var reader = new StreamReader("Task.csv"))
                using (var csv = new CsvReader(reader, configuration))
                {
                    var records = csv.GetRecords<TaskModel>();
                    taskList = records.ToList();
                    grdTasks.DataSource = taskList;

                }
            }
        }
        private bool Validations()
        {
            if (txtName.Text == String.Empty)
            {
                MessageBox.Show("Enter Task Name", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            if (txtDescription.Text == String.Empty)
            {
                MessageBox.Show("Enter Description", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            return true;
        }
        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (Validations())
            {
                if (String.IsNullOrEmpty(taskUpdateId))
                {
                    taskList.Clear();
                    taskModel.TaskName = txtName.Text;
                    taskModel.TaskDescription = txtDescription.Text;
                    taskModel.TaskId = DateTime.Now.ToString("yyyyMMddmmss");
                    taskList.Add(taskModel);
                    var configTask = new CsvConfiguration(CultureInfo.InvariantCulture);
                    if (File.Exists("Task.csv"))
                    {
                        configTask.HasHeaderRecord = false;
                    }

                    using (var stream = File.Open("Task.csv", FileMode.Append))
                    using (var writer = new StreamWriter(stream))
                    using (var csv = new CsvWriter(writer, configTask))
                    {

                        csv.WriteRecords(taskList);

                    }


                }
                else
                {
                    taskList.Where(x => x.TaskId == taskUpdateId).ToList().ForEach(y => { y.TaskName = txtName.Text; y.TaskDescription = txtDescription.Text; });
                    UpdateorDeleteFile();

                }
                ClearData();
                GetTasks();
            }
        }
        private void UpdateorDeleteFile()
        {
            if (File.Exists("Task.csv"))
            {
                File.Delete("Task.csv");
                var configTask = new CsvConfiguration(CultureInfo.InvariantCulture);


                using (var stream = File.Open("Task.csv", FileMode.Append))
                using (var writer = new StreamWriter(stream))
                using (var csv = new CsvWriter(writer, configTask))
                {
                    
                    csv.WriteRecords(taskList);

                }
            }
        }
        private void ClearData()
        {
            txtName.Text = String.Empty;
            txtDescription.Text = String.Empty;
            taskUpdateId = String.Empty;
        }

        private void grdTasks_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            taskUpdateId = String.Empty;
            if (e.ColumnIndex == 0)
            {
                if (grdTasks.Rows.Count > 0)
                {
                    string taskId = grdTasks[2, e.RowIndex].Value.ToString();
                    taskList.RemoveAll(x => x.TaskId == taskId);
                    UpdateorDeleteFile();
                    GetTasks();

                }
            }
            else if (e.ColumnIndex == 1)
            {
                if (grdTasks.Rows.Count > 0)
                {
                    taskUpdateId = grdTasks[2, e.RowIndex].Value.ToString();
                    txtName.Text = grdTasks[3, e.RowIndex].Value.ToString();
                    txtDescription.Text = grdTasks[4, e.RowIndex].Value.ToString();
                   
                }

            }
        }
    }
}
