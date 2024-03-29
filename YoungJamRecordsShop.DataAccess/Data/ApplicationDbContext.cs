﻿using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using YoungJamRecordsShop.Models;

namespace YoungJamRecordsShop.DataAccess
{
    public class ApplicationDbContext : IdentityDbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {
        }

        public DbSet<AlbumType>? AlbumType { get; set; }
        public DbSet<CaseType>? CaseType { get; set; }
        public DbSet<Product>? Product { get; set; }
        public DbSet<ApplicationUser>? ApplicationUser { get; set; }
    }
}