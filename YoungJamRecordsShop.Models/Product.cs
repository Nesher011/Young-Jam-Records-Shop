using Microsoft.AspNetCore.Mvc.ModelBinding.Validation;
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

        [ValidateNever]
        public string? CoverImageUrl { get; set; }

        [ValidateNever]
        public Guid AlbumTypeId { get; set; }

        [ValidateNever]
        public AlbumType AlbumType { get; set; }

        [ValidateNever]
        public Guid CaseTypeId { get; set; }

        [ValidateNever]
        public CaseType CaseType { get; set; }
    }
}