using Microsoft.AspNetCore.Mvc;

namespace MvcDemo.Controllers
{
    public class StudentController : Controller
    {
        public IActionResult Index()
        {
            ViewData["Message"] = "Danh sách sinh viên";
            return View();
        }

        public IActionResult Detail(int id = 1)
        {
            ViewData["Message"] = $"Thông tin chi tiết sinh viên với ID = {id}";
            return View();
        }
    }
}
