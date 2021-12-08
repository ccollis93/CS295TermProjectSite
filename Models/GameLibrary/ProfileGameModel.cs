using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace GameBaseSite.Models
{
    public class ProfileGameModel
    {
        [Key]
        public string GameId { get; set; } //unique identifier for each game. 


        [Required]
        [MaxLength(255)]
        public string Title { get; set; } //User imputs this, only validation will be length limit

        [Required]
        [MaxLength(100)]
        public string Genre { get; set; } //user inputs this, only validation is length limit

        [Required]
        public string EsrbRating { get; set; } //user picks from a list of ratings

        
        [MaxLength(25)]
        public string Type { get; set; }

        

    }
}
