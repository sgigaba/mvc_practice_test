namespace mvc_practice_test
{
    using Microsoft.EntityFrameworkCore;
    using mvc_practice_test.Models;

    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) 
            : base(options)
        {
        }

        public DbSet<TestTable> TestTables { get; set; }

        public DbSet<Employee> Employees { get; set; }
    }
}
