using System.ComponentModel.DataAnnotations;

namespace YoungJamRecordsShop.Models
{
    public class CaseType
    {
        [Key]
        public Guid Id { get; set; }

        [Display(Name = "Case Type")]
        [Required]
        public string? Name { get; set; }
    }
}