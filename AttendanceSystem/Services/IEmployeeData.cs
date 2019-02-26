using AttendanceSystem.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AttendanceSystem.Services
{
    public interface IEmployeeData
    {
        IEnumerable<Employee> GetAll();

        Employee Get(int id);

        Employee SignIn(Employee employee);
        Employee SignOut(Employee employee);
        Employee AddEmployee(Employee employee);
    }
}
