using Microsoft.AspNetCore.Mvc;

namespace MvcDemo.Controllers
{
    public class TeacherController : Controller
    {
        public IActionResult Index()
        {
            ViewData["Message"] = "Danh sách giáo viên";
            return View();
        }

        public IActionResult Profile(int id = 1)
        {
            ViewData["Message"] = $"Thông tin giáo viên với ID = {id}";
            return View();
        }
    }
}
