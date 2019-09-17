using freshapi.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace freshapi.Data
{
    public class ApplicationDbContext : IdentityDbContext<IdentityUser>
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);

            builder.Entity<IdentityRole>().HasData(
                    new { Id = "1", Name = "Admin", NormlizedName = "ADMIN" },
                    new { Id = "2", Name = "Customer", NormlizedName = "CUSTOMER" },
                    new { Id = "3", Name = "Moderator", NormlizedName = "MODERATOR" }
                );  
        }

        public DbSet<ProductModel> ProductModels { get; set; }
    }
}
