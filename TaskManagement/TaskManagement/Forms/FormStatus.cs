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
using System.Runtime.InteropServices;

namespace TaskManagement.Forms
{
    public partial class FormStatus : Form
    {
        List<TaskDetailsModel> taskDetailsList = new List<TaskDetailsModel>();
        public FormStatus()
        {
            
            InitializeComponent();
            GetAssignedTasks();
            ddlStatus.Items.Clear();
            ddlStatus.Items.Add("ToDo");
            ddlStatus.Items.Add("Ongoing");
            ddlStatus.Items.Add("Done");
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

                    
                    grdTaskAssign.DataSource = taskDetailsList;

                }
                }
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            
           
                var data=taskDetailsList.Where(x=>x.EmployeeName.StartsWith(txtEmployee.Text)||x.EmployeeName.EndsWith(txtEmployee.Text)).ToList();
                var taskdata = data.Where(x => x.TaskName.StartsWith(txtTask.Text) || x.TaskName.EndsWith(txtTask.Text)).ToList();
            if (ddlStatus.Text != "--Select--")
            {
                var finaldata=taskdata.Where(x=>x.Status==ddlStatus.Text).ToList();
                grdTaskAssign.DataSource = finaldata.ToList();
            }
            else
            {
                grdTaskAssign.DataSource = taskdata.ToList();
            }
            

        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            txtEmployee.Text = String.Empty;
            txtTask.Text= String.Empty;
            ddlStatus.Text = "--Select--";
            GetAssignedTasks();
        }
    }
}
