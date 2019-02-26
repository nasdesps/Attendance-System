using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AttendanceSystem.ViewModels
{
    public class EmployeeSignInModel
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public DateTime ClockIn { get; set; }
        public DateTime ClockOut { get; set; }
    }
}
