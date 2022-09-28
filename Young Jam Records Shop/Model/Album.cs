using System.ComponentModel.DataAnnotations;

namespace Young_Jam_Records_Shop.Model
{
    public class Album
    {
        [Key]
        public int Id { get; set; }

        [Required]
        public string Name { get; set; }

        [Required]
        public string Author { get; set; }

        [Range(0.01, 999999.99)]
        [Required]
        public decimal Price { get; set; }
    }
}