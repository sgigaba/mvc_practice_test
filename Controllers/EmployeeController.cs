namespace mvc_practice_test.Controllers
{
    using Microsoft.AspNetCore.Mvc;
    using mvc_practice_test.Models;

    public class EmployeeController : Controller
    {
        private readonly ApplicationDbContext context;

        public EmployeeController(ApplicationDbContext context)
        {
            this.context = context;
        }

        [HttpGet]
        public IActionResult Index()
        {
            var employeeData = this.context.Employees.ToList();

            return this.View(employeeData);
        }

        [HttpGet]
        public IActionResult AddEmployee()
        {
            return this.View();
        }

        [HttpPost]
        public IActionResult AddEmployee(Employee model)
        {
            if (this.ModelState.IsValid)
            {
                this.context.Employees.Add(model);
                this.context.SaveChanges();
            }

            return this.RedirectToAction("Index");
        }

        [HttpGet]
        public IActionResult Delete(int id)
        {
            if (id > 0)
            {
                var employee = this.context.Employees.Find(id);

                this.context.Remove(employee);
                this.context.SaveChanges();
            }

            return this.RedirectToAction("Index");
        }

        [HttpGet]
        public IActionResult Edit()
        {
            return this.View();
        }

        [HttpPost]
        public IActionResult Edit(Employee model)
        {
            return this.RedirectToAction("Index");
        }
    }
}
