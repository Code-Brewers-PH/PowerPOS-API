using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Core.Entities;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace Infrastructure.Data
{
    public class RepositoryContext : IdentityDbContext<ApplicationUser, IdentityRole, string>
    {
        public RepositoryContext(DbContextOptions options) : base(options)
        {
        }

        DbSet<ApplicationUser> ApplicationUsers { get; set; }
        DbSet<Product> Products { get; set; }
        DbSet<Category> Categories { get; set; }
        DbSet<Inventory> Inventory { get; set; }
        DbSet<Order> Orders { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            SeedData(modelBuilder);
        }

        private void SeedData(ModelBuilder modelBuilder)
        {
            // Comment this whenever the migration fails, it means it already exist in the db and
            // the seeder is trying again to add these values : Matt
            modelBuilder.Entity<IdentityRole>().HasData(
                new IdentityRole { Id = "6ed57acf-cb38-4df4-ac5f-be45115fd783", Name = "Administrator", NormalizedName = "ADMINISTRATOR" },
                new IdentityRole { Id = "38b13138-2eb6-415b-b1d4-c36f6c6fdee4", Name = "Customer", NormalizedName = "CUSTOMER" }
            );
        }
    }
}
