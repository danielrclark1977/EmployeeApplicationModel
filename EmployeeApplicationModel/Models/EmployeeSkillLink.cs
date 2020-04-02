using System;
using System.Collections.Generic;

namespace EmployeeApplicationModel.Models
{
    public partial class EmployeeSkillLink
    {
        public int SkillLinkId { get; set; }
        public int Employee { get; set; }
        public int Skill { get; set; }

        public virtual Employees EmployeeNavigation { get; set; }
    }
}
