namespace WBankWebApp.Models
{
    public class AccountType
    {
        public int AccountTypeID { get; set; }
        public string AccountTypeName { get; set; } = string.Empty; // Renamed for clarity if desired

        // Optional: Navigation property to link Customers
        public ICollection<Customer> Customers { get; set; } = new List<Customer>();
    }
}
