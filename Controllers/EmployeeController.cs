namespace mvc_practice_test.Controllers
{
    using Microsoft.AspNetCore.Mvc;
    using Microsoft.EntityFrameworkCore;
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
            //var titles = this.context.EnumTitles.ToList();
            var employee = this.context.Employees.Include(_ => _.EnumTitle).ToList();

            return this.View(employee);
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
        public IActionResult Edit(int id)
        {
            var employee = this.context.Employees.FirstOrDefault(_ => _.EmployeeID == id);

            return this.View(employee);
        }

        [HttpPost]
        public IActionResult Edit(Employee model)
        {
            if (this.ModelState.IsValid)
            {
                this.context.Update(model);
                this.context.SaveChanges();
            }

            return this.RedirectToAction("Index");
        }
    }
}
