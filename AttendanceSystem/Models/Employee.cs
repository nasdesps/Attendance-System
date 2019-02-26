using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace AttendanceSystem.Models
{
    public class Employee
    {
        public int ID { get; set; }

        [Required, MaxLength(50)]
        [MinLength(2)]
        public string FirstName { get; set; }

        [Required, MaxLength(50)]
        public string LastName { get; set; }

        [Required]
        public DateTime ClockIn { get; set; }

        [Required]
        public DateTime ClockOut { get; set; }
    }
}
