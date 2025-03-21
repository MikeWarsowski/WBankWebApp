using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Linq;
using WBankWebApp.Models;

namespace WBankWebApp.Controllers
{
    public class HomeController : Controller
    {
        private readonly WBankDbContext _context;

        public HomeController(WBankDbContext context)
        {
            _context = context;
        }

        [HttpPost]
        public IActionResult QueryDatabase(string accountNumber, string customerName)
        {
            var query = _context.Customers.AsQueryable();

            if (!string.IsNullOrWhiteSpace(accountNumber))
            {
                query = query.Where(c => c.AccountNumber == accountNumber);
            }

            if (!string.IsNullOrWhiteSpace(customerName))
            {
                query = query.Where(c => c.Fname.Contains(customerName) || c.Lname.Contains(customerName));
            }

            var results = query.ToList();

            return View("Index", results);
        }

        public IActionResult Index()
        {
            return View();
        }
    }
}
