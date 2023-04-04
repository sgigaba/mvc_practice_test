namespace Mvc_practice_test.Controllers
{
    using Microsoft.AspNetCore.Mvc;
    using mvc_practice_test;
    using mvc_practice_test.Models;

    public class TestController : Controller
    {
        private readonly ApplicationDbContext context;

        public TestController(ApplicationDbContext context)
        {
            this.context = context;
        }

        public IActionResult Index()
        {
            var testTable = this.context.TestTables.ToList();

            return this.View();
        }
    }
}
