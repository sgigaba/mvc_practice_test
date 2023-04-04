namespace Mvc_practice_test.Controllers
{
    using Microsoft.AspNetCore.Mvc;

    public class TestController : Controller
    {
        public IActionResult Index()
        {
            return this.View();
        }
    }
}
