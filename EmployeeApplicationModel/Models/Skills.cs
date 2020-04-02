using System;
using System.Collections.Generic;

namespace EmployeeApplicationModel.Models
{
    public partial class Skills
    {
        public int Id { get; set; }
        public string SkillName { get; set; }
        public int? MonthsExperience { get; set; }
    }
}
