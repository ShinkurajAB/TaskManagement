using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web;

namespace TaskManagement.Model
{
    public class TaskDetailsModel
    {
        public string TaskDetailsId { get; set; }
        public string TaskId { get; set; }
        public string EmployeeId { get; set; }
        public string EmployeeName { get; set; }
        public string TaskName { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime DueDate { get; set; }
        public DateTime EndDate { get; set; }
        public string Status { get; set; }
    }
}
