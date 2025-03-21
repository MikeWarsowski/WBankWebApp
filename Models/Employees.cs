using System.ComponentModel.DataAnnotations;
using System;

namespace WBankWebApp.Models
{
    public class Employees
    {
        [Key] // Ensure this attribute is applied
        public int EmployeeID { get; set; }
        public string EmployeeNumber { get; set; } = string.Empty;
        public string FirstName { get; set; } = string.Empty;
        public string LastName { get; set; } = string.Empty;
        public string Title { get; set; } = string.Empty;
        public bool CanCreateNewAccount { get; set; } = false;
        public decimal HourlySalary { get; set; }
        public string Address { get; set; } = string.Empty;
        public string City { get; set; } = string.Empty;
        public string State { get; set; } = string.Empty;
        public string ZipCode { get; set; } = string.Empty;
        public string EmailAddress { get; set; } = string.Empty;
    }
}
