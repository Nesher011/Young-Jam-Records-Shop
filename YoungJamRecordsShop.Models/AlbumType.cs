using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace YoungJamRecordsShop.Models
{
    public class AlbumType
    {
        [Key]
        public Guid Id { get; set; }

        [Required]
        public string Format { get; set; }
    }
}