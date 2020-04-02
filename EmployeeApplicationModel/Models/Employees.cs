using System;
using System.Collections.Generic;

namespace EmployeeApplicationModel.Models
{
    public partial class Employees
    {
        public Employees()
        {
            EmployeeSkillLink = new HashSet<EmployeeSkillLink>();
        }

        public int Id { get; set; }
        public string FirstName { get; set; }
        public string MiddleName { get; set; }
        public string LastName { get; set; }
        public string AddressStreet { get; set; }
        public string AddressState { get; set; }
        public string AddressCity { get; set; }
        public int? AddressZip { get; set; }
        public int? CurrentJob { get; set; }
        public bool IsActive { get; set; }

        public virtual ICollection<EmployeeSkillLink> EmployeeSkillLink { get; set; }
    }
}
