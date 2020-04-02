using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace EmployeeApplicationModel.Models
{
    [MetadataType(typeof(EmployeesMetaData))]
    public partial class Employees
    {
        public class EmployeesMetaData
        {
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
            
        }
        [System.ComponentModel.DataAnnotations.Schema.NotMapped]
        public int[] Skills { get; set; }
    }
}
