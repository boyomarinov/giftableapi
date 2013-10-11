using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Giftable.Models
{
    public class User
    {
        [Key]
        public int Id { get; set; }

        [Required]
        public string Username { get; set; }

        public string Email { get; set; }

        public string AuthenticationCode { get; set; }

        public string AccessToken { get; set; }

        public virtual ICollection<Gift> Wishlist { get; set; } 

        public virtual ICollection<Gift> SuggestedGifts { get; set; } 
    }
}
