namespace mvc_practice_test.Models
{
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;

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

        [ForeignKey("EnumTitles")]
        public int? TitleId { get; set; }

        [NotMapped]
        public EnumTitles? EnumTitle { get; set; }

        [NotMapped]
        public List<EnumTitles>? Titles { get; set; }

        public bool? EmployeeRetired { get; set; }
    }
}
