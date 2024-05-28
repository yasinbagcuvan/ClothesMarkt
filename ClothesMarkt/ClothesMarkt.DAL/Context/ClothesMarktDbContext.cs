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
using System.Reflection.Emit;

namespace ClothesMarkt.DAL.Context
{
	public class ClothesMarktDbContext : IdentityDbContext<IdentityUser<int>, IdentityRole<int>, int>
	{
		public DbSet<Tshirt> Tshirts { get; set; }
		public DbSet<Shirt> Shirts { get; set; }
		//public DbSet<ShirtsRenkler> ShirtsRenklers { get; set; }
		//public DbSet<TshirtsRenkler> TshirtsRenklers { get; set; }
		public DbSet<Category> Categories { get; set; }
		public DbSet<Renk> Colors { get; set; }
		public ClothesMarktDbContext(DbContextOptions<ClothesMarktDbContext> options) : base(options)
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

			builder.Entity<Renk>()
				   .HasData(
				new Renk() { Id = 1, Name = "Altın", Created = DateTime.Now },
				new Renk() { Id = 2, Name = "Bej", Created = DateTime.Now },
				new Renk() { Id = 3, Name = "Beyaz", Created = DateTime.Now },
				new Renk() { Id = 4, Name = "Bordo", Created = DateTime.Now },
				new Renk() { Id = 5, Name = "Ekru", Created = DateTime.Now },
				new Renk() { Id = 6, Name = "Gri", Created = DateTime.Now },
				new Renk() { Id = 7, Name = "Gümüş", Created = DateTime.Now },
				new Renk() { Id = 8, Name = "Haki", Created = DateTime.Now },
				new Renk() { Id = 9, Name = "Kahverengi", Created = DateTime.Now },
				new Renk() { Id = 10, Name = "Kırmızı", Created = DateTime.Now },
				new Renk() { Id = 11, Name = "Lacivert", Created = DateTime.Now },
				new Renk() { Id = 12, Name = "Mavi", Created = DateTime.Now },
				new Renk() { Id = 13, Name = "Metalik", Created = DateTime.Now },
				new Renk() { Id = 14, Name = "Mor", Created = DateTime.Now },
				new Renk() { Id = 15, Name = "Pembe", Created = DateTime.Now },
				new Renk() { Id = 16, Name = "Sarı", Created = DateTime.Now },
				new Renk() { Id = 17, Name = "Siyah", Created = DateTime.Now },
				new Renk() { Id = 18, Name = "Turkuaz", Created = DateTime.Now },
				new Renk() { Id = 19, Name = "Turuncu", Created = DateTime.Now },
				new Renk() { Id = 20, Name = "Yeşil", Created = DateTime.Now },
				new Renk() { Id = 21, Name = "Çok Renkli", Created = DateTime.Now }
				);
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


			//builder.Entity<ShirtsRenkler>()
			//	.Ignore(gr => gr.Id)
			//	.Ignore(gr => gr.RowNum)
			//	.Ignore(gr => gr.Updated)
			//	.HasKey(gr => new { gr.ShirtId, gr.RenkId });

			//builder.Entity<ShirtsRenkler>()
			//	.HasOne(gr => gr.Shirt)
			//	.WithMany(g => g.Renkler)
			//	.HasForeignKey(gr => gr.ShirtId);

			//builder.Entity<ShirtsRenkler>()
			//	.HasOne(gr => gr.Renk)
			//	.WithMany(r => r.Shirts)
			//	.HasForeignKey(gr => gr.RenkId);

			//builder.Entity<TshirtsRenkler>()
			//	.HasKey(gr => new { gr.TshirtId, gr.RenkId });

			//builder.Entity<TshirtsRenkler>()
			//	.HasOne(gr => gr.Tshirt)
			//	.WithMany(g => g.Renkler)
			//	.HasForeignKey(gr => gr.TshirtId);

			//builder.Entity<TshirtsRenkler>()
			//	.HasOne(gr => gr.Renk)
			//	.WithMany(r => r.Tshirts)
			//	.HasForeignKey(gr => gr.RenkId);

		}

	}
}
