using System.ComponentModel.DataAnnotations;

namespace _12.Week_Code_First_1.Data
{
    public class Movie
    {
        [Key]
        public int Id { get; set; }

        [Required]
        public string Title { get; set; } = "";
        public string Genre { get; set; } = "";
        public int ReleaseYear { get; set; }
    }
}
