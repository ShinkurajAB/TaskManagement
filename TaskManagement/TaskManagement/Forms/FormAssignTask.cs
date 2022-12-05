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
using System.Reflection;
using System.Xml.Linq;

namespace TaskManagement.Forms
{
    public partial class FormAssignTask : Form
    {
        List<TaskModel> taskList = new List<TaskModel>();
        List<EmployeeModel> employeeList = new List<EmployeeModel>();
        List<TaskDetailsModel> taskDetailsList = new List<TaskDetailsModel>();
        TaskDetailsModel taskDetailsModel = new TaskDetailsModel();
        DataTable dtemployees = new DataTable();
        DataTable dtTask = new DataTable();
        string taskAssignUpdateid = String.Empty;
        public FormAssignTask()
        {
            InitializeComponent();
            GetEmployees();
            GetTasks();
            ddlStatus.Items.Clear();
            ddlStatus.Items.Add("ToDo");
            ddlStatus.Items.Add("Ongoing");
            ddlStatus.Items.Add("Done");
            GetAssignedTasks();

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
                    dtTask = ToDataTable(taskList);
                    DataRow newRow = dtTask.NewRow();
                    newRow[0] = "0";
                    newRow[1] = "--Select Task--";
                    dtTask.Rows.InsertAt(newRow, 0);
                    ddlTask.DataSource = dtTask;
                    ddlTask.DisplayMember = "TaskName";
                    ddlTask.ValueMember = "TaskId";
                    ddlTask.SelectedItem = 0;
                }
            }
        }
        private void GetEmployees()
        {
            if (File.Exists("Employee.csv"))
            {
                var configuration = new CsvConfiguration(CultureInfo.InvariantCulture)
                {
                    HasHeaderRecord = true,
                };
                using (var reader = new StreamReader("Employee.csv"))
                using (var csv = new CsvReader(reader, configuration))
                {
                    var records = csv.GetRecords<EmployeeModel>();
                    employeeList = records.ToList();

                    dtemployees = ToDataTable(employeeList);
                    DataRow newRow = dtemployees.NewRow();
                    newRow[0] = "0";
                    newRow[1] = "--Select Employee--";
                    dtemployees.Rows.InsertAt(newRow, 0);

                    ddlAssignTo.DataSource = dtemployees;
                    ddlAssignTo.DisplayMember = "EmployeeName";
                    ddlAssignTo.ValueMember = "EmployeeId";
                    ddlAssignTo.SelectedItem = 0;
                }
            }
        }
        public DataTable ToDataTable<T>(List<T> items)
        {
            DataTable dataTable = new DataTable(typeof(T).Name);

            PropertyInfo[] Props = typeof(T).GetProperties(BindingFlags.Public | BindingFlags.Instance);
            foreach (PropertyInfo prop in Props)
            {
                dataTable.Columns.Add(prop.Name);
            }
            foreach (T item in items)
            {
                var values = new object[Props.Length];
                for (int i = 0; i < Props.Length; i++)
                {
                    values[i] = Props[i].GetValue(item, null);
                }
                dataTable.Rows.Add(values);
            }

            return dataTable;
        }
        private void ddlTask_SelectedIndexChanged(object sender, EventArgs e)
        {
            txtDescription.Text = String.Empty;
            if (ddlTask.SelectedIndex != 0)
            {
                if (ddlTask.SelectedValue.ToString() != "0")
                {
                    string taskid = ddlTask.SelectedValue.ToString();
                    var description = taskList.Where(x => x.TaskId == taskid).ToList().Select(x => x.TaskDescription).ToList();
                    foreach (var item in description)
                    {
                        txtDescription.Text = item;
                    }
                }
            }
        }

        private void ddlAssignTo_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (ddlAssignTo.SelectedIndex != 0)
            {
                if (ddlAssignTo.SelectedValue.ToString() != "0")
                {
                    string employeeid = ddlAssignTo.SelectedValue.ToString();
                }
            }
        }
        private bool Validations()
        {
            if(ddlAssignTo.Text=="--Select Employee--")
            {
                MessageBox.Show("Select Employee", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            if(ddlTask.Text=="--Select Task--")
            {
                MessageBox.Show("Select Task ", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            if (ddlStatus.Text == "--Select Status--")
            {
                MessageBox.Show("Select Status ", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            if (taskDetailsList.Count>0)
            {
              
                var data = taskDetailsList.Where(x => x.TaskId == ddlTask.SelectedValue.ToString()).ToList().Select(x => x.EmployeeId).ToList();
                foreach (var item in data)
                {
                    
                        if (item.ToString() != ddlAssignTo.SelectedValue.ToString())
                        {
                            MessageBox.Show("Task already assigned to another employee","Error",MessageBoxButtons.OK,MessageBoxIcon.Error);
                            return false;
                        }
                   
                }
               
            }
            return true;
        }
        private void btnAssign_Click(object sender, EventArgs e)
        {
            if (Validations())
            {
                if (String.IsNullOrEmpty(taskAssignUpdateid))
                {

                    taskDetailsList.Clear();
                    taskDetailsModel.TaskId = ddlTask.SelectedValue.ToString();
                    taskDetailsModel.EmployeeId = ddlAssignTo.SelectedValue.ToString();
                    taskDetailsModel.EmployeeName = ddlAssignTo.Text;
                    taskDetailsModel.TaskName = ddlTask.Text;
                    taskDetailsModel.StartDate = dtpStartDate.Value;
                    taskDetailsModel.EndDate = dtpEndDate.Value;
                    taskDetailsModel.DueDate = DateTime.Now;
                    taskDetailsModel.Status = ddlStatus.SelectedItem.ToString();
                    taskDetailsModel.TaskDetailsId = DateTime.Now.ToString("yyyyMMddmmss");
                    taskDetailsList.Add(taskDetailsModel);
                    var configTask = new CsvConfiguration(CultureInfo.InvariantCulture);
                    if (File.Exists("TasksAssigned.csv"))
                    {
                        configTask.HasHeaderRecord = false;
                    }

                    using (var stream = File.Open("TasksAssigned.csv", FileMode.Append))
                    using (var writer = new StreamWriter(stream))
                    using (var csv = new CsvWriter(writer, configTask))
                    {
                        csv.WriteRecords(taskDetailsList);
                    }



                }
                else
                {
                    taskDetailsList.Where(x => x.TaskDetailsId == taskAssignUpdateid).ToList().ForEach(y => { y.EmployeeId = ddlAssignTo.SelectedValue.ToString(); y.EmployeeName = ddlAssignTo.Text; y.TaskId = ddlTask.SelectedValue.ToString(); y.StartDate = dtpStartDate.Value; y.EndDate = dtpEndDate.Value; y.DueDate = DateTime.Now; y.TaskDetailsId = taskAssignUpdateid;y.Status = ddlStatus.Text; });
                    UpdateorDeleteFile();

                }
                ClearData();
                GetAssignedTasks();
            }
            
        }
        private void UpdateorDeleteFile()
        {
            if (File.Exists("TasksAssigned.csv"))
            {
                File.Delete("TasksAssigned.csv");
                var configTasksAssigned = new CsvConfiguration(CultureInfo.InvariantCulture);


                using (var stream = File.Open("TasksAssigned.csv", FileMode.Append))
                using (var writer = new StreamWriter(stream))
                using (var csv = new CsvWriter(writer, configTasksAssigned))
                {

                    csv.WriteRecords(taskDetailsList);

                }
            }
        }
        private void ClearData()
        {
            txtDescription.Text = String.Empty;
            ddlAssignTo.Text = "--Select Employee--";
            ddlTask.Text = "--Select Task--";
            ddlStatus.Text = "--Select Status--";
            dtpStartDate.Value = DateTime.Now;
            dtpEndDate.Value = DateTime.Now;
            taskAssignUpdateid = String.Empty;
        }
        private void GetAssignedTasks()
        {

            if (File.Exists("TasksAssigned.csv"))
            {
                var configuration = new CsvConfiguration(CultureInfo.InvariantCulture)
                {
                    HasHeaderRecord = true,
                };
                using (var reader = new StreamReader("TasksAssigned.csv"))
                using (var csv = new CsvReader(reader, configuration))
                {
                    var records = csv.GetRecords<TaskDetailsModel>();
                    taskDetailsList = records.ToList();

                    DataTable dtTaskDetails = new DataTable();
                    dtTaskDetails = ToDataTable(taskDetailsList);
                    grdAssignDetails.DataSource = taskDetailsList;

                }
            }
        }

        private void grdAssignDetails_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            taskAssignUpdateid = String.Empty;
            if (e.ColumnIndex == 0)
            {
                if (grdAssignDetails.Rows.Count > 0)
                {
                    string taskAssignId = grdAssignDetails[2, e.RowIndex].Value.ToString();
                    taskDetailsList.RemoveAll(x => x.TaskDetailsId == taskAssignId);
                    UpdateorDeleteFile();
                    GetAssignedTasks();

                }
            }
            else if (e.ColumnIndex == 1)
            {
                if (grdAssignDetails.Rows.Count > 0)
                {
                    taskAssignUpdateid = grdAssignDetails[2, e.RowIndex].Value.ToString();
                    ddlAssignTo.Text = grdAssignDetails[5, e.RowIndex].Value.ToString();
                    ddlTask.Text = grdAssignDetails[6, e.RowIndex].Value.ToString();
                    string startdate = grdAssignDetails[7, e.RowIndex].Value.ToString();
                    dtpStartDate.Value = Convert.ToDateTime(startdate);
                    string enddate = grdAssignDetails[8, e.RowIndex].Value.ToString();
                    dtpEndDate.Value = Convert.ToDateTime(enddate);
                    ddlStatus.Text = grdAssignDetails[10, e.RowIndex].Value.ToString();

                }
            }
        }
    }
}
