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
using ComponentFactory.Krypton.Toolkit;
using CsvHelper.Configuration;
using CsvHelper;
using TaskManagement.Model;

namespace TaskManagement
{
    public partial class Login :KryptonForm
    {
       List<EmployeeModel>employeeList=new List<EmployeeModel>();
        public Login()
        {
            InitializeComponent();

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
                   

                }
            }
        }
       

        private void btnLogin_Click(object sender, EventArgs e)
        {
            this.Hide();
            
            if (txtUserName.Text == "admin" && txtPassword.Text == "admin")
            {
                Dashboard dashboard = new Dashboard();
                dashboard.ShowDialog();
            }
            else if(txtUserName.Text == "user" && txtPassword.Text == "user")
            {
                UserDashBoard userDashboard = new UserDashBoard();
                userDashboard.ShowDialog();
            }

            
        }
        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
