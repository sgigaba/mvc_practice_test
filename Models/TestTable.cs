namespace mvc_practice_test.Models
{
    using System.ComponentModel.DataAnnotations;

    public class TestTable
    {
        [Key]
        public int ID { get; set; }

        public string TestColumn { get; set; }
    }
}
