namespace mvc_practice_test.Models
{
    using System.ComponentModel.DataAnnotations;

    public class Employee
    {
        [Key]
        public int EmployeeID { get; set; }

        public string? EmployeeNumber { get; set; }

        public string? FirstName { get; set; }

        public string? LastName { get; set; }

        public string? MiddleName { get; set; }

        public string? Initials { get; set; }

        public string? PrefferedName { get; set; }

        public string? MaidenName { get; set; }

        public int? TitleId { get; set; }

        public bool? EmployeeRetired { get; set; }
    }
}
