using System.ComponentModel.DataAnnotations;

namespace _12.Week_Code_First_1.Data
{
    public class Game
    {
        [Key]
        public int Id { get; set; }

        [Required]
        public string Name { get; set; } = "";
        public string Platform { get; set; } = "";

        [Range(0, 10)]
        public decimal Rating { get; set; }
    }

}
