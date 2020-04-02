using System;

namespace EmployeeApplication.Data
{
    public class EmployerJob
    {
        public int EmployerId { get; set; }
        public int JobId { get; set; }
        public string JobName { get; set; }
        public string JobLocation { get; set; }
        public DateTime JobStartDate { get; set; }
        public DateTime JobEndDate { get; set; }
        public decimal JobRate { get; set; }

        public EmployerJob()
        { }
    }
}
