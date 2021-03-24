using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace Assignment9.Models
{
    public class Movie
    {
        [Key]
        public int MovieID { get; set; }
        [Required(ErrorMessage = "You must enter a movie category")]
        public string Category { get; set; }
        [Required(ErrorMessage = "You must enter a movie title")]
        public string MovieTitle { get; set; }
        [Required(ErrorMessage = "You must enter a director")]
        public string Director { get; set; }
        [Required(ErrorMessage = "You must enter the release year")]
        public string YearReleased { get; set; }
        [Required(ErrorMessage = "You must enter the MPAA rating")]
        public string Rating { get; set; }                   
        public bool Edited { get; set; } = false;
        #nullable enable
        public string? LentTo { get; set; }
        [MaxLength(25)]
        public string? Notes { get; set; }
    }
}
