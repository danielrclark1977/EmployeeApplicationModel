using System;

namespace EmployeeApplication.Data
{
    public class Employer
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Address { get; set; }
        public string Phone { get; set; }
        [System.ComponentModel.DataAnnotations.Schema.NotMapped]
        public int[] Jobs { get; set; }
        public bool IsActive { get; set; }
        public Employer()
        { }
        public Employer(int id, string name, string address, string phone, int[] jobs, bool isActive)
        {
            this.Id = id;
            this.Name = name;
            this.Address = address;
            this.Phone = phone;
            this.Jobs = jobs;
            this.IsActive = isActive;
        }
    }
}
