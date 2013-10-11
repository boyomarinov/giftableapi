using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Giftable.Models;

namespace Giftable.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext()
            : base("GiftableDb")
        {
        }

        public IDbSet<User> Users { get; set; }
        public IDbSet<Circle> Circles { get; set; }
        public IDbSet<Gift> Gifts { get; set; }
    }
}
