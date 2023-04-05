namespace mvc_practice_test.Models
{
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;

    public class EnumTitles
    {
        [Key]
        public int TitleID { get; set; }

        public string Title { get; set; }
    }
}
