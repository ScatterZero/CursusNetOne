﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cursus.Data.Entities
{
    public class HomePage
    {
        public int Id { get; set; }
        public string BranchName { get; set; }
        public string SupportHotline { get; set; }
        public string PhoneNumber { get; set; }
        public string Address { get; set; }
        public string WorkingTime { get; set; }
        public string LastUpdatedBy { get; set; }
        public DateTime LastUpdatedDate { get; set; }
    }
}
