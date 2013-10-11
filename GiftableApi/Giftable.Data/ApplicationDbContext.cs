﻿using System;
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

        public DbSet<User> Users { get; set; }
        public DbSet<Circle> Circles { get; set; }
        public DbSet<Gift> Gifts { get; set; }
    }
}
