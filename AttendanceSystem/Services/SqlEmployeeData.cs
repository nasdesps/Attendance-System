using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AttendanceSystem.Data;
using AttendanceSystem.Models;

namespace AttendanceSystem.Services
{
    public class SqlEmployeeData : IEmployeeData
    {
        private AttendanceSystemDbContext _context;

        public SqlEmployeeData(AttendanceSystemDbContext context)
        {
            _context = context;
        }

        public Employee AddEmployee(Employee employee)
        {
            _context.Employees.Add(employee);
            _context.SaveChanges();
            return employee;
        }

        public Employee Get(int id)
        {
            return _context.Employees.FirstOrDefault(e => e.ID == id);
        }

        public IEnumerable<Employee> GetAll()
        {
            return _context.Employees.OrderBy(e => e.FirstName);
        }

        public Employee SignIn(Employee employee)
        {
            throw new NotImplementedException();
        }

        public Employee SignOut(Employee employee)
        {
            throw new NotImplementedException();
        }
    }
}
