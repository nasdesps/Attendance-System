﻿using AttendanceSystem.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AttendanceSystem.Data
{
    public class AttendanceSystemDbContext : DbContext
    {
        public AttendanceSystemDbContext(DbContextOptions options)
            : base(options)
        { }

        public DbSet<Employee> Employees { get; set; }
    }
}
