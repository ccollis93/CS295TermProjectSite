using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace GameBaseSite.Models
{
    public class UserModel
    {
        [Key]
       public int UserId { get; set; }

        [Required]
       public string UserName { get; set; }

       public string PlayStyle { get; set; }

       public string FavoriteGame { get; set; } 
      
    }
}
