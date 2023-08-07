using eCommerce;
using eCommerce.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace eCommerce.Controllers
{
    public class eCommerceController : Controller
    {
      

        public IActionResult Index()
        {
            return View();
        }
                                                                    
        public IActionResult Customer()
        {
            /*using var dbContext = new ECommerceDbContext();
            var customers = dbContext.Customers.ToList();
            return View(customers);*/
            return View();
        }

        public IActionResult Category()
        {
            /*using var dbContext = new ECommerceDbContext();
            var categories = dbContext.Categories.ToList();
            return View(categories);*/
            return View();
        }

    }
}
