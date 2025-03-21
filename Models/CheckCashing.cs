using System;

namespace WBankWebApp.Models
{
    public class CheckCashing
    {
        public int CheckCashingID { get; set; }
        public int LocationID { get; set; } // Foreign key
        public int EmployeeID { get; set; } // Foreign key
        public int CustomerID { get; set; } // Foreign key
        public DateTime CheckCashingDate { get; set; } = DateTime.Now;
        public decimal CheckCashingAmount { get; set; }

        // Navigation properties
        public Locations? Location { get; set; }
        public Employees? Employee { get; set; }
        public Customer? Customer { get; set; }
    }
}
