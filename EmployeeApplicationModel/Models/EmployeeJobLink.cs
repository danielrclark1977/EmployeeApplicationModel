using System;
using System.Collections.Generic;

namespace EmployeeApplicationModel.Models
{
    public partial class EmployeeJobLink
    {
        public int JobLinkId { get; set; }
        public int? Employee { get; set; }
        public int? Job { get; set; }
    }
}
