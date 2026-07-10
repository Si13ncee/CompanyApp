using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace CompanyApp.Models
{
    public class Employee
    {
        [Key]
        public int EmployeeId { get; set; }

        public string? Title { get; set; }

        public string FirstName { get; set; }

        public string LastName { get; set; }

        public string? Phone { get; set; }

        public string? Email { get; set; }

        public override string ToString() => $"{FirstName} {LastName}";
        public string FullName => string.IsNullOrWhiteSpace(Title) ? $"{FirstName} {LastName}" : $"{Title} {FirstName} {LastName}";
    }
}
