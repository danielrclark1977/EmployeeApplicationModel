using System;
using System.Collections.Generic;
using System.Text;

namespace EmployeeApplication.Data
{
    public class Job
    {
        public int Id { get; set; }
        public string JobName { get; set; }
        public string JobLocation { get; set; }
        public DateTime JobStartDate { get; set; }
        public DateTime JobEndDate { get; set; }
        public decimal JobRate { get; set; }
        public bool IsActive { get; set; }
        public Job()
        { }
    }
}
