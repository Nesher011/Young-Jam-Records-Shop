using System.ComponentModel.DataAnnotations;

namespace YoungJamRecordsShop.Models
{
    public class CaseType
    {
        [Key]
        public int Id { get; set; }

        [Display(Name = "Case Type")]
        [Required]
        public string? Name { get; set; }
    }
}