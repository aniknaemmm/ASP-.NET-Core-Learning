﻿using Microsoft.EntityFrameworkCore;
using MigrationTwoDbContext.Models;

namespace MigrationTwoDbContext.Data
{
    public class MobileContext : DbContext
    {
        public DbSet<Phone> Phones { get; set; }
        public DbSet<Order> Orders { get; set; }

        public MobileContext(DbContextOptions<MobileContext> options)
            : base(options)
        {
        }
    }
}