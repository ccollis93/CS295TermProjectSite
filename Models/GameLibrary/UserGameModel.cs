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
        public int GameId { get; set; }

        [Key]
        public int UserId { get; set; }

        [Required]
        public string Title { get; set; }
        
    }
}
