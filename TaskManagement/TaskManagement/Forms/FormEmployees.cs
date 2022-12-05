using CsvHelper;
using CsvHelper.Configuration;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Eventing.Reader;
using System.Drawing;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Documents;
using System.Windows.Forms;
using TaskManagement.Model;

namespace TaskManagement.Forms
{
    public partial class FormEmployees : Form
    {
        EmployeeModel employeeModel = new EmployeeModel();
        List<EmployeeModel> employeeList = new List<EmployeeModel>();
        string employeeUpdateId=String.Empty;
        public FormEmployees()
        {
            InitializeComponent();
            
            GetEmployees();
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
                    gridEmployees.DataSource = employeeList;
                    
                }
            }
        }
        private bool Validations()
        {
            if (txtName.Text == String.Empty)
            {
                MessageBox.Show("Enter Employee Name", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            if (txtEmail.Text == String.Empty)
            {
                MessageBox.Show("Enter Email", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            return true;
        }
            private void btnAdd_Click(object sender, EventArgs e)
            {
            if (Validations())
            {
                if (String.IsNullOrEmpty(employeeUpdateId))
                {
                    employeeList.Clear();
                    employeeModel.EmployeeName = txtName.Text;
                    employeeModel.Email = txtEmail.Text;
                    employeeModel.Dob = dtpDob.Value;
                    employeeModel.EmployeeId = DateTime.Now.ToString("yyyyMMddmmss");
                    employeeList.Add(employeeModel);
                    var configEmployee = new CsvConfiguration(CultureInfo.InvariantCulture);
                    if (File.Exists("Employee.csv"))
                    {
                        configEmployee.HasHeaderRecord = false;
                    }

                    using (var stream = File.Open("Employee.csv", FileMode.Append))
                    using (var writer = new StreamWriter(stream))
                    using (var csv = new CsvWriter(writer, configEmployee))
                    {

                        csv.WriteRecords(employeeList);

                    }


                }
                else
                {
                    employeeList.Where(x => x.EmployeeId == employeeUpdateId).ToList().ForEach(y => { y.EmployeeName = txtName.Text; y.Email = txtEmail.Text; y.Dob = dtpDob.Value; });
                    UpdateorDeleteFile();

                }
                ClearData();
                GetEmployees();
            }

        }
        private void UpdateorDeleteFile()
        {
            if (File.Exists("Employee.csv"))
            {
                File.Delete("Employee.csv");
                var configEmployee = new CsvConfiguration(CultureInfo.InvariantCulture);


                using (var stream = File.Open("Employee.csv", FileMode.Append))
                using (var writer = new StreamWriter(stream))
                using (var csv = new CsvWriter(writer, configEmployee))
                {
                   
                    csv.WriteRecords(employeeList);

                }
            }
        }
        private void ClearData()
        {
            txtName.Text = String.Empty;
            txtEmail.Text = String.Empty;
            dtpDob.Value = DateTime.Now;
            employeeUpdateId = String.Empty;
        }
        

        private void gridEmployees_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            employeeUpdateId = String.Empty;
            if(e.ColumnIndex==0)
            {
                if(gridEmployees.Rows.Count>0)
                {
                    string employyeId = gridEmployees[2, e.RowIndex].Value.ToString();
                    employeeList.RemoveAll(x => x.EmployeeId == employyeId);
                    UpdateorDeleteFile();
                    GetEmployees();
                    
                }
            }
            else if(e.ColumnIndex==1)
            {
                if (gridEmployees.Rows.Count > 0)
                {
                    employeeUpdateId  = gridEmployees[2, e.RowIndex].Value.ToString();                    
                    txtName.Text= gridEmployees[3, e.RowIndex].Value.ToString();
                    txtEmail.Text= gridEmployees[5, e.RowIndex].Value.ToString();
                    string birthday= gridEmployees[4, e.RowIndex].Value.ToString();
                    dtpDob.Value=Convert.ToDateTime(birthday);
                }

            }
        }
    }
}
