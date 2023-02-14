using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Mission06_annazlr.Models
{
    public class ApplicationResponse
    {
        [Key]
        [Required]
        public string Category { get; set; }
        [Required]
        public string MovieTitle { get; set; }
        [Required]
        public int Year { get; set; }
        [Required]
        public string Director { get; set; }
        [Required]
        public string Rating { get; set; }
        public bool Edited { get; set; }
        public string LentTo { get; set; }
        [MaxLengthAttribute(25)]
        public string Notes { get; set; }

    }
}
