using System.ComponentModel.DataAnnotations;

namespace WBankWebApp.Models
{
    public class Locations
    {
        [Key] // Ensure this attribute is applied
        public int LocationID { get; set; }
        public required string LocationCode { get; set; }
        public required string Address { get; set; }
        public required string City { get; set; }
        public required string State { get; set; }
    }
}
