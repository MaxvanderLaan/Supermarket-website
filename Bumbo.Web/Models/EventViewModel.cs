﻿using System;

namespace Bumbo.Web.Models
{
    public class EventViewModel
    {
        public Int64 id { get; set; }

        public String title { get; set; }

        public String start { get; set; }

        public String end { get; set; }

        public bool allDay { get; set; }
        public string color { get; set; }
    }
}