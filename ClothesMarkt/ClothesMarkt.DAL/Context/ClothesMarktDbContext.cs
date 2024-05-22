using ClothesMarkt.Entities;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static Azure.Core.HttpHeader;

namespace ClothesMarkt.DAL.Context
{
	public class ClothesMarktDbContext : IdentityDbContext<IdentityUser<int>, IdentityRole<int>, int>
	{
		public DbSet<Product> Products { get; set; }
		public DbSet<Category> Categories { get; set; }
		public DbSet<Color> Colors { get; set; }
		public ClothesMarktDbContext(DbContextOptions<ClothesMarktDbContext> options):base(options)
        {
            
        }
        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);

            var hasher = new PasswordHasher<IdentityUser<int>>();

            builder.Entity<IdentityUser<int>>()
                   .HasData(new IdentityUser<int>
                   {
                       Id = 1,
                       UserName = "admin",
                       NormalizedUserName = "ADMIN",
                       Email = "admin@mail.com",
                       NormalizedEmail = "ADMIN@MAIL.COM",
                       EmailConfirmed = true,
                       PhoneNumberConfirmed = true,
                       PhoneNumber = "-",
                       PasswordHash = hasher.HashPassword(null, "Az*123456"),
                       SecurityStamp = Guid.NewGuid().ToString()
                   });


            //Admin Role Add

            builder.Entity<IdentityRole<int>>()
                   .HasData(new IdentityRole<int>
                   {
                       Id = 1,
                       Name = "Admin",
                       NormalizedName = "ADMIN"
                   });

            //User To Role Add

            builder.Entity<IdentityUserRole<int>>()
                   .HasData(new IdentityUserRole<int>
                   {
                       UserId = 1,
                       RoleId = 1
                   });
        }

    }
}
