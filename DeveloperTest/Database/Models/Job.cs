﻿using System;

namespace DeveloperTest.Database.Models
{
    public class Job
    {
        public int JobId { get; set; }

        public string Engineer { get; set; }

        public string Customer { get; set; }

        public DateTime When { get; set; }
    }
}
