﻿using BulkyWeb.Models;
using Microsoft.EntityFrameworkCore;

namespace BulkyWeb.data
{
    public class ApplicationDBContext : DbContext
    {
        public ApplicationDBContext(DbContextOptions<ApplicationDBContext> options): base (options)
        {
            
        }
        public DbSet<Category> Categories {  get; set; }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Category>().HasData(
                new Category { Id = 1, Name = "Action", DisplayOrder = 0 },
                new Category { Id = 2, Name = "Scifi", DisplayOrder = 1 },
                new Category { Id = 3, Name = "History", DisplayOrder = 2 }
            );
        }
    }
}
