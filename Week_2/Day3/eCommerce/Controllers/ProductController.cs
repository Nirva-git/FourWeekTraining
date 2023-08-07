using eCommerce.Models;
using Microsoft.AspNetCore.Mvc;

namespace eCommerce.Controllers
{
    public class ProductController : Controller
    {
        private readonly ECommerceDbContext _dbContext;

        public ProductController(ECommerceDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public IActionResult Product()
        {
            var products = _dbContext.Products.ToList();
            return View(products);
        }

        [HttpGet]
        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Create(Product product)
        {
            if (ModelState.IsValid)
            {
                _dbContext.Products.Add(product);
                _dbContext.SaveChanges();

                return RedirectToAction("Details", new { id = product.Id });
            }

            return View(product);
        }
    }
}
