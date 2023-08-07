using Microsoft.AspNetCore.Mvc;
using WebApp.Models;

namespace WebApp.Controllers
{
    public class ProductController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        //public IActionResult Details()
        //{
        //    return View();
        //}
        public IActionResult Details(int id)
        {
            

            // Set the display message
            string displayMessage = "Product details retrieved successfully.";

            // Create an instance of the view model and assign the product and display message
            ProductDetails viewModel = new ProductDetails
            {
                Id = id,
                DisplayMessage = displayMessage
            };

            // Pass the view model to the view
            return View(viewModel);
        }

      

        public IActionResult Create()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Create(Product product)
        {
            return Json(product);
        }

        public IActionResult Edit()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Edit(Product product)
        {
            return Json(product);
        }
        public IActionResult Delete()
        {
            return View();
        }
    }
}
