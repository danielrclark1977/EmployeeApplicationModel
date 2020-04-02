using System;
using System.Collections.Generic;

namespace EmployeeApplicationModel.Models
{
    public partial class Jobs
    {
        public int Id { get; set; }
        public string JobName { get; set; }
        public string JobLocation { get; set; }
        public DateTime? JobStartDate { get; set; }
        public DateTime? JobEndDate { get; set; }
        public decimal? JobRate { get; set; }
        public bool IsActive { get; set; }
    }
}
