﻿using ClickToBuy.Model;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace ClickToBuy.Database
{
    public class CTBContext : DbContext 
    {
        public DbSet<Country> Countries { get; set; }
        public DbSet<City> Cities { get; set; }
        public DbSet<Brand> Brands { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<Gender> Genders { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Country>().HasIndex(c=>c.Name).IsUnique();
            modelBuilder.Entity<City>().HasIndex(c=>c.Name).IsUnique();
            modelBuilder.Entity<Brand>().HasIndex(b=>b.Name).IsUnique();
            modelBuilder.Entity<Category>().HasIndex(c=>c.Name).IsUnique();
            modelBuilder.Entity<Gender>().HasIndex(g=>g.Name).IsUnique();
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            string connectionString = @"Data Source = DESKTOP-HHA0TOP; 
                                    Initial Catalog = ClickToBuy; 
                                    Integrated Security = SSPI;";
            optionsBuilder.UseSqlServer(connectionString);
        }
    }
}
