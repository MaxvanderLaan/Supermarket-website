﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bumbo.Domain.Services.CAO.CAORules
{
    public class Surtax
    {
        public double SurtaxRate { get; set; }
        public TimeSpan StartTime { get; set; }
        public TimeSpan EndTime { get; set; }
        public DayOfWeek? Day { get; set; }
    }
}
