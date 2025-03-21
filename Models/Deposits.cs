using System.ComponentModel.DataAnnotations;
using System;
namespace WBankWebApp.Models
{
    public class Deposits
    {
        [Key] // Ensure this attribute is applied
        public int DepositID { get; set; }

        public int LocationID { get; set; }
        public int EmployeeID { get; set; }
        public int CustomerID { get; set; }
        public DateTime DepositDate { get; set; } = DateTime.Now;
        public decimal DepositAmount { get; set; }

        // Navigation properties (optional)
        public Locations? Location { get; set; }
        public Employees? Employee { get; set; }
        public Customer? Customer { get; set; }
    }
}
