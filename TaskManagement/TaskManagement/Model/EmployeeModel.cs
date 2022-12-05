using CsvHelper.Configuration.Attributes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TaskManagement.Model
{
    public class EmployeeModel
    {
        public string EmployeeId { get; set; }
        public string EmployeeName { get; set; }       
        
        [Format("yyyy-MM-dd")]        
        public DateTime Dob { get; set; }
        public string Email { get; set; }


    }
}
