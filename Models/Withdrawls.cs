using System;

namespace WBankWebApp.Models
{
    public class Withdrawals
    {
        public int WithdrawalID { get; set; }
        public int LocationID { get; set; } // Foreign key
        public int EmployeeID { get; set; } // Foreign key
        public int CustomerID { get; set; } // Foreign key
        public DateTime WithdrawalDate { get; set; } = DateTime.Now;
        public decimal WithdrawalAmount { get; set; }
        public bool WithdrawalSuccessful { get; set; } = true;

        // Navigation properties
        public Locations? Location { get; set; }
        public Employees? Employee { get; set; }
        public Customer? Customer { get; set; }
    }
}
