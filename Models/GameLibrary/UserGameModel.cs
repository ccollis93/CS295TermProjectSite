using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace GameBaseSite.Models
{
    public class UserGameModel
    {
        [Key]
        public int UsrGameId { get; set; } //unique identifier for each game. 


        [Required]
        [MaxLength(100)]
        public string? Title { get; set; } //User imputs this, only validation will be length limit

        [Required]
        [MaxLength(30)]
        public string? Genre { get; set; } //user inputs this, only validation is length limit

        [Required]
        public string? EsrbRating { get; set; } //user picks from a list of ratings

        [Required]
        [RangeAttribute(1,10)]
        public int? UserRating { get; set; } //1-10. 1 being bad 10 being the best game ever 

        [Required]
        [MaxLength(3)]
        public string Status { get; set; }

        [MaxLength(500)]
        public string? Review { get; set; }


    }
}
