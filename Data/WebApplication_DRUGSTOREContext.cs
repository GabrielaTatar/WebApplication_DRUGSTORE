﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using WebApplication_DRUGSTORE.Models;

namespace WebApplication_DRUGSTORE.Data
{
    public class WebApplication_DRUGSTOREContext : DbContext
    {
        public WebApplication_DRUGSTOREContext (DbContextOptions<WebApplication_DRUGSTOREContext> options)
            : base(options)
        {
        }

        public DbSet<WebApplication_DRUGSTORE.Models.Product> Product { get; set; } = default!;

        public DbSet<WebApplication_DRUGSTORE.Models.Brand> Brand { get; set; }

        public DbSet<WebApplication_DRUGSTORE.Models.Review> Review { get; set; }

    }
}
