using System;
using System.ComponentModel.DataAnnotations;

namespace EmployeeApplication.Data
{
    public class Employee
    {
        public int Id { get; set; }
        [Required]
        [StringLength(20, ErrorMessage = "First Name is too long.")]
        public string FirstName { get; set; }
        [StringLength(20, ErrorMessage = "Middle Name is too long.")]
        public string MiddleName { get; set; }
        [Required]
        [StringLength(20, ErrorMessage = "Last Name is too long.")]
        public string LastName { get; set; }
        public string AddressStreet { get; set; }
        public string AddressState { get; set; }
        public string AddressCity { get; set; }
        public int AddressZip { get; set; }
        public int CurrentJob { get; set; }
        public bool IsActive { get; set; }
        [System.ComponentModel.DataAnnotations.Schema.NotMapped]
        public int SkillsId { get; set; }
        public Employee()
        { }
        public Employee(int id, string firstName, string middleName, string lastName, string addressStreet, string addressCity, string addressState, int addressZip, int skillsId, int currentJob, bool isActive)
        {
            this.Id = id;
            this.FirstName = firstName;
            this.MiddleName = middleName;
            this.LastName = lastName;
            this.AddressStreet = addressStreet;
            this.AddressState = addressState;
            this.AddressCity = addressCity;
            this.AddressZip = addressZip;
            this.CurrentJob = currentJob;
            this.IsActive = isActive;
            this.SkillsId = skillsId;
        }
    }
}