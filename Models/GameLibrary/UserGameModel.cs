﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace GameBaseSite.Models
{
    public class UserGameModel
    {
        
        [Key]
        public string GameId { get; set; }

        [Key]
        public string UserId { get; set; }

        [Required]
        public string Title { get; set; }
        
    }
}
