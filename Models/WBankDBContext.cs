using Microsoft.EntityFrameworkCore;
using WBankWebApp.Models;

namespace WBankWebApp.Models
{
    public class WBankDbContext : DbContext
    {
        public WBankDbContext(DbContextOptions<WBankDbContext> options) : base(options) { }

        public DbSet<Customer> Customers { get; set; }
        public DbSet<AccountType> AccountType { get; set; }
        public DbSet<Deposits> Deposits { get; set; }
        public DbSet<Locations> Locations { get; set; }
        public DbSet<CheckCashing> CheckCashing { get; set; }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            // Seed Locations Table
            modelBuilder.Entity<Locations>().HasData(
                new Locations { LocationID = 1, LocationCode = "LOC001", Address = "123 Main St", City = "Asheville", State = "NC" },
                new Locations { LocationID = 2, LocationCode = "LOC002", Address = "456 Elm St", City = "Raleigh", State = "NC" }
            );

            // Seed AccountType Table
            modelBuilder.Entity<AccountType>().HasData(
                new AccountType { AccountTypeID = 1, AccountTypeName = "Savings" },
                new AccountType { AccountTypeID = 2, AccountTypeName = "Checking" }
            );
        }
    }
}
