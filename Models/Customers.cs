using System;

namespace WBankWebApp.Models
{
    public class Customer
    {
        public int CustomerID { get; set; }
        public string? AccountNumber { get; set; }
        public int AccountTypeID { get; set; }
        public required string Fname { get; set; }
        public required string Lname { get; set; }
        public required string Gender { get; set; }
        public required string Address { get; set; }
        public required string City { get; set; }
        public required string State { get; set; }
        public required string PhoneNumber { get; set; }
        public required string EmailAddress { get; set; }
        public DateTime DateCreated { get; set; }
    }
}
