namespace mvc_practice_test.Controllers
{
    using Microsoft.AspNetCore.Mvc;

    public class EmployeeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
