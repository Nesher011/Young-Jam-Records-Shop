using System.ComponentModel.DataAnnotations;

namespace YoungJamRecordsShop.Models
{
    public class Product
    {
        [Key]
        public Guid Id { get; set; }

        [Required]
        public string? Title { get; set; }

        public string? Description { get; set; }

        [Required]
        public string? Author { get; set; }

        [Required]
        public string EAN { get; set; }

        [Range(0.01, 9999.99)]
        [Required]
        public double ListPrice { get; set; }

        [Range(0.01, 9999.99)]
        [Required]
        public double Price { get; set; }

        public string CoverImageUrl { get; set; }
        public Guid AlbumTypeId { get; set; }
        public AlbumType AlbumType { get; set; }
        public Guid CaseTypeId { get; set; }
        public CaseType CaseType { get; set; }
    }
}