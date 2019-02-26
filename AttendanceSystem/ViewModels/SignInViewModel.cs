using AttendanceSystem.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AttendanceSystem.ViewModels
{
    public class SignInViewModel
    {
        public IEnumerable<Employee> Employees { get; set; }
    }
}
