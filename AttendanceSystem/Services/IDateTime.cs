﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AttendanceSystem.Services
{
    public interface IDateTime
    {
        DateTime Now { get; }
    }
}
