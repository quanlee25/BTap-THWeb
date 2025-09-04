using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;
using WebApplication_TH03.Models;

namespace WebApplication29_08.Controllers
{
    public class HomeController : Controller
    {
        protected Product product = new Product();
        public IActionResult Index()
        {
            var products = product.GetProductsList();
            return View(products);
        }
    }
}
