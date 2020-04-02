using System;
using System.Collections.Generic;

namespace EmployeeApplication.Data
{
    public partial class Employer
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Address { get; set; }
        public string Phone { get; set; }
        public bool IsActive { get; set; }
    }
}
